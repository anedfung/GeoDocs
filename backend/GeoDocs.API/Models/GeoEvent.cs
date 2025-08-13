namespace GeoDocs.API.Models
{
  public class GeoEvent
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? EventDate { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}