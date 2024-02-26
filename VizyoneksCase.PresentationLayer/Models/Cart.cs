using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.PresentationLayer.Models
{
    public class Cart
    {

        private List<CartLine> _cartLines=new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cartLines; }   
        }

        public void AddCartLine(Product product,int quantity)
        {

            var line = _cartLines.FirstOrDefault(i => i.Product.ProductId == product.ProductId);

            if (line == null)
            {

                _cartLines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {

                line.Quantity += quantity;
            }

        }


        public void DeleteCartLine(Product product)
        {
            _cartLines.RemoveAll(i=>i.Product.ProductId == product.ProductId);

        }

        public double Total()
        {

            return _cartLines.Sum(i=>i.Product.UnitPrice*i.Quantity);
        }

        public void Clear() 
        { 
           _cartLines.Clear(); 
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
