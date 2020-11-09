using Modelo.Ruta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Ruta
{
    public class logicaControladorRuta
    {
        //Negocira INSERT
        public int NegociarInsertRuta(int id, string Estacion, int id_Vehiculo)

        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.InsertRuta(id, Estacion, id_Vehiculo);
        }

        //Negociar SELECT
        public static DataTable NegociarSelectRuta()
        {
            return AccesoMetodosCRUDRuta.ListRuta();
        }

        //Negocira UPDATE
        public int NegociarUpdateRuta(int id, string Estacion, int id_Vehiculo)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.UpdateRuta(id, Estacion, id_Vehiculo);
        }

        //Negocira DELETE
        public int NegociarDeleteRuta(int id)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.DeleteRuta(id);
        }
    }
}
