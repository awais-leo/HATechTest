namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        string item;
        char[] scannedItems;
        public Checkout()
        {
            scannedItems = Array.Empty<char>();
        }
        public  int GetTotalPrice()
        {
            scannedItems = item.ToCharArray();
            var price = item.Contains("A") ? 50 : item.Contains("B") ? 30 :item.Contains("C") ? 20 : item.Contains("D") ? 15  : 0;
            return (price * scannedItems.Count());

        }

        public  void ScanItem(string v)
        {
            item= v;
            GetTotalPrice();
            
        }
    }
}