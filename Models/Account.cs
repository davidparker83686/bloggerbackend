using System.ComponentModel.DataAnnotations;

namespace bloggerbackend.Models
{
  public class Account
  {
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    public string Picture { get; set; }
  }
}