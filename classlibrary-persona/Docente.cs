using System;
using System.Collections.Generic;
using System.Text;

namespace classlibrary_persona
{
    public class Docente : Persona
    {
        #region Atributos
        private string materia;
        private string legajo;
        #endregion

        #region Propiedades
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        #endregion

        #region Constructores
        public Docente()
        {
        }

        public Docente(string Nom, long DNI, DateTime FecNac, char Sex, string Mat, string Leg)
        {
            Nombre = Nom;
            Dni = DNI;
            FechNac = FecNac;
            Sexo = Sex;
            Materia = Mat;
            Legajo = Leg;
        }
        #endregion


        #region Métodos
        #endregion
    }
}