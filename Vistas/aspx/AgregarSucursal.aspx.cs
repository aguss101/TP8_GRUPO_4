using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
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


            Sucursal sucursalToAdd = new Sucursal();

            sucursalToAdd.NombreSucursal = txtNameSuc.Text;
            sucursalToAdd.DescripcionSucursal = txtDesc.Text;
            sucursalToAdd.DireccionSucursal = txtDir.Text;
            sucursalToAdd.idProvinciaSucursal = ddlProvincias.SelectedIndex + 1;
            try
            {
                sucursalManager.AddSucursal(sucursalToAdd);
                lblCorrect.Text = "Sucursal agregada correctamente.\n Nombre:" + sucursalToAdd.NombreSucursal +
                                  "\n Descripcion: " + sucursalToAdd.DescripcionSucursal +
                                  "\n Direccion: " + sucursalToAdd.DireccionSucursal +
                                  "\n Provincia: " + ddlProvincias.SelectedItem.Text
                ;
                
                lblCorrect.ForeColor = System.Drawing.Color.Green;

            }
            catch (Exception ex)
            {
                lblCorrect.Text = "Error al agregar la sucursal: " + ex.Message;
                lblCorrect.ForeColor = System.Drawing.Color.Red;
            }
            /*
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
            */

        }
    }
}