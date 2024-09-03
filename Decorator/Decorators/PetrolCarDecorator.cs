namespace Decorator
{
    //The following Concrete Decorator class will add Petrol Engine to the Existing Car
    public class PetrolCarDecorator : CarDecorator
    {
        //Pass the existing car object while creating the Instance of PetrolCarDecorator class
        //Also pass the same existing pizza object to the base class constructor 
        //i.e. CarDecorator abstract class constructor
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }

        //Overriding the ManufactureCar method to add Petrol Engine
        public override ICar ManufactureCar()
        {
            //First Call the Concrete Components ManufactureCar Method 
            car.ManufactureCar();
            //Then Add a Petrol Engine by calling the AddEngine Method
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}
