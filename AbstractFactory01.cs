using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice = 0;
            Console.WriteLine("Choose 1: For Fast Shipping With Motorbikes");
            Console.WriteLine("Choose 2: For Fast Shipping With Truck");
            Console.Write("Your Choice: ");
            Choice = Int32.Parse(Console.ReadLine());
            if(Choice == 1)
            {
                FastShipment fastShipment = new FastShipment();
                fastShipment.Show();
            }
            else
            {
                TruckShipment truckShipment = new TruckShipment();
                truckShipment.Show();
            }
        }
    }

    public class FastShipment : OrderFactory
    {
        public override ShipmentLength GetDetails1()
        {
            return new Under10km();
        }

        public override ShipmentTime GetDetails2()
        {
            return new FastSpeed();
        }

        public override ShipmentVehicles GetDetails3()
        {
            return new Motorbikes();
        }
    }

    public class TruckShipment : OrderFactory
    {
        public override ShipmentLength GetDetails1()
        {
            return new Under10km();
        }

        public override ShipmentTime GetDetails2()
        {
            return new FastSpeed();
        }

        public override ShipmentVehicles GetDetails3()
        {
            return new Trucks();
        }
    }

    public abstract class OrderFactory
    {
        public abstract ShipmentLength GetDetails1();
        public abstract ShipmentTime GetDetails2();
        public abstract ShipmentVehicles GetDetails3();

        public void Show()
        {
            Console.WriteLine(this.GetDetails1());
            Console.WriteLine(this.GetDetails2());
            Console.WriteLine(this.GetDetails3());
        }
    }

    public interface ShipmentLength
    {
        object Details();
    }

    public interface ShipmentTime
    {
        object Details();
    }

    public interface ShipmentVehicles
    {
        object Details();
    }

    public class Under10km : ShipmentLength
    {
        public object Details()
        {
            return "The length is under 10km";
        }
    }

    public class Morethan10KM : ShipmentLength
    {
        public object Details()
        {
            return "The length is more than 10km";
        }
    }

    public class NormalSpeed : ShipmentTime
    {
        public object Details()
        {
            return "At most 5 hours to delivery";
        }
    }
    public class FastSpeed : ShipmentTime
    {
        public object Details()
        {
            return"At most 2 hours to delivery";
        }
    }

    public class Motorbikes : ShipmentVehicles
    {
        public object Details()
        {
           return "This item will be delivery by motobikes";
        }
    }
    public class Vans : ShipmentVehicles
    {
        public object Details()
        {
            return "This item will be delivery by vans";
        }
    }

    public class Trucks : ShipmentVehicles
    {
        public object Details()
        {
            return "This item will be delivery by trucks";
        }
    }

}

