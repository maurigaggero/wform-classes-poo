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
using Negocios;

namespace wform
{
    public partial class Form_carga : Form
    {
        public Form_carga()
        {
            InitializeComponent();
        }

        #region METODOS
        public Alumno objAlumno = new Alumno();

        public NegAlumnos objNegAlumno = new NegAlumnos();

        public Docente objDocente = new Docente();

        public NegDocentes objNegDocente = new NegDocentes();

        /////////////////////////////////

        public int funcion = 0;

        public void LimpiarCampos()
        {
            lbl_aviso.Text = "";
            lbl_edad.Text = "";

            txt_nombre.Text = "Nombre";
            txt_nombre.Focus();
            txt_nombre.SelectAll();

            txt_dni.Text = "DNI";
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
                        objDocente.Dni = dni;
                        objDocente.Nombre = nombre;
                        objDocente.FechNac = fechanac;
                        objDocente.Sexo = sexo;
                        objDocente.Materia = matcarr;
                        objDocente.Legajo = legajo;

                        if (funcion == 1)
                        {
                            objNegDocente.abmDocentes("Agregar", objDocente);

                            LlenarDg_Docentes();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se grabó con éxito!";

                            funcion = 0;
                        }


                        if (funcion == 2)
                        {
                            objNegDocente.abmDocentes("Modificar", objDocente);

                            LlenarDg_Docentes();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se editó con éxito!";

                            funcion = 0;
                        }

                        if (funcion == 3)
                        {
                            objNegDocente.abmDocentes("Eliminar", objDocente);

                            LlenarDg_Docentes();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se eliminó con éxito!";

                            funcion = 0;
                        }
                    }
                    if (radio_alumno.Checked == true && txt_legajo.Text.Any(x => char.IsNumber(x)))
                    {
                        objAlumno.Dni = dni;
                        objAlumno.Nombre = nombre;
                        objAlumno.FechNac = fechanac;
                        objAlumno.Sexo = sexo;
                        objAlumno.Carrera = matcarr;
                        objAlumno.Legajo = Convert.ToInt64(legajo);

                        if (funcion == 1)
                        {
                            objNegAlumno.abmAlumnos("Agregar", objAlumno);

                            LlenarDg_Alumnos();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se grabó con éxito!";

                            funcion = 0;
                        }


                        if (funcion == 2)
                        {
                            objNegAlumno.abmAlumnos("Modificar", objAlumno);

                            LlenarDg_Alumnos();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se editó con éxito!";

                            funcion = 0;
                        }

                        if (funcion == 3)
                        {
                            objNegAlumno.abmAlumnos("Eliminar", objAlumno);

                            LlenarDg_Alumnos();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se eliminó con éxito!";

                            funcion = 0;
                        }
                    }
                }
                if (radio_f.Checked)
                {
                    char sexo = 'F';

                    if (radio_docente.Checked == true && txt_legajo.Text.Any(x => !char.IsNumber(x)))
                    {
                        objDocente.Dni = dni;
                        objDocente.Nombre = nombre;
                        objDocente.FechNac = fechanac;
                        objDocente.Sexo = sexo;
                        objDocente.Materia = matcarr;
                        objDocente.Legajo = legajo;

                        if (funcion == 1)
                        {
                            objNegDocente.abmDocentes("Agregar", objDocente);

                            LlenarDg_Docentes();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se grabó con éxito!";

                            funcion = 0;
                        }


                        if (funcion == 2)
                        {
                            objNegDocente.abmDocentes("Modificar", objDocente);

                            LlenarDg_Docentes();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se editó con éxito!";

                            funcion = 0;
                        }

                        if (funcion == 3)
                        {
                            objNegDocente.abmDocentes("Eliminar", objDocente);

                            LlenarDg_Docentes();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se eliminó con éxito!";

                            funcion = 0;
                        }

                    }
                    if (radio_alumno.Checked == true && txt_legajo.Text.Any(x => char.IsNumber(x)))
                    {
                        objAlumno.Dni = dni;
                        objAlumno.Nombre = nombre;
                        objAlumno.FechNac = fechanac;
                        objAlumno.Sexo = sexo;
                        objAlumno.Carrera = matcarr;
                        objAlumno.Legajo = Convert.ToInt64(legajo);

                        if (funcion == 1)
                        {
                            objNegAlumno.abmAlumnos("Agregar", objAlumno);

                            LlenarDg_Alumnos();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se grabó con éxito!";

                            funcion = 0;
                        }


                        if (funcion == 2)
                        {
                            objNegAlumno.abmAlumnos("Modificar", objAlumno);

                            LlenarDg_Alumnos();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se editó con éxito!";

                            funcion = 0;
                        }

                        if (funcion == 3)
                        {
                            objNegAlumno.abmAlumnos("Eliminar", objAlumno);

                            LlenarDg_Alumnos();
                            LimpiarCampos();

                            lbl_aviso.Text = "Se eliminó con éxito!";

                            funcion = 0;
                        }
                    }
                }
            }
        }

        private void LlenarDg_Docentes()
        {
            dg_datos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegDocente.listadoDocentes("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dg_datos.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
            }
        }

        private void LlenarDg_Alumnos()
        {
            dg_datos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegAlumno.listadoAlumnos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dg_datos.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
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

            txt_dni.Text = dg_datos.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = dg_datos.CurrentRow.Cells[1].Value.ToString();
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
            funcion = 1;

            Cargar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            funcion = 2;

            Cargar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            funcion = 3;

            Cargar();
        }

        private void btn_fdocente_Click(object sender, EventArgs e)
        {
            LlenarDg_Docentes();
        }
        private void btn_falumno_Click(object sender, EventArgs e)
        {
            LlenarDg_Alumnos();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void dg_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToBox();
        }

        public int flag = 0;
        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.Width -= 300;
                flag -= 1;
            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                this.Width += 300;
                flag += 1;
            }
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
            txt_dni.MaxLength = 8;

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