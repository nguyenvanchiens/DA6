using DA6.Api.Interface.IService;
using DA6.Core.Data;
using DA6.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace DA6.Api.Interface.Service
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected DA6DbContext _context = null;
        private DbSet<T> table = null;
        public BaseService(DA6DbContext context)
        {
            this._context = context;
            table = _context.Set<T>();
        }
        public int Delete(object id)
        {
            T existing = GetById(id);
            var result = table.Remove(existing);
            if (result != null)
            {
                Save();
                return (int)StatusCodeRespon.Success;
            }
            return (int)StatusCodeRespon.BadRequest;

        }

        public virtual IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public virtual T GetById(object id)
        {
            return table.Find(id);
        }

        public virtual int Insert(T obj)
        {
            var result = table.Add(obj);
            if (result != null)
            {
                Save();
                return (int)StatusCodeRespon.UpdateSuccess;
            }

            return (int)StatusCodeRespon.BadRequest;
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public virtual int Update(T obj)
        {
            var result = table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            if (result != null)
            {
                Save();
                return (int)StatusCodeRespon.UpdateSuccess;
            }
            return (int)StatusCodeRespon.BadRequest;
        }
    }
}
