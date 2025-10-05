using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface;
public interface IAppUser
{
    Task<AppUser?> GetByIdAsync(string id);
    Task<AppUser?> GetByEmailAsync(string email);
    Task<IEnumerable<AppUser>> GetAllAsync();
    Task<AppUser> CreateAsync(AppUser user, string password);
    Task<AppUser?> UpdateAsync(AppUser user);
    Task<bool> DeleteAsync(string id);
}

