namespace proyectoFinal
{
    partial class frmAcceso
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
            this.btnAcceso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcceso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcceso
            // 
            this.btnAcceso.Location = new System.Drawing.Point(175, 223);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(75, 23);
            this.btnAcceso.TabIndex = 0;
            this.btnAcceso.Text = "Entrar";
            this.btnAcceso.UseVisualStyleBackColor = true;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña:";
            // 
            // txtAcceso
            // 
            this.txtAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcceso.Location = new System.Drawing.Point(100, 139);
            this.txtAcceso.Name = "txtAcceso";
            this.txtAcceso.PasswordChar = '*';
            this.txtAcceso.Size = new System.Drawing.Size(227, 31);
            this.txtAcceso.TabIndex = 3;
            this.txtAcceso.TextChanged += new System.EventHandler(this.txtAcceso_TextChanged);
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 282);
            this.Controls.Add(this.txtAcceso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceso);
            this.Name = "frmAcceso";
            this.Text = "frmAcceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcceso;
    }
}