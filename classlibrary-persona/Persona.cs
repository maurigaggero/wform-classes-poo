using System;

namespace classlibrary_persona
{
    public class Persona
    {
        #region Atributos
        private string nombre;
        private long dni;
        private DateTime fechNac;
        private char sexo;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public DateTime FechNac
        {
            get { return fechNac; }
            set { fechNac = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        #endregion


        #region Constructores
        public Persona()
        {
        }

        public Persona(string Nom, long DNI, DateTime FecNac, char Sex)
        {
            Nombre = Nom;
            Dni = DNI;
            FechNac = FecNac;
            Sexo = Sex;
        }
        #endregion


        #region Métodos
        public int Edad()
        {
            int edad = (Convert.ToInt32(DateTime.Now.Year)) - Convert.ToInt32(FechNac.Year);
            return edad;
        }
        #endregion
    }
}
