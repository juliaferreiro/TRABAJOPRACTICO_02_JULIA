namespace TRABAJOPRACTICO_02_JULIA
{
    partial class Bono
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
            groupBox1 = new GroupBox();
            cmbNacionalidad = new ComboBox();
            cmbSexo = new ComboBox();
            txtEdad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSueldo = new TextBox();
            groupBox2 = new GroupBox();
            chkBD = new CheckBox();
            chkOracle = new CheckBox();
            chkJava = new CheckBox();
            chkVBNet = new CheckBox();
            chkASPNet = new CheckBox();
            chkPHP = new CheckBox();
            groupBox3 = new GroupBox();
            rdb10 = new RadioButton();
            rdb610 = new RadioButton();
            rdb15 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtBono = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNacionalidad);
            groupBox1.Controls.Add(cmbSexo);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Location = new Point(88, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Items.AddRange(new object[] { "Nacional", "Extranjero" });
            cmbNacionalidad.Location = new Point(434, 79);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(121, 23);
            cmbNacionalidad.TabIndex = 7;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "(Seleccionar)", "Femenino", "Masculino" });
            cmbSexo.Location = new Point(95, 76);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(455, 34);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 82);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 4;
            label4.Text = "Nacionalidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 42);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Edad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Sexo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(95, 34);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkBD);
            groupBox2.Controls.Add(chkOracle);
            groupBox2.Controls.Add(chkJava);
            groupBox2.Controls.Add(chkVBNet);
            groupBox2.Controls.Add(chkASPNet);
            groupBox2.Controls.Add(chkPHP);
            groupBox2.Location = new Point(88, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 146);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cursos";
            // 
            // chkBD
            // 
            chkBD.AutoSize = true;
            chkBD.Location = new Point(183, 110);
            chkBD.Name = "chkBD";
            chkBD.Size = new Size(121, 19);
            chkBD.TabIndex = 5;
            chkBD.Text = "Introducción a BD";
            chkBD.UseVisualStyleBackColor = true;
            // 
            // chkOracle
            // 
            chkOracle.AutoSize = true;
            chkOracle.Location = new Point(183, 72);
            chkOracle.Name = "chkOracle";
            chkOracle.Size = new Size(60, 19);
            chkOracle.TabIndex = 4;
            chkOracle.Text = "Oracle";
            chkOracle.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(183, 37);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(48, 19);
            chkJava.TabIndex = 3;
            chkJava.Text = "Java";
            chkJava.UseVisualStyleBackColor = true;
            // 
            // chkVBNet
            // 
            chkVBNet.AutoSize = true;
            chkVBNet.Location = new Point(30, 110);
            chkVBNet.Name = "chkVBNet";
            chkVBNet.Size = new Size(62, 19);
            chkVBNet.TabIndex = 2;
            chkVBNet.Text = "VB.Net";
            chkVBNet.UseVisualStyleBackColor = true;
            // 
            // chkASPNet
            // 
            chkASPNet.AutoSize = true;
            chkASPNet.Location = new Point(30, 73);
            chkASPNet.Name = "chkASPNet";
            chkASPNet.Size = new Size(69, 19);
            chkASPNet.TabIndex = 1;
            chkASPNet.Text = "ASP.Net";
            chkASPNet.UseVisualStyleBackColor = true;
            // 
            // chkPHP
            // 
            chkPHP.AutoSize = true;
            chkPHP.Location = new Point(30, 37);
            chkPHP.Name = "chkPHP";
            chkPHP.Size = new Size(49, 19);
            chkPHP.TabIndex = 0;
            chkPHP.Text = "PHP";
            chkPHP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdb10);
            groupBox3.Controls.Add(rdb610);
            groupBox3.Controls.Add(rdb15);
            groupBox3.Location = new Point(398, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(298, 146);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Antiguedad";
            // 
            // rdb10
            // 
            rdb10.AutoSize = true;
            rdb10.Location = new Point(71, 109);
            rdb10.Name = "rdb10";
            rdb10.Size = new Size(106, 19);
            rdb10.TabIndex = 2;
            rdb10.TabStop = true;
            rdb10.Text = "Más de 10 años";
            rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb610
            // 
            rdb610.AutoSize = true;
            rdb610.Location = new Point(71, 72);
            rdb610.Name = "rdb610";
            rdb610.Size = new Size(100, 19);
            rdb610.TabIndex = 1;
            rdb610.TabStop = true;
            rdb610.Text = "De 6 a 10 años";
            rdb610.UseVisualStyleBackColor = true;
            // 
            // rdb15
            // 
            rdb15.AutoSize = true;
            rdb15.Location = new Point(71, 36);
            rdb15.Name = "rdb15";
            rdb15.Size = new Size(94, 19);
            rdb15.TabIndex = 0;
            rdb15.TabStop = true;
            rdb15.Text = "De 1 a 5 años";
            rdb15.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(308, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 334);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 4;
            button2.Text = "Nuevo calculo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(621, 334);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtBono
            // 
            txtBono.Enabled = false;
            txtBono.Location = new Point(596, 305);
            txtBono.Name = "txtBono";
            txtBono.Size = new Size(100, 23);
            txtBono.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(543, 308);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 7;
            label5.Text = "Bono";
            // 
            // Bono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(label5);
            Controls.Add(txtBono);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Bono";
            Text = "Bono";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbNacionalidad;
        private ComboBox cmbSexo;
        private TextBox txtEdad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSueldo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox chkBD;
        private CheckBox chkOracle;
        private CheckBox chkJava;
        private CheckBox chkVBNet;
        private CheckBox chkASPNet;
        private CheckBox chkPHP;
        private RadioButton rdb10;
        private RadioButton rdb610;
        private RadioButton rdb15;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtBono;
        private Label label5;
    }
}