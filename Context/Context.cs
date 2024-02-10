using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
namespace GroupProject.Context
{
    public class Context : DbContext
    {
        #region DbSet
        public virtual DbSet<TeacherModel> Teachers { get; set; }
        #endregion

        readonly string _connectionString = "";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
