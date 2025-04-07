using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCars
{
    public class Audi : Vehicle
    {
        public Audi(double weight, double length, double maxSpeed,
                    string wheelDrive, string @class, string color)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            WheelDrive = wheelDrive;
            Class = @class;
            Color = color;
        }
    }

    public class Honda : Vehicle
    {
        public Honda(double weight, double length, double maxSpeed,
                     string wheelDrive, string @class, string color)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            WheelDrive = wheelDrive;
            Class = @class;
            Color = color;
        }
    }

    public class Tesla : Vehicle
    {
        public Tesla(double weight, double length, double maxSpeed,
                     string wheelDrive, string @class, string color)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            WheelDrive = wheelDrive;
            Class = @class;
            Color = color;
        }
    }

    public class Volvo : Cargo
    {
        public Volvo(double weight, double length, double maxSpeed,
                     double tonnage, double tankVolume, int axlesAmount)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            Tonnage = tonnage;
            TankVolume = tankVolume;
            AxlesAmount = axlesAmount;
        }
    }

    public class Man : Cargo
    {
        public Man(double weight, double length, double maxSpeed,
                   double tonnage, double tankVolume, int axlesAmount)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            Tonnage = tonnage;
            TankVolume = tankVolume;
            AxlesAmount = axlesAmount;
        }
    }

    public class Scania : Cargo
    {
        public Scania(double weight, double length, double maxSpeed,
                      double tonnage, double tankVolume, int axlesAmount)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            Tonnage = tonnage;
            TankVolume = tankVolume;
            AxlesAmount = axlesAmount;
        }
    }
    public class Abrams : Tank
    {
        public Abrams(double weight, double length, double maxSpeed,
                      double caliber, int shotsPerMinute, int crewSize)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            ProjectileCaliber = caliber;
            ShotsPerMinute = shotsPerMinute;
            CrewSize = crewSize;
        }
    }

    public class Merkava : Tank
    {
        public Merkava(double weight, double length, double maxSpeed,
                       double caliber, int shotsPerMinute, int crewSize)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            ProjectileCaliber = caliber;
            ShotsPerMinute = shotsPerMinute;
            CrewSize = crewSize;
        }
    }

    public class Tiger : Tank
    {
        public Tiger(double weight, double length, double maxSpeed,
                     double caliber, int shotsPerMinute, int crewSize)
        {
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
            ProjectileCaliber = caliber;
            ShotsPerMinute = shotsPerMinute;
            CrewSize = crewSize;
        }
    }

}
