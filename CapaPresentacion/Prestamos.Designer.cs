namespace CapaPresentacion
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbtnregistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(79)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tbtnregistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 481);
            this.panel1.TabIndex = 80;
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
            this.tbtnregistrar.Text = "Realizar prestamo";
            this.tbtnregistrar.UseVisualStyleBackColor = false;
            this.tbtnregistrar.Click += new System.EventHandler(this.tbtnregistrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calendario);
            this.panel2.Controls.Add(this.txtmatricula);
            this.panel2.Controls.Add(this.lblmatricula);
            this.panel2.Controls.Add(this.txtlibro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 481);
            this.panel2.TabIndex = 81;
            // 
            // txtmatricula
            // 
            this.txtmatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtmatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatricula.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtmatricula.Location = new System.Drawing.Point(57, 88);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(260, 23);
            this.txtmatricula.TabIndex = 159;
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblmatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.lblmatricula.Location = new System.Drawing.Point(53, 62);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(85, 21);
            this.lblmatricula.TabIndex = 158;
            this.lblmatricula.Text = "Matricula";
            // 
            // txtlibro
            // 
            this.txtlibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtlibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlibro.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtlibro.Location = new System.Drawing.Point(57, 148);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(260, 23);
            this.txtlibro.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(53, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 21);
            this.label1.TabIndex = 146;
            this.label1.Text = "Número de identificación del libro ";
            // 
            // calendario
            // 
            this.calendario.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.calendario.Location = new System.Drawing.Point(57, 190);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(260, 20);
            this.calendario.TabIndex = 161;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbtnregistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.TextBox txtlibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calendario;
    }
}