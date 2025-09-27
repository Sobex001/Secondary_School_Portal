using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Secondary_School_Portal.Models.Entities;
using Secondary_School_Portal.Models.Entities.Enum;

namespace Secondary_School_Portal.ProjectDatabase 
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AcademicCalendar> AcademicCalendars { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ReportCard> ReportCards { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<TeacherSubject>()
                .HasKey(ts => new { ts.TeacherId, ts.SubjectId, ts.SessionYear, ts.Term });

            builder.Entity<Result>()
                .HasKey(r => new { r.StudentId, r.SubjectId, r.TeacherId, r.Term, r.Session });

           
            builder.Entity<Student>()
                .HasOne(s => s.AppUser)
                .WithOne(u => u.Student)
                .HasForeignKey<Student>(s => s.AppUserId)
                .OnDelete(DeleteBehavior.SetNull); 

            builder.Entity<Student>()
                .HasOne(s => s.Parent)
                .WithMany(p => p.Students)
                .HasForeignKey(s => s.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Student>()
                .HasOne(s => s.StudentClass)
                .WithMany(sc => sc.Students)
                .HasForeignKey(s => s.StudentClassId)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.Entity<Teacher>()
                .HasOne(t => t.AppUser)
                .WithOne(u => u.Teacher)
                .HasForeignKey<Teacher>(t => t.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);

         
            builder.Entity<Parent>()
                .HasOne(p => p.AppUser)
                .WithOne(u => u.Parent)
                .HasForeignKey<Parent>(p => p.AppUserId)
                .OnDelete(DeleteBehavior.SetNull);

         
            builder.Entity<Notification>()
                .HasOne(n => n.AppUser)
                .WithMany()
                .HasForeignKey(n => n.AppUserId)
                .OnDelete(DeleteBehavior.Cascade);

           
            builder.Entity<Announcement>()
                .HasOne(a => a.CreatedBy)
                .WithMany()
                .HasForeignKey(a => a.CreatedById)
                .OnDelete(DeleteBehavior.SetNull);

            
            builder.Entity<Assignment>()
                .HasOne(a => a.Teacher)
                .WithMany(t => t.Assignments)
                .HasForeignKey(a => a.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Assignment>()
                .HasOne(a => a.Subject)
                .WithMany(s => s.Assignments)
                .HasForeignKey(a => a.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Assignment>()
                .HasOne(a => a.StudentClass)
                .WithMany()
                .HasForeignKey(a => a.StudentClassId)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.Entity<Result>()
                .HasOne(r => r.Student)
                .WithMany(s => s.Results)
                .HasForeignKey(r => r.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Result>()
                .HasOne(r => r.Subject)
                .WithMany(s => s.Results)
                .HasForeignKey(r => r.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Result>()
                .HasOne(r => r.Teacher)
                .WithMany(t => t.Results)
                .HasForeignKey(r => r.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.Entity<ReportCard>()
                .HasOne(rc => rc.Student)
                .WithMany(s => s.ReportCards)
                .HasForeignKey(rc => rc.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

         
            builder.Entity<TimeTable>()
                .HasOne(tt => tt.StudentClass)
                .WithMany()
                .HasForeignKey(tt => tt.StudentClassId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TimeTable>()
                .HasOne(tt => tt.Subject)
                .WithMany()
                .HasForeignKey(tt => tt.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TimeTable>()
                .HasOne(tt => tt.Teacher)
                .WithMany(t => t.TimeTables)
                .HasForeignKey(tt => tt.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Student>()
                .HasIndex(s => s.RegNumber)
                .IsUnique();

            builder.Entity<Student>()
                .HasIndex(s => new { s.StudentClassId, s.IsActive });

            builder.Entity<TeacherSubject>()
               .HasKey(ts => new { ts.TeacherId, ts.SubjectId });

            builder.Entity<TeacherSubject>()
                .HasOne(ts => ts.Teacher)
                .WithMany(t => t.TeacherSubjects)
                .HasForeignKey(ts => ts.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TeacherSubject>()
                .HasOne(ts => ts.Subject)
                .WithMany(s => s.TeacherSubjects)
                .HasForeignKey(ts => ts.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Assignment>()
                .HasIndex(a => new { a.StudentClassId, a.Term, a.Session });

            builder.Entity<Assignment>()
                .HasIndex(a => a.DueDate);

            builder.Entity<Result>()
                .HasIndex(r => new { r.StudentId, r.Term, r.Session });

            builder.Entity<TimeTable>()
                .HasIndex(t => new { t.StudentClassId, t.Day, t.StartTime })
                .IsUnique();

            builder.Entity<TimeTable>()
                .HasIndex(t => new { t.TeacherId, t.Day, t.StartTime });

            builder.Entity<Notification>()
                .HasIndex(n => new { n.AppUserId, n.IsRead, n.CreatedAt });

            builder.Entity<TeacherSubject>()
                .HasIndex(ts => new { ts.SubjectId, ts.IsActive, ts.SessionYear });

        
            builder.Entity<AppUser>()
                .HasIndex(u => u.Email);

            builder.Entity<Subject>()
                .HasIndex(s => s.Name);

            builder.Entity<StudentClass>()
                .HasIndex(sc => sc.Name);

            
            builder.Entity<AppUser>()
                .Property(u => u.FullName)
                .HasMaxLength(100);

            builder.Entity<Student>()
                .Property(s => s.RegNumber)
                .HasMaxLength(20);

            builder.Entity<Student>()
                .Property(s => s.PhoneNumber)
                .HasMaxLength(15);

            builder.Entity<StudentClass>()
                .Property(sc => sc.Name)
                .HasMaxLength(50);

            builder.Entity<Subject>()
                .Property(s => s.Name)
                .HasMaxLength(100);

            builder.Entity<Teacher>()
                .Property(t => t.Id)
                .HasMaxLength(450);

            builder.Entity<Assignment>()
                .Property(a => a.Title)
                .HasMaxLength(200);

            builder.Entity<Announcement>()
                .Property(a => a.Title)
                .HasMaxLength(200);

            builder.Entity<Result>()
                .Property(r => r.ExamScore)
                .HasPrecision(5, 2);

            builder.Entity<Result>()
                .Property(r => r.CAScore)
                .HasPrecision(5, 2);
            var adminRoleId = Guid.NewGuid().ToString();
            var teacherRoleId = Guid.NewGuid().ToString();
            var studentRoleId = Guid.NewGuid().ToString();
            var parentRoleId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = teacherRoleId, Name = "Teacher", NormalizedName = "TEACHER" },
                new IdentityRole { Id = studentRoleId, Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole { Id = parentRoleId, Name = "Parent", NormalizedName = "PARENT" }
            );

            var hasher = new PasswordHasher<AppUser>();
            var adminId = Guid.NewGuid().ToString();

            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                FullName = "System Administrator",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = hasher.HashPassword(null, "Admin@123")
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                }
            );

            builder.Entity<StudentClass>().HasData(
                new StudentClass { Id = 1, Name = "JSS 1A" },
                new StudentClass { Id = 3, Name = "JSS 2A" },
                new StudentClass { Id = 5, Name = "JSS 3A" },
                new StudentClass { Id = 7, Name = "SS 1A" },
                new StudentClass { Id = 9, Name = "SS 2A" },
                new StudentClass { Id = 11, Name = "SS 3A" }
            );

            builder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Mathematics", Description = "Basic Mathematics", IsActive = true },
                new Subject { Id = 2, Name = "English Language", Description = "English Language and Literature", IsActive = true },
                new Subject { Id = 3, Name = "Physics", Description = "Basic Physics", IsActive = true },
                new Subject { Id = 4, Name = "Chemistry", Description = "Basic Chemistry", IsActive = true },
                new Subject { Id = 5, Name = "Biology", Description = "Basic Biology", IsActive = true },
                new Subject { Id = 6, Name = "Government", Description = "Government Studies", IsActive = true },
                new Subject { Id = 7, Name = "Economics", Description = "Basic Economics", IsActive = true },
                new Subject { Id = 8, Name = "Geography", Description = "Physical and Human Geography", IsActive = true },
                new Subject { Id = 9, Name = "History", Description = "Nigerian and World History", IsActive = true },
                new Subject { Id = 10, Name = "Computer Science", Description = "Basic Computer Studies", IsActive = true },
                new Subject { Id = 11, Name = "Basic Science", Description = "Introduction to Science for Junior Secondary", IsActive = true },
                new Subject { Id = 12, Name = "Basic Technology", Description = "Introduction to Technology", IsActive = true },
                new Subject { Id = 13, Name = "Business Studies", Description = "Foundations of Business and Commerce", IsActive = true },
                new Subject { Id = 14, Name = "Civic Education", Description = "Citizenship and Civic Responsibilities", IsActive = true },
                new Subject { Id = 15, Name = "Social Studies", Description = "Society and Human Relationships", IsActive = true },
                new Subject { Id = 16, Name = "Christian Religious Studies", Description = "Bible Knowledge and Christian Values", IsActive = true },
                new Subject { Id = 17, Name = "Islamic Religious Studies", Description = "Quranic Knowledge and Islamic Values", IsActive = true },
                new Subject { Id = 18, Name = "Physical and Health Education", Description = "Health and Physical Fitness", IsActive = true },
                new Subject { Id = 19, Name = "Agricultural Science", Description = "Introduction to Agriculture", IsActive = true },
                new Subject { Id = 20, Name = "Home Economics", Description = "Basic Home and Family Management", IsActive = true },
                new Subject { Id = 21, Name = "Fine Arts", Description = "Drawing, Painting and Creative Arts", IsActive = true },
                new Subject { Id = 22, Name = "Music", Description = "Introduction to Music and Instruments", IsActive = true },
                new Subject { Id = 23, Name = "French", Description = "Basic French Language", IsActive = true }
            );
        }
    }
}
