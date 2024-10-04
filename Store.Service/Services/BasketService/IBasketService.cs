using Store.Service.Services.BasketService.Dtos;
namespace Store.Service.Services.BasketService
{
    public interface IBasketService
    {
        Task<CustomerBasketDto> GetBasketAsync(string BasketId);

        Task<CustomerBasketDto> UpdateBasketAsync(CustomerBasketDto basket);

        Task<bool> DeleteBasketAsync(string basketId);
    }
}
