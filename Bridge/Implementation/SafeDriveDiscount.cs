namespace Bridge.Implementation
{
    // ConcreteImplementorA
    public class SafeDriverDiscount : IDiscount
    {
        public int GetDiscount()
        {
            return 10;
        }
    }
}
