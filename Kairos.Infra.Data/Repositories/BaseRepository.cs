using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Domain.Interfaces.Repositories;

namespace Kairos.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntiry obj)
        {
            Db.Set<TEntiry>().Add(obj);
            Db.SaveChanges();
        }

        public TEntiry GetById(int id)
        {
            return Db.Set<TEntiry>().Find(id);
        }

        public IEnumerable<TEntiry> GetAll()
        {
            return Db.Set<TEntiry>().ToList();
        }

        public void Update(TEntiry obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntiry obj)
        {
            Db.Set<TEntiry>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
