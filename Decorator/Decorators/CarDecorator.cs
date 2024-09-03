namespace Decorator
{
    // The Base Decorator class is also inherited from the same interface as the other Concrete Components inherited. 
    // The primary responsibility of this Base Decorator class is to define the wrapping interface for all concrete decorators. 
    // The default implementation of the wrapping code includes a field for storing a wrapped component and
    // we need to initialize that field. Here, we are initializing that field using the class constructor

    //Inherited from the Base Component Interface
    public abstract class CarDecorator : ICar
    {
        //Create a Field to store the Concrete Component
        protected ICar car;

        //Initializing the Field using Constructor
        //While Creating an instance of the CarDecorator (Instance of the Child Class that Implements CarDecorator abstract)
        //We need to pass the existing car object which we want to decorate
        public CarDecorator(ICar car)
        {
            //Store that existing car object in the car variable
            this.car = car;
        }

        //Providing Implementation for the Base Component Interface
        //Here, we are just calling the Concrete Component ManufactureCar method
        //We are making this Method Virtual to allow the Child Concrete Decorator class to override
        public virtual ICar ManufactureCar()
        {
            //Call the Existing Car Object ManufactureCar method to return the car without engine
            //Later in the Child class of this abstract we will see how to call this method 
            //and how to add an Engine
            return car.ManufactureCar();
        }
    }
}
