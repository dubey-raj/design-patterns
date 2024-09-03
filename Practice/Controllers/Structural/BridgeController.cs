using Bridge.Abstraction;
using Bridge.Implementation;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BridgeController : ControllerBase
    {
        private readonly ILogger<BridgeController> _logger;
        private readonly IServiceProvider _serviceProvider;
        public BridgeController(ILogger<BridgeController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        [HttpGet(Name = "Bridge")]
        public string Get()
        {
            var discount = _serviceProvider.GetRequiredKeyedService<IDiscount>("sdd");
            CarInsurance comp1 = new Comprehensive(2023, "Mercedes-Benz", "E-Class", discount);
            CarInsurance thirdParty1 = new ThirdParty(2023, "VW", "Tiguan", discount);
            CarInsurance propDamage1 = new PropertyDamage(2023, "Cadillac", "Escalade", discount);
            Console.WriteLine("Safe Driver Discounts:");
            Console.WriteLine("----------------------");
            Print(comp1);
            Print(thirdParty1);
            Print(propDamage1);

            discount = _serviceProvider.GetRequiredKeyedService<IDiscount>("ncd");
            CarInsurance comp2 = new Comprehensive(2023, "Mercedes-Benz", "E-Class", discount);
            CarInsurance thirdParty2 = new ThirdParty(2023, "VW", "Tiguan", discount);
            CarInsurance propDamage2 = new PropertyDamage(2023, "Cadillac", "Escalade", discount);
            Console.WriteLine("\nNo Claims Discounts:");
            Console.WriteLine("--------------------");
            Print(comp2);
            Print(thirdParty2);
            Print(propDamage2);

            discount = _serviceProvider.GetRequiredKeyedService<IDiscount>("aod");
            CarInsurance comp3 = new Comprehensive(2023, "Mercedes-Benz", "E-Class", discount);
            CarInsurance thirdParty3 = new ThirdParty(2023, "VW", "Tiguan", discount);
            CarInsurance propDamage3 = new PropertyDamage(2023, "Cadillac", "Escalade", discount);
            Console.WriteLine("\nAuto Owners Discounts:");
            Console.WriteLine("----------------------");
            Print(comp3);
            Print(thirdParty3);
            Print(propDamage3);
            return "";
        }
        static void Print(CarInsurance carInsurance)
        {
            Console.WriteLine($"{PascalCaseToSentence(carInsurance.GetType().Name)} Premium: {carInsurance.Year} {carInsurance.Make} {carInsurance.Model} @ ${carInsurance.CalculatePremium():f2} p/m");
        }

        static string PascalCaseToSentence(string input)
        {
            return Regex.Replace(input, "(\\B[A-Z])", " $1").Trim();
        }
    }
}
