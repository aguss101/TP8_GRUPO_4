using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    internal class DataBaseAccess
    {
        private static string routeConection = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales;Integrated Security = True";


        public DataTable GetTable(string querySql, string nameTable)
        {

            SqlConnection conection = new SqlConnection(routeConection);
            conection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(querySql, routeConection);   /// --> Hacer Tablas.
			DataSet dataset = new DataSet();
            adapter.Fill(dataset, nameTable);
            return dataset.Tables[nameTable];
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(routeConection);
        }

        public int ExecuteQuery(string querySQL)
        {

            SqlConnection conection = new SqlConnection(routeConection);
            conection.Open();
            SqlCommand cmd = new SqlCommand(querySQL, conection);
            int filas = (int)cmd.ExecuteNonQuery();                                 /// --> Ingreso de datos.
			conection.Close();
            return filas;

        }

        public int ExecuteSP(SqlCommand command, String NameSP)
        {
            SqlConnection conection = new SqlConnection(routeConection);
            conection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = command;
            cmd.Connection = conection;
            cmd.CommandType = CommandType.StoredProcedure; /// --> Este es por si quieren hacer un script de SQL
			cmd.CommandText = NameSP;
            int filas = cmd.ExecuteNonQuery();
            conection.Close();
            return filas;

        }
    }
}
