using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WindowsContainers
{
    public class StockRepositoryContext : DbContext
    {
        public DbSet<StockBinding> Stock { get; set; }

              protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    optionsBuilder.UseSqlServer(@"Server=db;Database=StockDatabase;User=sa;Password=D0cker!a8s;");
                }
    }

    [Table("Stock")]
    public class StockBinding
    {
        [Key]
        public int StockId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
