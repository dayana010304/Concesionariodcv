using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDVehiculo
    {
        //Operacion INSERT 

        public int insertVehiculo(int id, string marca, string modelo, string placa, string anio, string id_tv)

        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacInsert_tv();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);


            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacINSERT_tv(_comando);

        }

        //Operacion SELECT 
        public static DataTable ListVehiculo()
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoSelect_tv();

            _comando.CommandText = "select * from Vehiculo1";

            return MetodosCRUDVehiculo.EjecutarComandoSelect_tv(_comando);
        }

        //Operacion UPDATE
        public int UpdateVehiculo(int id, string marca, string modelo, string placa, string anio, string id_tv)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcUpdate_tv();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacUpdate_tv(_comando);

        }

        //Operacion DELETE
        public int DeleteVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcDelete_tv();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacDelete_tv(_comando);

        }
    }
}
