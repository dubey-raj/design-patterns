using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public class ThirdParty : CarInsurance
    {
        public ThirdParty(int year, string make, string model, IDiscount discount) : base(year, make, model, discount)
        {
        }

        protected override decimal GetPremium()
        {
            return 50.00m;
        }
    }
}
