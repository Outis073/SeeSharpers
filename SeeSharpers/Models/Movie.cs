using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Microsoft.Build.Framework;

namespace SeeSharpers.Models;

public class Movie
{
    public int Id { get; set; }
    [Required]
    public String Title { get; set; }
    [Required]
    public TimeSpan Duration { get; set; }
    [Required]
    public Boolean Movie3d { get; set; }
    [Required]
    public DateTime BeginTime { get; set; }
    [Required]
    public Int16 AgeRequirement { get; set; }
    [Required]
    public String Thumbnail { get; set; }
    [Required]
    public List<Language> Language { get; set; }
    [Required]
    public String Description { get; set; }


    [Required]
    [ForeignKey(name: "Genres")]
    public String Genre { get; set; }
}