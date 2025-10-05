using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Repositories.Interface;

public interface ITimeTable
{
        Task<TimeTable> AddAsync(TimeTable timeTable);
        Task<TimeTable?> UpdateAsync(TimeTable timeTable);
        Task DeleteAsync(int id);
        Task<IEnumerable<TimeTable>> GetAllAsync();
        Task<TimeTable?> GetByIdWithDetailsAsync(int id);
        Task<IEnumerable<TimeTable>> GetByClassIdAsync(int classId);
        Task<IEnumerable<TimeTable>> GetByTeacherIdAsync(string teacherId);
        Task<IEnumerable<TimeTable>> GetBySubjectIdAsync(int subjectId);
        Task<IEnumerable<TimeTable>> GetByDayAsync(DayOfWeek day);
        Task<IEnumerable<TimeTable>> GetByClassTermAndSessionAsync(int classId, Term term, int sessionYear);
        Task<bool> IsTimeSlotTakenAsync(int classId, DayOfWeek day, TimeSpan startTime, TimeSpan endTime);
        Task<bool> IsTeacherAvailableAsync(string teacherId, DayOfWeek day, TimeSpan startTime, TimeSpan endTime);
        Task<IEnumerable<TimeTable>> GetAllWithDetailsAsync();
        Task<IEnumerable<TimeTable>> GetByTermAndSessionAsync(Term term, int sessionYear);
}
