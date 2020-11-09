using Controlador.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string anio = txtAnio.Text;
            string id_tv = txtId_tv.Text;

            //Crear una instancia de la clase logica

            logicaControladorVehiculo negocioAddVehiculo = new logicaControladorVehiculo();

            //Crear varibale local 

            int resultadoAddVehiculo = negocioAddVehiculo.NegociarInsertVehiculo(id, marca, modelo, placa, anio, id_tv);

            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Registro ok";
            else
                lblMensaje.Text = "No se pudo hacer el registro";

            negocioAddVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            GridView.DataSource = logicaControladorVehiculo.NegociarSelectVehiculo();

            GridView.DataBind();

            txtId.Text = txtMarca.Text = "";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string anio = txtAnio.Text;
            string id_tv = txtId_tv.Text;

            //Crear una instancia de la clase logica

            logicaControladorVehiculo negocioUpdateVehiculo = new logicaControladorVehiculo();

            //Crear varibale local 

            int resultadoUpdateVehiculo = negocioUpdateVehiculo.NegociarUpdateVehiculo(id, marca, modelo, placa, anio, id_tv);

            if (resultadoUpdateVehiculo > 0)
                lblMensaje.Text = "Actualizacion realizada";
            else
                lblMensaje.Text = "No se pudo actualizar";

            negocioUpdateVehiculo = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            //Crear una instancia de la clase logica

            logicaControladorVehiculo negocioDeleteVehiculo = new logicaControladorVehiculo();

            //Crear varibale local 

            int resultadoDeleteVehiculo = negocioDeleteVehiculo.NegociarDeleteVehiculo(id);

            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = "Se pudo eliminar correctamente";
            else
                lblMensaje.Text = "No se pudo eleminar";

            negocioDeleteVehiculo = null;

        }
    }
}