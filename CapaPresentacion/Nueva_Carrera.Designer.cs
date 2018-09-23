namespace CapaPresentacion
{
    partial class Nueva_Carrera
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnregistrar.Location = new System.Drawing.Point(138, 125);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(165, 42);
            this.btnregistrar.TabIndex = 34;
            this.btnregistrar.Text = "Registrar ";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txtcarrera
            // 
            this.txtcarrera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.txtcarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcarrera.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtcarrera.Location = new System.Drawing.Point(152, 53);
            this.txtcarrera.Multiline = true;
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(260, 22);
            this.txtcarrera.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre carrera";
            // 
            // Nueva_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 192);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.label1);
            this.Name = "Nueva_Carrera";
            this.Text = "Nueva_Carrera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Label label1;
    }
}