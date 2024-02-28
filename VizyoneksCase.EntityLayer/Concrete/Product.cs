using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizyoneksCase.EntityLayer.Concrete
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name{ get; set; }
        public double UnitPrice  { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Categories{ get; set; }

    }
}
