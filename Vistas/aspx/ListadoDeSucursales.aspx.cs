using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Vistas
{
    public partial class ListadoDeSucursales : System.Web.UI.Page
    {
        private SucursalManager sucursalmanager = new SucursalManager();
        private int Orden
        {
            get { return ViewState["Orden"] != null ? (int)ViewState["Orden"] : 0; }
            set { ViewState["Orden"] = value; }    
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSucursales();

        }
        private void LoadSucursales()
        {
            List<Sucursal> list = sucursalmanager.GetSucursales();
            gvSucursales.DataSource = list;
            gvSucursales.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblInvalidInputSuc.Visible = false;

            int idInput;
            if (int.TryParse(txbIdSucursal.Text, out idInput))
            {
                Sucursal suc = sucursalmanager.GetSucursalID(idInput);
                bool sucursalValida = suc.IdSucursal == idInput;
                if (sucursalValida)
                {
                    gvSucursales.DataSource = new List<Sucursal> { suc };
                    gvSucursales.DataBind();
                }
                else
                {
                    lblInvalidInputSuc.Text = $"La sucursal {idInput} no existe.";
                    lblInvalidInputSuc.Visible = true;
                }
               }
                else
                {
                lblInvalidInputSuc.Text = $"Ingrese un ID válido";
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