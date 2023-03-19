using PapAPI.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Entity.Dominio
{
    public interface ISuma:IEntity
    {
        public int IdSuma { get; set; }
        public double sumando1 { get; set; }
        public double sumando2 { get; set; }
        public double resultado { get; set; }


    }
    public class Suma: ISuma
    {
        [Key]
        public int IdSuma { get; set; }
        public double sumando1 { get; set; }
        public double sumando2 { get; set; }
        public double resultado { get; set; }
    }
}
