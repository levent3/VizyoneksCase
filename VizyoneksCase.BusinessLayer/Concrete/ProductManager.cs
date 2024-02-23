using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Abstract;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productService;
        public ProductManager(IProductDal productDal)
        {
            _productService = productDal;
        }

        public IProductDal ProductDal { get; }

        public void TDelete(Product entity)
        {
           _productService.Delete(entity);
        }

        public Product TGetById(int id)
        {
            return _productService.GetById(id);
        }

        public List<Product> TGetLİst()
        {
            return _productService.GetLİst();

        }

        public void TInsert(Product entity)
        {
             _productService.Insert(entity);

        }

        public void TUpdate(Product entity)
        {
            _productService.Update(entity); 
        }
    }
}
