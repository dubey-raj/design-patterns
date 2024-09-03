namespace Strategy
{
    public class PaymentService : IPaymentService
    {
        private IPaymentStrategy _paymentMethod;
        public PaymentService(IPaymentStrategy paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        
        public bool CompletePurchase(double amount)
        {
            return _paymentMethod.ProcessPayment(amount);
        }
    }
}
