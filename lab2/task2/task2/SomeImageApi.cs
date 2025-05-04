namespace task2
{
    public class SomeImageApi
    {
        private SomeEntityController controller;

        public SomeImageApi(SomeEntityController controller)
        {
            this.controller = controller;
        }

        public string? GetImage(int id)
        {
            var entity = controller.GetOne(id) as SomeImageEntity;
            return entity?.ImageUrl;
        }

        public void SetImage(int id, string url)
        {
            var entity = controller.GetOne(id) as SomeImageEntity;
            if (entity != null)
            {
                entity.ImageUrl = url;
            }
        }

        public List<SomeImageEntity> GetEntitiesByFilter(Func<SomeEntity, bool> filter)
        {
            var filtered = controller.GetByFilter(filter);
            var images = new List<SomeImageEntity>();
            foreach (var entity in filtered)
            {
                if (entity is SomeImageEntity imageEntity)
                {
                    images.Add(imageEntity);
                }
            }
            return images;
        }
    }

}