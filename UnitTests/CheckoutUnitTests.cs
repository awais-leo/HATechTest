using CheckoutKata;
using CheckoutKata.Model;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace UnitTests
{
    public class Tests
    {
        public ICheckout checkout;
        public IEnumerable<Product> products;
        public IEnumerable<Offers> offers;
        [SetUp]
        public void Setup()
        {
            products = new[]
            {
                new Product {SKU = 'A', Price = 50},
                new Product {SKU = 'B', Price = 30},
                new Product {SKU = 'C', Price = 20},
                new Product {SKU = 'D', Price = 15}
            };
            offers = new[]
            {
                new Offers {SKU = 'A', OfferQuantity = 3, OfferDiscount = 20},
                new Offers {SKU = 'B', OfferQuantity = 2, OfferDiscount = 15}
            };
            checkout = new Checkout(products,offers);
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