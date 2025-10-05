using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface;

public interface ITeacher
{
        Task<Teacher> AddAsync(Teacher teacher);
        Task<Teacher?> UpdateAsync(Teacher teacher);
        Task<Teacher?> GetByAppUserIdAsync(string appUserId);
        Task<Teacher?> GetByIdWithDetailsAsync(string id);
        Task<IEnumerable<Teacher>> GetAllWithDetailsAsync();
        Task<IEnumerable<Subject>> GetSubjectsByTeacherIdAsync(string teacherId);
        Task<IEnumerable<Assignment>> GetAssignmentsByTeacherIdAsync(string teacherId);
        Task<IEnumerable<TimeTable>> GetTimeTableByTeacherIdAsync(string teacherId);
        Task DeactivateTeacherAsync(string teacherId);
}
