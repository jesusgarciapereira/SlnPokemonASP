using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLASP
{
    public class clsListadosJugadorBL
    {
        /// <summary>
        /// Obtiene el listado completo de jugadores desde la capa DAL.
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        /// <returns>Una lista de objetos de tipo clsJugador con las reglas de negocio aplicadas.</returns>
        public static List<clsJugador> ObtenerListadoJugadoresBL()
        {
            return clsListadosJugadorDAL.ObtenerListadoJugadoresDAL();
        }
    }
}
