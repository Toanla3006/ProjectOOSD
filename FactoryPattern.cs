using System;
using System.Net.Mail;
namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string  PromotionName = "";
            string  ExpiryDate = "";
            int     Quantity = 0;
            int i = 1;
            while (i != 0)
            {
                Console.WriteLine("Choose 0: Exit Programme");
                Console.WriteLine("Choose 1: Create Basic Promotion");
                Console.WriteLine("Choose 2: Send Email");
                Console.Write("Your Choice: ");
                i = Int32.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Promotion promotion = PromotionFactory.GetPromotion("BasicPromotion");
                    PromotionName = promotion.GetPromotionName();
                    ExpiryDate = promotion.GetExpireTime();
                    Quantity = promotion.GetQuantity();
                }else if( i== 2)
                {
                    String BodyMessage = "Promotion Name: " + PromotionName + "\n" + "Expiry Date: " + ExpiryDate + "\n" + "Quantity: " + Quantity;
                    MailMessage message = new MailMessage("laquoctoan30062000@gmail.com","laquoctoan3006@gmail.com","Promotion", BodyMessage);
                    SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                    client.EnableSsl = true;
                    client.Credentials = new System.Net.NetworkCredential("laquoctoan30062000@gmail.com", "");
                    client.Send(message);
                }
                Console.WriteLine("\n\n================================\n\n");
            }
        }
    }
    public interface Promotion
    {
        String GetPromotionName();
        String GetExpireTime();
        int GetQuantity();
    }

    public class BasicPromotion : Promotion
    { 
        public String GetPromotionName()
        {
            Console.Write("Input the Promotion Name: ");
            String PromotionName = Console.ReadLine();
            return PromotionName;
        }
        public String GetExpireTime()
        {
            Console.Write("Input the Promotion Expiry Date: ");
            String ExpiryDate = Console.ReadLine();
            return ExpiryDate;
        }
        public int GetQuantity()
        {
            Console.Write("Input the Promotion Quantity Turns: ");
            int Quantity = Int32.Parse(Console.ReadLine());
            return Quantity;
        }
    }

    public class LuxuryPromotion : Promotion
    {
        public String GetPromotionName()
        {
            Console.Write("Input the Promotion Name: ");
            String PromotionName = Console.ReadLine();
            return PromotionName;
        }
        public String GetExpireTime()
        {
            Console.Write("Input the Promotion Expiry Date: ");
            String ExpiryDate = Console.ReadLine();
            return ExpiryDate;
        }
        public int GetQuantity()
        {
            Console.Write("Input the Promotion Quantity Turns: ");
            int Quantity = Int32.Parse(Console.ReadLine());
            return Quantity;
        }
    }

    public class PromotionFactory
    {

        private PromotionFactory()
        {
        }

        public static Promotion GetPromotion(String PromotionType)
        {
            switch (PromotionType)
            {

                case "BasicPromotion":
                    return new BasicPromotion();
                case "LuxuryPromotion":
                    return new LuxuryPromotion();
                default:
                    return null;
            }
        }

    }

}
