

namespace CheckoutKata.Model.Interface
{
    public interface IOffers
    {
        char SKU { get; set; }
        int OfferQuantity { get; set; }
        int OfferDiscount { get; set; }
    }
}
