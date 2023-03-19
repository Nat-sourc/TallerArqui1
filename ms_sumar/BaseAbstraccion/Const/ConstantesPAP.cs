using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.Abstraction.Const
{
    public enum ConstantesEstadoPAP
    {
        EstadoPinturaVerticalidad_Bueno = 1,
        EstadoPinturaVerticalidad_Regular = 2,
        EstadoPinturaVerticalidad_Malo = 3,
        EstadoConexion_Bueno = 1,
        EstadoConexion_Regular = 2,
        EstadoConexion_Malo = 3,
    }


    public enum ConstantesPotencialPAP
    {
        CONST_POTENCIA_AC = 15000,
        CONST_POTENCIA_ON = -850,
        CONST_POTENCIA_OFF = -1200,
    }


    public enum ConstantesArchivosCIPS
    {
        CONST_ARCHIVO_CIPS_ALEGRO = 1,
        CONST_ARCHIVO_CIPS_MC_MILLER_GX = 2,
        CONST_ARCHIVO_CIPS_MC_MILLER_BTVM = 3,
    }

    public enum ConstantesTipoAccesorio
    {
        CONST_TIPO_ACCESORIO_AISLAMIENTO = 1,
        CONST_TIPO_ACCESORIO_ENCAMISADO = 2,
        CONST_TIPO_ACCESORIO_INTERFASE = 3,
        CONST_TIPO_ACCESORIO_MARCOH = 4,
        CONST_TIPO_ACCESORIO_ESTACION = 5,

    }

    public enum ConstantesModuloArchivo
    {
        CONST_MODULO_ARCHIVO_CIPS = 1,
        CONST_MODULO_ARCHIVO_DCVG = 2,
        CONST_MODULO_ARCHIVO_SUELOS = 3
    }
    public enum ComparacionPotencia_ON_OFF
    {
        CONST_BORNEOFF_MAYOR = 1,
        CONST_BORNEOFF_MENOROIGUAL = 2
    }

}
