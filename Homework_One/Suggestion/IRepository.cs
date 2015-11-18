using System;
using System.Collections.Generic;

namespace Homework_One.Suggestion
{
    public interface IRepository
    {
        void Add<TEntity>(TEntity entity) where TEntity : Entity;

        void Update<TEntity>(TEntity entity) where TEntity : Entity;

        void Delete<TEntity>(TEntity entity) where TEntity : Entity;

        TEntity GetById<TEntity>(Guid id) where TEntity : Entity;

        IEnumerable<TEntity> GetAll<TEntity>() where TEntity : Entity;
    }

    public class Entity
    {
        public Guid Id { get; set; }
    }

    public class InMemoryRepository : IRepository
    {
        public void Add<TEntity>(TEntity entity) where TEntity : Entity
        {
            entity.Id = Guid.NewGuid();

            Table<TEntity>.Instance.Add(entity.Id, entity);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : Entity
        {
            Table<TEntity>.Instance[entity.Id] = entity;
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : Entity
        {
            Table<TEntity>.Instance.Remove(entity.Id);
        }

        public TEntity GetById<TEntity>(Guid id) where TEntity : Entity
        {
            return Table<TEntity>.Instance[id];
        }

        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : Entity
        {
            return Table<TEntity>.Instance.Values;
        }

        private static class Table<TEntity>
        {
            private static IDictionary<Guid, TEntity> _instance;

            public static IDictionary<Guid, TEntity> Instance
            {
                get
                {
                    if (_instance != null)
                    {
                        return _instance;
                    }

                    _instance = new Dictionary<Guid, TEntity>();

                    return _instance;
                }
            }
        }
    }
}
