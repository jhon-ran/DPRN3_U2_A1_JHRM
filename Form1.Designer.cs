
namespace DPRN3_U2_A1_JHRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmpSerie = new System.Windows.Forms.TextBox();
            this.cmpMarca = new System.Windows.Forms.TextBox();
            this.cmpModelo = new System.Windows.Forms.TextBox();
            this.conectar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.cmpTVehiculo = new System.Windows.Forms.ComboBox();
            this.cmpVerificacion = new System.Windows.Forms.ComboBox();
            this.cmpAnoAdq = new System.Windows.Forms.DateTimePicker();
            this.cmpAnoVehiculo = new System.Windows.Forms.DateTimePicker();
            this.cmpColor = new System.Windows.Forms.ListBox();
            this.cmpFoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmpFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE VEHICULOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de vehículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año de adquisición";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Año de vehículo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(829, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fotografía de vehículo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Verificación";
            // 
            // cmpSerie
            // 
            this.cmpSerie.Location = new System.Drawing.Point(184, 181);
            this.cmpSerie.Name = "cmpSerie";
            this.cmpSerie.Size = new System.Drawing.Size(157, 27);
            this.cmpSerie.TabIndex = 11;
            this.cmpSerie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmpMarca
            // 
            this.cmpMarca.Location = new System.Drawing.Point(184, 299);
            this.cmpMarca.Name = "cmpMarca";
            this.cmpMarca.Size = new System.Drawing.Size(157, 27);
            this.cmpMarca.TabIndex = 12;
            // 
            // cmpModelo
            // 
            this.cmpModelo.Location = new System.Drawing.Point(184, 363);
            this.cmpModelo.Name = "cmpModelo";
            this.cmpModelo.Size = new System.Drawing.Size(157, 27);
            this.cmpModelo.TabIndex = 13;
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(424, 370);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(128, 29);
            this.conectar.TabIndex = 18;
            this.conectar.Text = "Conectar con BD";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(577, 370);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(147, 29);
            this.guardar.TabIndex = 19;
            this.guardar.Text = "Guardar vehículo";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cmpTVehiculo
            // 
            this.cmpTVehiculo.FormattingEnabled = true;
            this.cmpTVehiculo.Items.AddRange(new object[] {
            "Sedan",
            "Pick-up",
            "Motocicleta"});
            this.cmpTVehiculo.Location = new System.Drawing.Point(190, 108);
            this.cmpTVehiculo.Name = "cmpTVehiculo";
            this.cmpTVehiculo.Size = new System.Drawing.Size(151, 28);
            this.cmpTVehiculo.TabIndex = 22;
            this.cmpTVehiculo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmpVerificacion
            // 
            this.cmpVerificacion.FormattingEnabled = true;
            this.cmpVerificacion.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmpVerificacion.Location = new System.Drawing.Point(567, 298);
            this.cmpVerificacion.Name = "cmpVerificacion";
            this.cmpVerificacion.Size = new System.Drawing.Size(151, 28);
            this.cmpVerificacion.TabIndex = 23;
            // 
            // cmpAnoAdq
            // 
            this.cmpAnoAdq.CustomFormat = "yyyy";
            this.cmpAnoAdq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmpAnoAdq.Location = new System.Drawing.Point(184, 241);
            this.cmpAnoAdq.Name = "cmpAnoAdq";
            this.cmpAnoAdq.ShowUpDown = true;
            this.cmpAnoAdq.Size = new System.Drawing.Size(157, 27);
            this.cmpAnoAdq.TabIndex = 24;
            this.cmpAnoAdq.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmpAnoVehiculo
            // 
            this.cmpAnoVehiculo.CustomFormat = "yyyy";
            this.cmpAnoVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmpAnoVehiculo.Location = new System.Drawing.Point(567, 118);
            this.cmpAnoVehiculo.Name = "cmpAnoVehiculo";
            this.cmpAnoVehiculo.ShowUpDown = true;
            this.cmpAnoVehiculo.Size = new System.Drawing.Size(157, 27);
            this.cmpAnoVehiculo.TabIndex = 25;
            // 
            // cmpColor
            // 
            this.cmpColor.FormattingEnabled = true;
            this.cmpColor.ItemHeight = 20;
            this.cmpColor.Items.AddRange(new object[] {
            "Rojo",
            "Negro",
            "Amarillo",
            "Gris",
            "Azul"});
            this.cmpColor.Location = new System.Drawing.Point(568, 181);
            this.cmpColor.MultiColumn = true;
            this.cmpColor.Name = "cmpColor";
            this.cmpColor.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.cmpColor.Size = new System.Drawing.Size(150, 104);
            this.cmpColor.TabIndex = 26;
            this.cmpColor.SelectedIndexChanged += new System.EventHandler(this.cmpColor_SelectedIndexChanged);
            // 
            // cmpFoto
            // 
            this.cmpFoto.Location = new System.Drawing.Point(797, 118);
            this.cmpFoto.Name = "cmpFoto";
            this.cmpFoto.Size = new System.Drawing.Size(223, 177);
            this.cmpFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmpFoto.TabIndex = 27;
            this.cmpFoto.TabStop = false;
            this.cmpFoto.Click += new System.EventHandler(this.cmpFoto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(865, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmpFoto);
            this.Controls.Add(this.cmpColor);
            this.Controls.Add(this.cmpAnoVehiculo);
            this.Controls.Add(this.cmpAnoAdq);
            this.Controls.Add(this.cmpVerificacion);
            this.Controls.Add(this.cmpTVehiculo);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.cmpModelo);
            this.Controls.Add(this.cmpMarca);
            this.Controls.Add(this.cmpSerie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cmpFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cmpSerie;
        private System.Windows.Forms.TextBox cmpMarca;
        private System.Windows.Forms.TextBox cmpModelo;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ComboBox cmpTVehiculo;
        private System.Windows.Forms.ComboBox cmpVerificacion;
        private System.Windows.Forms.DateTimePicker cmpAnoAdq;
        private System.Windows.Forms.DateTimePicker cmpAnoVehiculo;
        private System.Windows.Forms.ListBox cmpColor;
        private System.Windows.Forms.PictureBox cmpFoto;
        private System.Windows.Forms.Button button1;
    }
}

