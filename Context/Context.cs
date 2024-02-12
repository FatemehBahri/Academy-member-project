using GroupProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupProject.Context
{
    public class Context : DbContext
    {
        #region DbSet
        public DbSet<StudentModel> Students { get; set; }
        public virtual DbSet<TeacherModel> Teachers { get; set; }

        #endregion
        readonly string _connectionString = "Server=BAHRI\\SQLSERVER2022;Database=University_DB;Trusted_Connection=true;TrustServerCertificate=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }


    }
}
