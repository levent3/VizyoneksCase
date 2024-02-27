using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.BusinessLayer.Abstract
{
    public interface ICardService: IGenericService<Cart>
    {
       
            Cart GetCart();
            void SaveCart(Cart cart);
            void AddToCart(Product product, int quantity);
         
        
    }
}
