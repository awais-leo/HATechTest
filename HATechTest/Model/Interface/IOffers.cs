using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Model.Interface
{
    public interface IOffers
    {
        char SKU { get; set; }
        int OfferQuantity { get; set; }
        int OfferDiscount { get; set; }
    }
}
