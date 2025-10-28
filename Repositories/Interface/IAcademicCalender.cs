using Secondary_School_Portal.Models.Entities;

namespace Secondary_School_Portal.Repositories.Interface
{
    public interface IAcademicCalender
    {
        Task<AcademicCalendar> CreateCalenderAsync(AcademicCalendar calendar);
        Task<AcademicCalendar> DeleteCalenderAsync(int Id);
        Task<IEnumerable<AcademicCalendar>> GetAllCalenderAsync();
        Task<IEnumerable<AcademicCalendar>> GetCalenderByIdAsync(int Id);
        Task<AcademicCalendar> UpdateCalenderAsync(AcademicCalendar calendar);
        Task<bool> IsCalenderActive(int Id);
        Task<IEnumerable<AcademicCalendar>> GetCalenderBySessionYearAsync(int sessionYear);
    } 
}
