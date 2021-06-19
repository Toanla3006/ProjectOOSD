using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            USER customer = new CUSTOMER(new CheckingAccount());
            customer.RegisterAccount();
        }
    }

    public interface Account
    {
        void RegisterAccount(string USERNAME, string PASSWORD);
    }

    public class CheckingAccount : Account
    {
        public void RegisterAccount(string USERNAME, string PASSWORD)
        {
            if(USERNAME != "Admin")
            {
                Console.WriteLine("CHECKED USERNAME");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
          
        }
    }
    public class SavingAccount: Account
    {
        public void RegisterAccount(string USERNAME, string PASSWORD)
        {
            Console.WriteLine("SAVING ACCOUNT");
        }
    }

    public abstract class USER
    {

        protected Account account;

        public USER(Account account)
        {
            this.account = account;
        }

        public abstract void RegisterAccount();
    }

    public class CUSTOMER : USER
    {
           public CUSTOMER(Account account) : base(account)
           {
               
           }
           public override void RegisterAccount()
           {
                string Username, Password;
                Console.WriteLine("Register: ");
                Console.Write("Input Username: ");
                Username = Console.ReadLine();
                Console.Write("Input Password: ");
                Password = Console.ReadLine();
                Console.WriteLine("REGISTED AS CUSTOMER");
                account.RegisterAccount(Username,Password);
            }
    }
    public class Shipper : USER
    {
        public Shipper(Account account) : base(account)
        {

        }
        public override void RegisterAccount()
        {
            string Username, Password;
            Console.WriteLine("Register: ");
            Console.Write("Input Username: ");
            Username = Console.ReadLine();
            Console.Write("Input Password: ");
            Password = Console.ReadLine();
            Console.WriteLine("REGISTED AS SHIPPER");
            account.RegisterAccount(Username,Password);
        }
    }

    public class Admin : USER
    {
        public Admin(Account account) : base(account)
        {

        }
        public override void RegisterAccount()
        {
            string Username, Password;
            Console.WriteLine("Register: ");
            Console.Write("Input Username: ");
            Username = Console.ReadLine();
            Console.Write("Input Password");
            Password = Console.ReadLine();
            Console.WriteLine("REGISTED AS ADMIN");
            account.RegisterAccount(Username,Password);
        }
    }
}
