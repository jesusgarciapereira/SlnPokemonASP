using DAL.Conexion;
using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListadosJugadorDAL
    {
        /// <summary>
        /// Obtiene el listado completo de Jugadores ordenado por sus puntuaciones de la BBDD.
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        /// <returns>Una lista de objetos de tipo clsJugador</returns>
        public static List<clsJugador> ObtenerListadoJugadoresDAL()
        {
            // Declaración de variables para la conexión y operaciones con la base de datos
            SqlConnection miConexion;                   // Objeto para la conexión a SQL Server
            SqlCommand miComando = new SqlCommand();    // Objeto para ejecutar comandos SQL
            SqlDataReader miLector;                     // Objeto para leer los resultados de la consulta

            List<clsJugador> listadoCompletoJugadores = new List<clsJugador>();
            clsJugador jugador;

            try
            {
                // Establece la conexión con la base de datos
                miConexion = clsMyConnection.getConnection();

                // Configura el comando SQL que se va a ejecutar (consulta SELECT ordenada)
                miComando.CommandText = "SELECT * FROM Jugadores ORDER BY puntuacion DESC";
                // Asigna la conexión al comando
                miComando.Connection = miConexion;
                // Ejecuta el comando y obtiene un lector de datos
                miLector = miComando.ExecuteReader();

                // Verifica si el lector contiene filas (si hay datos)
                if (miLector.HasRows)
                {
                    // Lee fila por fila mientras haya datos
                    while (miLector.Read())
                    {
                        // Crea un nuevo objeto clsJugador, verificando primero que no sea NULL ninguna Propiedad en la BD 
                        // Los cast son necesarios porque el lector devuelve objetos
                        if (miLector["nick"] != DBNull.Value && miLector["puntuacion"] != DBNull.Value)
                        {
                            jugador = new clsJugador((int)miLector["id"], (string)miLector["nick"], (int)miLector["puntuacion"]);
                            listadoCompletoJugadores.Add(jugador);
                        }                  
                    }
                }
                // Cierra el lector de datos (importante para liberar recursos)
                miLector.Close();
                // Cierra la conexión a la base de datos usando el método de la clase de conexión
                clsMyConnection.closeConnection(ref miConexion);
            }
            catch (SqlException exSql)
            {
                // Captura excepciones específicas de SQL y las relanza
                throw exSql;
            }

            // Devuelve la lista completa de jugadores obtenida de la base de datos
            return listadoCompletoJugadores;
        }
    }
}
