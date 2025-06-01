namespace task3
{
    class Program3
    {
        static void Main()
        {
            var container = new Container();
            var car1 = new Sedan("Toyota");

            container.Add(car1);
            car1.Model = "Honda";
        }
    }
}