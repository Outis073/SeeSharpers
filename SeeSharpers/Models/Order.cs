using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace SeeSharpers.Models;

public class Order
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public int Code { get; set; }

    public DateTime CreatedDate { get; set; }

    public Boolean Secret { get; set; }

    [Required]
 
    public List<Ticket> Tickets { get; set; }

    public Boolean IsPrinted { get; set; }
}