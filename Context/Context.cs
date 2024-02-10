using Microsoft.EntityFrameworkCore;
namespace GroupProject.Context
{
    public class Context : DbContext
    {
        #region DbSet


        #endregion

        readonly string _connectionString = "";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
