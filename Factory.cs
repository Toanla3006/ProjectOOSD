using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Promotion promotion = PromotionFactory.GetPromotion("Discount50Percentage");
            String A = promotion.getPromotionName();
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine("Send " + A + " to Customer " + i);
            }
        }
    }
    public interface Promotion
    {
        String getPromotionName();
        String getTime();
        String CustomerStageForApply();
        int Quantity();
    }

    public class Discount10Percentage : Promotion
    {
        public String getPromotionName()
        {
            return "Discount 10%";
        }
        public String getTime()
        {
            return "1 month";
        }
        public String CustomerStageForApply()
        {
            return "Basic";
        }
        public int Quantity()
        {
            return 5;
        }
    }

    public class Discount50Percentage : Promotion
    {
        public String getPromotionName()
        {
            return "Discount 50%";
        }
        public String getTime()
        {
            return "15 days";
        }
        public String CustomerStageForApply()
        {
            return "Gold";
        }
        public int Quantity()
        {
            return 1;
        }
    }
    public class PromotionFactory
    {
        private PromotionFactory()
        {
        }
        public static Promotion GetPromotion(String promoteName)
        {   
            switch (promoteName)
            {
                
                case "Discount10Percentage":
                    return new Discount10Percentage();

                case "Discount50Percentage":
                    return new Discount50Percentage();

                default:
                    return null;
            }
        }
    }
}
