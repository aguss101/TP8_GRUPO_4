using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        
       private SucursalManager sucursalManager = new SucursalManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadProvincias();
            }
            
        }

        protected void LoadProvincias()
        {
            List <String> provincias = sucursalManager.GetSucursalProvincias();
            ddlProvincias.DataSource = provincias;
            ddlProvincias.DataBind();
        }
    
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