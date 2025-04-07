using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCars
{
    public abstract class CarFactory
    {
        public abstract Car CreateCar(params object[] parameters);
    }

    public class AudiFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Audi((double)p[0], (double)p[1], (double)p[2], (string)p[3], (string)p[4], (string)p[5]);
    }

    public class HondaFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Honda((double)p[0], (double)p[1], (double)p[2], (string)p[3], (string)p[4], (string)p[5]);
    }

    public class TeslaFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Tesla((double)p[0], (double)p[1], (double)p[2], (string)p[3], (string)p[4], (string)p[5]);
    }

    public class VolvoFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Volvo((double)p[0], (double)p[1], (double)p[2], (double)p[3], (double)p[4], (int)p[5]);
    }

    public class ManFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Man((double)p[0], (double)p[1], (double)p[2], (double)p[3], (double)p[4], (int)p[5]);
    }

    public class ScaniaFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Scania((double)p[0], (double)p[1], (double)p[2], (double)p[3], (double)p[4], (int)p[5]);
    }

    public class AbramsFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Abrams((double)p[0], (double)p[1], (double)p[2], (double)p[3], (int)p[4], (int)p[5]);
    }

    public class MerkavaFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Merkava((double)p[0], (double)p[1], (double)p[2], (double)p[3], (int)p[4], (int)p[5]);
    }

    public class TigerFactory : CarFactory
    {
        public override Car CreateCar(params object[] p) =>
            new Tiger((double)p[0], (double)p[1], (double)p[2], (double)p[3], (int)p[4], (int)p[5]);
    }

}
