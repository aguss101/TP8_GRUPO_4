using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        //private DataBaseAccess db = new DataBaseAccess();
        //private SucursalManager sucursalManager = new SucursalManager();

        protected void Page_Load(object sender, EventArgs e)
        {}

        protected void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            int idInput;
            if (int.TryParse(txbEliminarSucursal.Text.Trim(), out idInput))
            {
                lblComprobarSucursal.Visible = true; //esta linea es solamente para que funcione el progrma luego hay que eliminarla

                /* if (sucursalManager.SucursalExists(idInput))
                 {
                     sucursalManager.DeleteSucursal(idInput);

                     lblEliminado.Visible = true;
                     txbEliminarSucursal.Text = "";
                     lblError.Visible = false;

                     lblErrorFormato.Visible = false;
                 }
                 else
                 {
                     lblError.Visible = true;
                     lblEliminado.Visible = false;

                     lblErrorFormato.Visible = false;
                 }
             }
             else
             {
                 lblErrorFormato.Visible = true;

                 lblEliminado.Visible = false;
                 lblError.Visible = false;
             }
                */
            }
        }
        protected void comprobarSucursal(object sender, EventArgs e)
        {
            if (int.TryParse(txbEliminarSucursal.Text, out int id))
            {
                lblComprobarSucursal.Visible = true; //esta linea es solamente para que funcione el progrma luego hay que eliminarla
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