using DAL.Conexion;
using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsManejadoraJugadorDAL
    {
        /// <summary>
        /// Crea un nuevo Jugador con su puntuacion en la Base de Datos
        /// Pre: Ninguno
        /// Post: Ninguno
        /// </summary>
        /// <returns>El número de filas afectadas</returns>
        public static int CrearJugadorDAL(clsJugador jugador)
        {
            int numeroFilasAfectadas = 0;

            SqlConnection miConexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            // Recuerda poner el tipo que corresponda (Int, Varchar, Date...)
            miComando.Parameters.Add("@nick", SqlDbType.VarChar).Value = jugador.Nick;
            miComando.Parameters.Add("@puntuacion", SqlDbType.Int).Value = jugador.Puntuacion;

            try
            {
                miConexion = clsMyConnection.getConnection();
                miComando.CommandText = "INSERT INTO Jugadores VALUES (@nick, @puntuacion)";

                miComando.Connection = miConexion;
                numeroFilasAfectadas = miComando.ExecuteNonQuery();

                clsMyConnection.closeConnection(ref miConexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return numeroFilasAfectadas;
        }
    }
}