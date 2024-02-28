using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Concrete;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.BusinessLayer.Concrete
{
    public class CardManager : GenericManager<Cart>, ICardService
    {
        private readonly Context context;
        private readonly IHttpContextAccessor _httpContextAccessor;
     

        public CardManager(Context context,IHttpContextAccessor httpContextAccessor) : base(context)
        {
            this.context = context;
            _httpContextAccessor = httpContextAccessor;
          
        }


    
        public void AddToCart(Product product, int quantity)
        {
            var cart = GetCart();
            if (cart == null)
            {
                cart = new Cart();
            }
            if (cart.CartLines == null)
            {
                cart.CartLines = new List<CartLine>();
            }


            var existingLine = cart.CartLines.FirstOrDefault(line => line.Product.ProductId == product.ProductId);

            if (existingLine != null)
            {
                existingLine.Quantity += quantity;
            }
            else
            {
               cart.CartLines.Add(new CartLine { Product = product, Quantity = quantity });
            }

            SaveCart(cart);
        }

        public Cart GetCart()
        {
            var cartJson = _httpContextAccessor.HttpContext.Session.GetString("Cart");

            if (string.IsNullOrEmpty(cartJson))
            {
                var cart = new Cart();
                SaveCart(cart);
                return cart;
            }

            var xx = JsonSerializer.Deserialize<Cart>(cartJson);
            return xx;
        }

     

        public void SaveCart(Cart cart)
        {
            var cartJsonxx = _httpContextAccessor.HttpContext.Session.GetString("Cart");
            var cartJson = JsonSerializer.Serialize(cart);
            _httpContextAccessor.HttpContext.Session.SetString("Cart", cartJson);
        }
    }
}
