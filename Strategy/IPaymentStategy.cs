namespace Strategy
{
    //Strategy (Interface)
    public interface IPaymentStrategy
    {
        bool ProcessPayment(double amount);
    }
}
