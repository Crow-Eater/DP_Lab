namespace task2
{
    public class SomeImageEntity : SomeEntity
    {
        private string imageUrl;

        public SomeImageEntity(int id, string name, string description, bool status, string imageUrl)
            : base(id, name, description, status)
        {
            this.imageUrl = imageUrl;
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
    }
}