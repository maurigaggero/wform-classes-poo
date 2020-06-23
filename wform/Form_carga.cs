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

        #region METODOS
        public void LimpiarCampos()
        {
            lbl_aviso.Text = "";
            lbl_edad.Text = "";

            txt_nombre.Text = "Nombre";
            txt_nombre.Focus();
            txt_nombre.SelectAll();

            txt_dni.Text = "DNI";
            //txt_fecha.Value = DateTime.Now;
            txt_carr_materia.Text = "Carrera/Materia";
            txt_legajo.Text = "Legajo";
            radio_f.Checked = false;
            radio_m.Checked = false;
            radio_alumno.Checked = false;
            radio_docente.Checked = false;
        }

        public void Cargar()
        {
            if (txt_nombre.Text == "Nombre" || txt_dni.Text == "DNI" ||
                txt_carr_materia.Text == "Carrera/Materia" || txt_legajo.Text == "Legajo" ||
                radio_alumno.Checked == false && radio_docente.Checked == false ||
                radio_f.Checked == false && radio_m.Checked == false)
            {
                lbl_aviso.Text = "*Completar campo.";
            }
            else if (radio_docente.Checked == true && txt_legajo.Text.Any(x => char.IsNumber(x)) ||
            radio_alumno.Checked == true && txt_legajo.Text.Any(x => !char.IsNumber(x)))
            {
                lbl_aviso.Text = "Error en el campo 'Legajo'";
            }
            else
            {
                string nombre = txt_nombre.Text;
                long dni = Convert.ToInt32(txt_dni.Text);
                DateTime fechanac = txt_fecha.Value;
                string matcarr = txt_carr_materia.Text;
                var legajo = txt_legajo.Text;


                if (radio_m.Checked)
                {
                    char sexo = 'M';

                    if (radio_docente.Checked == true && txt_legajo.Text.Any(x => !char.IsNumber(x)))
                    {
                        Docente d = new Docente(nombre, dni, fechanac, sexo, matcarr, Convert.ToString(legajo));

                        dg_datos.Rows.Add(d.Nombre, d.Dni, d.FechNac, d.Sexo, d.Legajo, d.Materia);

                        //dg_datos.CurrentRow.DefaultCellStyle.ForeColor = Color.Blue;
                        //dg_datos.CurrentRow.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                    if (radio_alumno.Checked == true && txt_legajo.Text.Any(x => char.IsNumber(x)))
                    {
                        Alumno a = new Alumno(nombre, dni, fechanac, sexo, matcarr, Convert.ToInt64(legajo));

                        dg_datos.Rows.Add(a.Nombre, a.Dni, a.FechNac, a.Sexo, a.Legajo, a.Carrera);
                    }
                }
                if (radio_f.Checked)
                {
                    char sexo = 'F';

                    if (radio_docente.Checked == true && txt_legajo.Text.Any(x => !char.IsNumber(x)))
                    {
                        Docente d = new Docente(nombre, dni, fechanac, sexo, matcarr, Convert.ToString(legajo));

                        dg_datos.Rows.Add(d.Nombre, d.Dni, d.FechNac, d.Sexo, d.Legajo, d.Materia);

                    }
                    if (radio_alumno.Checked == true && txt_legajo.Text.Any(x => char.IsNumber(x)))
                    {
                        Alumno a = new Alumno(nombre, dni, fechanac, sexo, matcarr, Convert.ToInt64(legajo));

                        dg_datos.Rows.Add(a.Nombre, a.Dni, a.FechNac, a.Sexo, a.Legajo, a.Carrera);
                    }
                }
                LimpiarCampos();
            }
        }

        public void GridToBox()
        {
            if (dg_datos.CurrentRow.Cells[3].Value.ToString() == "F")
            {
                radio_f.Checked = true;
            }
            if (dg_datos.CurrentRow.Cells[3].Value.ToString() == "M")
            {
                radio_m.Checked = true;
            }

            txt_nombre.Text = dg_datos.CurrentRow.Cells[0].Value.ToString();
            txt_dni.Text = dg_datos.CurrentRow.Cells[1].Value.ToString();
            txt_fecha.Value = Convert.ToDateTime(dg_datos.CurrentRow.Cells[2].Value.ToString());
            txt_legajo.Text = dg_datos.CurrentRow.Cells[4].Value.ToString();
            txt_carr_materia.Text = dg_datos.CurrentRow.Cells[5].Value.ToString();

            if (dg_datos.CurrentRow.Cells[4].Value.ToString().Any(x => !char.IsNumber(x)))
            {
                radio_docente.Checked = true;
            }
            if (dg_datos.CurrentRow.Cells[4].Value.ToString().Any(x => char.IsNumber(x)))
            {
                radio_alumno.Checked = true;
            }
        }
        #endregion

        #region EVENTOS
        private void btn_cargar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dg_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToBox();
        }

        private void txt_fecha_ValueChanged(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            Docente d = new Docente();

            int fecha = Convert.ToInt32(txt_fecha.Value.Year);
            lbl_edad.Text = "Edad: " + Convert.ToString(d.Edad(fecha));
            lbl_edad.Text = "Edad: " + Convert.ToString(a.Edad(fecha));
        }

        #endregion

        #region VALIDACION
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                lbl_aviso.Text = "*Solo se permiten letras";
                e.Handled = true;
                return;
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                lbl_aviso.Text = "*Solo se permiten números";
                e.Handled = true;
                return;
            }
        }

        private void txt_carr_materia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                lbl_aviso.Text = "*Solo se permiten letras";
                e.Handled = true;
                return;
            }
        }

        private void txt_legajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radio_alumno.Checked == true)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    lbl_aviso.Text = "*Solo se permiten números";
                    e.Handled = true;
                    return;
                }
            }
            if (radio_docente.Checked == true)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    lbl_aviso.Text = "*Solo se permiten letras";
                    e.Handled = true;
                    return;
                }
            }
        }
        #endregion
    }
}