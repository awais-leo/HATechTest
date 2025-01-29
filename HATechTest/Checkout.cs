using CheckoutKata.Model.Interface;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly IEnumerable<IProduct> _product;
       
        char[] scannedItems;
        public Checkout(IEnumerable<IProduct> product)
        {
            scannedItems = Array.Empty<char>();
            _product = product;
        }
        public  int GetTotalPrice()
        {           

            var price = scannedItems.Sum(item => _product.First(x => x.SKU == item).Price);
            return price;

        }

        public  void ScanItem(string item)
        {
            scannedItems = item.ToCharArray().Where(x => _product.Any(y => y.SKU == x)).ToArray();

            GetTotalPrice();
            
        }
    }
}