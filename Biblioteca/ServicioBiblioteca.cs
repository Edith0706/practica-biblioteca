using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Biblioteca;

public class ServicioBiblioteca
{
    private string connectionString;

    public ServicioBiblioteca()
    {
        connectionString = ConfigurationManager.ConnectionStrings["Bibliotecaa"].ConnectionString;
    }

    public Usuario AutenticarUsuario(string email)
    {
        Usuario usuario = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Usuarios WHERE email = @Email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                usuario = new Usuario
                {
                    UsuarioId = (int)reader["usuario_id"],
                    Nombre = (string)reader["nombre"],
                    Email = (string)reader["email"],
                    FechaRegistro = (DateTime)reader["fecha_registro"]
                };
            }
        }
        return usuario;
    }

    public List<Libro> ObtenerLibros()
    {
        List<Libro> libros = new List<Libro>();

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Libros";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        LibroId = Convert.ToInt32(reader["libro_id"]),
                        Titulo = reader["titulo"].ToString(),
                        Autor = reader["autor"].ToString(),
                        AnioPublicacion = Convert.ToDateTime(reader["anio_publicacion"]),
                        Genero = reader["genero"].ToString()

                    };

                    libros.Add(libro);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            Console.WriteLine("Error al obtener los libros: " + ex.Message);
        }

        return libros;
    }

    public bool GuardarPrestamo(int usuarioId, int libroId, DateTime fechaPrestamo, DateTime fechaDevolucion)
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Data Source=TuServidor;Initial Catalog=TuBaseDeDatos;Integrated Security=True";

        // Consulta SQL para insertar el préstamo en la tabla Prestamos
        string query = "INSERT INTO Prestamos (usuario_id, libro_id, fecha_prestamo, fecha_devolucion) VALUES (@UsuarioId, @LibroId, @FechaPrestamo, @FechaDevolucion)";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.Parameters.AddWithValue("@LibroId", libroId);
                    command.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                    command.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        catch (Exception ex)
        {
            // Manejo de errores (puedes agregar logging u otro manejo de excepciones según tu requerimiento)
            Console.WriteLine("Error al guardar el préstamo: " + ex.Message);
            return false;
        }
    }

    public Prestamo PrestarLibro(int usuarioId, int libroId)
    {
        Prestamo prestamo = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Prestamos (usuario_id, libro_id, fecha_prestamo, fecha_devolucion) VALUES (@UsuarioId, @LibroId, @FechaPrestamo, @FechaDevolucion);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UsuarioId", usuarioId);
            command.Parameters.AddWithValue("@LibroId", libroId);
            command.Parameters.AddWithValue("@FechaPrestamo", DateTime.Now);
            command.Parameters.AddWithValue("@FechaDevolucion", DateTime.Now.AddDays(14)); // 14 días de préstamo

            connection.Open();
            int prestamoId = Convert.ToInt32(command.ExecuteScalar());

            if (prestamoId > 0)
            {
                prestamo = new Prestamo
                {
                    PrestamoId = prestamoId,
                    UsuarioId = usuarioId,
                    LibroId = libroId,
                    FechaPrestamo = DateTime.Now,
                    FechaDevolucion = DateTime.Now.AddDays(14)
                };
            }
        }
        return prestamo;
    }
}
