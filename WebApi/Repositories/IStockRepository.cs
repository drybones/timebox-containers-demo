namespace WebApi.Repositories
{
    public interface IStockRepository
    {
        int GetQuantity(int productId);
    }
}