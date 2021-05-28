using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FastShipment Delivery = new FastShipment();
            Delivery.Show();
            Console.WriteLine("==============================");
            TruckShipment TruckDelivery = new TruckShipment();
            TruckDelivery.Show();
        }
    }
    public abstract class ShipmentOrder
    {
        public abstract ShipmentLength GetDetails1();
        public abstract ShipmentMethod GetDetails2();
        public abstract ShipmentVehicles GetDetails3();
        public abstract ShipmentStatus GetDetails4();
        public abstract PricePerKilomet GetDetails5();

        public void Show()
        {
            Console.WriteLine(this.GetDetails1());
            Console.WriteLine(this.GetDetails2());
            Console.WriteLine(this.GetDetails3());
            Console.WriteLine(this.GetDetails4());
            Console.WriteLine(this.GetDetails5());
        }
    }

    public class FastShipment : ShipmentOrder
    {
        public override ShipmentLength GetDetails1()
        {
            return new Under10km();
        }

        public override ShipmentMethod GetDetails2()
        {
            return new FastSpeed();
        }

        public override ShipmentVehicles GetDetails3()
        {
            return new Motobikes();
        }

        public override ShipmentStatus GetDetails4()
        {
            return new Pending();
        }
        public override PricePerKilomet GetDetails5()
        {
            return new Price1();
        }
    }

    public class TruckShipment : ShipmentOrder
    {
        public override ShipmentLength GetDetails1()
        {
            return new Under10km();
        }

        public override ShipmentMethod GetDetails2()
        {
            return new FastSpeed();
        }

        public override ShipmentVehicles GetDetails3()
        {
            return new Trucks();
        }

        public override ShipmentStatus GetDetails4()
        {
            return new Pending();
        }
        public override PricePerKilomet GetDetails5()
        {
            return new Price3();
        }
    }

    public interface ShipmentLength
    {
        object Details();
    }

    public interface ShipmentMethod
    {
        object Details();
    }

    public interface ShipmentVehicles
    {
        object Details();
    }

    public interface ShipmentStatus
    {
        object Details();
    }

    public interface PricePerKilomet
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

    public class NormalSpeed : ShipmentMethod
    {
        public object Details()
        {
            return "At most 5 hours to delivery";
        }
    }
    public class FastSpeed : ShipmentMethod
    {
        public object Details()
        {
            return "At most 2 hours to delivery";
        }
    }
    public class Motobikes : ShipmentVehicles
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
    public class WaitingToGet : ShipmentStatus
    {
        public object Details()
        {
            return "This item is in waiting";
        }
    }

    public class Pending : ShipmentStatus
    {
        public object Details()
        {
            return "This order is delivering";
        }
    }

    public class Finish : ShipmentStatus
    {
        public object Details()
        {
            return "This order is finished";
        }
    }
    public class Price1 : PricePerKilomet
    {
        public object Details()
        {
            return "Price: 2$ per KM";
        }
    }

    public class Price2 : PricePerKilomet
    {
        public object Details()
        {
            return "Price: 3.5$ per KM";
        }
    }

    public class Price3 : PricePerKilomet
    {
        public object Details()
        {
            return "Price: 5$ per KM";
        }
    }
}
