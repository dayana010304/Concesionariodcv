using Modelo.Conductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Conductor
{
    public class logicaControladorConductor
    {
        //Negocira INSERT
        public int NegociarInsertConductor(int id, string nombre, string Tipo_Licencia, string id_veh, string id_tc)

        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.InsertConductor(id, nombre, Tipo_Licencia, id_veh, id_tc);
        }

        //Negociar SELECT
        public static DataTable NegociarSelectConductor()
        {
            return AccesoMetodosCRUDConductor.ListConductor();
        }

        //Negocira UPDATE
        public int NegociarUpdateConductor(int id, string nombre, string Tipo_Licencia, string id_veh, string id_tc)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.UpdateConductor(id, nombre, Tipo_Licencia, id_veh, id_tc);         
        }

        //Negocira DELETE
        public int NegociarDeleteConductor(int id)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.DeleteConductor(id);
        }
    }
}
