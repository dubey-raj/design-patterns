using Microsoft.AspNetCore.Mvc;
using Strategy;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StrategyController : ControllerBase
    {

        private readonly ILogger<BuilderController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public StrategyController(ILogger<BuilderController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Implementation of strategy pattern
        /// </summary>
        /// <param name="payBy">Payment method of payment e.g. cc,paypal,crypto</param>
        /// <returns></returns>
        [HttpGet(Name = "strategy")]
        public string Get(string payBy)
        {
            double purchaseAmount = 100.00;
            IPaymentStrategy paymentMethod = null;

            if (payBy == "cc") {
                paymentMethod = new CreditCardPayment("1234567890123456", "12/25", "123");
            }
            else if (payBy == "paypal")
            {
                paymentMethod = new PayPalPayment("user@example.com");
            }
            else if(payBy == "crypto")
            {
                paymentMethod = new CryptoPayment("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa");
            }

            IPaymentService checkout = new PaymentService(paymentMethod);
            checkout.CompletePurchase(purchaseAmount);

            return $"response using Strategy pattern using {payBy}";
        }
    }
}
