using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Microsoft.Build.Framework;

namespace SeeSharpers.Models;

public class Movie
{
    public int MovieId { get; set; }
    [Required]
    public String MovieTitle { get; set; }
    [Required]
    public TimeSpan MovieDuration { get; set; }
    [Required]
    public Boolean Movie3d { get; set; }
    [Required]
    public DateTime MovieBeginTime { get; set; }
    [Required]
    public Int16 MovieAgeRequirement { get; set; }
    [Required]
    public String MovieThumbnail { get; set; }
    [Required]
    public List<Language> MovieLanguage { get; set; }
    [Required]
    public String MovieDescription { get; set; }


    [Required]
    [ForeignKey("Genres")]
    public String MovieGenre { get; set; }
}