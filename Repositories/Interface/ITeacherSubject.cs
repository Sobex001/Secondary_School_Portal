using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;
namespace Secondary_School_Portal.Repositories.Interface;

public interface ITeacherSubject
{
        Task<TeacherSubject> AssignSubjectAsync(TeacherSubject teacherSubject);
        Task UnassignSubjectAsync(string teacherId, int subjectId);
        Task<IEnumerable<TeacherSubject>> GetAllActiveAsync();
        Task<IEnumerable<TeacherSubject>> GetByTeacherIdAsync(string teacherId);
        Task<IEnumerable<TeacherSubject>> GetBySubjectIdAsync(int subjectId);
        Task<IEnumerable<TeacherSubject>> GetByTermAndSessionAsync(Term term, int sessionYear);
        Task DeactivateAsync(string teacherId, int subjectId);
        Task<bool> IsTeacherAssignedAsync(string teacherId, int subjectId, int sessionYear);
}
