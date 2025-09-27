using Secondary_School_Portal.Models.Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace Secondary_School_Portal.Models.Entities
{
public class ReportCard
    {
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Student Student { get; set; } = default!;
        [Required]
        public Term Term { get; set; }
        [Required]
        public int SessionYear { get; set; }
        [Required]
        public string PdfFilePath { get; set; } = default!;
        public DateTime UploadDate { get; set; } = DateTime.UtcNow;
        public string? UploadedBy { get; set; }
        public bool IsApproved { get; set; } = false;
    }
}