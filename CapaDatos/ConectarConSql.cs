using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class ConectarConSql
    {
        private readonly string connectionString;
        public ConectarConSql()
        {
            connectionString = "Server= SANTI; DataBase= DB_FACTURAS; integrated security= true";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }

    //public abstract class CD_ConectarConSql
    //{
    //    private SqlConnection sqlConnection = new SqlConnection("Server= (local); DataBase= DB_FACTURAS; integrated security= true");

    //    public SqlConnection OpenCon()
    //    {
    //        if (sqlConnection.State == ConnectionState.Closed)
    //            sqlConnection.Open();
    //        return sqlConnection;
    //    }

    //    public SqlConnection CloseConn()
    //    {
    //        if (sqlConnection.State == ConnectionState.Open)
    //            sqlConnection.Close();
    //        return sqlConnection;
    //    }
    //}

}
