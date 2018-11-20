using CuantoGastoApp.Model;
using MySql.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CuantoGastoApp.Context
{
    public class GlobalContext: DbContext
    {
        public DbSet<Line> Line {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=cuantogastodb;Trusted_Connection=True;");
            optionsBuilder.UseMySQL(@"server=localhost;database=cuantogastodb;user=admin;password=1234");
        }

    }
}