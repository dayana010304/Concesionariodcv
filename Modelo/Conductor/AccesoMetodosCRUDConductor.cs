using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDConductor
    {
        //Operacion Insert
        public int InsertConductor(int id, string nombre, string Tipo_Licencia, string id_veh, string id_tc)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoTipoProcAlmInsert();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@Tipo_Licencia", Tipo_Licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_veh);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tc);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacInsert(_comando);
        }

        //Operacion Select
        public static DataTable ListConductor()
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoSelect();

            _comando.CommandText = "select * from Conductor";

            return MetodosCRUDConductor.EjecutarComandoSelect(_comando);
        }

        //Operacion UPDATE
        public int UpdateConductor(int id, string nombre, string Tipo_Licencia, string id_veh, string id_tc)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcUpdate();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@Tipo_Licencia", Tipo_Licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_veh);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tc);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacUpdate(_comando);

        }

        //Operacion DELETE
        public int DeleteConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcDelete();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacDelete(_comando);
        }
    }
}