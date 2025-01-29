using CheckoutKata.Model.Interface;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly IEnumerable<IProduct> _product;
        private readonly IEnumerable<IOffers> _offers;
        char[] scannedItems;
        public Checkout(IEnumerable<IProduct> product, IEnumerable<IOffers> offers)
        {
            scannedItems = Array.Empty<char>();
            _product = product;
            _offers = offers;
        }
        public  int GetTotalPrice()
        {           

            var price = scannedItems.Sum(item => _product.First(x => x.SKU == item).Price);
            
            var totalDiscount = _offers.Sum(offer => CalculateDiscount(offer, scannedItems));

            return price - totalDiscount;

        }

        public  void ScanItem(string item)
        {
            scannedItems = item.ToCharArray().Where(x => _product.Any(y => y.SKU == x)).ToArray();

            GetTotalPrice();
            
        }
        private int CalculateDiscount(IOffers offers, char[] scannedItems)
        {
            int itemCount = scannedItems.Count(x => x == offers.SKU);
            return (itemCount / offers.OfferQuantity) * offers.OfferDiscount;
        }
    }
}