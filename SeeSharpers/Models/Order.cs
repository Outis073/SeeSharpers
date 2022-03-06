using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.IdentityModel.Tokens;

namespace SeeSharpers.Models;

public class Order
{
    public int OrderId { get; set; }

    public string? OrderEmail { get; set; }

    public int OrderCode { get; set; }

    public DateTime CreatedDate { get; set; }

    public Boolean OrderSecret { get; set; }

    [ForeignKey("Tickets")]
    public List<Ticket> OrderTickets { get; set; }

    public Boolean OrderIsPrinted { get; set; }
}