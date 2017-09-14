namespace WindowsContainers.Repositories
{
    public interface IStockRepository
    {
        int GetQuantity(int productId);
        bool LowStockWarning(int productId);
    }
}