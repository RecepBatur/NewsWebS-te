using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //Veritabanı bağlantı konfigurasyonu.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RECEP;Database=NewsDB;Integrated Security=True;Encrypt=False;");
        }

        //Burada DbSet'lerimi oluşturdum.
        public DbSet<News> Newses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
