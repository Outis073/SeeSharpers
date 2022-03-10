using System.Numerics;

namespace SeeSharpers.Services.SeatAllocateService
{
    public class Seat
    {
        public int Number { get; set; }
        public int RowNumber { get; init; }
        public Vector2 Position { get; init; }
        public bool Occupied { get; set; }

        public Seat(Vector2 position, bool occupied = false)
        {
            Position = position;
            Occupied = occupied;
            RowNumber = (int) position.Y + 1;
        }

        protected bool Equals(Seat other)
        {
            return Occupied == other.Occupied && Position.Equals(other.Position);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Seat) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Occupied, Position);
        }
    }
}