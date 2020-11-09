using Modelo.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Vehiculo
{
    public class logicaControladorVehiculo
    {
        //Negocira INSERT
        public int NegociarInsertVehiculo(int id, string marca, string modelo, string placa, string anio, string id_tv)

        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();

            return negociarAcceso.insertVehiculo(id, marca, modelo, placa, anio, id_tv);
        }

        //Negociar SELECT
        public static DataTable NegociarSelectVehiculo()
        {
            return AccesoMetodosCRUDVehiculo.ListVehiculo();
        }

        //Negocira UPDATE
        public int NegociarUpdateVehiculo(int id, string marca, string modelo, string placa, string anio, string id_tv)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();

            return negociarAcceso.UpdateVehiculo(id, marca, modelo, placa, anio, id_tv);
        }

        //Negocira DELETE
        public int NegociarDeleteVehiculo(int id)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();

            return negociarAcceso.DeleteVehiculo(id);
        }
    }
}

namespace Controlador
{
    public class logicaContraladorConductor
    {
        public logicaContraladorConductor()
        {
        }
    }
}