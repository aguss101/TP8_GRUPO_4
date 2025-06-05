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
            if (!IsPostBack)
            {
                LoadSucursales();
            }

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
            gvSucursales.Visible = true;

            int idInput;
            if (int.TryParse(txbIdSucursal.Text, out idInput) && idInput > 0)
            {
                try
                {
                    Sucursal suc = sucursalmanager.GetSucursalID(idInput);
                    gvSucursales.DataSource = new List<Sucursal> { suc };
                    gvSucursales.DataBind();
                    gvSucursales.Visible = true;
                }
                catch (Exception ex)
                {
                    lblInvalidInputSuc.Text = "Ese ID de sucursal no existe.";
                    lblInvalidInputSuc.Visible = true;
                }
            }
            else
            {
                lblInvalidInputSuc.Text = "Valor inválido, ingrese un número!";
                lblInvalidInputSuc.Visible = true;
            }

            txbIdSucursal.Text = "";
        }


        protected void btnOrdenarSucursales(object sender, EventArgs e)
        {
            lblInvalidInputSuc.Visible = false;
            pnlOrden.Visible = true;
        }
        
        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvSucursales.Visible = true;
            lblInvalidInputSuc.Visible = false;
            LoadSucursales();
        }
        protected void sortList(object sender, EventArgs e)
        {
            pnlOrden.Visible = false;
            List<Sucursal> list = sucursalmanager.GetSucursales();

            if (sender is Button btn)
            {
                switch (btn.CommandArgument.ToString())
                {
                    case "ID":
                        list = list.OrderBy(s => s.IdSucursal).ToList();
                        break;
                    case "NOMBRE":
                        list = list.OrderBy(s => s.NombreSucursal).ToList();
                        break;
                    case "PROVINCIA":
                        list = list.OrderBy(s => s.ProvinciaSucursal).ToList();
                        break;
                    case "CANCELAR":
                        desfiltrarTabla(list);
                        return;
                }
                desfiltrarTabla(list);
            }
        }
        protected void desfiltrarTabla(List<Sucursal> list)
        {
            gvSucursales.Visible = true;
            gvSucursales.DataSource = list;
            gvSucursales.DataBind();
        }
    }
}