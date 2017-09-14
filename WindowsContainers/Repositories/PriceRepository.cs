using System.Linq;

namespace WindowsContainers.Repositories
{
    public class PriceRepository : IPriceRepository
    {
        public int GetPrice(int productId)
        {
            using (var db = new PriceRepositoryContext())
            {
                return db.Price.FirstOrDefault(s => s.ProductId == productId).Price;
            }
        }
    }
}