using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_IM.Utils
{
    class DBConnection
    {
        private SqlConnection connection;

        public SqlConnection getConnection()
        {
            connection = new SqlConnection("server=localhost;database=DbEvaluacion;Integrated Security=true;");
            return connection;
        }
    }
}
