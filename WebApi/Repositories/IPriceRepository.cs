namespace WebApi.Repositories
{
    public interface IPriceRepository
    {
        int GetPrice(int productId);
    }
}