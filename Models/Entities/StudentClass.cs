namespace Secondary_School_Portal.Models.Entities
{
    public class StudentClass
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 

        public ICollection<Student>? Students { get; set; } 
        public ICollection<Subject>? Subjects { get; set; }
    }
}
