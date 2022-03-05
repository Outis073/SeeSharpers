namespace SeeSharpers.Services.AutomaticSeatAllocation
{
    public class SeatRow
    {
        public List<Seat> Seats { get; }
        public int PositionY { get; }

        public SeatRow(int y)
        {
            Seats = new List<Seat>();
            PositionY = y;
        }

        public void AddSeat(Seat seat)
        {
            if (!HasSeat(seat))
            {
                Seats.Add(seat);
            }
        }

        public void RemoveSeat(Seat seat)
        {
            if (HasSeat(seat))
            {
                Seats.Remove(seat);
            }
        }

        public bool HasSeat(Seat seat)
        {
            return Seats.Contains(seat);
        }
    }
}