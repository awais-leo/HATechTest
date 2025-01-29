
namespace CheckoutKata
{
    public interface ICheckout
    {
        void ScanItem(string item);
        int GetTotalPrice();
    }
}
