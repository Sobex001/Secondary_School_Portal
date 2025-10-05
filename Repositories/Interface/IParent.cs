using Secondary_School_Portal.Models.Entities;
namespace Secondary_School_Portal.Repositories.Interface
{
    public interface IParent
    {
        Task<Parent> CreateAsync(Parent parent);
        Task<Parent?> GetByIdAsync(int id);
        Task<IEnumerable<Parent>> GetAllAsync();
        Task<IEnumerable<Parent>> GetActiveParentsAsync();
        Task<Parent?> UpdateAsync(Parent parent);
        Task DeleteAsync(int id);
        Task DeleteAsync(Parent parent);
    }
}