namespace Phone2Go
{
    partial class Venta
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
            this.cbtelefonos = new System.Windows.Forms.ComboBox();
            this.txtcantPila = new System.Windows.Forms.TextBox();
            this.txtMem = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblnombretel = new System.Windows.Forms.Label();
            this.lblcan = new System.Windows.Forms.Label();
            this.txtAcce = new System.Windows.Forms.TextBox();
            this.lbldescripcionPant = new System.Windows.Forms.Label();
            this.lbldescripcionB = new System.Windows.Forms.Label();
            this.lbldescripcionCam = new System.Windows.Forms.Label();
            this.cbpila = new System.Windows.Forms.ComboBox();
            this.Memoria = new System.Windows.Forms.ComboBox();
            this.btnsal = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbcamaras = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbtelefonos
            // 
            this.cbtelefonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtelefonos.FormattingEnabled = true;
            this.cbtelefonos.Location = new System.Drawing.Point(23, 34);
            this.cbtelefonos.Name = "cbtelefonos";
            this.cbtelefonos.Size = new System.Drawing.Size(121, 21);
            this.cbtelefonos.TabIndex = 0;
            this.cbtelefonos.SelectedIndexChanged += new System.EventHandler(this.cbtelefonos_SelectedIndexChanged);
            // 
            // txtcantPila
            // 
            this.txtcantPila.Enabled = false;
            this.txtcantPila.Location = new System.Drawing.Point(74, 90);
            this.txtcantPila.Name = "txtcantPila";
            this.txtcantPila.Size = new System.Drawing.Size(41, 20);
            this.txtcantPila.TabIndex = 4;
            this.txtcantPila.Text = "0";
            this.txtcantPila.TextChanged += new System.EventHandler(this.txtcantPila_TextChanged);
            this.txtcantPila.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantPila_KeyDown);
            this.txtcantPila.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantPila_KeyPress);
            // 
            // txtMem
            // 
            this.txtMem.Enabled = false;
            this.txtMem.Location = new System.Drawing.Point(74, 117);
            this.txtMem.Name = "txtMem";
            this.txtMem.Size = new System.Drawing.Size(41, 20);
            this.txtMem.TabIndex = 5;
            this.txtMem.Text = "0";
            this.txtMem.TextChanged += new System.EventHandler(this.txtMem_TextChanged);
            this.txtMem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMem_KeyDown);
            this.txtMem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMem_KeyPress);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(9, 193);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(20, 18);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono.TabIndex = 7;
            this.lbltelefono.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pantalla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bateria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Camaras";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(90, 193);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(75, 23);
            this.btnend.TabIndex = 12;
            this.btnend.Text = "Terminar";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Camara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bateria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pantalla";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(293, 162);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(10, 13);
            this.lblprice.TabIndex = 17;
            this.lblprice.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = " ";
            // 
            // lblnombretel
            // 
            this.lblnombretel.AutoSize = true;
            this.lblnombretel.Location = new System.Drawing.Point(293, 34);
            this.lblnombretel.Name = "lblnombretel";
            this.lblnombretel.Size = new System.Drawing.Size(10, 13);
            this.lblnombretel.TabIndex = 21;
            this.lblnombretel.Text = " ";
            // 
            // lblcan
            // 
            this.lblcan.AutoSize = true;
            this.lblcan.Location = new System.Drawing.Point(293, 101);
            this.lblcan.Name = "lblcan";
            this.lblcan.Size = new System.Drawing.Size(10, 13);
            this.lblcan.TabIndex = 22;
            this.lblcan.Text = " ";
            // 
            // txtAcce
            // 
            this.txtAcce.Enabled = false;
            this.txtAcce.Location = new System.Drawing.Point(151, 144);
            this.txtAcce.Name = "txtAcce";
            this.txtAcce.Size = new System.Drawing.Size(41, 20);
            this.txtAcce.TabIndex = 23;
            this.txtAcce.Text = "0";
            this.txtAcce.TextChanged += new System.EventHandler(this.txtAcce_TextChanged);
            this.txtAcce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcce_KeyDown);
            this.txtAcce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcce_KeyPress);
            // 
            // lbldescripcionPant
            // 
            this.lbldescripcionPant.AutoSize = true;
            this.lbldescripcionPant.Location = new System.Drawing.Point(344, 101);
            this.lbldescripcionPant.Name = "lbldescripcionPant";
            this.lbldescripcionPant.Size = new System.Drawing.Size(10, 13);
            this.lbldescripcionPant.TabIndex = 26;
            this.lbldescripcionPant.Text = " ";
            // 
            // lbldescripcionB
            // 
            this.lbldescripcionB.AutoSize = true;
            this.lbldescripcionB.Location = new System.Drawing.Point(344, 74);
            this.lbldescripcionB.Name = "lbldescripcionB";
            this.lbldescripcionB.Size = new System.Drawing.Size(10, 13);
            this.lbldescripcionB.TabIndex = 25;
            this.lbldescripcionB.Text = " ";
            // 
            // lbldescripcionCam
            // 
            this.lbldescripcionCam.AutoSize = true;
            this.lbldescripcionCam.Location = new System.Drawing.Point(344, 128);
            this.lbldescripcionCam.Name = "lbldescripcionCam";
            this.lbldescripcionCam.Size = new System.Drawing.Size(10, 13);
            this.lbldescripcionCam.TabIndex = 24;
            this.lbldescripcionCam.Text = " ";
            // 
            // cbpila
            // 
            this.cbpila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpila.Enabled = false;
            this.cbpila.FormattingEnabled = true;
            this.cbpila.Location = new System.Drawing.Point(306, 224);
            this.cbpila.Name = "cbpila";
            this.cbpila.Size = new System.Drawing.Size(121, 21);
            this.cbpila.TabIndex = 1;
            this.cbpila.Visible = false;
            this.cbpila.SelectedIndexChanged += new System.EventHandler(this.cbpila_SelectedIndexChanged);
            // 
            // Memoria
            // 
            this.Memoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Memoria.FormattingEnabled = true;
            this.Memoria.Location = new System.Drawing.Point(306, 250);
            this.Memoria.Name = "Memoria";
            this.Memoria.Size = new System.Drawing.Size(121, 21);
            this.Memoria.TabIndex = 2;
            this.Memoria.Visible = false;
            this.Memoria.SelectedIndexChanged += new System.EventHandler(this.Memoria_SelectedIndexChanged);
            // 
            // btnsal
            // 
            this.btnsal.Location = new System.Drawing.Point(515, 275);
            this.btnsal.Name = "btnsal";
            this.btnsal.Size = new System.Drawing.Size(75, 23);
            this.btnsal.TabIndex = 30;
            this.btnsal.Text = "Salir";
            this.btnsal.UseSelectable = true;
            this.btnsal.Click += new System.EventHandler(this.btnsal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(446, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Correo";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(433, 251);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "metroLabel1";
            this.metroLabel1.Visible = false;
            // 
            // cbcamaras
            // 
            this.cbcamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcamaras.FormattingEnabled = true;
            this.cbcamaras.Location = new System.Drawing.Point(74, 143);
            this.cbcamaras.Name = "cbcamaras";
            this.cbcamaras.Size = new System.Drawing.Size(70, 21);
            this.cbcamaras.TabIndex = 35;
            this.cbcamaras.SelectedIndexChanged += new System.EventHandler(this.cbcamaras_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 312);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbcamaras);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnsal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbldescripcionPant);
            this.Controls.Add(this.lbldescripcionB);
            this.Controls.Add(this.lbldescripcionCam);
            this.Controls.Add(this.txtAcce);
            this.Controls.Add(this.lblcan);
            this.Controls.Add(this.lblnombretel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtMem);
            this.Controls.Add(this.txtcantPila);
            this.Controls.Add(this.Memoria);
            this.Controls.Add(this.cbpila);
            this.Controls.Add(this.cbtelefonos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbtelefonos;
        private System.Windows.Forms.TextBox txtcantPila;
        private System.Windows.Forms.TextBox txtMem;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblnombretel;
        private System.Windows.Forms.Label lblcan;
        private System.Windows.Forms.TextBox txtAcce;
        private System.Windows.Forms.Label lbldescripcionPant;
        private System.Windows.Forms.Label lbldescripcionB;
        private System.Windows.Forms.Label lbldescripcionCam;
        private System.Windows.Forms.ComboBox cbpila;
        private System.Windows.Forms.ComboBox Memoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnsal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cbcamaras;
        private System.Windows.Forms.Label label11;
    }
}