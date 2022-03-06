namespace SeeSharpers.Models;

public class Ticket
{
    public int TicketId { get; set; }

    public int TicketSeat { get; set; }

    public int TicketCode { get; set; }

    public int TicketDiscountType { get; set; }

    public Boolean TicketPopcornArrangement { get; set; }

    public decimal TicketTotalPrice { get; set; }
}