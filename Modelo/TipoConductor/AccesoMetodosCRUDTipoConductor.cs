using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class AccesoMetodosCRUDTipoConductor
    {
        // Operacion Insert
        public int insertTipoConductor(int id, string Tipo_Persona)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoProcAlmacInsert_tc();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@Tipo_Persona", Tipo_Persona);

            return MetodosCRUDTipoConductor.EjecutarComandoProcAlmacInsert_tc(_comando);

        }

        //Operacion Select
        public static DataTable ListTipoConductor()
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoSelect_tc();

            _comando.CommandText = "select * from Tipo_Conductor";

            return MetodosCRUDTipoConductor.EjecutarComandoSelect_tc(_comando);
        }
        //Operacion UPDATE
        public int UpdateTipoConductor(int id, string Tipo_Persona)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoProcUpdate_tc();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@Tipo_Persona", Tipo_Persona);

            return MetodosCRUDTipoConductor.EjecutarComandoProcAlmacUpdate_tc(_comando);
        }

        //Operacion DELETE
        public int DeleteTipoConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearComandoProcDelete_tc();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDTipoConductor.EjecutarComandoProcAlmacDelete_tc(_comando);

        }
    }
}