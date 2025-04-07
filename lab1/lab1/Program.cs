namespace FactoryMethodCars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory audiFactory = new AudiFactory();
            Car audi = audiFactory.CreateCar(1400.0, 4.4, 240.0, "front", "sedan", "black");
            PrintVehicleInfo("Audi", audi);

            CarFactory hondaFactory = new HondaFactory();
            Car honda = hondaFactory.CreateCar(1300.0, 4.3, 220.0, "front", "sedan", "red");
            PrintVehicleInfo("Honda", honda);

            CarFactory teslaFactory = new TeslaFactory();
            Car tesla = teslaFactory.CreateCar(2000.0, 4.7, 250.0, "all", "electric", "white");
            PrintVehicleInfo("Tesla", tesla);

            Console.WriteLine();

            CarFactory volvoFactory = new VolvoFactory();
            Car volvo = volvoFactory.CreateCar(9000.0, 8.5, 100.0, 25.0, 500.0, 4);
            PrintCargoInfo("Volvo", volvo);

            CarFactory manFactory = new ManFactory();
            Car man = manFactory.CreateCar(9500.0, 9.0, 95.0, 30.0, 550.0, 6);
            PrintCargoInfo("Man", man);

            CarFactory scaniaFactory = new ScaniaFactory();
            Car scania = scaniaFactory.CreateCar(9200.0, 8.7, 105.0, 27.0, 520.0, 5);
            PrintCargoInfo("Scania", scania);

            Console.WriteLine();

            CarFactory abramsFactory = new AbramsFactory();
            Car abrams = abramsFactory.CreateCar(62000.0, 9.7, 70.0, 120.0, 6, 4);
            PrintTankInfo("Abrams", abrams);

            CarFactory merkavaFactory = new MerkavaFactory();
            Car merkava = merkavaFactory.CreateCar(65000.0, 9.0, 65.0, 120.0, 5, 4);
            PrintTankInfo("Merkava", merkava);

            CarFactory tigerFactory = new TigerFactory();
            Car tiger = tigerFactory.CreateCar(57000.0, 8.5, 60.0, 88.0, 4, 5);
            PrintTankInfo("Tiger", tiger);
        }

        static void PrintVehicleInfo(string name, Car car)
        {
            var vehicle = car as Vehicle;
            Console.WriteLine($"{name} - {vehicle.Class}, {vehicle.Color}, {vehicle.WheelDrive} drive, {vehicle.MaxSpeed} km/h");
        }

        static void PrintCargoInfo(string name, Car car)
        {
            var cargo = car as Cargo;
            Console.WriteLine($"{name} - {cargo.Tonnage}t, {cargo.TankVolume}L, {cargo.AxlesAmount} axles");
        }

        static void PrintTankInfo(string name, Car car)
        {
            var tank = car as Tank;
            Console.WriteLine($"{name} - {tank.ProjectileCaliber}mm, {tank.ShotsPerMinute} shots/min, crew: {tank.CrewSize}");
        }
    }

}
