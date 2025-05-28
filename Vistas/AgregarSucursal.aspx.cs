using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        /*
        //private SucursalManager sucursalManager = new SucursalManager();
        //private DataBaseAccess db = new DataBaseAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProvincias();
            }
        }

        protected void CargarProvincias()
        {
            string query = "SELECT Id_Provincia, DescripcionProvincia FROM Provincia";
            DataTable tabla = db.GetTable(query, "Provincia");

            ddlProvincias.DataSource = tabla;
            ddlProvincias.DataTextField = "DescripcionProvincia";
            ddlProvincias.DataValueField = "Id_Provincia";
            ddlProvincias.DataBind();
            ddlProvincias.Items.Insert(0, new ListItem("-- Seleccione una provincia --", "0"));
        }
    */
        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                string nombre = txtNameSuc.Text;
                string descripcion = txtDesc.Text;
                int idProvincia = int.Parse(ddlProvincias.SelectedValue);
                string direccion = txtDir.Text;
                try
                {
                    //sucursalManager.AddSucursal(nombre, descripcion, idProvincia, direccion);
                    lblCorrect.Text = "Sucursal agregada correctamente.";

                }
                catch (Exception ex)
                {
                    lblCorrect.Text = "Error al agregar la sucursal: " + ex.Message;
                    lblCorrect.ForeColor = System.Drawing.Color.Red;
                }
                txtNameSuc.Text = "";
                txtDesc.Text = "";
                txtDir.Text = "";
            }
        }
    }
}