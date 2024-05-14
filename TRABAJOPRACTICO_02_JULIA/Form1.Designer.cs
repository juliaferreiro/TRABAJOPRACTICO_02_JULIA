namespace TRABAJOPRACTICO_02_JULIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            grbDatos = new GroupBox();
            button4 = new Button();
            grbCantidad = new GroupBox();
            rdb100 = new RadioButton();
            rdb500 = new RadioButton();
            rdb50 = new RadioButton();
            rdb200 = new RadioButton();
            rdb30 = new RadioButton();
            groupBox4 = new GroupBox();
            cmbCompania = new ComboBox();
            grbOutput = new GroupBox();
            lblRecargas = new Label();
            lblnumero = new Label();
            groupBox1.SuspendLayout();
            grbDatos.SuspendLayout();
            grbCantidad.SuspendLayout();
            groupBox4.SuspendLayout();
            grbOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(114, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // button3
            // 
            button3.Location = new Point(399, 24);
            button3.Name = "button3";
            button3.Size = new Size(75, 43);
            button3.TabIndex = 2;
            button3.Text = "Salir de la aplicación";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(219, 24);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 1;
            button2.Text = "Nueva recarga";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(51, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 0;
            button1.Text = "Carga celular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(button4);
            grbDatos.Controls.Add(grbCantidad);
            grbDatos.Controls.Add(groupBox4);
            grbDatos.Location = new Point(114, 181);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(542, 168);
            grbDatos.TabIndex = 1;
            grbDatos.TabStop = false;
            grbDatos.Text = "Datos del cliente";
            grbDatos.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(346, 81);
            button4.Name = "button4";
            button4.Size = new Size(75, 43);
            button4.TabIndex = 3;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // grbCantidad
            // 
            grbCantidad.Controls.Add(rdb100);
            grbCantidad.Controls.Add(rdb500);
            grbCantidad.Controls.Add(rdb50);
            grbCantidad.Controls.Add(rdb200);
            grbCantidad.Controls.Add(rdb30);
            grbCantidad.Location = new Point(24, 24);
            grbCantidad.Name = "grbCantidad";
            grbCantidad.Size = new Size(147, 138);
            grbCantidad.TabIndex = 2;
            grbCantidad.TabStop = false;
            grbCantidad.Text = "Cantidad";
            grbCantidad.Visible = false;
            // 
            // rdb100
            // 
            rdb100.AutoSize = true;
            rdb100.Location = new Point(76, 22);
            rdb100.Name = "rdb100";
            rdb100.Size = new Size(49, 19);
            rdb100.TabIndex = 4;
            rdb100.TabStop = true;
            rdb100.Text = "$100";
            rdb100.UseVisualStyleBackColor = true;
            rdb100.Visible = false;
            // 
            // rdb500
            // 
            rdb500.AutoSize = true;
            rdb500.Location = new Point(76, 91);
            rdb500.Name = "rdb500";
            rdb500.Size = new Size(49, 19);
            rdb500.TabIndex = 3;
            rdb500.TabStop = true;
            rdb500.Text = "$500";
            rdb500.UseVisualStyleBackColor = true;
            rdb500.Visible = false;
            // 
            // rdb50
            // 
            rdb50.AutoSize = true;
            rdb50.Location = new Point(12, 57);
            rdb50.Name = "rdb50";
            rdb50.Size = new Size(43, 19);
            rdb50.TabIndex = 2;
            rdb50.TabStop = true;
            rdb50.Text = "$50";
            rdb50.UseVisualStyleBackColor = true;
            rdb50.Visible = false;
            // 
            // rdb200
            // 
            rdb200.AutoSize = true;
            rdb200.Location = new Point(76, 57);
            rdb200.Name = "rdb200";
            rdb200.Size = new Size(49, 19);
            rdb200.TabIndex = 1;
            rdb200.TabStop = true;
            rdb200.Text = "$200";
            rdb200.UseVisualStyleBackColor = true;
            rdb200.Visible = false;
            // 
            // rdb30
            // 
            rdb30.AutoSize = true;
            rdb30.Location = new Point(12, 23);
            rdb30.Name = "rdb30";
            rdb30.Size = new Size(43, 19);
            rdb30.TabIndex = 0;
            rdb30.TabStop = true;
            rdb30.Text = "$30";
            rdb30.UseVisualStyleBackColor = true;
            rdb30.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbCompania);
            groupBox4.Location = new Point(274, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 49);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Compañía";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // cmbCompania
            // 
            cmbCompania.FormattingEnabled = true;
            cmbCompania.Items.AddRange(new object[] { "", "Motorola", "Telecel", "Nextel" });
            cmbCompania.Location = new Point(31, 18);
            cmbCompania.Name = "cmbCompania";
            cmbCompania.Size = new Size(121, 23);
            cmbCompania.TabIndex = 0;
            cmbCompania.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // grbOutput
            // 
            grbOutput.Controls.Add(lblRecargas);
            grbOutput.Location = new Point(114, 372);
            grbOutput.Name = "grbOutput";
            grbOutput.Size = new Size(542, 44);
            grbOutput.TabIndex = 2;
            grbOutput.TabStop = false;
            grbOutput.Visible = false;
            // 
            // lblRecargas
            // 
            lblRecargas.AutoSize = true;
            lblRecargas.Location = new Point(46, 16);
            lblRecargas.Name = "lblRecargas";
            lblRecargas.Size = new Size(63, 15);
            lblRecargas.TabIndex = 0;
            lblRecargas.Text = "Recargas...";
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(550, 163);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(38, 15);
            lblnumero.TabIndex = 3;
            lblnumero.Text = "label1";
            lblnumero.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblnumero);
            Controls.Add(grbOutput);
            Controls.Add(grbDatos);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Recarga_Celular";
            groupBox1.ResumeLayout(false);
            grbDatos.ResumeLayout(false);
            grbCantidad.ResumeLayout(false);
            grbCantidad.PerformLayout();
            groupBox4.ResumeLayout(false);
            grbOutput.ResumeLayout(false);
            grbOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox grbDatos;
        private GroupBox grbCantidad;
        private GroupBox groupBox4;
        private Button button4;
        private RadioButton rdb100;
        private RadioButton rdb500;
        private RadioButton rdb50;
        private RadioButton rdb200;
        private RadioButton rdb30;
        private GroupBox grbOutput;
        private Label lblRecargas;
        private ComboBox cmbCompania;
        private Label lblnumero;
    }
}
