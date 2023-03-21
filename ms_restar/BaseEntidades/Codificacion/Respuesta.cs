using PapAPI.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Entity.Codificacion
{
    public interface IRespuesta 
    {
        public int IdRespuesta { get; set; }
        public int CodigoRespuesta { get; set; }
        public int IdIdiomaRespuesta { get; set; }
        public string MensajeRespuesta { get; set; }

        
    }

    public class Respuesta : IRespuesta
    {
        [Key]
        public int IdRespuesta { get; set; }
        public int CodigoRespuesta { get; set; }
        public int IdIdiomaRespuesta { get; set; }
        public string MensajeRespuesta { get; set; }
        public int Estado { get; set; }
        

        public Respuesta()
        {
            this.MensajeRespuesta = string.Empty;
        }

    }
}
