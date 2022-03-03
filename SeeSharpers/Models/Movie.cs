using System.Reflection.Metadata;

namespace SeeSharpers.Models;

public class Movie
{
    public int MovieId { get; set; }
    public String MovieName { get; set; }

    public TimeSpan MovieDuration { get; set; }

    public Boolean Movie3d { get; set; }

    public DateTime MovieBeginTime { get; set; }

    public Int16 MovieAgeRequirement { get; set; }

    public String MovieThumbnail { get; set; }

    public String MovieLanguage { get; set; }

    public String MovieDescription { get; set; }
}