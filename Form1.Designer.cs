namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.TextBox();
            this.app = new System.Windows.Forms.TextBox();
            this.mat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.RbEliminar = new System.Windows.Forms.RadioButton();
            this.RbInsertar = new System.Windows.Forms.RadioButton();
            this.RbModificar = new System.Windows.Forms.RadioButton();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.IdUsr = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maestro = new System.Windows.Forms.TextBox();
            this.Tarea = new System.Windows.Forms.TextBox();
            this.addHw = new System.Windows.Forms.Button();
            this.RbTareas = new System.Windows.Forms.RadioButton();
            this.GBoptions = new System.Windows.Forms.GroupBox();
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            this.GBoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(130, 111);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // app
            // 
            this.app.Location = new System.Drawing.Point(130, 137);
            this.app.Name = "app";
            this.app.Size = new System.Drawing.Size(100, 20);
            this.app.TabIndex = 1;
            // 
            // mat
            // 
            this.mat.Location = new System.Drawing.Point(130, 163);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(100, 20);
            this.mat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Materia :";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(38, 204);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(73, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Agregar Usr";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvPersonas
            // 
            this.DgvPersonas.AllowUserToAddRows = false;
            this.DgvPersonas.AllowUserToDeleteRows = false;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonas.Location = new System.Drawing.Point(7, 247);
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.RowHeadersVisible = false;
            this.DgvPersonas.Size = new System.Drawing.Size(587, 175);
            this.DgvPersonas.TabIndex = 7;
            this.DgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersonas_CellContentClick);
            // 
            // RbEliminar
            // 
            this.RbEliminar.AutoCheck = false;
            this.RbEliminar.AutoSize = true;
            this.RbEliminar.Location = new System.Drawing.Point(39, 23);
            this.RbEliminar.Name = "RbEliminar";
            this.RbEliminar.Size = new System.Drawing.Size(61, 17);
            this.RbEliminar.TabIndex = 8;
            this.RbEliminar.TabStop = true;
            this.RbEliminar.Text = "Eliminar";
            this.RbEliminar.UseVisualStyleBackColor = true;
            this.RbEliminar.CheckedChanged += new System.EventHandler(this.RbEliminar_CheckedChanged);
            // 
            // RbInsertar
            // 
            this.RbInsertar.AutoSize = true;
            this.RbInsertar.Location = new System.Drawing.Point(106, 25);
            this.RbInsertar.Name = "RbInsertar";
            this.RbInsertar.Size = new System.Drawing.Size(60, 17);
            this.RbInsertar.TabIndex = 9;
            this.RbInsertar.TabStop = true;
            this.RbInsertar.Text = "Insertar";
            this.RbInsertar.UseVisualStyleBackColor = true;
            this.RbInsertar.CheckedChanged += new System.EventHandler(this.RbInsertar_CheckedChanged);
            // 
            // RbModificar
            // 
            this.RbModificar.AutoSize = true;
            this.RbModificar.Location = new System.Drawing.Point(172, 25);
            this.RbModificar.Name = "RbModificar";
            this.RbModificar.Size = new System.Drawing.Size(68, 17);
            this.RbModificar.TabIndex = 10;
            this.RbModificar.TabStop = true;
            this.RbModificar.Text = "Modificar";
            this.RbModificar.UseVisualStyleBackColor = true;
            this.RbModificar.CheckedChanged += new System.EventHandler(this.RbModificar_CheckedChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(117, 204);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar Usr";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(198, 204);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(87, 23);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "Modificar Usr";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // IdUsr
            // 
            this.IdUsr.AutoSize = true;
            this.IdUsr.Location = new System.Drawing.Point(63, 92);
            this.IdUsr.Name = "IdUsr";
            this.IdUsr.Size = new System.Drawing.Size(61, 13);
            this.IdUsr.TabIndex = 14;
            this.IdUsr.Text = "Id Usuario :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maestro :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tarea :";
            // 
            // maestro
            // 
            this.maestro.Location = new System.Drawing.Point(380, 144);
            this.maestro.Name = "maestro";
            this.maestro.Size = new System.Drawing.Size(100, 20);
            this.maestro.TabIndex = 16;
            // 
            // Tarea
            // 
            this.Tarea.Location = new System.Drawing.Point(380, 118);
            this.Tarea.Name = "Tarea";
            this.Tarea.Size = new System.Drawing.Size(100, 20);
            this.Tarea.TabIndex = 15;
            // 
            // addHw
            // 
            this.addHw.Location = new System.Drawing.Point(369, 183);
            this.addHw.Name = "addHw";
            this.addHw.Size = new System.Drawing.Size(92, 23);
            this.addHw.TabIndex = 19;
            this.addHw.Text = "Agregar tarea";
            this.addHw.UseVisualStyleBackColor = true;
            this.addHw.Click += new System.EventHandler(this.addHw_Click);
            // 
            // RbTareas
            // 
            this.RbTareas.AutoSize = true;
            this.RbTareas.Location = new System.Drawing.Point(246, 27);
            this.RbTareas.Name = "RbTareas";
            this.RbTareas.Size = new System.Drawing.Size(58, 17);
            this.RbTareas.TabIndex = 20;
            this.RbTareas.TabStop = true;
            this.RbTareas.Text = "Tareas";
            this.RbTareas.UseVisualStyleBackColor = true;
            this.RbTareas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // GBoptions
            // 
            this.GBoptions.Controls.Add(this.button2);
            this.GBoptions.Controls.Add(this.button1);
            this.GBoptions.Controls.Add(this.RbTareas);
            this.GBoptions.Controls.Add(this.RbEliminar);
            this.GBoptions.Controls.Add(this.RbInsertar);
            this.GBoptions.Controls.Add(this.RbModificar);
            this.GBoptions.Location = new System.Drawing.Point(24, 13);
            this.GBoptions.Name = "GBoptions";
            this.GBoptions.Size = new System.Drawing.Size(565, 57);
            this.GBoptions.TabIndex = 21;
            this.GBoptions.TabStop = false;
            this.GBoptions.Text = "Seleccione una opción";
            // 
            // DgvUser
            // 
            this.DgvUser.AllowUserToAddRows = false;
            this.DgvUser.AllowUserToDeleteRows = false;
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUser.Location = new System.Drawing.Point(12, 247);
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.RowHeadersVisible = false;
            this.DgvUser.Size = new System.Drawing.Size(577, 175);
            this.DgvUser.TabIndex = 22;
            this.DgvUser.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ver Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ver Usuarios y tareas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 445);
            this.Controls.Add(this.DgvUser);
            this.Controls.Add(this.addHw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maestro);
            this.Controls.Add(this.Tarea);
            this.Controls.Add(this.IdUsr);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.app);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.GBoptions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            this.GBoptions.ResumeLayout(false);
            this.GBoptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox app;
        private System.Windows.Forms.TextBox mat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.RadioButton RbEliminar;
        private System.Windows.Forms.RadioButton RbInsertar;
        private System.Windows.Forms.RadioButton RbModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label IdUsr;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maestro;
        private System.Windows.Forms.TextBox Tarea;
        private System.Windows.Forms.Button addHw;
        private System.Windows.Forms.RadioButton RbTareas;
        private System.Windows.Forms.GroupBox GBoptions;
        private System.Windows.Forms.DataGridView DgvUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

