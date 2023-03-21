using PapAPI.Abstraction;
using PapAPI.Abstraction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PapAPI.BAL.Mesagges;
using PapAPI.Entity.Codificacion;

namespace PapAPI.BAL
{

    public interface IABussinesBase<T> : ICRUDBAL<T>
    {

    }

    public abstract class ABussinesBase<T> : IABussinesBase<T> where T : IEntity
    {
        public ILogger? logger;
       
        

        public abstract ResponseServicesDTO GetAll();

        public abstract ResponseServicesDTO GetById(int id);
        public abstract ResponseServicesDTO Add(T entity);
        
        /// <summary>
        /// Este metodo permita la creación de un objeto de respuesta. 
        /// </summary>
        /// <param name="ObjectResponse">Contiene el objeto que conforma la respuesta, puede ser lista de valores o una entidad</param>
        /// <param name="Success">Indica si el resultado de la operacion fur o nó satisfactorio</param>
        /// <param name="CodeServiceResponse">Codificación en la tabla de las respuestas</param>
        /// <param name="CountRegisters">Cantidad de registros que se retornan, aplica en el caso de que sea una lista</param>
        /// <returns></returns>
        public ResponseServicesDTO createResponse(Object? objectResponse, bool success, int codeServiceResponse, string? descriptionServiceResponse, int CountRegisters)
        {
            return new ResponseServicesDTO()
            {
                ObjectResponse = objectResponse,
                Success = success,
                CodeServiceResponse = codeServiceResponse,
                DescriptionServiceResponse = descriptionServiceResponse,
                CountRegisters = CountRegisters
            };
        }

       
        
    }
}
