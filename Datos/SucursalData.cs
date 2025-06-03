using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class SucursalData
    {
        private DataBaseAccess conexion = new DataBaseAccess();

        public List<Sucursal> GetSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            string querySQL = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN, ISNULL(DescripcionHorario, 'Sin horario') AS HORARIO FROM Sucursal LEFT JOIN Horario ON Id_HorarioSucursal=Id_Horario INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal";

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
                        DescripcionHorario = Convert.ToString(reader["HORARIO"])
                    };
                    sucursales.Add(sucursal);
                }
            }
            return sucursales;
        }


        public Sucursal GetSucursalID(int IdSucursal)
        {

            string querySQL = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN, ISNULL(DescripcionHorario, 'Sin horario') AS HORARIO FROM Sucursal LEFT JOIN Horario ON Id_HorarioSucursal=Id_Horario INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal WHERE Id_Sucursal = @IdSucursal";

            using (SqlConnection con = conexion.GetConnection())
            {
                Sucursal suc = new Sucursal();
                SqlCommand cmd = new SqlCommand(querySQL, con);
                cmd.Parameters.AddWithValue("@IdSucursal", IdSucursal);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Sucursal sucursal = new Sucursal
                    {
                        IdSucursal = Convert.ToInt32(reader["ID"]),
                        NombreSucursal = Convert.ToString(reader["NOMBRE"]),
                        DescripcionSucursal = Convert.ToString(reader["DESCRIPCION"]),
                        ProvinciaSucursal = Convert.ToString(reader["PROVINCIA"]),
                        DireccionSucursal = Convert.ToString(reader["DIRECCIÓN"]),
                        DescripcionHorario = Convert.ToString(reader["HORARIO"])
                    };
                    suc = sucursal;
                    return suc;
                }
                return null;


            }
        }
        public bool DeleteSucursal(int idSucursal)
        {
            string deleteQuery = "DELETE FROM Sucursal WHERE Id_Sucursal = @Id";

            using (SqlConnection con = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@Id", idSucursal);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // True si se eliminó, false si no existía
            }
        }
        public void AddSucursal(Sucursal sucursal)
        {
            string querysql = @"INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, DireccionSucursal, Id_ProvinciaSucursal, Id_HorarioSucursal)
                        VALUES (@nombre, @descripcion, @direccion, @Id_ProvinciaSucursal, @Id_HorarioSucursal)";

            using (SqlConnection con = conexion.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(querysql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", sucursal.NombreSucursal);
                    cmd.Parameters.AddWithValue("@descripcion", sucursal.DescripcionSucursal);
                    cmd.Parameters.AddWithValue("@direccion", sucursal.DireccionSucursal);
                    cmd.Parameters.AddWithValue("@Id_ProvinciaSucursal", sucursal.idProvinciaSucursal);
                    cmd.Parameters.AddWithValue("@Id_HorarioSucursal", sucursal.idHorarioSucursal.HasValue ? (object)sucursal.idHorarioSucursal.Value : DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
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

        public List<string> GetSucursalHorario()
        {
            List<string> horarios = new List<string>();
            string querySQL = "SELECT DescripcionHorario FROM Horario";
            using (SqlConnection con = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(querySQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    horarios.Add(Convert.ToString(reader["DescripcionHorario"]));
                }
            }
            return horarios;
        }

        public bool Exists(int idSucursal)
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
    }
}