using Secondary_School_Portal.Models.Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace Secondary_School_Portal.Models.Entities
{
    public class AcademicCalendar
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } =  string.Empty;
        public string? PdfFilePath { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.UtcNow;
        public AppUser UploadedBy { get; set; }
        public string UploadedById { get; set; } = string.Empty;
        public int SessionYear { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
