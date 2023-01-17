using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
//SqlConnection baglantı = new SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Webvizeödevi;Integrated Security=True");
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
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Webvizeödevi;Integrated Security=True");
        }

        public DbSet<Models.Ders> Ders { get; set; }

    }



}
