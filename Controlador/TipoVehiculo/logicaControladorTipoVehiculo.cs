using Modelo.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoVehiculo
{
    public class logicaControladorTipoVehiculo
    {
        //Negocira INSERT
        public int NegociarInsertTipoVehiculo(int id, string name)

        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.insertTipoVehiculo(id, name);
        }

        //Negociar SELECT
        public static DataTable NegociarSelectTipoVehiculo()
        {
            return AccesoMetodosCRUDtipoVehiculo.ListTipoVehiculo();
        }

        //Negocira UPDATE
        public int NegociarUpdateTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.UpdateTipoVehiculo(id, name);
        }

        //Negocira DELETE
        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccesoMetodosCRUDtipoVehiculo negociarAcceso = new AccesoMetodosCRUDtipoVehiculo();

            return negociarAcceso.DeleteTipoVehiculo(id);
        }


    }


}
