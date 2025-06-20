﻿using System;
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
                LoadHorarios();
            }

        }

        protected void LoadProvincias()
        {
            List<String> provincias = sucursalManager.GetSucursalProvincias();
            ddlProvincias.DataSource = provincias;
            ddlProvincias.DataBind();
            ddlProvincias.Items.Insert(0, new ListItem("--- Seleccionar ---", ""));
        }

        protected void LoadHorarios()
        {
            List<string> horarios = sucursalManager.GetSucursalHorarios();
            ddlHorario.DataSource = horarios;
            ddlHorario.DataBind();
            ddlHorario.Items.Insert(0, new ListItem("--- Seleccionar ---", ""));
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {


            Sucursal sucursalToAdd = new Sucursal();

            sucursalToAdd.NombreSucursal = txtNameSuc.Text;
            sucursalToAdd.DescripcionSucursal = txtDesc.Text;
            sucursalToAdd.DireccionSucursal = txtDir.Text;
            sucursalToAdd.idProvinciaSucursal = ddlProvincias.SelectedIndex;
            if (ddlHorario.SelectedIndex == 0)
            {
                sucursalToAdd.idHorarioSucursal = null;
            }
            else
            {
                sucursalToAdd.idHorarioSucursal = ddlHorario.SelectedIndex;
            }

            try
            {
                sucursalManager.AddSucursal(sucursalToAdd);
                lblCorrect.Text = "Sucursal agregada correctamente.<br />Nombre:" + sucursalToAdd.NombreSucursal +
                                  "<br />Descripcion: " + sucursalToAdd.DescripcionSucursal +
                                  "<br />Direccion: " + sucursalToAdd.DireccionSucursal +
                                  "<br />Provincia: " + ddlProvincias.SelectedItem.Text
                ;
                if (ddlHorario.SelectedIndex != 0)
                {
                    lblCorrect.Text += "<br />Horario: " + ddlHorario.SelectedItem.Text;
                }
                else 
                {
                    lblCorrect.Text += "<br />Horario: Sin horario";
                }

                lblCorrect.ForeColor = System.Drawing.Color.Green;
                ddlProvincias.SelectedIndex = 0;
                ddlHorario.SelectedIndex = 0;
                txtNameSuc.Text = "";
                txtDesc.Text = "";
                txtDir.Text = "";

            }
            catch (Exception ex)
            {
                lblCorrect.Text = "Error al agregar la sucursal: " + ex.Message;
                lblCorrect.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}