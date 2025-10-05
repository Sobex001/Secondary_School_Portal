using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;
namespace Secondary_School_Portal.Repositories.Interface;

public interface IAssignment
{
    Task<Assignment> CreateAsync(Assignment assignment);
    Task<Assignment?> GetByIdAsync(int id);
    Task<IEnumerable<Assignment>> GetAllAsync();
    Task<Assignment?> UpdateAsync(Assignment assignment);
    Task DeleteAsync(int id);
    Task<IEnumerable<Assignment>> GetByTeacherAsync(string teacherId);
    Task<IEnumerable<Assignment>> GetBySubjectAsync(int subjectId);
    Task<IEnumerable<Assignment>> GetByClassAsync(int studentClassId);
    Task<IEnumerable<Assignment>> GetBySessionAndTermAsync(int session, Term term);
    Task<IEnumerable<Assignment>> GetActiveAssignmentsAsync();
}
