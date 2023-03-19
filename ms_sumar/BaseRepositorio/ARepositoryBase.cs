using PapAPI.Abstraction;
using PapAPI.Abstraction.DBContext;
using PapAPI.DataAccess;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Repository
{

    public interface IARepositoryBase<T> : ICRUD<T>
    {

    }

    public abstract class ARepositoryBase<T>: IARepositoryBase<T> where T : IEntity
    {
        ILogger logger;
        IDBContext<T> dbctx;
        APIDBContext db;

        public ARepositoryBase(ILogger<ARepositoryBase<T>> _logger, IDBContext<T> _ctx, APIDBContext _db)
        {
            this.dbctx = _ctx;
            this.logger = _logger;
            this.db = _db;
        }

        public T GetById(int id)
        {
            return this.dbctx.GetById(id);
        }

        public IList<T> GetAll()
        {
            return this.dbctx.GetAll();
        }


        public T Save(T entity)
        {
            return this.dbctx.Save(entity);
        }

    
    }
}
