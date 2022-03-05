namespace SeeSharpers.Services.AutomaticSeatAllocation
{
    public class Seat
    {
        public int SeatNumber { get; }
        public int PositionX { get; }
        public int PositionY { get; }
        public bool Occupied { get; set; }

        public Seat(int seatNumber, int x, int y) : this(seatNumber, x, y, false)
        {
        }

        public Seat(int seatNumber, int x, int y, bool isOccupied)
        {
            SeatNumber = seatNumber;
            PositionX = x;
            PositionY = y;
            Occupied = isOccupied;
        }
    }
}