using CheckoutKata.Model.Interface;

namespace CheckoutKata.Model
{
    public class Offers : IOffers
    {
        public char SKU { get; set; }
        public int OfferQuantity { get; set; }
        public int OfferDiscount { get; set; }
    }
}
