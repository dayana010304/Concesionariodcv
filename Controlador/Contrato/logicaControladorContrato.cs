using Modelo.Contrato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Contrato
{
    public class logicaControladorContrato
    {
        //Negocira INSERT
        public int NegociarInsertContrato(int id, int id_conductor, int id_Vehiculo)

        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();

            return negociarAcceso.InsertContrato(id, id_conductor, id_Vehiculo);
        }

        //Negociar SELECT
        public static DataTable NegociarSelectContrato()
        {
            return AccesoMetodosCRUDContrato.ListContrato();
        }

        //Negocira UPDATE
        public int NegociarUpdateContrato(int id, int id_conductor, int id_Vehiculo)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();

            return negociarAcceso.UpdateContrato(id, id_conductor, id_Vehiculo);
        }

        //Negocira DELETE
        public int NegociarDeleteContrato(int id)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();

            return negociarAcceso.DeleteContrato(id);
        }
    }
}
