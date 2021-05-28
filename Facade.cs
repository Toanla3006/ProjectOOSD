using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingPaymentFacade.getInstance().buyProductByCashWithFreeShipping("helloworld@gmail.com");
        }
    }

    public class AccountService
    {

        public void getAccount(String email)
        {
            Console.WriteLine("Getting the account of " + email);
        }
    }

    public class PaymentService
    {

        public void paymentByPaypal()
        {
            Console.WriteLine("Payment by Paypal");
        }

        public void paymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit Card");
        }

        public void paymentByEbankingAccount()
        {
            Console.WriteLine("Payment by E-banking account");
        }

        public void paymentByCash()
        {
            Console.WriteLine("Payment by cash");
        }
    }

    public class ShippingService
    {

        public void freeShipping()
        {
            Console.WriteLine("Free Shipping");
        }

        public void standardShipping()
        {
            Console.WriteLine("Standard Shipping");
        }

        public void expressShipping()
        {
            Console.WriteLine("Express Shipping");
        }
    }

    public class ShippingPaymentFacade
    {
        private AccountService accountService;
        private static ShippingPaymentFacade INSTANCE = new ShippingPaymentFacade();
        private PaymentService paymentService;

        private ShippingPaymentFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
        }

        public static ShippingPaymentFacade getInstance()
        {
            return INSTANCE;
        }

        public void buyProductByCashWithFreeShipping(String email)
        {
            accountService.getAccount(email);
            paymentService.paymentByCash();
            Console.WriteLine("Done");
        }
    }
}
