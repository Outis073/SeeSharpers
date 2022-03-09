namespace SeeSharpers.Services.SeatAllocateService;

public class SeatAllocateService
{
    private readonly int _seatsPerRow;
    private readonly int _rows;

    internal HashSet<Seat> Seats = new();

    public SeatAllocateService(int seatsPerRow, int rows)
    {
        _seatsPerRow = seatsPerRow;
        _rows = rows;

        GenerateSeats();
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

        void Add(int x, int y) => Seats.Add(new(0, new(x, y)));
    }

    public void SetOccupiedSeats()
    {

    }
}