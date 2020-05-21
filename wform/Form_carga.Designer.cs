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
            this.panel_persona = new System.Windows.Forms.Panel();
            this.group_sexo = new System.Windows.Forms.GroupBox();
            this.radio_o = new System.Windows.Forms.RadioButton();
            this.radio_f = new System.Windows.Forms.RadioButton();
            this.radio_m = new System.Windows.Forms.RadioButton();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel_condicion = new System.Windows.Forms.Panel();
            this.group_condicion = new System.Windows.Forms.GroupBox();
            this.radio_alumno = new System.Windows.Forms.RadioButton();
            this.radio_docente = new System.Windows.Forms.RadioButton();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.txt_carr_materia = new System.Windows.Forms.TextBox();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.panel_persona.SuspendLayout();
            this.group_sexo.SuspendLayout();
            this.panel_condicion.SuspendLayout();
            this.group_condicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_persona
            // 
            this.panel_persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_persona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_persona.Controls.Add(this.group_sexo);
            this.panel_persona.Controls.Add(this.txt_fecha);
            this.panel_persona.Controls.Add(this.txt_dni);
            this.panel_persona.Controls.Add(this.txt_nombre);
            this.panel_persona.Location = new System.Drawing.Point(61, 49);
            this.panel_persona.Name = "panel_persona";
            this.panel_persona.Size = new System.Drawing.Size(248, 408);
            this.panel_persona.TabIndex = 0;
            // 
            // group_sexo
            // 
            this.group_sexo.Controls.Add(this.radio_o);
            this.group_sexo.Controls.Add(this.radio_f);
            this.group_sexo.Controls.Add(this.radio_m);
            this.group_sexo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_sexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_sexo.Location = new System.Drawing.Point(34, 244);
            this.group_sexo.Name = "group_sexo";
            this.group_sexo.Size = new System.Drawing.Size(179, 129);
            this.group_sexo.TabIndex = 3;
            this.group_sexo.TabStop = false;
            this.group_sexo.Text = "Sexo";
            // 
            // radio_o
            // 
            this.radio_o.AutoSize = true;
            this.radio_o.Location = new System.Drawing.Point(30, 91);
            this.radio_o.Name = "radio_o";
            this.radio_o.Size = new System.Drawing.Size(66, 27);
            this.radio_o.TabIndex = 5;
            this.radio_o.TabStop = true;
            this.radio_o.Text = "Otro";
            this.radio_o.UseVisualStyleBackColor = true;
            // 
            // radio_f
            // 
            this.radio_f.AutoSize = true;
            this.radio_f.Location = new System.Drawing.Point(30, 62);
            this.radio_f.Name = "radio_f";
            this.radio_f.Size = new System.Drawing.Size(106, 27);
            this.radio_f.TabIndex = 4;
            this.radio_f.TabStop = true;
            this.radio_f.Text = "Femenino";
            this.radio_f.UseVisualStyleBackColor = true;
            // 
            // radio_m
            // 
            this.radio_m.AutoSize = true;
            this.radio_m.Location = new System.Drawing.Point(30, 29);
            this.radio_m.Name = "radio_m";
            this.radio_m.Size = new System.Drawing.Size(108, 27);
            this.radio_m.TabIndex = 3;
            this.radio_m.TabStop = true;
            this.radio_m.Text = "Masculino";
            this.radio_m.UseVisualStyleBackColor = true;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha.Location = new System.Drawing.Point(34, 180);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(171, 30);
            this.txt_fecha.TabIndex = 2;
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(34, 108);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(171, 30);
            this.txt_dni.TabIndex = 1;
            this.txt_dni.Text = "DNI";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(34, 37);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 30);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Text = "Nombre";
            // 
            // panel_condicion
            // 
            this.panel_condicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_condicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_condicion.Controls.Add(this.lbl_aviso);
            this.panel_condicion.Controls.Add(this.group_condicion);
            this.panel_condicion.Controls.Add(this.btn_cargar);
            this.panel_condicion.Controls.Add(this.txt_carr_materia);
            this.panel_condicion.Controls.Add(this.txt_legajo);
            this.panel_condicion.Location = new System.Drawing.Point(429, 49);
            this.panel_condicion.Name = "panel_condicion";
            this.panel_condicion.Size = new System.Drawing.Size(248, 408);
            this.panel_condicion.TabIndex = 4;
            // 
            // group_condicion
            // 
            this.group_condicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.group_condicion.Controls.Add(this.radio_alumno);
            this.group_condicion.Controls.Add(this.radio_docente);
            this.group_condicion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_condicion.ForeColor = System.Drawing.Color.White;
            this.group_condicion.Location = new System.Drawing.Point(3, 14);
            this.group_condicion.Name = "group_condicion";
            this.group_condicion.Size = new System.Drawing.Size(240, 67);
            this.group_condicion.TabIndex = 3;
            this.group_condicion.TabStop = false;
            this.group_condicion.Text = "Condición";
            // 
            // radio_alumno
            // 
            this.radio_alumno.AutoSize = true;
            this.radio_alumno.Location = new System.Drawing.Point(21, 29);
            this.radio_alumno.Name = "radio_alumno";
            this.radio_alumno.Size = new System.Drawing.Size(91, 27);
            this.radio_alumno.TabIndex = 6;
            this.radio_alumno.TabStop = true;
            this.radio_alumno.Text = "Alumno";
            this.radio_alumno.UseVisualStyleBackColor = true;
            // 
            // radio_docente
            // 
            this.radio_docente.AutoSize = true;
            this.radio_docente.Location = new System.Drawing.Point(133, 29);
            this.radio_docente.Name = "radio_docente";
            this.radio_docente.Size = new System.Drawing.Size(95, 27);
            this.radio_docente.TabIndex = 7;
            this.radio_docente.TabStop = true;
            this.radio_docente.Text = "Docente";
            this.radio_docente.UseVisualStyleBackColor = true;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Location = new System.Drawing.Point(51, 283);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(153, 46);
            this.btn_cargar.TabIndex = 10;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // txt_carr_materia
            // 
            this.txt_carr_materia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carr_materia.Location = new System.Drawing.Point(42, 180);
            this.txt_carr_materia.Name = "txt_carr_materia";
            this.txt_carr_materia.Size = new System.Drawing.Size(171, 30);
            this.txt_carr_materia.TabIndex = 9;
            this.txt_carr_materia.Text = "Carrera/Materia";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.Location = new System.Drawing.Point(42, 108);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(171, 30);
            this.txt_legajo.TabIndex = 8;
            this.txt_legajo.Text = "Legajo";
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.AutoSize = true;
            this.lbl_aviso.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviso.ForeColor = System.Drawing.Color.Red;
            this.lbl_aviso.Location = new System.Drawing.Point(38, 360);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(0, 23);
            this.lbl_aviso.TabIndex = 4;
            // 
            // Form_carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 516);
            this.Controls.Add(this.panel_condicion);
            this.Controls.Add(this.panel_persona);
            this.MaximizeBox = false;
            this.Name = "Form_carga";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de carga";
            this.panel_persona.ResumeLayout(false);
            this.panel_persona.PerformLayout();
            this.group_sexo.ResumeLayout(false);
            this.group_sexo.PerformLayout();
            this.panel_condicion.ResumeLayout(false);
            this.panel_condicion.PerformLayout();
            this.group_condicion.ResumeLayout(false);
            this.group_condicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_persona;
        private System.Windows.Forms.GroupBox group_sexo;
        private System.Windows.Forms.RadioButton radio_o;
        private System.Windows.Forms.RadioButton radio_f;
        private System.Windows.Forms.RadioButton radio_m;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel_condicion;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.TextBox txt_carr_materia;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.GroupBox group_condicion;
        private System.Windows.Forms.RadioButton radio_alumno;
        private System.Windows.Forms.RadioButton radio_docente;
        private System.Windows.Forms.Label lbl_aviso;
    }
}

