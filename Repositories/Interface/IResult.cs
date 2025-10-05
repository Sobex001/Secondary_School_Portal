using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Repositories.Interface;

public interface IResult
{
    Task<Result> CreateAsync(Result result);
    Task<Result?> GetByIdAsync(int id);
    Task<IEnumerable<Result>> GetAllAsync();
    Task<IEnumerable<Result>> GetByStudentAsync(int studentId);
    Task<IEnumerable<Result>> GetBySubjectAsync(int subjectId);
    Task<IEnumerable<Result>> GetByTeacherAsync(string teacherId);
    Task<Result?> UpdateAsync(Result result);
    Task DeleteAsync(int id);
}
