namespace TP04Prog.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TP04Prog.Models;

    public static class DB 
    { 
        public static Usuarios Login(LoginViewModel l)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                FROM Usuarios
                                WHERE Usuario = @usuario
                                AND Password = @password";

                return connection.QueryFirstOrDefault<Usuarios>(
                    query,
                    new
                    {
                        usuario = l.usuario,
                        password = l.password
                    });
            }
        }
    }
    




