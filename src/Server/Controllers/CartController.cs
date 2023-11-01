using BlazorEcommerce.Server.Services.CartService;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlazorEcommerce.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = await _cartService.GetCartProducts(cartItems);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> StoreCartItems(List<CartItem> cartItems)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var result = await _cartService.StoreCartItems(cartItems);

            return Ok(result);
        }

        [HttpGet("count")]
        public async Task<ActionResult<ServiceResponse<int>>> GetCount(int count)
        {
            return await _cartService.GetCartItemsCount();
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetDbCartProducts()
        {
            var result = await _cartService.GetDbCartProducts();

            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<ActionResult<ServiceResponse<List<bool>>>> AddToCart(CartItem cartItem)
        {
            var result = await _cartService.AddToCart(cartItem);

            return Ok(result);
        }

        [HttpPut("update-quantity")]
        public async Task<ActionResult<ServiceResponse<List<bool>>>> UpdateToCart(CartItem cartItem)
        {
            var result = await _cartService.UpdateQuantity(cartItem);

            return Ok(result);
        }


        [HttpDelete("{productId}/{productTypeId}")]
        public async Task<ActionResult<ServiceResponse<List<bool>>>> DeleteFromCart(int productId, int productTypeId)
        {
            var result = await _cartService.RemoveItemfromCart(productId, productTypeId);

            return Ok(result);
        }
    }
}
