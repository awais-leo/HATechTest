namespace UnitTests
{
    public class Checkout
    {
        static string item;
        public static int GetTotalPrice()
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

        public static void ScanItem(string v)
        {
            item= v;
            GetTotalPrice();
            
        }
    }
}