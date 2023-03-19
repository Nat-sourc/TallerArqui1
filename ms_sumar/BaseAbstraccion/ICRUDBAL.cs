using PapAPI.Abstraction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Abstraction
{
    public interface ICRUDBAL<T>
    {
        ResponseServicesDTO GetById(int id);
        ResponseServicesDTO GetAll();
      
        ResponseServicesDTO Add(T entity);
       
    }
}
