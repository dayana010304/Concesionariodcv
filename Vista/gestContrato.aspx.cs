using Controlador.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int id_conductor = Int32.Parse(txtIdConductor.Text);
            int id_vehiculo = Int32.Parse(txtIdVehiculo.Text);

            //Crear una instancia de la clase logica

            logicaControladorContrato negocioAddContrato = new logicaControladorContrato();

            //Crear varibale local 

            int resultadoAddContrato = negocioAddContrato.NegociarInsertContrato(id, id_conductor, id_vehiculo);

            if (resultadoAddContrato > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo hacer el registro";

            negocioAddContrato = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorContrato.NegociarSelectContrato();

            GridView.DataBind();

            txtId.Text = txtIdVehiculo.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int id_conductor = Int32.Parse(txtIdConductor.Text);
            int id_vehiculo = Int32.Parse(txtIdVehiculo.Text);

            //Crear una instancia de la clase logica

            logicaControladorContrato negocioUpdateContrato = new logicaControladorContrato();

            //Crear varibale local 

            int resultadoUpdateContrato = negocioUpdateContrato.NegociarUpdateContrato(id, id_conductor, id_vehiculo);

            if (resultadoUpdateContrato > 0)
                lblMensaje.Text = "Actualizacion Correcta";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateContrato = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            //Crear una instancia de la clase logica

            logicaControladorContrato negocioDeleteContrato = new logicaControladorContrato();

            //Crear varibale local 

            int resultadoDeleteContrato = negocioDeleteContrato.NegociarDeleteContrato(id);

            if (resultadoDeleteContrato > 0)
                lblMensaje.Text = "Se elimino correctamente";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteContrato = null;

        }
    }
}