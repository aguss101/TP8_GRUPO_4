using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

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

        public List <String> GetSucursalProvincias()
        {
            return sucursalData.GetSucursalProvincias();
        }
    }
}
