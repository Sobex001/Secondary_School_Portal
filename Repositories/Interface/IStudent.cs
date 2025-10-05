using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface;

public interface IStudent
{
        Task<Student> CreateAsync(Student student);
        Task<Student?> GetByIdAsync(int id);
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student?> GetByRegNumberAsync(string regNumber);
        Task<IEnumerable<Student>> GetByClassAsync(int studentClassId);
        Task<IEnumerable<Student>> GetByParentAsync(int parentId);
        Task<Student?> GetByAppUserIdAsync(string appUserId);
        Task<Student?> UpdateAsync(Student student);
        Task DeleteAsync(int id);
        Task DeleteAsync(Student student);
        Task<IEnumerable<Student>> GetActiveStudentsAsync();
        Task<IEnumerable<Student>> GetInactiveStudentsAsync();
}
