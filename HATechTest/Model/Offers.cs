using CheckoutKata.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Model
{
    public class Offers : IOffers
    {
        public char SKU { get; set; }
        public int OfferQuantity { get; set; }
        public int OfferDiscount { get; set; }
    }
}
