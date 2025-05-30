using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool SucursalExists(int idSucursal)
        {
            string querySQL = "SELECT COUNT(*) FROM Sucursal WHERE Id_Sucursal = @Id";
            using (SqlConnection con = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(querySQL, con);
                cmd.Parameters.AddWithValue("@Id", idSucursal);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public void DeleteSucursal(int idSucursal)
        {
            string querysql = "DELETE FROM Sucursal WHERE Id_Sucursal = @idSucursal ";
            using (SqlConnection con = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(querysql, con);

            }
        }
        public List<string> GetSucursalProvincias()
        {
            List<string> provincias = new List<string>();
            string querySQL = "SELECT DescripcionProvincia FROM Provincia";
            using (SqlConnection con = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(querySQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    provincias.Add(Convert.ToString(reader["DescripcionProvincia"]));
                }
            }
            return provincias;
        }
        /*
                cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                con.Open();
                cmd.ExecuteNonQuery();

        */
            }
        }
    