
namespace Solid_principle.Customer
{
    public class CustomerNotRegistered :ICalculateDiscount

    {
        public string Name {get;set; }
        public int Id { get; set; }
        public string CustomerType { get; set; }
        public decimal CalculateDiscount(decimal amount, int years) => amount;
        


        public CustomerNotRegistered()
        {
            
        }
       
        public CustomerNotRegistered(string name, int id,string customerType)
        {
            Name = name;
            Id = id;
            CustomerType = customerType;
        }

        


    }
}