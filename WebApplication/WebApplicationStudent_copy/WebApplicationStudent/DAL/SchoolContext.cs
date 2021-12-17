using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApplicationStudent.Models;


namespace WebApplicationStudent.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("AplicactionStudent")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
