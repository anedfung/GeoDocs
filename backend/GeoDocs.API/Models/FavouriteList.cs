namespace GeoDocs.API.Models
{
  public class FavouriteList
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int[] EventIds { get; set; } = [];
  }
}