namespace segunparcial
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
            this.btn_ventana2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ventana2
            // 
            this.btn_ventana2.Location = new System.Drawing.Point(58, 205);
            this.btn_ventana2.Name = "btn_ventana2";
            this.btn_ventana2.Size = new System.Drawing.Size(283, 109);
            this.btn_ventana2.TabIndex = 0;
            this.btn_ventana2.Text = "Click aqui para entrar al sistema de autobuses";
            this.btn_ventana2.UseVisualStyleBackColor = true;
            this.btn_ventana2.Click += new System.EventHandler(this.btn_ventana2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(445, 512);
            this.Controls.Add(this.btn_ventana2);
            this.Name = "Form1";
            this.Text = "INICIO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ventana2;
    }
}

