namespace Services.Models;

public class MovieDTO
{
    public int? Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Budget { get; set; }
}