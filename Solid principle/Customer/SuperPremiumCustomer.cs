namespace Solid_principle.Customer
{
    public class SuperPremiumCustomer:ICalculateDiscount
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string CustomerType { get; set; }

        public decimal CalculateDiscount(decimal amount, int years)
        {
            decimal discount = years > 5 ? (decimal)5 / 100 : (decimal)years / 100;
            return (amount - (0.5m * amount)) - discount * (amount - (0.5m * amount));
        }

        public SuperPremiumCustomer()
        {
            
        }
        public SuperPremiumCustomer(string name , int id , string customerType)
        {
            Name = name;
            Id = id;
            CustomerType = customerType;
        }
       
    }
}