using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapAPI.Abstraction;
using PapAPI.Abstraction.DTO;
using PapAPI.BAL.Mesagges;
using PapAPI.Entity.Dominio;
using PapAPI.Entity.Codificacion;
using Microsoft.Extensions.Logging;
using PapAPI.BAL;
using SumaAPI.Repository.Dominio;

namespace SumaAPI.BAL.Dominio
{
    public class RestaBAL<T> : ABussinesBase<T> where T: Resta
    {
        SumaRepository<T> repositorio;
        public RestaBAL(ILogger<RestaBAL<T>> _logger, SumaRepository<T> _repositorio)
        {
            this.repositorio = _repositorio;
            this.logger = _logger;
        }

        override public ResponseServicesDTO GetById(int id)
        {
            Object o = repositorio.GetById(id);
            ResponseServicesDTO response = createResponse(
                o,
                true,
                1,
                "exitoso",
                0);
            return response;
        }

        override public ResponseServicesDTO GetAll()
        {
            Object o = repositorio.GetAll();
            ResponseServicesDTO response = createResponse(
                o,
                true,
                 1,
                "exitoso",
                0);
            logger.LogInformation("Retornando los registros del cliente");
            return response;
        }

       

        override public ResponseServicesDTO Add(T entity)
        {
            entity.diferencia = entity.miniendo - entity.sustraendo;
            Object o = repositorio.Save(entity);
            
            ResponseServicesDTO response = createResponse(
                o,
                true,
                1,
                "exitosa",
                0);
            return response;
        }
    }
}
