using VatanAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace VatanAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            //builder.Entity<Category>().HasData
            //(
             
            //);
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired();
            builder.Entity<Product>().Property(p => p.Detail);
            builder.Entity<Product>().Property(p => p.ImageURL).IsRequired();
            builder.Entity<Product>().Property(p => p.Cost).IsRequired();
            builder.Entity<Product>().Property(p => p.CategoryID).IsRequired();

            builder.Entity<Product>().HasData
            (

                new Product()
                { Id = 1,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    Name = string.Format("SM-A325FZKHTUR"),
                    Cost = 4799,
                    Detail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",

                },
                new Product()
                { Id = 2,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lg/thumb/nano75pa1-2_small.jpg",
                    Name = string.Format("55NANO756PA"),
                    Cost = 11799,
                    Detail = "LG 55NANO756 55inc 139 CM NANOCELL 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",

                },
                new Product()
                { Id = 3,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    Name = string.Format("SM-A325FZKHTUR"),
                    Cost = 4.799,
                    Detail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",

                },
                new Product()
                { Id = 4,
                    ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/philips/thumb/v2-88491_small.jpg",
                    Name = string.Format("GC5032/20"),
                    Cost = 1.599,
                    Detail = "PHILIPS GC5032/20 AZUR ELITE OPTİMAL TEMP TEKNOLOJİLİ BUHARLI ÜTÜ",

                },
                 new Product()
                 { Id = 5,
                     ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/arnica/thumb/130693-1_small.jpg",
                     Name = string.Format("IH32059 KÖPÜKLÜ EKO SİYAH"),
                     Cost = 1499,
                     Detail = "ARNICA KÖPÜKLÜ TÜRK KAHVE MAKİNESİ EKO SİYAH - IH32059",

                 },
                  new Product()
                  {   Id=6,
                      ImageURL = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/vivo/thumb/127471_small.jpg",
                      Name = string.Format("Y11s_SİYAH"),
                      Cost = 2799,
                      Detail = "Vivo Y11s 32 Gb Fantom Siyahı Akıllı Telefon",

                  }

            ) ;

        }
    }
}
