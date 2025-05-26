using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLASP
{
    public class clsManejadoraJugadorBL
    {

        /// <summary>
        /// Crea un nuevo Jugador con su puntuacion desde la capa DAL
        /// Pre: Ninguno
        /// Post: Ninguno
        /// </summary>
        /// <returns>El número de filas afectadas con las reglas de negocio aplicadas.</returns>
        public static int CrearJugadorBL(clsJugador jugador)
        {
            return clsManejadoraJugadorDAL.CrearJugadorDAL(jugador);
        }
    }
}