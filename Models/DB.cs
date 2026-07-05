namespace TP04Prog.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TP04Prog.Models;


    public static class DB 
    { 
private static string _connectionString =
@"Server=.\SQLEXPRESS;Database=album2026;Integrated Security=True;TrustServerCertificate=True;";
        public static Usuarios? Login(LogInViewModel l)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                FROM Usuarios
                                WHERE Usuario = @usuario
                                AND Password = @password";

                return connection.QueryFirstOrDefault<Usuarios?>(
                    query,
                    new
                    {
                        usuario = l.usuario,
                        password = l.password
                    });
            }
        }
        public static void Register(Usuarios u)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Usuarios (Usuario, Password, Nombre)
                                VALUES (@usuario, @password, @nombre)";

                connection.Execute(query,
                    new
                    {
                        usuario = u.Usuario,
                        password = u.Password,
                        nombre = u.Nombre
                    });
            }
        } 

        public static Usuarios? GetUsuarioById(int pid)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                FROM Usuarios
                                WHERE ID = @id";

                return connection.QueryFirstOrDefault<Usuarios?>(
                    query,
                    new
                    {
                        id = pid
                    });
            }
        }
        public static void UpdateUsuario(Usuarios u)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Usuarios
                                SET Usuario = @usuario,
                                    Password = @password,
                                    Nombre = @nombre
                                WHERE ID = @id";

                connection.Execute(query,
                    new
                    {
                        id = u.ID,
                        usuario = u.Usuario,
                        password = u.Password,
                        nombre = u.Nombre
                    });
            }
        }
       


    }
    




