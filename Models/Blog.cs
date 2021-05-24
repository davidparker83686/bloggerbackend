using System.ComponentModel.DataAnnotations;

namespace bloggerbackend.Models
{
  public class Blog
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string Title { get; set; }
    public string Body { get; set; }
    public string imgUrl { get; set; }
    public bool published { get; set; }
    public Account Creator { get; set; }
    public string CreatorId { get; set; }
  }
}