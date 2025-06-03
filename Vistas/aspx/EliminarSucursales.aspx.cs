using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Diagnostics;

namespace Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        private SucursalManager sucursalManager = new SucursalManager();

        protected void Page_Load(object sender, EventArgs e)
        {}

        protected void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            int idInput;
            lblErrorFormato.Visible = false;
            lblEliminado.Visible = false;
            lblError.Visible = false;
            

            if (int.TryParse(txbEliminarSucursal.Text.Trim(), out idInput))
            {
                if (sucursalManager.Exists(idInput))
                {
                    string nombreSucursal = sucursalManager.GetSucursalID(idInput).NombreSucursal;
                    pnlConfirmacion.Visible = true;
                    lblConfirmacion.Text = "Desea eliminar la Sucursal: " + nombreSucursal + " ?";
                    btnConfirmar.CommandArgument = idInput.ToString();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            else
            {
                lblErrorFormato.Visible = true;
            }
        }
        protected void comprobarSucursal(object sender, EventArgs e)
        {
            if (int.TryParse(txbEliminarSucursal.Text, out int id))
            {
                
            }
        }
        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(btnConfirmar.CommandArgument, out int idSucursal))
            {
                pnlConfirmacion.Visible = false;
                lblEliminado.Visible = true;
                txbEliminarSucursal.Text = "";
                sucursalManager.DeleteSucursal(idSucursal);
                btnConfirmar.CommandArgument = "null";
                limpiarTabla();
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlConfirmacion.Visible = false;
            txbEliminarSucursal.Text = "";
            btnConfirmar.CommandArgument = "null";
            limpiarTabla();
        }
        protected void txbEliminarSucursal_TextChanged(object sender, EventArgs e)
        {

            int idInput;
            if (int.TryParse(txbEliminarSucursal.Text, out idInput) && idInput > 0)
            {
                try
                {
                    Sucursal suc = sucursalManager.GetSucursalID(idInput);

                    if (suc != null)
                    {
                        lblError.Visible = false;
                        gvRegistroAEliminar.DataSource = new List<Sucursal> { suc };
                        gvRegistroAEliminar.DataBind();
                    }
                    else
                    {
                        limpiarTabla();
                    }
                }
                catch (Exception ex)
                {
                    limpiarTabla();
                }
            }
            else
            {
                limpiarTabla();
            }
        }
        protected void limpiarTabla()
        {
            gvRegistroAEliminar.DataSource = null;
            gvRegistroAEliminar.DataBind();
        }
    }
}