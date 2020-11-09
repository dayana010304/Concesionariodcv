using Controlador.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;
            string Tipo_Licencia = txtTipoLicencia.Text;
            string id_veh = txtIdVehiculo.Text;
            string id_tc = txtIdeTipoConductor.Text;

            //Crear una instancia de la clase logica

            logicaControladorConductor negocioAddConductor = new logicaControladorConductor();

            //Crear varibale local 

            int resultadoAddConductor = negocioAddConductor.NegociarInsertConductor(id, nombre, Tipo_Licencia, id_veh, id_tc);

            if (resultadoAddConductor > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo hacer el registro";

            negocioAddConductor = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorConductor.NegociarSelectConductor();

            GridView.DataBind();

            txtId.Text = txtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;
            string Tipo_Licencia = txtTipoLicencia.Text;
            string id_veh = txtIdVehiculo.Text;
            string id_tc = txtIdeTipoConductor.Text;


            //Crear una instancia de la clase logica

            logicaControladorConductor negocioUpdateConductor = new logicaControladorConductor();

            //Crear varibale local 

            int resultadoUpdateConductor = negocioUpdateConductor.NegociarInsertConductor(id, nombre, Tipo_Licencia, id_veh, id_tc);

            if (resultadoUpdateConductor > 0)
                lblMensaje.Text = "Actualizacion Correcta";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateConductor = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = txtName.Text;
            string Tipo_Licencia = txtTipoLicencia.Text;
            string id_veh = txtIdVehiculo.Text;
            string id_tc = txtIdeTipoConductor.Text;

            //Crear una instancia de la clase logica

            logicaControladorConductor negocioDeleteConductor = new logicaControladorConductor();

            //Crear varibale local 

            int resultadoDeleteConductor = negocioDeleteConductor.NegociarDeleteConductor(id);

            if (resultadoDeleteConductor > 0)
                lblMensaje.Text = "Se elimino correctamente";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteConductor = null;
        }
    }
}