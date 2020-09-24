using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_IM.Dao
{
    interface IConsultasDao
    {
        DataTable consulta1(String nombre,String codigo);
        DataTable consulta2();

        DataTable consulta3(String newName);
        DataTable consulta4();

        DataTable consulta5();
    }
}
