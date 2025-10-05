using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface;
public interface INotification
{
    Task<Notification> CreateAsync(Notification notification);
    Task<Notification?> GetByIdAsync(int id);
    Task<IEnumerable<Notification>> GetAllAsync();
    Task<IEnumerable<Notification>> GetByUserIdAsync(string userId);
    Task<IEnumerable<Notification>> GetUnreadByUserIdAsync(string userId);
    Task<Notification?> MarkAsReadAsync(int id);
    Task<Notification?> UpdateAsync(Notification notification);
    Task DeleteAsync(int id);
    Task DeleteAsync(Notification notification);
}
