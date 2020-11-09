using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class MetodosCRUDRuta
    {
        // Crear tipo comando INSERT
        public static SqlCommand CrearComandoProcAlmacInsertRuta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addRuta", _conexion);

            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando INSERT
        public static int EjecutarComandoProcAlmacInsertRuta(SqlCommand comando)
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
        public static SqlCommand CrearComandoSelect()
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
        public static DataTable EjecutarComandoSelectRuta(SqlCommand comando)
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
        public static SqlCommand CrearComandoProcUpdateRuta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateRuta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }
        //Ejecutar tipo de comando UPDATE

        public static int EjecutarComandoProcUpdateRuta(SqlCommand comando)
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
        public static SqlCommand CrearComandoProcDeleteRuta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteRuta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }
        //Ejecutar tipo de comando DELETE

        public static int EjecutarComandoProcDeleteRuta(SqlCommand comando)
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
