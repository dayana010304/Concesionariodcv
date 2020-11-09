using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoConductor
{
    public class logicaContraladorTipoConductor
    {
        //Negocira INSERT
        public int NegociarInsertTipoConductor(int id, string Tipo_Persona)

        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();

            return negociarAcceso.insertTipoConductor(id, Tipo_Persona);
        }

        //Negociar SELECT
        public static DataTable NegociarSelectTipoConductor()
        {
            return AccesoMetodosCRUDTipoConductor.ListTipoConductor();
        }

        //Negocira UPDATE
        public int NegociarUpdateTipoConductor(int id, string Tipo_Persona)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();

            return negociarAcceso.UpdateTipoConductor(id, Tipo_Persona);
        }

        //Negocira DELETE
        public int NegociarDeleteTipoConductor(int id)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();

            return negociarAcceso.DeleteTipoConductor(id);
        }

    }
}
