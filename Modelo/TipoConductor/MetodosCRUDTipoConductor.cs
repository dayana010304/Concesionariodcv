using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class MetodosCRUDTipoConductor
    {
        // Crear tipo comando INSERT
        public static SqlCommand CrearComandoProcAlmacInsert_tc()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addTipo_Conductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando INSERT
        public static int EjecutarComandoProcAlmacInsert_tc(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();

            }
        }

        // Crear tipo comando Select
        public static SqlCommand CrearComandoSelect_tc()
        {
            //Usar la conexion
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //Crear la instruccion select
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;

            return _comando;
        }

        //Ejecutar el tipo de comando Select
        public static DataTable EjecutarComandoSelect_tc(SqlCommand comando)
        {
            DataTable _Table = new DataTable();

            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_Table);
            }
            catch (Exception Ex) { throw Ex; }
            finally { comando.Connection.Close(); }

            return _Table;
        }

        // Crear tipo comando UPDATE
        public static SqlCommand CrearComandoProcUpdate_tc()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("UpdateTipo_Conductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }
        //Ejecutar tipo de comando UPDATE

        public static int EjecutarComandoProcAlmacUpdate_tc(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();

            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        // Crear utipo comando DELETE
        public static SqlCommand CrearComandoProcDelete_tc()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteTipo_Conductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }
        //Ejecutar tipo de comando DELETE

        public static int EjecutarComandoProcAlmacDelete_tc(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();

            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
  
