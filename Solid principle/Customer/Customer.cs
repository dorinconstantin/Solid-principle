namespace Solid_principle.Customer
{
    public abstract class Customer: ICalculateDiscount
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public string CustomerType { get; set; }

        public Customer()
        {

        }
        public Customer(string name,int id,string customerType)
        {
            Name = name;
            Id = id;
            CustomerType = customerType;
        }
        public abstract decimal CalculateDiscount(decimal amount, int years);








    }
    }