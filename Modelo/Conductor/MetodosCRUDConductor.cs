﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class MetodosCRUDConductor
    {
        public static SqlCommand CrearComandoTipoProcAlmInsert()
        {
            string _CadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_CadenaConexion);

            SqlCommand _comando = new SqlCommand("addConductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //ejeutar tipo de comando Insert
        public static int EjecutarComandoProcAlmacInsert(SqlCommand comando)
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

        // Crear tipo comando SELECT
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

        //Ejecutar tipo de comando SELECT
        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _table = new DataTable();

            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);

            }
            catch (Exception Ex) { throw Ex; }
            finally { comando.Connection.Close(); }

            return _table;
        }

        // Crear tipo comando UPDATE
        public static SqlCommand CrearComandoProcUpdate()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("updateConductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }
        //Ejecutar tipo de comando UPDATE

        public static int EjecutarComandoProcAlmacUpdate(SqlCommand comando)
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

        // Crear tipo comando DELETE
        public static SqlCommand CrearComandoProcDelete()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteConductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;

        }
        //Ejecutar tipo de comando DELETE

        public static int EjecutarComandoProcAlmacDelete(SqlCommand comando)
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

