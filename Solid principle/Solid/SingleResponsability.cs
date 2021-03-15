namespace Solid_principle
{
   public  interface ILogger
    {
        public void SendMail(string sendmail);
       
    }

   public interface ILogError
    {
        public void LogError(string error);
       
        
        
        interface IUser
        {
            public void Login(string passw, string user);
            public void Register(string user, string passw);

        }
    }

}