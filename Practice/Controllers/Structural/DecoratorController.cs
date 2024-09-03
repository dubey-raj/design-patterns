using Decorator;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecoratorController : ControllerBase
    {

        private readonly ILogger<DecoratorController> _logger;

        public DecoratorController(ILogger<DecoratorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Decorator")]
        public string Get()
        {
            //Create an instance of Concrete Component BMWCar
            ICar bmwCar1 = new BMWCar();
            //Calling the ManufactureCar method will create the BMWCar without an engine
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            //Adding Diesel Engine to the bmwCar1
            //Create an instance DieselCarDecorator class and 
            //pass existing bmwCar1 as an argument to the Constructor which we want to decorate
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            //Calling the ManufactureCar method on the carWithDieselEngine object will add Diesel Engine to the bmwCar1 car
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();

            //The Process is the same for adding Petrol Engine to the existing Car
            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();

            return "Response with decorator pattern";
        }
    }
}
