using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class SucursalData
    {
        private DataBaseAccess conexion = new DataBaseAccess();


        public List<Sucursal> GetSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            string querySQL = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA,DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal ";

            using (SqlConnection con = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(querySQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sucursal sucursal = new Sucursal
                    {
                        IdSucursal = Convert.ToInt32(reader["ID"]),
                        NombreSucursal = Convert.ToString(reader["NOMBRE"]),
                        DescripcionSucursal = Convert.ToString(reader["DESCRIPCION"]),
                        ProvinciaSucursal = Convert.ToString(reader["PROVINCIA"]),
                        DireccionSucursal = Convert.ToString(reader["DIRECCIÓN"]),
                    };
                    sucursales.Add(sucursal);
                }
            }
            return sucursales;
        }


        public Sucursal GetSucursalID(int IdSucursal)
        {

            string querySQL = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA,DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal WHERE Id_Sucursal = @IdSucursal";

            using (SqlConnection con = conexion.GetConnection())
            {
                Sucursal suc = new Sucursal();
                SqlCommand cmd = new SqlCommand(querySQL, con);
                cmd.Parameters.AddWithValue("@IdSucursal", IdSucursal);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sucursal sucursal = new Sucursal
                    {
                        IdSucursal = Convert.ToInt32(reader["ID"]),
                        NombreSucursal = Convert.ToString(reader["NOMBRE"]),
                        DescripcionSucursal = Convert.ToString(reader["DESCRIPCION"]),
                        ProvinciaSucursal = Convert.ToString(reader["PROVINCIA"]),
                        DireccionSucursal = Convert.ToString(reader["DIRECCIÓN"]),
                    };
                    suc = sucursal;
                }
                return suc;


            }
        }

    }
}