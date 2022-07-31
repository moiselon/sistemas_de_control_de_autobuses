namespace segunparcial
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbcumpleaño = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtautobus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.dgvcontactos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "APELLIDO(S):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "cedula: ";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(85, 34);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(160, 20);
            this.tbnombre.TabIndex = 21;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(108, 75);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(160, 20);
            this.tbapellido.TabIndex = 22;
            // 
            // tbcumpleaño
            // 
            this.tbcumpleaño.Location = new System.Drawing.Point(151, 119);
            this.tbcumpleaño.Name = "tbcumpleaño";
            this.tbcumpleaño.Size = new System.Drawing.Size(160, 20);
            this.tbcumpleaño.TabIndex = 23;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(77, 156);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(234, 20);
            this.txtcedula.TabIndex = 24;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(401, 37);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 23);
            this.btnagregar.TabIndex = 25;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(528, 37);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(103, 23);
            this.btnborrar.TabIndex = 26;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "marca: ";
            // 
            // txtautobus
            // 
            this.txtautobus.Location = new System.Drawing.Point(85, 198);
            this.txtautobus.Name = "txtautobus";
            this.txtautobus.Size = new System.Drawing.Size(203, 20);
            this.txtautobus.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "modelo: ";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(85, 250);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(203, 20);
            this.txtmodelo.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "placa: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "color: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "año: ";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(85, 296);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(203, 20);
            this.txtplaca.TabIndex = 34;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(68, 336);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(203, 20);
            this.txtcolor.TabIndex = 35;
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(52, 391);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(203, 20);
            this.txtaño.TabIndex = 36;
            // 
            // dgvcontactos
            // 
            this.dgvcontactos.AllowUserToAddRows = false;
            this.dgvcontactos.AllowUserToDeleteRows = false;
            this.dgvcontactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontactos.Location = new System.Drawing.Point(319, 169);
            this.dgvcontactos.Name = "dgvcontactos";
            this.dgvcontactos.ReadOnly = true;
            this.dgvcontactos.Size = new System.Drawing.Size(782, 209);
            this.dgvcontactos.TabIndex = 37;
            this.dgvcontactos.DoubleClick += new System.EventHandler(this.dgvcontactos_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ruta: ";
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(52, 444);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(203, 20);
            this.txtruta.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(681, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Datos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1113, 591);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvcontactos);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtautobus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.tbcumpleaño);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "agenda";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbcumpleaño;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtautobus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.DataGridView dgvcontactos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Label label11;
    }
}