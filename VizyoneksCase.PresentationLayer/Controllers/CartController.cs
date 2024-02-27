using Microsoft.AspNetCore.Mvc;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Concrete;

using VizyoneksCase.PresentationLayer.Models;

namespace VizyoneksCase.PresentationLayer.Controllers
{
    public class CartController : Controller
    {

 
        private readonly IProductService _productService;

        public ICardService _CardService { get; }

        public CartController(ICardService cardService,IProductService productService)
        {
           
            _CardService = cardService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var xx = _CardService.GetCart();
            return View(xx);
        }

        public IActionResult AddToCart(int Id)
        {
            var product=_productService.TGetById(Id);   

            if(product != null) 
            {
                var cart = _CardService.GetCart();
                _CardService.AddToCart(product, 1);
                _CardService.SaveCart(cart);
            }
            return RedirectToAction("Index");

        }

        public IActionResult RemoveToCart(int Id)
        {
            var product = _productService.TGetById(Id);

            if (product != null)
            {
                var cart = _CardService.GetCart();
                _CardService.TDelete(cart);
                _CardService.SaveCart(cart);
            }
            return RedirectToAction("Index");

        }



    }
}
