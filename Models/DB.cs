namespace TP04Prog.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TP04Prog.Models;

    public static class DB 
    { 
        private static string _connectionString = @"Server=localhost;DataBase=album2026;Integrated Security=True;TrustServerCertificate=True;"; 
        public static bool LogIn(string username, string password)
        { 
            int resultado = 0;
            using(SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                string query = "SELECT * FROM Usuarios WHERE Usuario = @username AND Password = @password";
                resultado = connection.Query<Usuarios>(query, new { username, password }).ToList().Count(); 
            }
            return resultado > 0;  
        }
    }
    




