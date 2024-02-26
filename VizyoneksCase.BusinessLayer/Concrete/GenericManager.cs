using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Concrete;
using VizyoneksCase.DataAccesLayer.Repositories;

namespace VizyoneksCase.BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class, new()
    {

        private readonly DataAccesLayer.Abstract.IGenericDal<T> _genericDal;
        protected Context _context { get; }
        public GenericManager(Context context)
        {
            _context = context;
            _genericDal = new GenericRepository<T>(context);
        }
        void IGenericService<T>.TDelete(T entity)
        {
            _genericDal.Delete(entity); 
        }

        T IGenericService<T>.TGetById(int id)
        {
           var data= _genericDal.GetById(id);
            return data;
        }

        List<T> IGenericService<T>.TGetLİst()
        {
            var data=_genericDal.GetLİst();
            return data;

        }

        void IGenericService<T>.TInsert(T entity)
        {
            _genericDal.Insert(entity); 
        }

        void IGenericService<T>.TUpdate(T entity)
        {
            _genericDal.Update(entity); 
        }
    }
}
