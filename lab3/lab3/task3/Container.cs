namespace task3
{
    class Container
    {
        private List<Car> cars = new();

        public void Add(Car car)
        {
            cars.Add(car);
            Console.WriteLine($"Добавлен объект типа {car.GetType().Name}");

            car.OnPropertyChanged += (prop, oldVal, newVal) =>
            {
                Console.WriteLine($"Изменено свойство {prop}: '{oldVal}' -> '{newVal}'");
            };
        }
    }
}
