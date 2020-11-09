using Controlador.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string Estacion = txtEstacion.Text;
            int id_Vehiculo = Int32.Parse(txtIdVehiculo.Text);

            //Crear una instancia de la clase logica

            logicaControladorRuta negocioAddRuta = new logicaControladorRuta();

            //Crear varibale local 

            int resultadoAddRuta = negocioAddRuta.NegociarInsertRuta(id, Estacion, id_Vehiculo);

            if (resultadoAddRuta > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo hacer el registro";

            negocioAddRuta = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string Estacion = txtEstacion.Text;
            int id_Vehiculo = Int32.Parse(txtIdVehiculo.Text);

            //Crear una instancia de la clase logica

            logicaControladorRuta negocioUpdateRuta = new logicaControladorRuta();

            //Crear varibale local 

            int resultadoUpdateRuta = negocioUpdateRuta.NegociarUpdateRuta(id, Estacion, id_Vehiculo);

            if (resultadoUpdateRuta > 0)
                lblMensaje.Text = "Actualizacion correcta";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateRuta = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            //Crear una instancia de la clase logica

            logicaControladorRuta negocioDeleteRuta = new logicaControladorRuta();

            //Crear varibale local 

            int resultadoDeleteRuta = negocioDeleteRuta.NegociarDeleteRuta(id);

            if (resultadoDeleteRuta > 0)
                lblMensaje.Text = "Se elimino correctamente";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteRuta = null;

        }
    }
}