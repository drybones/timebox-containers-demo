using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WindowsContainers.Repositories
{
    public class PriceRepositoryContext : DbContext
    {
        public DbSet<PriceBinding> Price { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=db2;Database=PriceDatabase;User=sa;Password=D0cker!a8s;");
        }
    }

    [Table("Price")]
    public class PriceBinding
    {
        [Key]
        public int PriceId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Price { get; set; }
    }
}