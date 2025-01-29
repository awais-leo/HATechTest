namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        string item;
        public  int GetTotalPrice()
        {

            return item == "A" ? 50 : item == "B" ? 30 :item == "C" ? 20 : item == "D" ? 15  : 0;
                        
        }

        public  void ScanItem(string v)
        {
            item= v;
            GetTotalPrice();
            
        }
    }
}