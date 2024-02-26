using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Concrete;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.BusinessLayer.Concrete
{
    public class ProductManager : GenericManager<Product>,IProductService
    {
        public ProductManager(Context context ):base(context)
        {            
        }
    }
}
