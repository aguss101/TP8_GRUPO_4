using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Negocio
{
    public class SucursalManager
    {
        private SucursalData sucursalData = new SucursalData();
        public List<Sucursal> GetSucursales()
        {
            return sucursalData.GetSucursales();
        }

        public Sucursal GetSucursalID(int idSucursal)
        {
            return sucursalData.GetSucursalID(idSucursal);
        }

        public List<String> GetSucursalProvincias()
        {
            return sucursalData.GetSucursalProvincias();

        }
        public List<String> GetSucursalHorarios()
        {
            return sucursalData.GetSucursalHorario();
        }
        public void AddSucursal(Sucursal sucursal)
        {
            sucursalData.AddSucursal(sucursal);
        }
        public bool DeleteSucursal(int idSucursal) => sucursalData.DeleteSucursal(idSucursal);
        public bool Exists(int idSucursal) => sucursalData.Exists(idSucursal);

    }
}
