using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace CapaDatos
{
    public class UserDao:ConectarConSql
    {
        
        public bool InicioSesion(string gente, string clave)
        {
            try
            {
                //Garantiza llamar los métodos desechables por ello no es necesario cerrar la conexión.
                using (var connection = ObtenerConexion())
                {
                    connection.Open(); //La conexión existirá hasta que los elementos se completen.

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT tblSeguridad.idEmpleado, strNombreEmpleado, tblPuestoEmpleado.strDescripcion, strEmailEmpleado, strUsuario, Password FROM tblSeguridad " +
                            "inner join tblEmpleado on tblEmpleado.idEmpleado = tblSeguridad.idEmpleado " +
                            "inner join tblPuestoEmpleado on tblPuestoEmpleado.idRolEmpleado = tblEmpleado.idRolEmpleado where strUsuario = @User and Password = @Pass ";
                        command.Parameters.AddWithValue("@User", gente);
                        command.Parameters.AddWithValue("@Pass", clave);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserLoginCache.IdUser = reader.GetInt64(0);
                                UserLoginCache.NombreEmpleado = reader.GetString(1);
                                UserLoginCache.Cargo = reader.GetString(2);
                                UserLoginCache.CorreoElectronico = reader.GetString(3);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        
                    }
                }
            }
            catch (Exception ex1) {
                Console.WriteLine("Algo salió mal dentro del Inicio de sessión: UserDAO" + ex1);
                return false;
            }  
        }
    }
}
