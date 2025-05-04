namespace task2
{
    public class FlexibleSomeEntityApiClient
    {
        private SomeEntityApiClient baseClient;

        public FlexibleSomeEntityApiClient(SomeEntityApiClient baseClient)
        {
            this.baseClient = baseClient;
        }

        public List<SomeEntity> GetSortedByName()
        {
            var list = baseClient.GetMany();
            list.Sort((a, b) => a.Name.CompareTo(b.Name));
            return list;
        }

        public List<SomeEntity> GetByName(string name)
        {
            return baseClient.GetMany().FindAll(e => e.Name == name);
        }

        public List<SomeEntity> GetByStatus(bool status)
        {
            return baseClient.GetMany().FindAll(e => e.Status == status);
        }
    }
}