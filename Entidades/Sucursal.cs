using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string DireccionSucursal { get; set; }
        public string DescripcionSucursal { get; set; }
        public int idProvinciaSucursal { get; set; }

        public string ProvinciaSucursal { get; set; }

    }
}
