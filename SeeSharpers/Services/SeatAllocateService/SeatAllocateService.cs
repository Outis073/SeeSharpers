
using System.Numerics;
using SeeSharpers.Data;
using SeeSharpers.Models;
using SeeSharpers.Services.SeatAllocateService.Exceptions;
using SeeSharpers.Services.SeatAllocateService.Extensions;

namespace SeeSharpers.Services.SeatAllocateService;

public class SeatAllocateService
{
    private readonly ApplicationDbContext _context;
    private readonly Viewing _viewing;
    private readonly int _seatsPerRow;
    private readonly int _rows;

    private readonly HashSet<Seat> _seats = new();

    public SeatAllocateService(Viewing viewing, ApplicationDbContext context)
    {
        _viewing = viewing;
        _seatsPerRow = viewing.Theatre.AmountOfSeats;
        _rows = viewing.Theatre.AmountOfRows;
        _context = context;

        GenerateSeats();
    }

    /**
     * Get the seat based on the x and y value from a Vector2.
     */
    public Seat? GetSeat(Vector2 position) => GetSeat((int) position.X, (int) position.Y);

    /**
     * Get the seat based on the x and y value.
     */
    public Seat? GetSeat(int x, int y)
    {
        return _seats.First(s => (int) s.Position.X == x && (int) s.Position.Y == y);
    }

    /**
     * Set The next seat that is available occupied, and return the seats that are set to occupied.
     * <param name="amount">amount of seats that you want to occupy.</param>
     */
    public List<Seat> OccupyNextSeat(int amount)
    {
        List<Seat> newOccupiedSeats = new();

        if (GetFreeSeatCount() < amount)
            throw new NoFreeSeatException();

        for (int i = 0; i < amount; i++)
        {
            var seat = _seats.NextSeat();

            if (seat != null && SaveOccupiedSeat(seat))
            {
                newOccupiedSeats.Add(seat);
            }
        }

        return newOccupiedSeats;
    }

    /**
     * Get amount of not occupied seats.
     */
    public int GetFreeSeatCount()
    {
        return _seats.Count(s => !s.Occupied);
    }

    private void GenerateSeats()
    {
        var radius = (int) Math.Floor(_seatsPerRow / 2.0);
        var evenRows = _seatsPerRow % 2 == 0;

        for (int row = 0; row < _rows; row++)
        {
            Add(0, row);
            for (int i = 1; i <= radius; i++)
            {
                if (!evenRows || (evenRows && i != radius)) Add(i, row);
                Add(-i, row);
            }
        }

        AllocateSeatNumbers();
        SetOccupiedSeats();

        void Add(int x, int y) => _seats.Add(new Seat(new Vector2(x, y)));
    }

    private void AllocateSeatNumbers()
    {
        for (int y = 0; y < _rows; y++)
        {
            var xMin = _seats.Where(s => (int) s.Position.Y == y).Min(s => (int) s.Position.X);
            var xMax = _seats.Where(s => (int) s.Position.Y == y).Max(s => (int) s.Position.X);
            var numberIterator = 1;

            for (int x = xMin; x <= xMax; x++)
            {
                var seat = GetSeat(x, y);
                if (seat == null) continue;

                seat.Number = numberIterator++;
            }
        }
    }

    private void SetOccupiedSeats()
    {
        GetViewingSeats().ForEach(vs =>
        {
            var seat = GetSeat(vs.X, vs.Y);

            if (seat != null)
            {
                seat.Occupied = true;
            }
        });
    }

    private List<ViewingSeat> GetViewingSeats()
    {
        return _context.ViewingSeats.Where(s => s.ViewingId == _viewing.Id).ToList();
    }

    private bool SaveOccupiedSeat(Seat seat)
    {
        var listedSeat = GetSeat(seat.Position);

        if (listedSeat == null) return false;

        var viewingSeat = new ViewingSeat
        {
            ViewingId = _viewing.Id,
            X = (int) seat.Position.X,
            Y = (int) seat.Position.Y
        };

        listedSeat.Occupied = true;

        try
        {
            _context.ViewingSeats.Add(viewingSeat);
        }
        catch (Exception e)
        {
            return false;
        }

        return true;
    }
}