namespace Secondary_School_Portal.Models.Entities
{
    public class Subject
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}
