namespace SeeSharpers.Services.SeatAllocateService.Extensions;

public static class SeatsExtensions
{
    public static Seat? NextSeat(this IEnumerable<Seat> @this)
    {
        var seats = @this.ToList();

        if (seats.All(s => s.Occupied))
        {
            return null;
        }

        int row = seats.Where(s => !s.Occupied).Min(s => Math.Abs((int) s.Position.Y));
        var rowSeats = seats.Where(CheckRow).ToList();
        int seatX = rowSeats.Where(s => !s.Occupied).Min(s => Math.Abs((int) s.Position.X));
        var isOdd = rowSeats.Count(s => s.Occupied) % 2 == 1;
        return rowSeats.First(s => (int) s.Position.X == (isOdd ? -seatX : seatX) && CheckRow(s));

        bool CheckRow(Seat s) => (int) s.Position.Y == row;
    }
}