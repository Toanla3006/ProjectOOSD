using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingPaymentFacade.getInstance().CalculateShipment();
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
            Console.WriteLine("Payment by Cash");
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
        private PaymentService paymentService;
        private ShippingService shippingService;
        private static ShippingPaymentFacade INSTANCE = new ShippingPaymentFacade();

        private ShippingPaymentFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
        }

        public static ShippingPaymentFacade getInstance()
        {
            return INSTANCE;
        }

        public void CalculateShipment()
        {
            Double Total = 0;
            int choice1 = 0;
            int choice2 = 0;
            Console.Write("Input Email to Contact: ");
            String email = Console.ReadLine();
            Console.Write("Input Estimated Kilometer: ");
            Double Kilometer = Double.Parse(Console.ReadLine()); 
            Console.WriteLine("==============================");
            Console.WriteLine("Choose 1: Use Paypal");
            Console.WriteLine("Choose 2: Use Credit Card");
            Console.WriteLine("Choose 3: Use E-banking account");
            Console.WriteLine("Choose 4: Use Cash");
            Console.Write("Please choose your way to pay:");
            choice1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("==============================");
            Console.WriteLine("Choose 1: Free Shipping");
            Console.WriteLine("Choose 2: Standard Shipping");
            Console.WriteLine("Choose 3: Express Shipping");
            Console.Write("Please choose type of Delivery:");
            choice2 = Int32.Parse(Console.ReadLine());
            Console.Clear();
            accountService.getAccount(email);
            if(choice1 == 1){
                paymentService.paymentByPaypal();
            }else if (choice1 == 2){
                paymentService.paymentByCreditCard();
            }else if (choice1 == 3)
            {
                Total = Kilometer + 2;
                paymentService.paymentByEbankingAccount();
            }else{
                Total = Kilometer + 3;
                paymentService.paymentByCash();
            }

            if (choice2 == 1)
            {
                shippingService.freeShipping();
            }
            else if (choice2 == 2)
            {
                Total = Kilometer * 5;
                shippingService.standardShipping();
            }
            else
            {
                Total += Kilometer * 10;
                shippingService.expressShipping();
            }
            Console.WriteLine("Total Price: " + Total + "$");
            Console.WriteLine("Calculate Done");
        }
    }
}
