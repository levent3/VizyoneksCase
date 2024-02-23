using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.DataAccesLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Concrete;

namespace VizyoneksCase.DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class 
    {
        public void Delete(T entity)
        {
            using var context = new Context();
            context.Set<T>().Remove(entity);
            context.SaveChanges();  
        }

        public T GetById(int id)
        {
            var context = new Context();
            return context.Set<T>().Find(id);
             
        }

        public List<T> GetLİst()
        {
            var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            var context = new Context();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var context = new Context();
            context.Set<T>().Update(entity);    
            context.SaveChanges();
        }
    }
   
}
