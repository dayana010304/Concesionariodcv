using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class AccesoMetodosCRUDRuta
    {
        // Operacion Insert
        public int InsertRuta(int id, string Estacion, int id_Vehiculo)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacInsertRuta();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", Estacion);
            _comando.Parameters.AddWithValue("@id_Vehiculo", id_Vehiculo);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacInsertRuta(_comando);

        }

        //Operacion Select
        public static DataTable ListRuta()
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacInsertRuta();

            _comando.CommandText = "select * from Ruta";

            return MetodosCRUDRuta.EjecutarComandoSelectRuta(_comando);
        }
        //Operacion UPDATE
        public int UpdateRuta(int id, string Estacion, int id_Vehiculo)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcUpdateRuta();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", Estacion);
            _comando.Parameters.AddWithValue("@id_Vehiculo", id_Vehiculo);

            return MetodosCRUDRuta.EjecutarComandoProcUpdateRuta(_comando);

        }

        //Operacion DELETE
        public int DeleteRuta(int id)
        {
            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcDeleteRuta();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDRuta.EjecutarComandoProcDeleteRuta(_comando);

        }
    }
}
