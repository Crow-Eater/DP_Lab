namespace task2
{
    public class SomeEntity
    {
        private int id;
        private string name;
        private string description;
        private bool status;

        public SomeEntity(int id, string name, string description, bool status)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.status = status;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
