namespace Strategy
{
    //Concrete Strategies
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;
        private string _expiryDate;
        private string _cvc;
        public CreditCardPayment(string cardNumber, string expiryDate, string cvc)
        {
            _cardNumber = cardNumber;
            _expiryDate = expiryDate;
            _cvc = cvc;
        }
        public bool ProcessPayment(double amount)
        {
            // Logic to process credit card payment
            Console.WriteLine($"Processed payment of {amount} using Credit Card");
            return true;
        }
    }
}
