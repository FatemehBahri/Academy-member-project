using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD

=======
>>>>>>> 4e98e4477398744349d8b7c0f989c569dfd0deb9
namespace GroupProject.Context
{
    public class Context : DbContext
    {
        #region DbSet
<<<<<<< HEAD

        public DbSet<StudentModel> Students { get; set; }

=======
        public virtual DbSet<TeacherModel> Teachers { get; set; }
>>>>>>> 4e98e4477398744349d8b7c0f989c569dfd0deb9
        #endregion

        readonly string _connectionString = "";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BAHRI\\SQLSERVER2022;Database=University_DB;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
