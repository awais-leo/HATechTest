using CheckoutKata;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

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
        //item ‘B’ cost 30 pounds individually
        //item ‘C’ cost 20 pounds individually
        //item ‘D’ cost 15 pounds individually

        [Test]
        [TestCase("A",50)]
        [TestCase("B", 30)]
        [TestCase("C", 20)]
        [TestCase("D", 15)]
        [TestCase("E", 0)]
        public void WhenScanItem_ThenItReturnPrice(string item, int expectedPrice)
        {
            checkout.ScanItem(item);
            var result = checkout.GetTotalPrice();
            Assert.That(result, Is.EqualTo(expectedPrice));
        }
    }
}