using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
//SqlConnection baglantı = new SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=WVO;User ID=sa");
namespace WVO.EF
{
    public class YeniDBEntities : DbContext
    {
        public YeniDBEntities()
        {
        }
        public YeniDBEntities(DbContextOptions<YeniDBEntities> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=WVO;User ID=sa");
        }

        public DbSet<Models.Ders> Ders { get; set; }

    }



}
