using System.ComponentModel.Design;

namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //item ‘A’ cost 50 pounds individually

        [Test]
        public void WhenScanItem_ThenItReturnPrice()
        {
            Checkout.ScanItem("A");
            var result =Checkout.GetTotalPrice();
            Assert.That(result, Is.EqualTo(50));
        }
    }

    internal class Checkout
    {
        static string item;
        internal static int GetTotalPrice()
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

        internal static void ScanItem(string v)
        {
            item= v;
            GetTotalPrice();
            
        }
    }
}