using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.DataAccesLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Repositories;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.DataAccesLayer.Concrete
{
    public class ProductRepository:GenericRepository<Product>,IProductDal
    {
        public ProductRepository(Context context):base(context) { }
        
                
        

    }
}
