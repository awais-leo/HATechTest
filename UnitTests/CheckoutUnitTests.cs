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
}