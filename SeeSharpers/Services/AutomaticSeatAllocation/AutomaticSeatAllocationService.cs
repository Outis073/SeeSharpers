using System.Diagnostics;

namespace SeeSharpers.Services.AutomaticSeatAllocation
{
    public class AutomaticSeatAllocationService
    {
        private List<SeatRow> _seatRows;

        public AutomaticSeatAllocationService()
        {
            _seatRows = CreateDummyData(5, 15);

            Debug.WriteLine(_seatRows.ToString());
        }

        /**
         * Create dummy data to test the automatic seat allocation. This method needs to
         * be removed when there is a database implementation for the seats.
         */
        private static List<SeatRow> CreateDummyData(int rowCount, int seatCount)
        {
            List<SeatRow> seatRows = new List<SeatRow>();

            for (int y = 0; y < rowCount; y++)
            {
                SeatRow row = new SeatRow(y);

                for (int x = 0; x < seatCount; x++)
                {
                    row.AddSeat(new Seat(x + 1, x, row.PositionY));
                }
                seatRows.Add(row);
            }

            return seatRows;
        }
    }
}