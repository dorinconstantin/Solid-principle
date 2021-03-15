namespace Solid_principle.Customer
{
    public class PremiumCustomer:ICalculateDiscount
    {

        public string Name { get; set; }
        public int Id { get; set; }
        

        public string CustomerType { get; set; }
        public PremiumCustomer() 
        {
            
        }
        public PremiumCustomer(string name , int id,string customerType)
        {
            Name = name;
            Id = id;
            CustomerType = customerType;
        }


        
        public decimal CalculateDiscount(decimal amount, int years)
        {
            decimal discount = years > 5 ? (decimal)5 / 100 : (decimal)years / 100;
            return (0.7m * amount) - discount * (0.7m * amount);
        }
    }
    }

    


