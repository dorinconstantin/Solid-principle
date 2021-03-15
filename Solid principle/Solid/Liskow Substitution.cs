namespace Solid_principle
{
    public abstract  class  Employee: IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        //public  double WorkingHours { get; set; }
     
        public Employee()
        {
        }

        public Employee(int id , string name )
        {
            Id = id;
            Name = name;
         
        }

        public abstract double CalculateBonus(int salary);
       
        public override string ToString() => string.Format("Id: {0} NamE:{1}", Id, Name);
        
    }

    public class PermanentEmployee:Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base (id,name)
        {}

        public override double CalculateBonus(int salary) => salary * 0.5;
    }

    public class TemporaryEmployee:Employee
    {
        public TemporaryEmployee() { }

        public TemporaryEmployee(int id, string name): base(id,name)
        {

        }

        public override double CalculateBonus(int salary) => salary * 0.1;

    }

   

   public  interface IEmployee
    {
        string Name { get; set; }
        int Id { get; set; }
        public double CalculateBonus(int salary);
    }
        
    
}
