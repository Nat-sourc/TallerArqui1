using Microsoft.Extensions.Logging;
using PapAPI.Abstraction.DBContext;
using PapAPI.DataAccess;
using PapAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAPI.Repository.Dominio
{
    public class SumaRepository<T>:ARepositoryBase<T> where T : PapAPI.Entity.Dominio.Resta
    {
        ILogger logger;
        IDBContext<T> dbctx;

        public SumaRepository(ILogger<SumaRepository<T>> _logger, IDBContext<T> _ctx, APIDBContext _db) : base(_logger, _ctx, _db)
        {
            this.dbctx = _ctx;
            this.logger = _logger;
            
        }
    }
}
