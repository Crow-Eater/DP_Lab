namespace task2
{
    public class SomeEntityController
    {
        private List<SomeEntity> someEntitiesList = new();

        public void Create(SomeEntity entity)
        {
            someEntitiesList.Add(entity);
        }

        public void Update(SomeEntity entity)
        {
            var existing = someEntitiesList.FirstOrDefault(entity => entity.Id == entity.Id);
            if (existing != null)
            {
                existing.Name = entity.Name;
                existing.Description = entity.Description;
                existing.Status = entity.Status;
            }
        }

        public List<SomeEntity> GetByFilter(Func<SomeEntity, bool> filter)
        {
            return someEntitiesList.Where(filter).ToList();
        }

        public void Delete(int id)
        {
            someEntitiesList.RemoveAll(e => e.Id == id);
        }

        public void SetStatus(int id, bool status)
        {
            var e = GetOne(id);
            if (e != null) e.Status = status;
        }
        public void DeleteMany(List<int> ids)
        {
            someEntitiesList.RemoveAll(e => ids.Contains(e.Id));
        }

        public SomeEntity? GetOne(int id)
        {
            return someEntitiesList.FirstOrDefault(e => e.Id == id);
        }

        public List<SomeEntity> GetMany()
        {
            return someEntitiesList;
        }

        public void Print(int id)
        {
            var someEntity = GetOne(id);
            if (someEntity != null)
            {
                Console.WriteLine($"{{\"Id\": {someEntity.Id}, \"Name\": \"{someEntity.Name}\", \"Description\": \"{someEntity.Description}\", \"Status\": \"{someEntity.Status}\"}}");
            }
        }

        public void PrintMany()
        {
            foreach (var someEntity in someEntitiesList)
            {
                Print(someEntity.Id);
            }
        }
        public void Activate(int id)
        {
            SetStatus(id, true);
        }

        public void Deactivate(int id)
        {
            SetStatus(id, false);
        }
    }
}
