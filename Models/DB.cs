namespace TP04Prog.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using TP04Prog.Models;


    public static class DB 
    { 
        private static string _connectionString =
        @"Server=localhost;Database=album2026;Integrated Security=True;TrustServerCertificate=True";
        //@"Server=.\SQLEXPRESS;Database=album2026;Integrated Security=True;TrustServerCertificate=True;";


        
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

        public static List<Selecciones> GetSelecciones(int idUsuario)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                FROM Selecciones";
                
                List<Selecciones> selecciones = connection.Query<Selecciones>(query).ToList();
                foreach (Selecciones s in selecciones)
                {
                    s.Figuritas = GetFiguritasBySeleccion(s.ID, idUsuario);                
                }
                return selecciones;
            }
        }
        public static List<Figuritas> GetFiguritasBySeleccion(int seleccionId, int idUsuario)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                                SELECT
                                    F.*,
                                    J.*,
                                    UF.Pegada,
                                    UF.Cantidad
                                FROM Figuritas F
                                INNER JOIN Jugadores J
                                    ON F.idJugador = J.ID
                                LEFT JOIN UsuariosFiguritas UF
                                    ON UF.idFigurita = F.ID
                                AND UF.idUsuario = @idUsuario
                                WHERE J.IdSeleccion = @seleccionId";


                List<Figuritas> figuritas = connection.Query<Figuritas>(query, new { seleccionId, idUsuario }).ToList();

                foreach (Figuritas f in figuritas)
                {
                    f.Jugador = GetJugador(f.idJugador);
                }

                return figuritas;
            }
        }
        public static Figuritas GetFiguritaById(int id)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM Figuritas WHERE ID = @id";

                return connection.QueryFirstOrDefault<Figuritas>(query, new { id });
            }
        }
        public static Jugadores GetJugador(int jugadorId)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                FROM Jugadores
                                WHERE ID = @jugadorId";
                
                return connection.QueryFirstOrDefault<Jugadores>(query, new { jugadorId });
            }
        }
        public static Selecciones GetSeleccion(int seleccionId)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                FROM Selecciones
                                WHERE ID = @seleccionId";
                
                return connection.QueryFirstOrDefault<Selecciones>(query, new { seleccionId });
            }
        }
        public static void PegarFigurita(int idUsuario, int idFigurita)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE UsuariosFiguritas
                                SET Pegada = 1
                                WHERE idFigurita = @idFigurita
                                AND idUsuario = @idUsuario";

                int filas = connection.Execute(query, new { idFigurita, idUsuario });

                Console.WriteLine($"Filas actualizadas: {filas}");
            }
        }
        public static List<Figuritas> getFiguritasByUsuario(int idUsuario)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT 
                                    UF.Pegada,
                                    UF.Cantidad,
                                    F.*
                                FROM UsuariosFiguritas UF 
                                INNER JOIN Figuritas F
                                    ON UF.idFigurita = F.ID 
                                INNER JOIN Jugadores J 
                                    ON F.IdJugador = J.ID
                                WHERE UF.idUsuario = @idUsuario
                                ORDER BY J.IdSeleccion, F.Numero";
                
                List<Figuritas> figuritas = connection.Query<Figuritas>(query, new{idUsuario}).ToList();
                
                foreach ( Figuritas item in figuritas)
                {
                    item.Jugador = GetJugador(item.idJugador);
                    item.Jugador.Seleccion = GetSeleccion(item.Jugador.idSeleccion);
                }
                return figuritas;
            }  
        }
        public static List<Figuritas> getFiguritas()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM Figuritas";
                return connection.Query<Figuritas>(query).ToList();

            }
        }
            public static List<Figuritas> getFiguritasx5()
            {
                Random random = new Random();
                List<Figuritas> figus = new List<Figuritas>();

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = @"SELECT * FROM Figuritas  WHERE ID = @id";
                    int cantidad = getFiguritas().Count ;
                    for(int i = 0; i<5; i++)
                    {
                        figus.Add(connection.QueryFirstOrDefault<Figuritas>(query,new {id = random.Next(1, cantidad + 1)}));
                    }
                    foreach (Figuritas f in figus)
                    {
                        f.Jugador = GetJugador(f.idJugador);
                    }
                    return figus;



                }
            }
        public static void AgregarFigurita(int idUsuario, int idFigurita)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string queryExiste = @"
                    SELECT COUNT(*)
                    FROM UsuariosFiguritas
                    WHERE idUsuario = @idUsuario
                    AND idFigurita = @idFigurita";

                int existe = connection.ExecuteScalar<int>(queryExiste, new
                {
                    idUsuario,
                    idFigurita
                });

                if(existe > 0)
                {
                    string queryUpdate = @"
                        UPDATE UsuariosFiguritas
                        SET Cantidad = Cantidad + 1
                        WHERE idUsuario = @idUsuario
                        AND idFigurita = @idFigurita";

                    connection.Execute(queryUpdate, new
                    {
                        idUsuario,
                        idFigurita
                    });
                }
                else
                {
                    string queryInsert = @"
                        INSERT INTO UsuariosFiguritas
                        (idUsuario, idFigurita, Cantidad, Pegada)
                        VALUES
                        (@idUsuario, @idFigurita, 1, 0)";

                    connection.Execute(queryInsert, new
                    {
                        idUsuario,
                        idFigurita
                    });
                }
            }
        }

        public static int GetCantidadPegadas(int idUsuario)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM UsuariosFiguritas
                    WHERE idUsuario = @idUsuario
                    AND Pegada = 1";

                return connection.ExecuteScalar<int>(query, new { idUsuario });
            }
        }
    }
    




