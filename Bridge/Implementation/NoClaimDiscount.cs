namespace Bridge.Implementation
{
    public class NoClaimsDiscount : IDiscount
    {
        public int GetDiscount()
        {
            return 15;
        }
    }
}
