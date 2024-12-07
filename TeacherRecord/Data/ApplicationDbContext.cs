using Microsoft.EntityFrameworkCore;
using TeacherRecord.Models;

namespace TeacherRecord.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId=123,Name="NOICE",Salary=1234});
        }
    }
}
