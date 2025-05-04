namespace task3
{
    public class User
    {
        private string name;
        private bool isRegistered;
        private bool hasAccess;

        public User(string name, bool isRegistered, bool hasAccess)
        {
            this.name = name;
            this.isRegistered = isRegistered;
            this.hasAccess = hasAccess;
        }

        public string Name
        {
            get { return name; }
        }

        public bool IsRegistered
        {
            get { return isRegistered; }
        }

        public bool HasAccess
        {
            get { return hasAccess; }
        }
    }
}
