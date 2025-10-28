using Secondary_School_Portal.Repositories.Interface;

namespace Secondary_School_Portal.Repositories.Implementation;

public class Announcement : IAnnouncement
{
    public Task<Models.Entities.Announcement> CreateAnnouncementAsync(Models.Entities.Announcement announcement)
    {
        throw new NotImplementedException();
    }

    public Task<Models.Entities.Announcement> DeactivateAnnouncementAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Models.Entities.Announcement>> GetActiveAnnouncementsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Models.Entities.Announcement>> GetAllAnnouncementsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Models.Entities.Announcement>> GetAnnouncementsByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Models.Entities.Announcement>> SearchAnnouncementsAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

}
