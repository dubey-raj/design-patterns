namespace Strategy
{
    public interface IPaymentService
    {
        bool CompletePurchase(double amount);
    }
}
