namespace Formulario
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
            this.btnCambiaColor = new System.Windows.Forms.Button();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCambiaColor
            // 
            this.btnCambiaColor.Location = new System.Drawing.Point(91, 106);
            this.btnCambiaColor.Name = "btnCambiaColor";
            this.btnCambiaColor.Size = new System.Drawing.Size(75, 23);
            this.btnCambiaColor.TabIndex = 0;
            this.btnCambiaColor.Text = "&Continuar";
            this.btnCambiaColor.UseVisualStyleBackColor = true;
            this.btnCambiaColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(68, 56);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(121, 21);
            this.cmbColores.TabIndex = 1;
//            this.cmbColores.SelectedIndexChanged += new System.EventHandler(this.cmbColores_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.btnCambiaColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCambiaColor;
        private System.Windows.Forms.ComboBox cmbColores;
    }
}

