namespace SeeSharpers.Services.AutomaticSeatAllocation
{
    public class SeatRow
    {
        public int Id { get; }
        public int PositionY { get; }
        public List<Seat> Seats { get; }

        public SeatRow(int id, int positionY)
        {
            Id = id;
            PositionY = positionY;
            Seats = new List<Seat>();
        }

        public void AddSeat(Seat seat)
        {
            if (HasSeat(seat)) return;
            Seats.Add(seat);
        }

        public void RemoveSeat(Seat seat)
        {
            if (!HasSeat(seat)) return;
            Seats.Remove(seat);
        }

        public bool HasSeat(Seat seat)
        {
            return Seats.Contains(seat);
        }

        public Seat GetMiddleSeat()
        {
            var size = Seats.Count;

            // the rest can be 0 or 1, depends on the size.
            var rest = size % 2;
            var middle = size / 2 + rest;

            return Seats[middle];
        }
    }
}