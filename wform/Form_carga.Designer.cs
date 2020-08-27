namespace wform
{
    partial class Form_carga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_persona = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_ocultar = new System.Windows.Forms.Button();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.group_condicion = new System.Windows.Forms.GroupBox();
            this.radio_alumno = new System.Windows.Forms.RadioButton();
            this.radio_docente = new System.Windows.Forms.RadioButton();
            this.group_sexo = new System.Windows.Forms.GroupBox();
            this.radio_f = new System.Windows.Forms.RadioButton();
            this.radio_m = new System.Windows.Forms.RadioButton();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_carr_materia = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.dg_datos = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_docente = new System.Windows.Forms.Button();
            this.btn_alumno = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.panel_persona.SuspendLayout();
            this.group_condicion.SuspendLayout();
            this.group_sexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_persona
            // 
            this.panel_persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_persona.Controls.Add(this.btn_limpiar);
            this.panel_persona.Controls.Add(this.btn_eliminar);
            this.panel_persona.Controls.Add(this.btn_editar);
            this.panel_persona.Controls.Add(this.btn_ocultar);
            this.panel_persona.Controls.Add(this.lbl_aviso);
            this.panel_persona.Controls.Add(this.lbl_edad);
            this.panel_persona.Controls.Add(this.group_condicion);
            this.panel_persona.Controls.Add(this.group_sexo);
            this.panel_persona.Controls.Add(this.txt_fecha);
            this.panel_persona.Controls.Add(this.btn_cargar);
            this.panel_persona.Controls.Add(this.txt_dni);
            this.panel_persona.Controls.Add(this.txt_carr_materia);
            this.panel_persona.Controls.Add(this.txt_nombre);
            this.panel_persona.Controls.Add(this.txt_legajo);
            this.panel_persona.Location = new System.Drawing.Point(792, 37);
            this.panel_persona.Name = "panel_persona";
            this.panel_persona.Size = new System.Drawing.Size(301, 808);
            this.panel_persona.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_eliminar.Location = new System.Drawing.Point(126, 737);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(160, 56);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar Registro";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(126, 675);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(160, 56);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "Editar Registro";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_ocultar
            // 
            this.btn_ocultar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ocultar.Location = new System.Drawing.Point(3, 676);
            this.btn_ocultar.Name = "btn_ocultar";
            this.btn_ocultar.Size = new System.Drawing.Size(104, 117);
            this.btn_ocultar.TabIndex = 12;
            this.btn_ocultar.Text = "« Ocultar";
            this.btn_ocultar.UseVisualStyleBackColor = true;
            this.btn_ocultar.Click += new System.EventHandler(this.btn_ocultar_Click);
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_aviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_aviso.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviso.ForeColor = System.Drawing.Color.Red;
            this.lbl_aviso.Location = new System.Drawing.Point(0, 564);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(305, 35);
            this.lbl_aviso.TabIndex = 4;
            this.lbl_aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_edad
            // 
            this.lbl_edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_edad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_edad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.ForeColor = System.Drawing.Color.Orange;
            this.lbl_edad.Location = new System.Drawing.Point(-1, 284);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(305, 35);
            this.lbl_edad.TabIndex = 11;
            this.lbl_edad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_condicion
            // 
            this.group_condicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.group_condicion.Controls.Add(this.radio_alumno);
            this.group_condicion.Controls.Add(this.radio_docente);
            this.group_condicion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_condicion.ForeColor = System.Drawing.Color.White;
            this.group_condicion.Location = new System.Drawing.Point(20, 15);
            this.group_condicion.Name = "group_condicion";
            this.group_condicion.Size = new System.Drawing.Size(257, 67);
            this.group_condicion.TabIndex = 1;
            this.group_condicion.TabStop = false;
            this.group_condicion.Text = "Condición";
            // 
            // radio_alumno
            // 
            this.radio_alumno.AutoSize = true;
            this.radio_alumno.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_alumno.Location = new System.Drawing.Point(21, 26);
            this.radio_alumno.Name = "radio_alumno";
            this.radio_alumno.Size = new System.Drawing.Size(91, 27);
            this.radio_alumno.TabIndex = 2;
            this.radio_alumno.Text = "Alumno";
            this.radio_alumno.UseVisualStyleBackColor = true;
            // 
            // radio_docente
            // 
            this.radio_docente.AutoSize = true;
            this.radio_docente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_docente.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radio_docente.Location = new System.Drawing.Point(139, 26);
            this.radio_docente.Name = "radio_docente";
            this.radio_docente.Size = new System.Drawing.Size(95, 27);
            this.radio_docente.TabIndex = 3;
            this.radio_docente.Text = "Docente";
            this.radio_docente.UseVisualStyleBackColor = true;
            // 
            // group_sexo
            // 
            this.group_sexo.Controls.Add(this.radio_f);
            this.group_sexo.Controls.Add(this.radio_m);
            this.group_sexo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_sexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_sexo.Location = new System.Drawing.Point(21, 331);
            this.group_sexo.Name = "group_sexo";
            this.group_sexo.Size = new System.Drawing.Size(262, 76);
            this.group_sexo.TabIndex = 3;
            this.group_sexo.TabStop = false;
            this.group_sexo.Text = "Sexo";
            // 
            // radio_f
            // 
            this.radio_f.AutoSize = true;
            this.radio_f.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_f.Location = new System.Drawing.Point(138, 29);
            this.radio_f.Name = "radio_f";
            this.radio_f.Size = new System.Drawing.Size(107, 27);
            this.radio_f.TabIndex = 8;
            this.radio_f.Text = "Femenino";
            this.radio_f.UseVisualStyleBackColor = true;
            // 
            // radio_m
            // 
            this.radio_m.AutoSize = true;
            this.radio_m.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_m.Location = new System.Drawing.Point(6, 29);
            this.radio_m.Name = "radio_m";
            this.radio_m.Size = new System.Drawing.Size(109, 27);
            this.radio_m.TabIndex = 7;
            this.radio_m.Text = "Masculino";
            this.radio_m.UseVisualStyleBackColor = true;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha.Location = new System.Drawing.Point(21, 235);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(256, 30);
            this.txt_fecha.TabIndex = 6;
            this.txt_fecha.ValueChanged += new System.EventHandler(this.txt_fecha_ValueChanged);
            // 
            // btn_cargar
            // 
            this.btn_cargar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Location = new System.Drawing.Point(126, 614);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(160, 56);
            this.btn_cargar.TabIndex = 11;
            this.btn_cargar.Text = "Cargar Nuevo Registro";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(20, 165);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(257, 30);
            this.txt_dni.TabIndex = 5;
            this.txt_dni.Text = "DNI";
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_carr_materia
            // 
            this.txt_carr_materia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carr_materia.Location = new System.Drawing.Point(20, 508);
            this.txt_carr_materia.Name = "txt_carr_materia";
            this.txt_carr_materia.Size = new System.Drawing.Size(257, 30);
            this.txt_carr_materia.TabIndex = 10;
            this.txt_carr_materia.Text = "Carrera/Materia";
            this.txt_carr_materia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_carr_materia_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(21, 102);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(256, 30);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.Text = "Nombre";
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_legajo
            // 
            this.txt_legajo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.Location = new System.Drawing.Point(21, 445);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(256, 30);
            this.txt_legajo.TabIndex = 9;
            this.txt_legajo.Text = "Legajo";
            this.txt_legajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_legajo_KeyPress);
            // 
            // dg_datos
            // 
            this.dg_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dg_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Fecha_Nac,
            this.Sexo,
            this.Legajo,
            this.Carrera_Materia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_datos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_datos.Location = new System.Drawing.Point(29, 108);
            this.dg_datos.MultiSelect = false;
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.RowHeadersVisible = false;
            this.dg_datos.RowHeadersWidth = 51;
            this.dg_datos.RowTemplate.Height = 24;
            this.dg_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_datos.Size = new System.Drawing.Size(710, 585);
            this.dg_datos.TabIndex = 5;
            this.dg_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_datos_CellContentClick);
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Fecha_Nac
            // 
            this.Fecha_Nac.HeaderText = "Fecha_Nac";
            this.Fecha_Nac.MinimumWidth = 6;
            this.Fecha_Nac.Name = "Fecha_Nac";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            // 
            // Carrera_Materia
            // 
            this.Carrera_Materia.HeaderText = "Carrera_Materia";
            this.Carrera_Materia.MinimumWidth = 6;
            this.Carrera_Materia.Name = "Carrera_Materia";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.Location = new System.Drawing.Point(256, 725);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(284, 58);
            this.btn_mostrar.TabIndex = 15;
            this.btn_mostrar.Text = "Mostrar panel de carga >";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_docente
            // 
            this.btn_docente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docente.Location = new System.Drawing.Point(82, 25);
            this.btn_docente.Name = "btn_docente";
            this.btn_docente.Size = new System.Drawing.Size(253, 58);
            this.btn_docente.TabIndex = 16;
            this.btn_docente.Text = "Mostrar registro docentes";
            this.btn_docente.UseVisualStyleBackColor = true;
            this.btn_docente.Click += new System.EventHandler(this.btn_fdocente_Click);
            // 
            // btn_alumno
            // 
            this.btn_alumno.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumno.Location = new System.Drawing.Point(428, 25);
            this.btn_alumno.Name = "btn_alumno";
            this.btn_alumno.Size = new System.Drawing.Size(238, 58);
            this.btn_alumno.TabIndex = 17;
            this.btn_alumno.Text = "Mostrar registro alumnos";
            this.btn_alumno.UseVisualStyleBackColor = true;
            this.btn_alumno.Click += new System.EventHandler(this.btn_falumno_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(3, 614);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(104, 56);
            this.btn_limpiar.TabIndex = 15;
            this.btn_limpiar.Text = "Limpiar campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Form_carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1149, 857);
            this.Controls.Add(this.btn_alumno);
            this.Controls.Add(this.btn_docente);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.dg_datos);
            this.Controls.Add(this.panel_persona);
            this.MaximizeBox = false;
            this.Name = "Form_carga";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de carga";
            this.panel_persona.ResumeLayout(false);
            this.panel_persona.PerformLayout();
            this.group_condicion.ResumeLayout(false);
            this.group_condicion.PerformLayout();
            this.group_sexo.ResumeLayout(false);
            this.group_sexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_persona;
        private System.Windows.Forms.GroupBox group_sexo;
        private System.Windows.Forms.RadioButton radio_f;
        private System.Windows.Forms.RadioButton radio_m;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_carr_materia;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.GroupBox group_condicion;
        private System.Windows.Forms.RadioButton radio_alumno;
        private System.Windows.Forms.RadioButton radio_docente;
        private System.Windows.Forms.DataGridView dg_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera_Materia;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Button btn_ocultar;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_docente;
        private System.Windows.Forms.Button btn_alumno;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

