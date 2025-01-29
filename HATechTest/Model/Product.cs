using CheckoutKata.Model.Interface;

namespace CheckoutKata.Model
{
    public class Product : IProduct
    {
        public char SKU { get; set; }
        public int Price { get; set; }
    }
}
