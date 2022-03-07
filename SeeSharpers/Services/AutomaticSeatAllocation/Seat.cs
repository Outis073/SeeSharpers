namespace SeeSharpers.Services.AutomaticSeatAllocation
{
    public class Seat
    {
        public int Id { get; }
        public int SeatNumber { get; }
        public int PositionX { get; set; }
        public int PositionY { get; }
        public bool Occupied { get; set; }

        public Seat(int id, int seatNumber, int x, int y) : this(id, seatNumber, x, y, false)
        {
        }

        public Seat(int id, int seatNumber, int x, int y, bool isOccupied)
        {
            Id = id;
            SeatNumber = seatNumber;
            PositionX = x;
            PositionY = y;
            Occupied = isOccupied;
        }
    }
}