using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.Repositories.Interface
{
    public interface IReportCardRepository
    {
        Task<ReportCard> CreateAsync(ReportCard reportCard);
        Task<ReportCard?> GetByIdAsync(int id);
        Task<IEnumerable<ReportCard>> GetAllAsync();
        Task<IEnumerable<ReportCard>> GetByStudentIdAsync(int studentId);
        Task<ReportCard?> UpdateAsync(ReportCard reportCard);
        Task<ReportCard?> ApproveReportCardAsync(int id);
        Task DeleteAsync(int id);
        Task DeleteAsync(ReportCard reportCard);
    }
}