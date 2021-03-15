namespace Solid_principle.Customer
{
    public interface ICalculateDiscount
    {
      string Name { get; set; }
      int Id { get; set; }
      string CustomerType { get; set; }
        public decimal CalculateDiscount(decimal amount, int years);

    }
}