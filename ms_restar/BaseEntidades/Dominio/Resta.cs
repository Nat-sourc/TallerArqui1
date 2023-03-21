using PapAPI.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Entity.Dominio
{
    public interface IResta:IEntity
    {
        public int IdResta { get; set; }
        public double miniendo { get; set; }
        public double sustraendo { get; set; }
        public double diferencia { get; set; }


    }
    public class Resta: IResta
    {
        [Key]
        public int IdResta { get; set; }
        public double sustraendo { get; set; }
        public double miniendo { get; set; }
        public double diferencia { get; set; }
    }
}
