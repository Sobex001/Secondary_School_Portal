using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Repositories.Interface;

namespace Secondary_School_Portal.Repositories.Implementation;

public class AcademicCalender : IAcademicCalender
{
    public Task<AcademicCalendar> CreateCalenderAsync(AcademicCalendar calendar)
    {
        throw new NotImplementedException();
    }

    public Task<AcademicCalendar> DeleteCalenderAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AcademicCalendar>> GetAllCalenderAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AcademicCalendar>> GetCalenderByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AcademicCalendar>> GetCalenderBySessionYearAsync(int sessionYear)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsCalenderActive(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<AcademicCalendar> UpdateCalenderAsync(AcademicCalendar calendar)
    {
        throw new NotImplementedException();
    }
}
