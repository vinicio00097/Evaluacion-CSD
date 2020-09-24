using Evaluacion_IM.Dao;
using Evaluacion_IM.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_IM.Services
{
    class ConsultasService : IConsultasDao
    {
        DBConnection connection = new DBConnection();

        public DataTable consulta1(String nombre,String codigo)
        {
            using(SqlDataAdapter dataAdapter=new SqlDataAdapter())
            {
                DataTable table = new DataTable();

                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataAdapter.SelectCommand = new SqlCommand("EmpresaByCodigoNombre", connection.getConnection());
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@codigo", String.IsNullOrEmpty(codigo) ? null : codigo);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", String.IsNullOrEmpty(nombre) ? null : nombre);

                    dataAdapter.Fill(table);
                    return table;
                }
                catch(Exception e)
                {
                    return table;
                }
            }    
        }

        public DataTable consulta2()
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                DataTable table = new DataTable();

                try
                {

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataAdapter.SelectCommand = new SqlCommand("PuestosByEmpresa", connection.getConnection());
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.Fill(table);
                    return table;
                }
                catch (Exception e)
                {
                    return table;
                }
            }
        }

        public DataTable consulta3(String newName)
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                DataTable table = new DataTable();

                try
                {

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataAdapter.SelectCommand = new SqlCommand("ModifyEmpressName", connection.getConnection());
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.SelectCommand.Parameters.AddWithValue("@newName", newName);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@empresaCodigo", "01");

                    dataAdapter.Fill(table);
                    return table;
                }
                catch (Exception e)
                {
                    return table;
                }
            }
        }

        public DataTable consulta4()
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                DataTable table = new DataTable();

                try
                {

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataAdapter.SelectCommand = new SqlCommand("PuestosActivosByEmpresa", connection.getConnection());
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.Fill(table);
                    return table;
                }
                catch (Exception e)
                {
                    return table;
                }
            }
        }

        public DataTable consulta5()
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                DataTable table = new DataTable();

                try
                {

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataAdapter.SelectCommand = new SqlCommand("PorcentajePuestosActivos", connection.getConnection());
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.Fill(table);
                    return table;
                }
                catch (Exception e)
                {
                    return table;
                }
            }
        }
    }
}
