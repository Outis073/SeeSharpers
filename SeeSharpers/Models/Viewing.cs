namespace SeeSharpers.Models;

public class Viewing
{
    public int Id { get; set; }

    public DateTime StartDateTime { get; set; }

    public Theatre Theatre { get; set; }

    public Movie Movie { get; set; }
}