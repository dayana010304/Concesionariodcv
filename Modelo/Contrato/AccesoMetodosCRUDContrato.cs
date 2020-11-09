using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class AccesoMetodosCRUDContrato
    {
        // Operacion Insert
        public int InsertContrato(int id, int id_conductor, int id_Vehiculo)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacInsertContrato();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_Vehiculo);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacInsertContrato(_comando);
        }
        //Operacion Select
        public static DataTable ListContrato()
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoSelect();

            _comando.CommandText = "select * from Contrato";

            return MetodosCRUDContrato.EjecutarComandoSelectContrato(_comando);
        }

        //Operacion UPDATE
        public int UpdateContrato(int id, int id_conductor, int id_Vehiculo)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcUpdateContrato();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", id_conductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_Vehiculo);

            return MetodosCRUDContrato.EjecutarComandoProcUpdateContrato(_comando);

        }

        //Operacion DELETE
        public int DeleteContrato(int id)
        {
            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcDeleteContrato();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDContrato.EjecutarComandoProcDeleteContrato(_comando);
        }
    }
}
