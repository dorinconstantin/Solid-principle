using System;

namespace Solid_principle
{
    interface IPrintTasks
    {
        public void PhotoContent();


        public void ScanContent();

        public void PrintContent();
    }

    interface IPrintDuplicate
    {
        public void PrintDuplicated();
    }
    interface IFax
    {
        public void FaxContent();
    }

    public class HpLaserJet : IPrintTasks , IFax

    {
    public void PhotoContent()
    {
        Console.WriteLine("Copied done");
    }

    public void FaxContent()
    {
        Console.WriteLine("Fax done");
    }

    public void ScanContent()
    {
        Console.WriteLine("Scan done");
    }

    public void PrintContent()
    {
        Console.WriteLine("Print done");

    }

   
    }


   
           
       
        public class Cannon:IPrintTasks,IFax,IPrintDuplicate
        {
            public void PhotoContent()
            {
                Console.WriteLine("Done Photo Copied");
            }

            public void ScanContent()
            {
                Console.WriteLine("Scan Done");
            }

            public void PrintContent()
            {
                Console.WriteLine("Print finished");
            }

            public void FaxContent()
            {
                Console.WriteLine("The document send");
            }

            public void PrintDuplicated()
            {
                throw new NotImplementedException();
            }
        }
 
}