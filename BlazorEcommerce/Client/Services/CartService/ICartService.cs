namespace BlazorEcommerce.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;

        Task AddCart(CartItem cartItem);

        Task<List<CartProductResponse>> GetCartProducts();

        Task RemoveproductFromCart(int productId, int productTypeId);

        Task UpdateQuantity(CartProductResponse product);

        Task StoreCartItems(bool emptyLocalCart);

        Task GetCartItemsCount();
    }
}
