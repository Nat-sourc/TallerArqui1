using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Abstraction.Const
{
    public enum ConstantesVerificacionActivo
    {
        CONST_REGISTRADO = 1,
        CONST_VERIFICADO = 2,
        CONST_CORREGIR = 3,
        CONST_ANALISISLABORATORIO = 4,
        CONST_REGISTTROBV = 5,
        CONST_LISTOPARAINFORME = 6,
        CONST_TODOS = 9


    }
    public enum ConstantesMonitoreo
    {
        CONST_CINCO = 5,
        CONST_SEIS = 6,
        CONST_TRES = 3
    }
    public enum ConstantesSistemaCupon
    {
        CONST_BAJAPRESION = 1,
        CONST_ALTAPRESION = 2,
        CONST_NA = 3
    }
    public enum ConstantesIndicesActivo
    {
        CONST_INDICEUNO = 1,
        CONST_INDICEDOS = 2,
        CONST_INDICETRES = 3,
        CONST_INDICECUATRO = 4
    }

    public enum ConstantesNivelCorrosion
    {
        CONST_BAJO = 1,
        CONST_MODERADO = 2,
        CONST_ALTO = 3,
        CONST_SEVERO = 4

    }

}
