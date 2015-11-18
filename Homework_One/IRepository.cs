using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_One
{
    public interface IRepository<T> where T : class 
    {
        // Property List Entity
        IEnumerable<T> List { get; set; }

        // Get/Load entity
        T GetById(T entity);

        // Add entity
        void Add(T entity);

        // Update entity
        void Update(T entity);

        // Delete entity 
        void Delete(T entity);

        // Get all entities in a list
        IEnumerable<T> GetAll(List<T> entities);

        

    }
}