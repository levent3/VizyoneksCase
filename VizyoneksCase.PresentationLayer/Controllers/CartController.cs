using Microsoft.AspNetCore.Mvc;
using VizyoneksCase.PresentationLayer.Models;

namespace VizyoneksCase.PresentationLayer.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart(int Id)
        {

            return View();

        }


        //public Cart GetCart()
        //{
        //    var cart =(Cart)Session.


        //}
    }
}
