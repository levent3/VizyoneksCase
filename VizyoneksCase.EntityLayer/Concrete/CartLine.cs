﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizyoneksCase.EntityLayer.Concrete
{
    public class CartLine
    {
        public int Id { get; set; }
        public Product Product{ get; set; }
        public int Quantity{ get; set; }
    }
}
