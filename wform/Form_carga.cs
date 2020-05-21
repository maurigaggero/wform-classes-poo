using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classlibrary_persona;

namespace wform
{
    public partial class Form_carga : Form
    {
        public Form_carga()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            lbl_aviso.Text = "";

            txt_nombre.Text = "Nombre";
            txt_nombre.Focus();
            txt_nombre.SelectAll();

            txt_dni.Text = "DNI";
            txt_fecha.Value = DateTime.Now;
            txt_carr_materia.Text = "Carrera/Materia";
            txt_legajo.Text = "Legajo";
            radio_f.Checked = false;
            radio_m.Checked = false;
            radio_o.Checked = false;
            radio_alumno.Checked = false;
            radio_docente.Checked = false;
        }

        public void Enlazar()
        {
            if (txt_nombre.Text == "Nombre" || txt_dni.Text == "DNI" ||
                txt_carr_materia.Text == "Carrera/Materia" || txt_legajo.Text == "Legajo" ||
                radio_alumno.Checked == false && radio_docente.Checked == false ||
                radio_f.Checked == false && radio_m.Checked == false && radio_o.Checked == false)
            {
                lbl_aviso.Text = "*Completar campo.";
            }
            else
            {
                string nombre = txt_nombre.Text;
                long dni = Convert.ToInt32(txt_dni.Text);
                DateTime fechanac = txt_fecha.Value;
                string matcarr = txt_carr_materia.Text;
                long legajo = Convert.ToInt64(txt_legajo.Text);

                if (radio_m.Checked)
                {
                    char sexo = 'M';

                    if (radio_docente.Checked == true)
                    {
                        Docente d = new Docente(nombre, dni, fechanac, sexo, matcarr, Convert.ToString(legajo));
                        //lbl_edad.Text = "Edad: " + Convert.ToString(d.Edad());
                    }
                    if (radio_alumno.Checked == true)
                    {
                        Alumno a = new Alumno(nombre, dni, fechanac, sexo, matcarr, legajo);
                        //lbl_edad.Text = "Edad: " + Convert.ToString(a.Edad());
                    }
                }
                if (radio_f.Checked)
                {
                    char sexo = 'F';

                    if (radio_docente.Checked == true)
                    {
                        Docente d = new Docente(nombre, dni, fechanac, sexo, matcarr, Convert.ToString(legajo));
                    }
                    if (radio_alumno.Checked == true)
                    {
                        Alumno a = new Alumno(nombre, dni, fechanac, sexo, matcarr, legajo);
                    }
                }
                if (radio_o.Checked)
                {
                    char sexo = 'O';

                    if (radio_docente.Checked == true)
                    {
                        Docente d = new Docente(nombre, dni, fechanac, sexo, matcarr, Convert.ToString(legajo));
                    }
                    if (radio_alumno.Checked == true)
                    {
                        Alumno a = new Alumno(nombre, dni, fechanac, sexo, matcarr, legajo);
                    }
                }

                LimpiarCampos();
            }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            Enlazar();
        }
    }
}
