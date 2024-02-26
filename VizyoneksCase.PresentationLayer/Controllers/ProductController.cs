using Microsoft.AspNetCore.Mvc;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.BusinessLayer.Concrete;

namespace VizyoneksCase.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {
           _productManager = productManager;
        }

        [HttpGet]   
        public IActionResult Index()
        {
            
            var data = _productManager.TGetLİst();               
            return View(data.ToList());
        }
    }
}
