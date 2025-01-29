using CheckoutKata;
using UnitTests.TestContext;

namespace UnitTests
{
    public class Tests
    {
        public ICheckout checkout;
      
        [SetUp]
        public void Setup()
        {
            TestSetup.BuildTestData();
            checkout = new Checkout(TestSetup.products, TestSetup.offers);
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

        [Test]
        [TestCase("AA", 100)]
        [TestCase("BB", 45)]
        [TestCase("CC", 40)]
        [TestCase("DD", 30)]
        [TestCase("EE", 0)]
        public void WhenScanMultipleItems_ThenItReturnCorrectPrice(string item, int expectedPrice)
        {
            checkout.ScanItem(item);
            var result = checkout.GetTotalPrice();
            Assert.That(result, Is.EqualTo(expectedPrice));
        }

        [Test]
        [TestCase("AAB", 130)]
        [TestCase("BCD", 65)]
        [TestCase("CCD", 55)]
                
        public void WhenScanMultipleGroupItems_ThenItReturnCorrectPrice(string item, int expectedPrice)
        {
            checkout.ScanItem(item);
            var result = checkout.GetTotalPrice();
            Assert.That(result, Is.EqualTo(expectedPrice));
        }

        [Test]
        [TestCase("AAA", 130)]
        [TestCase("BB", 45)]
        public void WhenScanItemWithOffer_ThenItReturnCorrectPrice(string item,int expectedPrice)
        {
            checkout.ScanItem(item);
            var result = checkout.GetTotalPrice();
            Assert.That(result, Is.EqualTo(expectedPrice));
        }
    }
}