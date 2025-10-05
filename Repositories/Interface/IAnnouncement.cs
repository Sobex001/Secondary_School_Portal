using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface;

public interface IAnnouncement
{
    Task<Announcement> CreateAnnouncementAsync(Announcement announcement);
    Task<IEnumerable<Announcement>> GetAllAnnouncementsAsync();
    Task<IEnumerable<Announcement>> GetActiveAnnouncementsAsync();
    Task<IEnumerable<Announcement>> GetAnnouncementsByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<IEnumerable<Announcement>> SearchAnnouncementsAsync(string searchTerm);
    Task<Announcement> DeactivateAnnouncementAsync(int Id);
}
