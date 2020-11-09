using Controlador.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typename = txtName.Text;

            //Crear una instancia de la clase logica

            logicaControladorTipoVehiculo negocioAddTipoVehiculo = new logicaControladorTipoVehiculo();

            //Crear varibale local 

            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(cartypeid, typename);

            if (resultadoAddTipoVehiculo > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo hacer el registro";

            negocioAddTipoVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorTipoVehiculo.NegociarSelectTipoVehiculo();

            GridView.DataBind();

            txtId.Text = txtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cartypeid = Int32.Parse(txtId.Text);
            string typename = txtName.Text;

            //Crear una instancia de la clase logica

            logicaControladorTipoVehiculo negocioUpdateTipoVehiculo = new logicaControladorTipoVehiculo();

            //Crear varibale local 

            int resultadoUpdateTipoVehiculo = negocioUpdateTipoVehiculo.NegociarUpdateTipoVehiculo(cartypeid, typename);

            if (resultadoUpdateTipoVehiculo > 0)
                lblMensaje.Text = "Actualizacion realizada";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateTipoVehiculo = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int cartypeid = Int32.Parse(txtId.Text);

            //Crear una instancia de la clase logica

            logicaControladorTipoVehiculo negocioDeleteTipoVehiculo = new logicaControladorTipoVehiculo();

            //Crear varibale local 

            int resultadoDeleteTipoVehiculo = negocioDeleteTipoVehiculo.NegociarDeleteTipoVehiculo(cartypeid);

            if (resultadoDeleteTipoVehiculo > 0)
                lblMensaje.Text = "Se pudo eliminar correctamente";
            else
                lblMensaje.Text = "No se pudo eleminar";

            negocioDeleteTipoVehiculo = null;

        }
    }
}