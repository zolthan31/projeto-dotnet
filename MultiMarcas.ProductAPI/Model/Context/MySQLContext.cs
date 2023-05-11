using Microsoft.EntityFrameworkCore;

namespace MultiMarcas.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Bone",
                Price = new decimal(80.0),
                Description = "Lindo bone",
                CategoryName = "bone",
                ImageURL = "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem4.png",
                Marca = "Lacoste"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta",
                Price = new decimal(80.0),
                Description = "Linda camiseta",
                CategoryName = "T-shirt",
                ImageURL = "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem6.png",
                Marca = "Osklen"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa polo",
                Price = new decimal(120.0),
                Description = "Linda camisa polo",
                CategoryName = "Polo",
                ImageURL = "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem7.png",
                Marca = "Lacoste"
            });
        }
    }
}
