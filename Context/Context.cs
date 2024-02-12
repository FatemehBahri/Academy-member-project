using GroupProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupProject.Context
{
    public class Context : DbContext
    {
        #region DbSet

        public DbSet<StudentModel> Students { get; set; }

        #endregion

        readonly string _connectionString = "";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BAHRI\\SQLSERVER2022;Database=University_DB;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
