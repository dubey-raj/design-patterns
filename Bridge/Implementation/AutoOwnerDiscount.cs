namespace Bridge.Implementation
{
    // ConcreteImplementorC
    public class AutoOwnersDiscount : IDiscount
    {
        public int GetDiscount()
        {
            return 5;
        }
    }
}
