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
        //readonly string _connectionString = "Data Source=.;Initial Catalog=GroupProjectDb;Integrated Security=True;Trust Server Certificate=True";
        readonly string _connectionString = "Data Source=94.74.145.28,2022;Initial Catalog=plussumc_MyDataBase;Persist Security Info=True;User ID=plussumc_MyDataBase;Password=Abdolreza1378;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }


    }
}
