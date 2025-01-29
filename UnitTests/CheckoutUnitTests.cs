using CheckoutKata;
using System.ComponentModel.Design;

namespace UnitTests
{
    public class Tests
    {
        public ICheckout checkout;

        [SetUp]
        public void Setup()
        {
            checkout = new Checkout();
        }

        //item ‘A’ cost 50 pounds individually

        [Test]
        public void WhenScanItem_ThenItReturnPrice()
        {
            checkout.ScanItem("A");
            var result = checkout.GetTotalPrice();
            Assert.That(result, Is.EqualTo(50));
        }
    }
}