namespace Phone2Go
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhones = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStorage = new System.Windows.Forms.ComboBox();
            this.lblalma = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.lblcam = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblacc = new System.Windows.Forms.Label();
            this.btncont = new System.Windows.Forms.Button();
            this.lblprecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblspecs = new System.Windows.Forms.Label();
            this.lblcamara = new System.Windows.Forms.Label();
            this.lblbateria = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblstorage = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.txtmen = new System.Windows.Forms.TextBox();
            this.txtcam = new System.Windows.Forms.TextBox();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.lblpreciocam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefono";
            // 
            // cbPhones
            // 
            this.cbPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.Location = new System.Drawing.Point(27, 46);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(121, 21);
            this.cbPhones.TabIndex = 1;
            this.cbPhones.SelectedIndexChanged += new System.EventHandler(this.cbPhones_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtmen);
            this.panel1.Controls.Add(this.cbStorage);
            this.panel1.Controls.Add(this.lblalma);
            this.panel1.Location = new System.Drawing.Point(37, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 83);
            this.panel1.TabIndex = 2;
            // 
            // cbStorage
            // 
            this.cbStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStorage.FormattingEnabled = true;
            this.cbStorage.Location = new System.Drawing.Point(6, 35);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(121, 21);
            this.cbStorage.TabIndex = 1;
            this.cbStorage.SelectedIndexChanged += new System.EventHandler(this.cbStorage_SelectedIndexChanged);
            // 
            // lblalma
            // 
            this.lblalma.AutoSize = true;
            this.lblalma.Location = new System.Drawing.Point(3, 10);
            this.lblalma.Name = "lblalma";
            this.lblalma.Size = new System.Drawing.Size(85, 13);
            this.lblalma.TabIndex = 0;
            this.lblalma.Text = "Almacenamiento";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtcam);
            this.panel2.Controls.Add(this.cbCamera);
            this.panel2.Controls.Add(this.lblcam);
            this.panel2.Location = new System.Drawing.Point(37, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 80);
            this.panel2.TabIndex = 3;
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(6, 41);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(121, 21);
            this.cbCamera.TabIndex = 1;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // lblcam
            // 
            this.lblcam.AutoSize = true;
            this.lblcam.Location = new System.Drawing.Point(3, 10);
            this.lblcam.Name = "lblcam";
            this.lblcam.Size = new System.Drawing.Size(43, 13);
            this.lblcam.TabIndex = 0;
            this.lblcam.Text = "Camara";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtacc);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.lblacc);
            this.panel3.Location = new System.Drawing.Point(37, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 81);
            this.panel3.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblacc
            // 
            this.lblacc.AutoSize = true;
            this.lblacc.Location = new System.Drawing.Point(3, 10);
            this.lblacc.Name = "lblacc";
            this.lblacc.Size = new System.Drawing.Size(59, 13);
            this.lblacc.TabIndex = 0;
            this.lblacc.Text = "Accesorios";
            // 
            // btncont
            // 
            this.btncont.Enabled = false;
            this.btncont.Location = new System.Drawing.Point(555, 364);
            this.btncont.Name = "btncont";
            this.btncont.Size = new System.Drawing.Size(75, 23);
            this.btncont.TabIndex = 5;
            this.btncont.Text = "Continuar";
            this.btncont.UseVisualStyleBackColor = true;
            this.btncont.Click += new System.EventHandler(this.btncont_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(392, 306);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(10, 13);
            this.lblprecio.TabIndex = 6;
            this.lblprecio.Text = " ";
            this.lblprecio.Click += new System.EventHandler(this.lblprecio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio:";
            // 
            // lblspecs
            // 
            this.lblspecs.AutoSize = true;
            this.lblspecs.Location = new System.Drawing.Point(283, 207);
            this.lblspecs.Name = "lblspecs";
            this.lblspecs.Size = new System.Drawing.Size(87, 13);
            this.lblspecs.TabIndex = 8;
            this.lblspecs.Text = "Especificaciones";
            // 
            // lblcamara
            // 
            this.lblcamara.AutoSize = true;
            this.lblcamara.Location = new System.Drawing.Point(376, 238);
            this.lblcamara.Name = "lblcamara";
            this.lblcamara.Size = new System.Drawing.Size(10, 13);
            this.lblcamara.TabIndex = 9;
            this.lblcamara.Text = " ";
            // 
            // lblbateria
            // 
            this.lblbateria.AutoSize = true;
            this.lblbateria.Location = new System.Drawing.Point(376, 282);
            this.lblbateria.Name = "lblbateria";
            this.lblbateria.Size = new System.Drawing.Size(10, 13);
            this.lblbateria.TabIndex = 10;
            this.lblbateria.Text = " ";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(249, 353);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(515, 338);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(151, 20);
            this.txtemail.TabIndex = 12;
            this.txtemail.Visible = false;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Camara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bateria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Almacenamiento";
            // 
            // lblstorage
            // 
            this.lblstorage.AutoSize = true;
            this.lblstorage.Location = new System.Drawing.Point(376, 264);
            this.lblstorage.Name = "lblstorage";
            this.lblstorage.Size = new System.Drawing.Size(10, 13);
            this.lblstorage.TabIndex = 17;
            this.lblstorage.Text = " ";
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(333, 353);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 18;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // txtmen
            // 
            this.txtmen.Location = new System.Drawing.Point(133, 36);
            this.txtmen.Name = "txtmen";
            this.txtmen.Size = new System.Drawing.Size(35, 20);
            this.txtmen.TabIndex = 2;
            this.txtmen.TextChanged += new System.EventHandler(this.txtmen_TextChanged);
            // 
            // txtcam
            // 
            this.txtcam.Location = new System.Drawing.Point(133, 42);
            this.txtcam.Name = "txtcam";
            this.txtcam.Size = new System.Drawing.Size(35, 20);
            this.txtcam.TabIndex = 3;
            // 
            // txtacc
            // 
            this.txtacc.Location = new System.Drawing.Point(133, 39);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(35, 20);
            this.txtacc.TabIndex = 4;
            // 
            // lblpreciocam
            // 
            this.lblpreciocam.AutoSize = true;
            this.lblpreciocam.Location = new System.Drawing.Point(403, 264);
            this.lblpreciocam.Name = "lblpreciocam";
            this.lblpreciocam.Size = new System.Drawing.Size(10, 13);
            this.lblpreciocam.TabIndex = 19;
            this.lblpreciocam.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 399);
            this.Controls.Add(this.lblpreciocam);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lblstorage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lblbateria);
            this.Controls.Add(this.lblcamara);
            this.Controls.Add(this.lblspecs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.btncont);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbPhones);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Venta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblalma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblacc;
        private System.Windows.Forms.Button btncont;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblspecs;
        private System.Windows.Forms.Label lblcamara;
        private System.Windows.Forms.Label lblbateria;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblstorage;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.TextBox txtmen;
        private System.Windows.Forms.TextBox txtcam;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.Label lblpreciocam;
    }
}

