﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapAPI.BAL.Mesagges
{
    public enum BussinesMesageList
    {
        /***CODIGOS GENERICOS****/
        CONST_PAPAPI_CODIGO_RESPUESTA_GENERAL_SATISFACTORIA_1 = 1,
        CONST_PAPAPI_CODIGO_RESPUESTA_GENERAL_REGISTRO_NO_EXISTE_2 = 2,
        CONST_PAPAPI_CODIGO_RESPUESTA_GENERAL_REGISTRO_YA_EXISTE_3 = 3,
        CONST_PAPAPI_CODIGO_RESPUESTA_GENERAL_REGISTRO_EN_USO_4 = 4,
        CONST_PAPAPI_CODIGO_RESPUESTA_NOES_PERMITIDO_MODIFICAR_REGISTRO_5 = 5,

        /***CODIGOS ESPECIFICOS DEL MICROSERVICIO - DOMINIO CLIENTE****/
        CONST_PAPAPI_CODIGO_RESPUESTA_CLIENTE_YA_NO_ES_CLIENTE_1000 = 1000,

        /***CODIGOS ESPECIFICOS DEL MICROSERVICIO - DOMINIO POSTES****/
        CONST_PAPAPI_CODIGO_RESPUESTA_POSTE_NO_FUERA_SERVICIO_2000 = 2000,

        /***CODIGOS ESPECIFICOS DEL MICROSERVICIO - DOMINIO ABSCISA****/
        CONST_PAPAPI_CODIGO_RESPUESTA_ABSCISA_REAL_YA_EXISTE_3000 = 3000,
        CONST_PAPAPI_CODIGO_RESPUESTA_ABSCISA_REAL_SUPERA_LIMITES_DEL_CORREDOR_3001 = 3001,

        /***CODIGOS ESPECIFICOS DEL MICROSERVICIO CIPS - PK EN CONFLICTO****/
        CONST_CIPS_CODIGO_RESPUESTA_PK_EN_CONFLICTO_4000 = 4000,

    }
}