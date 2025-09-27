using System.ComponentModel.DataAnnotations;

namespace Secondary_School_Portal.Models.Entities;
public class Parent
{
    public int Id { get; set; }
    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    [Required]
    public string Address { get; set; }
    public ICollection<Student>? Students { get; set; } 
    public bool IsActive { get; set; } = true;
}
