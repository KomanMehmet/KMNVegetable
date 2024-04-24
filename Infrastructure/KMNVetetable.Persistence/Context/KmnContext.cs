using KMNVegetable.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KMNVetetable.Persistence.Context
{
    public class KmnContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DPSJ8S7;initial Catalog=KMNVegetable;integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<BestSeller> BestSellers { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<FooterContact> FooterContacts { get; set; }
        public DbSet<MainSlider> MainSliders { get; set; }
        public DbSet<NavBarContact> NavBarContacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductsDetails { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductDetail>()
        //        .HasOne(x => x.Catagory)
        //        .WithMany(y => y.ProductDetails)
        //        .HasForeignKey(x => x.CatagoryID)
        //        .OnDelete(DeleteBehavior.Restrict);
        //        //Rezervasyon tablosundaki picuplocation ile 
        //        //.WithMany(y => y.)//location tablosundaki pickupreservation'u ilişkilendir.
        //        //.HasForeignKey(z => z.PickUpLocationID)//pickuplocationID'ye göre ilişkilendir.
        //        //.OnDelete(DeleteBehavior.ClientSetNull);//silindiği zaman da null bir değer dönmesin diye bunu yapıyoruz.

        //    modelBuilder.Entity<ProductDetail>()
        //        .HasOne(x => x.Product)
        //        .WithMany(y => y.ProductDetails)
        //        .HasForeignKey(z => z.ProductID)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
    }
}
