using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.DataAccesLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Concrete;

namespace VizyoneksCase.DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class ,new()
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }
        public void Delete(T entity)
        {
           
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();  
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
             
        }

        public List<T> GetLİst()
        {
           
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
          
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
          
            _context.Set<T>().Update(entity);    
            _context.SaveChanges();
        }
    }
   
}
