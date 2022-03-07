using System.Diagnostics;

namespace SeeSharpers.Services.AutomaticSeatAllocation
{
    public class AutomaticSeatAllocationService
    {
        // int as in a Y Position.
        private List<SeatRow> _seatRows;

        // DummyData incrementing.
        private int _rowId = 1;

        private int _seatId = 1;
        // End DummyData incrementing.

        public AutomaticSeatAllocationService()
        {
            _seatRows = CreateDummyData(5, 15);

            Debug.WriteLine("unused row id: " + _rowId);
            Debug.WriteLine("unused seat id: " + _seatId);
        }

        /**
         * Create dummy data to test the automatic seat allocation. This method needs to
         * be removed when there is a database implementation for the seats.
         */
        private List<SeatRow> CreateDummyData(int rowCount, int seatCount)
        {
            var seatRows = new List<SeatRow>();

            for (var y = 0; y < rowCount; y++)
            {
                SeatRow row = new(_rowId, y);

                for (var x = 0; x < seatCount; x++)
                {
                    row.AddSeat(new Seat(_seatId, x + 1, x, row.PositionY));
                    _seatId++;
                }

                seatRows.Add(row);
                _rowId++;
            }

            return seatRows;
        }
    }
}