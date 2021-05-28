using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
			ModifyPriceSingleTon PriceModify = ModifyPriceSingleTon.GetInstance;
        }
    }

	public sealed class ModifyPriceSingleTon
	{
		private static double PricePerKilometer;
        private static ModifyPriceSingleTon Instance = null;
		public static ModifyPriceSingleTon GetInstance
        {
            get
            {
                if(Instance == null)
                {
                    Instance = new ModifyPriceSingleTon();
                }
                return Instance;
            }
        }
        private ModifyPriceSingleTon()
		{
            Console.Write("Price change: ");
            ModifyPriceSingleTon.PricePerKilometer = Double.Parse(Console.ReadLine());
            Console.WriteLine("Price change to: " + PricePerKilometer);
		}
    }
}
