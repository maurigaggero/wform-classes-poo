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

            txt_nombre.Text = "Nombre y Apellido";
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

        public void Cargar(string nombre, string dni, DateTime fechanac, char sexo, string matcarr, string legajo, string condicion)
        {
            switch (condicion)
            {
                case "docente":
                    objDocente.Dni = Convert.ToInt64(dni);
                    objDocente.Nombre = nombre;
                    objDocente.FechNac = fechanac;
                    objDocente.Sexo = sexo;
                    objDocente.Materia = matcarr;
                    objDocente.Legajo = legajo;

                    switch (funcion)
                    {
                        case 1:
                            objNegDocente.abmDocentes("Agregar", objDocente);
                            break;

                        case 2:
                            objNegDocente.abmDocentes("Modificar", objDocente);
                            break;

                        case 3:
                            objNegDocente.abmDocentes("Eliminar", objDocente);
                            break;
                    }

                    LlenarDg_Docentes("Todos");
                    
                    break;

                case "alumno":
                    objAlumno.Dni = Convert.ToInt64(dni);
                    objAlumno.Nombre = nombre;
                    objAlumno.FechNac = fechanac;
                    objAlumno.Sexo = sexo;
                    objAlumno.Carrera = matcarr;
                    objAlumno.Legajo = Convert.ToInt64(legajo);

                    switch (funcion)
                    {
                        case 1:
                            objNegAlumno.abmAlumnos("Agregar", objAlumno);
                            break;

                        case 2:
                            objNegAlumno.abmAlumnos("Modificar", objAlumno);
                            break;

                        case 3:
                            objNegAlumno.abmAlumnos("Eliminar", objAlumno);
                            break;
                    }

                    LlenarDg_Alumnos("Todos");

                    break;
            }
            LimpiarCampos();

            lbl_aviso.Text = "Se actualizó DB con éxito!";

            funcion = 0;
        }

        public void Cargar()
        {
            if (txt_nombre.Text == "Nombre y Apellido" || txt_dni.Text == "DNI" ||
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
                if(radio_docente.Checked == true && txt_legajo.Text.Any(x => !char.IsNumber(x)))
                {
                    if(radio_m.Checked)
                    {
                        string condicion = "docente";
                        Cargar(txt_nombre.Text, txt_dni.Text, txt_fecha.Value, 'M'/*sexo*/,
                            txt_carr_materia.Text, txt_legajo.Text, condicion);
                    }
                    if (radio_f.Checked)
                    {
                        string condicion = "docente";
                        Cargar(txt_nombre.Text, txt_dni.Text, txt_fecha.Value, 'F'/*sexo*/,
                            txt_carr_materia.Text, txt_legajo.Text, condicion);
                    }
                }
                if(radio_alumno.Checked == true && txt_legajo.Text.Any(x => char.IsNumber(x)))
                {
                    if (radio_m.Checked)
                    {
                        string condicion = "alumno";
                        Cargar(txt_nombre.Text, txt_dni.Text, txt_fecha.Value, 'M'/*sexo*/,
                            txt_carr_materia.Text, txt_legajo.Text, condicion);
                    }
                    if (radio_f.Checked)
                    {
                        string condicion = "alumno";
                        Cargar(txt_nombre.Text, txt_dni.Text, txt_fecha.Value, 'F'/*sexo*/,
                            txt_carr_materia.Text, txt_legajo.Text, condicion);
                    }
                }
            }
        }

        private void LlenarDg_Docentes(string cual)
        {
            dg_datos.Rows.Clear();

            if (cual == "Todos")
            {
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
            else
            {
                DataSet ds = new DataSet();
                ds = objNegDocente.listadoDocentes(cual);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dg_datos.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                    }
                }
            }
        }

        private void LlenarDg_Alumnos(string cual)
        {
            dg_datos.Rows.Clear();

            if (cual == "Todos")
            {
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
            else
            {
                DataSet ds = new DataSet();
                ds = objNegAlumno.listadoAlumnos(cual);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dg_datos.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                    }
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
            string cual = txt_filtro.Text;

            if (cual == string.Empty)
            {
                LlenarDg_Docentes("Todos");
            }
            else
            {
                LlenarDg_Docentes(cual);
            }
        }
        private void btn_falumno_Click(object sender, EventArgs e)
        {
            string cual = txt_filtro.Text;

            if (cual == string.Empty)
            {
                LlenarDg_Alumnos("Todos");
            }
            else
            {
                LlenarDg_Alumnos(cual);
            }
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                lbl_aviso.Text = "*Solo se permiten letras";
                e.Handled = true;
                return;
            }
        }

        private void txt_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_filtro.MaxLength = 8;

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                lbl_aviso.Text = "*Solo se permiten números";
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