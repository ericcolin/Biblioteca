namespace CapaPresentacion
{
    partial class Nuevo_Usuario
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
            this.btn_registrar = new System.Windows.Forms.Button();
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
            this.comboBox_carrera = new System.Windows.Forms.ComboBox();
            this.comboBox_tipo_usuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_registrar.Location = new System.Drawing.Point(250, 331);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(165, 42);
            this.btn_registrar.TabIndex = 44;
            this.btn_registrar.Text = "Registrar ";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(142, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Tipo de usuario";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(198, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Carrera";
            // 
            // txtgrupo
            // 
            this.txtgrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtgrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgrupo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtgrupo.Location = new System.Drawing.Point(274, 190);
            this.txtgrupo.Multiline = true;
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(260, 22);
            this.txtgrupo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(208, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(122, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Apellido materno";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(126, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Apellido paterno";
            // 
            // txtapm
            // 
            this.txtapm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtapm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapm.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtapm.Location = new System.Drawing.Point(274, 154);
            this.txtapm.Multiline = true;
            this.txtapm.Name = "txtapm";
            this.txtapm.Size = new System.Drawing.Size(260, 22);
            this.txtapm.TabIndex = 35;
            // 
            // txtapp
            // 
            this.txtapp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtapp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapp.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtapp.Location = new System.Drawing.Point(274, 115);
            this.txtapp.Multiline = true;
            this.txtapp.Name = "txtapp";
            this.txtapp.Size = new System.Drawing.Size(260, 22);
            this.txtapp.TabIndex = 34;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtnombre.Location = new System.Drawing.Point(274, 76);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(260, 22);
            this.txtnombre.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(195, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // comboBox_carrera
            // 
            this.comboBox_carrera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_carrera.FormattingEnabled = true;
            this.comboBox_carrera.Location = new System.Drawing.Point(274, 230);
            this.comboBox_carrera.Name = "comboBox_carrera";
            this.comboBox_carrera.Size = new System.Drawing.Size(260, 21);
            this.comboBox_carrera.TabIndex = 45;
            // 
            // comboBox_tipo_usuario
            // 
            this.comboBox_tipo_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_tipo_usuario.FormattingEnabled = true;
            this.comboBox_tipo_usuario.Location = new System.Drawing.Point(274, 264);
            this.comboBox_tipo_usuario.Name = "comboBox_tipo_usuario";
            this.comboBox_tipo_usuario.Size = new System.Drawing.Size(260, 21);
            this.comboBox_tipo_usuario.TabIndex = 46;
            // 
            // Nuevo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 460);
            this.Controls.Add(this.comboBox_tipo_usuario);
            this.Controls.Add(this.comboBox_carrera);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapm);
            this.Controls.Add(this.txtapp);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Nuevo_Usuario";
            this.Text = "Nuevo_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
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
        private System.Windows.Forms.ComboBox comboBox_carrera;
        private System.Windows.Forms.ComboBox comboBox_tipo_usuario;
    }
}