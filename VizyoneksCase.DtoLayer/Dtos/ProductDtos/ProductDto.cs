using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.DtoLayer.Dtos.ProductDto
{
    public class ProductDto
    {


        public int ProductId { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Categories { get; set; }
    }
}
