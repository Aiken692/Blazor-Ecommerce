namespace BlazorEcommerce.Server.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;

        public OrderService(
            DataContext context,
            ICartService cartService,
            IAuthService authService
            )
        {
            _context = context;
            _cartService = cartService;
            _authService = authService;
        }

        public async Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders()
        {
            var response = new ServiceResponse<List<OrderOverviewResponse>>();  

            var orders = await _context.Orders
                .Include(x => x.OrderItems)
                .ThenInclude(o => o.Product)
                .Where(u => u.UserId == _authService.GetUserId())
                .OrderByDescending(d => d.OrderDate)
                .ToListAsync();

            var orderResponse = new List<OrderOverviewResponse>();
            orders.ForEach( x =>orderResponse.Add(new OrderOverviewResponse
            {
                Id = x.Id,
                OrderDate = x.OrderDate,
                TotalPrice = x.TotalPrice,
                Product = x.OrderItems.Count > 1 ? $"{x.OrderItems.First().Product.Title} and" + $" {x.OrderItems.Count - 1} more..." : x.OrderItems.First().Product.Title,
                ProductImageUrl = x.OrderItems.First().Product.ImageUrl
            }));

            response.Data = orderResponse;

            return response;
        }

        public async Task<ServiceResponse<bool>> PlaceOrder(int userId)
        {
            var products = (await _cartService.GetDbCartProducts(userId)).Data;
            double totalPrice = 0;
            products.ForEach(product => totalPrice += product.Price * product.Quantity);

            var orderItems = new List<OrderItem>();

            products.ForEach(product => orderItems.Add(new OrderItem
            {
                ProductId = product.ProductId,
                ProductTypeId = product.ProductTypeId,
                Quantity = product.Quantity,
                TotalPrice = product.ProductTypeId * product.Quantity,
            }));

            var order = new Order
            {
                UserId = _authService.GetUserId(),
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                OrderItems = orderItems
            };

            _context.Orders.Add(order);

            _context.CartItems.RemoveRange(_context.CartItems.Where(ci => ci.UserId == userId));

            await _context.SaveChangesAsync();

            return new ServiceResponse<bool>
            {
                Data = true
            };
        }

        public async Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId)
        {
            var response = new ServiceResponse<OrderDetailsResponse>();
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.ProductType)
                .Where(o => o.UserId == _authService.GetUserId() && o.Id == orderId)
                .OrderByDescending(o => o.OrderDate)
                .FirstOrDefaultAsync();

            if (order == null)
            {
                response.Success = false;
                response.Message = "Order not found.";
                return response;
            }

            var orderDetailsResponse = new OrderDetailsResponse
            {
                OrderDate = order.OrderDate,
                TotalPrice = order.TotalPrice,
                Products = new List<OrderDetailsProductResponse>()
            };

            order.OrderItems.ForEach(item =>
            orderDetailsResponse.Products.Add(new OrderDetailsProductResponse
            {
                ProductId = item.ProductId,
                ImageUrl = item.Product.ImageUrl,
                ProductType = item.ProductType.Name,
                Quantity = item.Quantity,
                Title = item.Product.Title,
                TotalPrice = item.TotalPrice
            }));

            response.Data = orderDetailsResponse;

            return response;
        }


    }
}
