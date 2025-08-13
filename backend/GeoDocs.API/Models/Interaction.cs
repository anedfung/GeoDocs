namespace GeoDocs.API.Models
{
  public class Interaction
  {
    public int Id { get; set; }
    public int EventId { get; set; }
    public int UserId { get; set; }
    public string Type { get; set; } = string.Empty;
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
  }
}