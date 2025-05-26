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
        private int id;
        private string nick;
        private int puntuacion;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return id; }

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

        public clsJugador(int id) // Seguramente este Constructor es innecesario
        {
            this.id = id;
        }

        public clsJugador(int id, string nick, int puntuacion)
        {
            this.id = id;
            this.nick = nick;
            this.puntuacion = puntuacion;
        }
        #endregion
    }
}
