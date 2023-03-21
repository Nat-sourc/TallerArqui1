using PapAPI.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Entity.Parameters
{
    public interface IIdioma : IEntity
    {
        public int IdIdioma { get; set; }
        public int CodigoIdioma { get; set; }
        public string NombreIdioma { get; set; }
    }

    public class Idioma: IIdioma
    {
        [Key]
        public int IdIdioma { get; set; }
        public int CodigoIdioma { get; set; }
        public string NombreIdioma { get; set; }
        public int Estado { get; set; }
        

        public Idioma()
        {
            this.NombreIdioma = String.Empty;
        }

    }
}
