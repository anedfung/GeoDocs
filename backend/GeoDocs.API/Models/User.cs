namespace GeoDocs.API.Models
{
  public class User
  {
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string CreatedAt { get; set; } = string.Empty;
  }
}