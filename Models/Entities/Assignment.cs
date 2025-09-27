using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Models.Entities
{
    public class Assignment
    {
            public int Id { get; set; }
            public string? TeacherId { get; set; }
            public Teacher? Teacher { get; set; }
            public int SubjectId { get; set; }
            public Subject? Subject { get; set; }
            public int StudentClassId { get; set; }
            public StudentClass? StudentClass { get; set; }   
            public int Session { get; set; }
            public Term Term { get; set; }
            public bool IsActive { get; set; } = true;
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
            public string Title { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public DateTime DueDate { get; set; }
            public string? FileUrl { get; set; }
    }

    }