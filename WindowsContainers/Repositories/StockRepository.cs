using System.Linq;

namespace WindowsContainers.Repositories
{
    public class StockRepository : IStockRepository
    {
        //private readonly string m_ConnectionString;

        public int GetQuantity(int productId)
        {
            using (var db = new StockRepositoryContext())
            {
                return db.Stock.FirstOrDefault(s => s.ProductId == productId).Quantity;
            }
        }

        public bool LowStockWarning(int productId)
        {
            using (var db = new StockRepositoryContext())
            {
                return db.Stock.FirstOrDefault(s => s.ProductId == productId).LowStockWarning;
            }
        }
    }
}
