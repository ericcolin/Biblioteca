namespace CapaPresentacion
{
    partial class Menu_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Usuario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbtnregistrar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.comboBox_tipo_usuario = new System.Windows.Forms.ComboBox();
            this.comboBox_carrera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapm = new System.Windows.Forms.TextBox();
            this.txtapp = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dataGridView_usuario = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1362, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtmatricula);
            this.panel2.Controls.Add(this.lblmatricula);
            this.panel2.Controls.Add(this.comboBox_tipo_usuario);
            this.panel2.Controls.Add(this.comboBox_carrera);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtgrupo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtapm);
            this.panel2.Controls.Add(this.txtapp);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(265, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 472);
            this.panel2.TabIndex = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(79)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tbtnregistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 472);
            this.panel1.TabIndex = 79;
            // 
            // tbtnregistrar
            // 
            this.tbtnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(92)))));
            this.tbtnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbtnregistrar.FlatAppearance.BorderSize = 0;
            this.tbtnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbtnregistrar.Font = new System.Drawing.Font("Arial", 12F);
            this.tbtnregistrar.ForeColor = System.Drawing.Color.White;
            this.tbtnregistrar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnregistrar.Image")));
            this.tbtnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbtnregistrar.Location = new System.Drawing.Point(0, 257);
            this.tbtnregistrar.Name = "tbtnregistrar";
            this.tbtnregistrar.Size = new System.Drawing.Size(262, 44);
            this.tbtnregistrar.TabIndex = 8;
            this.tbtnregistrar.Text = "Registrar";
            this.tbtnregistrar.UseVisualStyleBackColor = false;
            this.tbtnregistrar.Click += new System.EventHandler(this.tbtnregistrar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_usuario);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.txtbuscar);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1362, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actulizar usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtbuscar.Location = new System.Drawing.Point(329, 63);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(232, 23);
            this.txtbuscar.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label13.Location = new System.Drawing.Point(325, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 21);
            this.label13.TabIndex = 63;
            this.label13.Text = "Introduce tu matricula";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1362, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtmatricula
            // 
            this.txtmatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtmatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatricula.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtmatricula.Location = new System.Drawing.Point(163, 60);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(260, 23);
            this.txtmatricula.TabIndex = 145;
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblmatricula.Location = new System.Drawing.Point(159, 34);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(85, 21);
            this.lblmatricula.TabIndex = 144;
            this.lblmatricula.Text = "Matricula";
            // 
            // comboBox_tipo_usuario
            // 
            this.comboBox_tipo_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_usuario.FormattingEnabled = true;
            this.comboBox_tipo_usuario.Location = new System.Drawing.Point(163, 420);
            this.comboBox_tipo_usuario.Name = "comboBox_tipo_usuario";
            this.comboBox_tipo_usuario.Size = new System.Drawing.Size(260, 21);
            this.comboBox_tipo_usuario.TabIndex = 143;
            // 
            // comboBox_carrera
            // 
            this.comboBox_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_carrera.FormattingEnabled = true;
            this.comboBox_carrera.Location = new System.Drawing.Point(163, 360);
            this.comboBox_carrera.Name = "comboBox_carrera";
            this.comboBox_carrera.Size = new System.Drawing.Size(260, 21);
            this.comboBox_carrera.TabIndex = 142;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(159, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 141;
            this.label6.Text = "Tipo de usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(159, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 140;
            this.label5.Text = "Carrera";
            // 
            // txtgrupo
            // 
            this.txtgrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtgrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrupo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtgrupo.Location = new System.Drawing.Point(163, 300);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(260, 23);
            this.txtgrupo.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(159, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 138;
            this.label4.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(159, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 137;
            this.label3.Text = "Apellido materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(159, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 136;
            this.label2.Text = "Apellido paterno";
            // 
            // txtapm
            // 
            this.txtapm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtapm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapm.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtapm.Location = new System.Drawing.Point(163, 240);
            this.txtapm.Name = "txtapm";
            this.txtapm.Size = new System.Drawing.Size(260, 23);
            this.txtapm.TabIndex = 135;
            // 
            // txtapp
            // 
            this.txtapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtapp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapp.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtapp.Location = new System.Drawing.Point(163, 180);
            this.txtapp.Name = "txtapp";
            this.txtapp.Size = new System.Drawing.Size(260, 23);
            this.txtapp.TabIndex = 134;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtnombre.Location = new System.Drawing.Point(163, 120);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(260, 23);
            this.txtnombre.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(159, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 132;
            this.label1.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(79)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 472);
            this.panel3.TabIndex = 80;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(94)))), ((int)(((byte)(92)))));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(0, 257);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(262, 44);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dataGridView_usuario
            // 
            this.dataGridView_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usuario.Location = new System.Drawing.Point(593, 13);
            this.dataGridView_usuario.Name = "dataGridView_usuario";
            this.dataGridView_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_usuario.Size = new System.Drawing.Size(631, 457);
            this.dataGridView_usuario.TabIndex = 62;
            this.dataGridView_usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_usuario_MouseClick);
            // 
            // Menu_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbtnregistrar;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.ComboBox comboBox_tipo_usuario;
        private System.Windows.Forms.ComboBox comboBox_carrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapm;
        private System.Windows.Forms.TextBox txtapp;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dataGridView_usuario;
    }
}