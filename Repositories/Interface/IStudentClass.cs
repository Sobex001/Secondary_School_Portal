using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface;

public interface IStudentClass
{
        Task<StudentClass> AddAsync(StudentClass studentClass);
        Task<StudentClass?> UpdateAsync(StudentClass studentClass);
        Task DeleteAsync(int id);
        Task<IEnumerable<StudentClass>> GetAllWithDetailsAsync();
        Task<StudentClass?> GetByIdWithDetailsAsync(int id);
        Task<StudentClass?> GetByNameAsync(string name);
}