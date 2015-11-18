using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Homework_One
{
    public class Repositories<T> : IRepository<T> where T : class 
    {
       
        
        // Get all entities in a list
        public IEnumerable<T> List { get; set; }
        

        public T GetById(T entity)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(List<T> entities)
        {
            var list = from item in entities select item;
            return list;
        }

    }
}