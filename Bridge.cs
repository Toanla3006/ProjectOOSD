using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Login AsCustomer = new CustomerLogin(new CheckingValid());
            AsCustomer.CheckAccount();
            Login AsShipper = new ShipperLogin(new CheckingValid());
            AsShipper.CheckAccount();
            Login AsAdministrator = new AdminLogin(new CheckingValid());
            AsAdministrator.CheckAccount();
        }
    }

    public interface Account
    {
        void CheckAccount();
    }

    public class CheckingValid : Account
    {
        public void CheckAccount()
        {
            Console.WriteLine("Account was checked !!!");
        }
    }

    public abstract class Login
    {
        protected Account account;

        protected Login()
        {
        }

        public abstract void CheckAccount();
    }

    public class AdminLogin : Login
    {
        public AdminLogin(Account acc)
        {
            this.account = acc;
        }
        public override void CheckAccount()
        {
            Console.WriteLine("You loggin as Administrator: ");
            account.CheckAccount();
        }
    }

    public class ShipperLogin : Login
    {
        public ShipperLogin(Account acc)
        {
            this.account = acc;
        }
        public override void CheckAccount()
        {
            Console.WriteLine("You loggin as Shipper: ");
            account.CheckAccount();
        }
    }

    public class CustomerLogin : Login
    {
        public CustomerLogin(Account acc)
        {
            this.account = acc;
        }
        public override void CheckAccount()
        {
            Console.WriteLine("You loggin as Customer: ");
            account.CheckAccount();
        }
    }
}
