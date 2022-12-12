using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }
        // TODO: Add DBSets (Tables of our Ddata base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Category>? categories { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
