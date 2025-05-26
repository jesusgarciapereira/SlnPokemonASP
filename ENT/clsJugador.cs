using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsJugador
    {
        #region Atributos
        private int idJugador;
        private string nick;
        private int puntuacion;
        #endregion

        #region Propiedades
        public int IdJugador
        {
            get { return idJugador; }

        }

        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }

        public int Puntuacion
        {
            get { return puntuacion; }
            // Es un campo calculado, no debería tener set
        }
        #endregion

        #region Constructores
        public clsJugador() 
        { 
        }

        public clsJugador(int idJugador, string nick, int puntuacion)
        {
            this.idJugador = idJugador;
            this.nick = nick;
            this.puntuacion = puntuacion;
        }
        #endregion
    }
}
