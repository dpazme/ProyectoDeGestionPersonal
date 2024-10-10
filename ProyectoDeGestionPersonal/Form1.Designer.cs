namespace ProyectoDeGestionPersonal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbcPlantilla1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.gboxGenero = new System.Windows.Forms.GroupBox();
            this.rboMasculino = new System.Windows.Forms.RadioButton();
            this.rboFemenino = new System.Windows.Forms.RadioButton();
            this.rboOtro = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.numericUpDow = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblSuscripcion = new System.Windows.Forms.Label();
            this.chkSi = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chklHobbies = new System.Windows.Forms.CheckedListBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.cboPaisResidencia = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.trackBarSatisfaccion = new System.Windows.Forms.TrackBar();
            this.lblnumeracion = new System.Windows.Forms.Label();
            this.lblFotoPerfil = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbcPlantilla1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.gboxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSatisfaccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPlantilla1
            // 
            this.tbcPlantilla1.Controls.Add(this.tabPage1);
            this.tbcPlantilla1.Controls.Add(this.tabPage2);
            this.tbcPlantilla1.Controls.Add(this.tabPage3);
            this.tbcPlantilla1.Location = new System.Drawing.Point(37, 51);
            this.tbcPlantilla1.Name = "tbcPlantilla1";
            this.tbcPlantilla1.SelectedIndex = 0;
            this.tbcPlantilla1.Size = new System.Drawing.Size(1040, 589);
            this.tbcPlantilla1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.panelDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.lblnumeracion);
            this.tabPage2.Controls.Add(this.trackBarSatisfaccion);
            this.tabPage2.Controls.Add(this.lblSatisfaccion);
            this.tabPage2.Controls.Add(this.lblPais);
            this.tabPage2.Controls.Add(this.cboPaisResidencia);
            this.tabPage2.Controls.Add(this.lblHobbies);
            this.tabPage2.Controls.Add(this.chklHobbies);
            this.tabPage2.Controls.Add(this.chkNo);
            this.tabPage2.Controls.Add(this.chkSi);
            this.tabPage2.Controls.Add(this.lblSuscripcion);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preferencias";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.lblFechaHora);
            this.tabPage3.Controls.Add(this.lblFotoPerfil);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1032, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visualizacion";
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.button1);
            this.panelDatos.Controls.Add(this.lblFechaNacimiento);
            this.panelDatos.Controls.Add(this.dateTimePicker1);
            this.panelDatos.Controls.Add(this.monthCalendar1);
            this.panelDatos.Controls.Add(this.lblEdad);
            this.panelDatos.Controls.Add(this.numericUpDow);
            this.panelDatos.Controls.Add(this.txtCorreo);
            this.panelDatos.Controls.Add(this.txtDireccion);
            this.panelDatos.Controls.Add(this.txtApellidos);
            this.panelDatos.Controls.Add(this.txtNombre);
            this.panelDatos.Controls.Add(this.gboxGenero);
            this.panelDatos.Controls.Add(this.lblCorreo);
            this.panelDatos.Controls.Add(this.lblDireccion);
            this.panelDatos.Controls.Add(this.lblApellidos);
            this.panelDatos.Controls.Add(this.lblNombre);
            this.panelDatos.Location = new System.Drawing.Point(3, 6);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1023, 548);
            this.panelDatos.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(48, 95);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(64, 16);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(48, 144);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(48, 194);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(118, 16);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // gboxGenero
            // 
            this.gboxGenero.Controls.Add(this.rboOtro);
            this.gboxGenero.Controls.Add(this.rboFemenino);
            this.gboxGenero.Controls.Add(this.rboMasculino);
            this.gboxGenero.Location = new System.Drawing.Point(737, 95);
            this.gboxGenero.Name = "gboxGenero";
            this.gboxGenero.Size = new System.Drawing.Size(193, 234);
            this.gboxGenero.TabIndex = 5;
            this.gboxGenero.TabStop = false;
            this.gboxGenero.Text = "Genero";
            // 
            // rboMasculino
            // 
            this.rboMasculino.AutoSize = true;
            this.rboMasculino.Location = new System.Drawing.Point(43, 45);
            this.rboMasculino.Name = "rboMasculino";
            this.rboMasculino.Size = new System.Drawing.Size(89, 20);
            this.rboMasculino.TabIndex = 0;
            this.rboMasculino.TabStop = true;
            this.rboMasculino.Text = "Masculino";
            this.rboMasculino.UseVisualStyleBackColor = true;
            // 
            // rboFemenino
            // 
            this.rboFemenino.AutoSize = true;
            this.rboFemenino.Location = new System.Drawing.Point(44, 83);
            this.rboFemenino.Name = "rboFemenino";
            this.rboFemenino.Size = new System.Drawing.Size(88, 20);
            this.rboFemenino.TabIndex = 1;
            this.rboFemenino.TabStop = true;
            this.rboFemenino.Text = "Femenino";
            this.rboFemenino.UseVisualStyleBackColor = true;
            // 
            // rboOtro
            // 
            this.rboOtro.AutoSize = true;
            this.rboOtro.Location = new System.Drawing.Point(44, 127);
            this.rboOtro.Name = "rboOtro";
            this.rboOtro.Size = new System.Drawing.Size(60, 20);
            this.rboOtro.TabIndex = 2;
            this.rboOtro.TabStop = true;
            this.rboOtro.Text = "Otros";
            this.rboOtro.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(454, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(244, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(454, 22);
            this.txtApellidos.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(244, 144);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(454, 22);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(244, 194);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(454, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // numericUpDow
            // 
            this.numericUpDow.Location = new System.Drawing.Point(818, 40);
            this.numericUpDow.Name = "numericUpDow";
            this.numericUpDow.Size = new System.Drawing.Size(120, 22);
            this.numericUpDow.TabIndex = 10;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(734, 40);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(231, 314);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(50, 265);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(116, 16);
            this.lblFechaNacimiento.TabIndex = 14;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblSuscripcion
            // 
            this.lblSuscripcion.AutoSize = true;
            this.lblSuscripcion.Location = new System.Drawing.Point(30, 30);
            this.lblSuscripcion.Name = "lblSuscripcion";
            this.lblSuscripcion.Size = new System.Drawing.Size(145, 16);
            this.lblSuscripcion.TabIndex = 0;
            this.lblSuscripcion.Text = "¿Suscribirse al boletín?";
            // 
            // chkSi
            // 
            this.chkSi.AutoSize = true;
            this.chkSi.Location = new System.Drawing.Point(33, 77);
            this.chkSi.Name = "chkSi";
            this.chkSi.Size = new System.Drawing.Size(41, 20);
            this.chkSi.TabIndex = 1;
            this.chkSi.Text = "Si";
            this.chkSi.UseVisualStyleBackColor = true;
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(126, 76);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(47, 20);
            this.chkNo.TabIndex = 2;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // chklHobbies
            // 
            this.chklHobbies.FormattingEnabled = true;
            this.chklHobbies.Items.AddRange(new object[] {
            "Futbol",
            "Danza",
            "Videojuegos"});
            this.chklHobbies.Location = new System.Drawing.Point(39, 193);
            this.chklHobbies.Name = "chklHobbies";
            this.chklHobbies.Size = new System.Drawing.Size(142, 106);
            this.chklHobbies.TabIndex = 3;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(36, 162);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(62, 16);
            this.lblHobbies.TabIndex = 4;
            this.lblHobbies.Text = "Hobbies:";
            // 
            // cboPaisResidencia
            // 
            this.cboPaisResidencia.FormattingEnabled = true;
            this.cboPaisResidencia.Items.AddRange(new object[] {
            "España",
            "Rumani",
            "Francia",
            "Suiza",
            "Portugal",
            "Belgica",
            "Holanda",
            "Albania"});
            this.cboPaisResidencia.Location = new System.Drawing.Point(665, 77);
            this.cboPaisResidencia.Name = "cboPaisResidencia";
            this.cboPaisResidencia.Size = new System.Drawing.Size(139, 24);
            this.cboPaisResidencia.TabIndex = 5;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(688, 42);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(128, 16);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Pais de Residencia:";
            // 
            // lblSatisfaccion
            // 
            this.lblSatisfaccion.AutoSize = true;
            this.lblSatisfaccion.Location = new System.Drawing.Point(45, 379);
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            this.lblSatisfaccion.Size = new System.Drawing.Size(169, 16);
            this.lblSatisfaccion.TabIndex = 7;
            this.lblSatisfaccion.Text = "Satisfaccion con el servicio";
            // 
            // trackBarSatisfaccion
            // 
            this.trackBarSatisfaccion.Location = new System.Drawing.Point(39, 449);
            this.trackBarSatisfaccion.Name = "trackBarSatisfaccion";
            this.trackBarSatisfaccion.Size = new System.Drawing.Size(166, 56);
            this.trackBarSatisfaccion.TabIndex = 8;
            this.trackBarSatisfaccion.Scroll += new System.EventHandler(this.trackBarSatisfaccion_Scroll);
            // 
            // lblnumeracion
            // 
            this.lblnumeracion.AutoSize = true;
            this.lblnumeracion.Location = new System.Drawing.Point(229, 458);
            this.lblnumeracion.Name = "lblnumeracion";
            this.lblnumeracion.Size = new System.Drawing.Size(0, 16);
            this.lblnumeracion.TabIndex = 9;
            // 
            // lblFotoPerfil
            // 
            this.lblFotoPerfil.AutoSize = true;
            this.lblFotoPerfil.Location = new System.Drawing.Point(73, 26);
            this.lblFotoPerfil.Name = "lblFotoPerfil";
            this.lblFotoPerfil.Size = new System.Drawing.Size(115, 16);
            this.lblFotoPerfil.TabIndex = 1;
            this.lblFotoPerfil.Text = "FOTO DE PERFIL";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(604, 167);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(174, 32);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "fechaHORA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(95, 653);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 43);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoDeGestionPersonal.Properties.Resources.fotoPerfil;
            this.pictureBox1.Location = new System.Drawing.Point(76, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(486, 653);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 43);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(815, 656);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 43);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1151, 728);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tbcPlantilla1);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Gestion Avanzada de Informacion Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tbcPlantilla1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.gboxGenero.ResumeLayout(false);
            this.gboxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSatisfaccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPlantilla1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gboxGenero;
        private System.Windows.Forms.RadioButton rboOtro;
        private System.Windows.Forms.RadioButton rboFemenino;
        private System.Windows.Forms.RadioButton rboMasculino;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numericUpDow;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox chklHobbies;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.CheckBox chkSi;
        private System.Windows.Forms.Label lblSuscripcion;
        private System.Windows.Forms.ComboBox cboPaisResidencia;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.TrackBar trackBarSatisfaccion;
        private System.Windows.Forms.Label lblSatisfaccion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblnumeracion;
        private System.Windows.Forms.Label lblFotoPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

