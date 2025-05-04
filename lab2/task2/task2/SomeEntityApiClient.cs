namespace task2
{
    public class SomeEntityApiClient
    {
        private SomeEntityController controller;

        public SomeEntityApiClient(SomeEntityController controller)
        {
            this.controller = controller;
        }

        public SomeEntity? GetOne(int id) => controller.GetOne(id);
        public List<SomeEntity> GetMany() => controller.GetMany();
        public void Create(SomeEntity entity) => controller.Create(entity);
        public void Update(SomeEntity entity) => controller.Update(entity);
        public void Delete(int id) => controller.Delete(id);
    }
}