﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        // [JsonPropertyName("nick")] // No hace falta, se llama igual
        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }

        public int Puntuacion
        {
            get { return puntuacion; }
            set { puntuacion = value; } // Es un campo calculado, no debería tener set. Pero debo ponérselo para hacer los Post
        }
        #endregion

        #region Constructores
        public clsJugador() 
        { 
        }

        public clsJugador(int id) 
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
