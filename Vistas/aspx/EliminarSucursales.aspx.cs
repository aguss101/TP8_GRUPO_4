using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

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

                bool eliminado = sucursalManager.DeleteSucursal(idInput);

                 if (eliminado)
                 {
                    lblEliminado.Visible = true;
                    txbEliminarSucursal.Text = "";
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
                //lblComprobarSucursal.Visible = true; //esta linea es solamente para que funcione el progrma luego hay que eliminarla
               /* if (sucursalManager.SucursalExists(id))
                {
                    lblComprobarSucursal.Visible = true;
                    lblEliminado.Visible = false;
                    lblError.Visible = false;
                    lblErrorFormato.Visible = false;
                }
                else
                {
                    lblComprobarSucursal.Visible = false;
                }*/
            }
        }
    }
}