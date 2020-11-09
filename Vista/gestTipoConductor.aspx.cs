using Controlador.TipoConductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string name = txtName.Text;

            //Crear una instancia de la clase logica

            logicaContraladorTipoConductor negocioAddTipoConductor = new logicaContraladorTipoConductor();

            //Crear varibale local 

            int resultadoAddTipoConductor = negocioAddTipoConductor.NegociarInsertTipoConductor(id, name);

            if (resultadoAddTipoConductor > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo hacer el registro";

            negocioAddTipoConductor = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaContraladorTipoConductor.NegociarSelectTipoConductor();

            GridView.DataBind();

            txtId.Text = txtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string name = txtName.Text;

            //Crear una instancia de la clase logica

            logicaContraladorTipoConductor negocioUpdateTipoConductor = new logicaContraladorTipoConductor();

            //Crear varibale local 

            int resultadoUpdateTipoConductor = negocioUpdateTipoConductor.NegociarUpdateTipoConductor(id, name);

            if (resultadoUpdateTipoConductor > 0)
                lblMensaje.Text = "Actualizacion Correcta";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateTipoConductor = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string name = txtName.Text;

            //Crear una instancia de la clase logica

            logicaContraladorTipoConductor negocioDeleteTipoConductor = new logicaContraladorTipoConductor();

            //Crear varibale local 

            int resultadoDeleteTipoConductor = negocioDeleteTipoConductor.NegociarDeleteTipoConductor(id);

            if (resultadoDeleteTipoConductor > 0)
                lblMensaje.Text = "Se elimino correctamente";
            else
                lblMensaje.Text = "No se pudo eliminar";

            negocioDeleteTipoConductor = null;
        }
    }
}