using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ListadoDeSucursales : System.Web.UI.Page
    {
        //private SucursalManager sucursalmanager = new SucursalManager();
        private int Orden
        {
            get { return ViewState["Orden"] != null ? (int)ViewState["Orden"] : 0; }
            set { ViewState["Orden"] = value; }
        }
        /*
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSucursales();
        private void LoadSucursales()
        {
            gvSucursales.DataSource = sucursalmanager.getSucursales();
            gvSucursales.DataBind();
        }
        */
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblInvalidInputSuc.Visible = false;

            int idInput;
            if (int.TryParse(txbIdSucursal.Text, out idInput))
            {
                try
                {
                    //gvSucursales.DataSource = sucursalmanager.FiltrarSucursalId(idInput);
                    //gvSucursales.DataBind();
                }
                catch (Exception ex)
                {
                    lblInvalidInputSuc.Text = "Error al filtrar sucursales: " + ex.Message;
                    lblInvalidInputSuc.Visible = true;
                }
            }
            else
            {
                lblInvalidInputSuc.Visible = true;
            }
            txbIdSucursal.Text = "";
        }
        
        protected void btnOrdenarSucursales(object sender, EventArgs e)
        {
            //DataTable tabla = sucursalmanager.getSucursales();
           // DataView vista = tabla.DefaultView;

            switch (Orden)
            {
                case 0:
                case -1:
                    Orden = 1;
               //     vista.Sort = "PROVINCIA ASC";
                    break;
                case 1:
                    Orden = -1;
                //    vista.Sort = "PROVINCIA DESC";
                    break;
                default:
                    Orden = 0;
                    break;
            }

           // gvSucursales.DataSource = vista.ToTable();
          //  gvSucursales.DataBind();
        }
        
        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txbIdSucursal.Text = "";
            //Orden = 0;
        } 
}
    }