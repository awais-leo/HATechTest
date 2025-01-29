namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        string item;
        public  int GetTotalPrice()
        {
            if (item == "A")
            {
                return 50;
            }
            else
            {
                return 0;
            }

            
        }

        public  void ScanItem(string v)
        {
            item= v;
            GetTotalPrice();
            
        }
    }
}