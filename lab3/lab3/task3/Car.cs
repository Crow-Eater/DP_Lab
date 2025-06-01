namespace task3
{
    abstract class Car
    {
        public event Action<string, object, object>? OnPropertyChanged;

        protected void Notify(string property, object oldValue, object newValue)
        {
            OnPropertyChanged?.Invoke(property, oldValue, newValue);
        }
    }

    class Sedan : Car
    {
        private string model;
        public string Model
        {
            get => model;
            set
            {
                var old = model;
                model = value;
                Notify(nameof(Model), old, value);
            }
        }

        public Sedan(string model) => this.model = model;
    }
}
