using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface;

public interface ISubject
{
    Task<Subject> AddAsync(Subject subject);
        Task<Subject?> GetByNameAsync(string name);
        Task<IEnumerable<Subject>> GetActiveSubjectsAsync();
        Task<IEnumerable<Subject>> GetSubjectsByTeacherIdAsync(string teacherId);
        Task<IEnumerable<Subject>> GetSubjectsByClassIdAsync(int classId);
        Task DeactivateSubjectAsync(int subjectId);
}
