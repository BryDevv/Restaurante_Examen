namespace Restaurante_Examen
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label3 = new Label();
            carrito = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            menu = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            tabPage3 = new TabPage();
            label5 = new Label();
            nombrebebida = new ComboBox();
            P_bebida = new Panel();
            label6 = new Label();
            tipobebida = new ComboBox();
            presentacionml = new ComboBox();
            label7 = new Label();
            this.P_platofuerte = new Panel();
            this.tipocarne = new ComboBox();
            acopañamiento = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            preciobebida = new Label();
            preciocarne = new Label();
            Postre = new Panel();
            label4 = new Label();
            presentacion_postre = new ComboBox();
            label10 = new Label();
            tipopostre = new ComboBox();
            azucar = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            comboBox1 = new ComboBox();
            label16 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label19 = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            comboBox6 = new ComboBox();
            label23 = new Label();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            label24 = new Label();
            label25 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carrito).BeginInit();
            P_bebida.SuspendLayout();
            this.P_platofuerte.SuspendLayout();
            Postre.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(13, 17);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(775, 807);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Postre);
            tabPage1.Controls.Add(P_bebida);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(carrito);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(menu);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(767, 774);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Menú";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(767, 774);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 90);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 17;
            label3.Text = "Carrito de compras:";
            // 
            // carrito
            // 
            carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carrito.Location = new Point(476, 126);
            carrito.Name = "carrito";
            carrito.RowHeadersWidth = 51;
            carrito.Size = new Size(264, 267);
            carrito.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(476, 425);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 14;
            label2.Text = "Menú:";
            // 
            // menu
            // 
            menu.FormattingEnabled = true;
            menu.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            menu.Location = new Point(26, 126);
            menu.Name = "menu";
            menu.Size = new Size(264, 28);
            menu.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(26, 636);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 10;
            label1.Text = "Restaurante";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(767, 663);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Buscar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 115);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 20;
            label5.Text = "Nombre";
            // 
            // nombrebebida
            // 
            nombrebebida.FormattingEnabled = true;
            nombrebebida.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            nombrebebida.Location = new Point(17, 157);
            nombrebebida.Name = "nombrebebida";
            nombrebebida.Size = new Size(156, 28);
            nombrebebida.TabIndex = 21;
            // 
            // P_bebida
            // 
            P_bebida.Controls.Add(this.P_platofuerte);
            P_bebida.Controls.Add(preciobebida);
            P_bebida.Controls.Add(presentacionml);
            P_bebida.Controls.Add(label7);
            P_bebida.Controls.Add(tipobebida);
            P_bebida.Controls.Add(nombrebebida);
            P_bebida.Controls.Add(label6);
            P_bebida.Controls.Add(label5);
            P_bebida.Location = new Point(26, 186);
            P_bebida.Name = "P_bebida";
            P_bebida.Size = new Size(291, 444);
            P_bebida.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 28);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 0;
            label6.Text = "Tipo de bebida:";
            // 
            // tipobebida
            // 
            tipobebida.FormattingEnabled = true;
            tipobebida.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            tipobebida.Location = new Point(17, 64);
            tipobebida.Name = "tipobebida";
            tipobebida.Size = new Size(127, 28);
            tipobebida.TabIndex = 20;
            // 
            // presentacionml
            // 
            presentacionml.FormattingEnabled = true;
            presentacionml.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            presentacionml.Location = new Point(17, 250);
            presentacionml.Name = "presentacionml";
            presentacionml.Size = new Size(156, 28);
            presentacionml.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 213);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 21;
            label7.Text = "Presentacion (ml):";
            // 
            // P_platofuerte
            // 
            this.P_platofuerte.Controls.Add(preciocarne);
            this.P_platofuerte.Controls.Add(this.tipocarne);
            this.P_platofuerte.Controls.Add(acopañamiento);
            this.P_platofuerte.Controls.Add(label8);
            this.P_platofuerte.Controls.Add(label9);
            this.P_platofuerte.Location = new Point(0, 0);
            this.P_platofuerte.Name = "P_platofuerte";
            this.P_platofuerte.Size = new Size(291, 444);
            this.P_platofuerte.TabIndex = 23;
            // 
            // tipocarne
            // 
            this.tipocarne.FormattingEnabled = true;
            this.tipocarne.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            this.tipocarne.Location = new Point(17, 64);
            this.tipocarne.Name = "tipocarne";
            this.tipocarne.Size = new Size(127, 28);
            this.tipocarne.TabIndex = 20;
            // 
            // acopañamiento
            // 
            acopañamiento.FormattingEnabled = true;
            acopañamiento.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            acopañamiento.Location = new Point(17, 157);
            acopañamiento.Name = "acopañamiento";
            acopañamiento.Size = new Size(156, 28);
            acopañamiento.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 28);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 0;
            label8.Text = "Tipo de carne:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 115);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 20;
            label9.Text = "Acompañamiento";
            // 
            // preciobebida
            // 
            preciobebida.AutoSize = true;
            preciobebida.Location = new Point(17, 402);
            preciobebida.Name = "preciobebida";
            preciobebida.Size = new Size(68, 20);
            preciobebida.TabIndex = 23;
            preciobebida.Text = "Precio: Q";
            // 
            // preciocarne
            // 
            preciocarne.AutoSize = true;
            preciocarne.Location = new Point(17, 399);
            preciocarne.Name = "preciocarne";
            preciocarne.Size = new Size(68, 20);
            preciocarne.TabIndex = 24;
            preciocarne.Text = "Precio: Q";
            preciocarne.Click += preciocarne_Click;
            // 
            // Postre
            // 
            Postre.Controls.Add(label4);
            Postre.Controls.Add(presentacion_postre);
            Postre.Controls.Add(label10);
            Postre.Controls.Add(tipopostre);
            Postre.Controls.Add(azucar);
            Postre.Controls.Add(label11);
            Postre.Controls.Add(label12);
            Postre.Location = new Point(26, 186);
            Postre.Name = "Postre";
            Postre.Size = new Size(291, 444);
            Postre.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 396);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 23;
            label4.Text = "Precio: Q";
            label4.Click += label4_Click;
            // 
            // presentacion_postre
            // 
            presentacion_postre.FormattingEnabled = true;
            presentacion_postre.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            presentacion_postre.Location = new Point(17, 250);
            presentacion_postre.Name = "presentacion_postre";
            presentacion_postre.Size = new Size(156, 28);
            presentacion_postre.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 213);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 21;
            label10.Text = "Presentacion:";
            // 
            // tipopostre
            // 
            tipopostre.FormattingEnabled = true;
            tipopostre.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            tipopostre.Location = new Point(17, 64);
            tipopostre.Name = "tipopostre";
            tipopostre.Size = new Size(127, 28);
            tipopostre.TabIndex = 20;
            // 
            // azucar
            // 
            azucar.FormattingEnabled = true;
            azucar.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            azucar.Location = new Point(17, 157);
            azucar.Name = "azucar";
            azucar.Size = new Size(156, 28);
            azucar.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 28);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 0;
            label11.Text = "Tipo de postre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 115);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 20;
            label12.Text = "Contiene azucar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 37);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 1;
            label13.Text = "Tipo:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(36, 138);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label15);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Location = new Point(36, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 444);
            panel1.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 396);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 23;
            label15.Text = "Precio: Q";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox1.Location = new Point(17, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 28);
            comboBox1.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 213);
            label16.Name = "label16";
            label16.Size = new Size(96, 20);
            label16.TabIndex = 21;
            label16.Text = "Presentacion:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox2.Location = new Point(17, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(127, 28);
            comboBox2.TabIndex = 20;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox3.Location = new Point(17, 157);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(156, 28);
            comboBox3.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 28);
            label17.Name = "label17";
            label17.Size = new Size(109, 20);
            label17.TabIndex = 0;
            label17.Text = "Tipo de postre:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 115);
            label18.Name = "label18";
            label18.Size = new Size(118, 20);
            label18.TabIndex = 20;
            label18.Text = "Contiene azucar:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(comboBox6);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(comboBox7);
            panel2.Controls.Add(comboBox8);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(label25);
            panel2.Location = new Point(36, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 444);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Controls.Add(label19);
            panel3.Controls.Add(comboBox4);
            panel3.Controls.Add(comboBox5);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 444);
            panel3.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 399);
            label19.Name = "label19";
            label19.Size = new Size(68, 20);
            label19.TabIndex = 24;
            label19.Text = "Precio: Q";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox4.Location = new Point(17, 64);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(127, 28);
            comboBox4.TabIndex = 20;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox5.Location = new Point(17, 157);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(156, 28);
            comboBox5.TabIndex = 21;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 28);
            label20.Name = "label20";
            label20.Size = new Size(103, 20);
            label20.TabIndex = 0;
            label20.Text = "Tipo de carne:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(17, 115);
            label21.Name = "label21";
            label21.Size = new Size(128, 20);
            label21.TabIndex = 20;
            label21.Text = "Acompañamiento";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(17, 402);
            label22.Name = "label22";
            label22.Size = new Size(68, 20);
            label22.TabIndex = 23;
            label22.Text = "Precio: Q";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox6.Location = new Point(17, 250);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(156, 28);
            comboBox6.TabIndex = 22;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(17, 213);
            label23.Name = "label23";
            label23.Size = new Size(127, 20);
            label23.TabIndex = 21;
            label23.Text = "Presentacion (ml):";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox7.Location = new Point(17, 64);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(127, 28);
            comboBox7.TabIndex = 20;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            comboBox8.Location = new Point(17, 157);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(156, 28);
            comboBox8.TabIndex = 21;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(17, 28);
            label24.Name = "label24";
            label24.Size = new Size(114, 20);
            label24.TabIndex = 0;
            label24.Text = "Tipo de bebida:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(17, 115);
            label25.Name = "label25";
            label25.Size = new Size(64, 20);
            label25.TabIndex = 20;
            label25.Text = "Nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 830);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carrito).EndInit();
            P_bebida.ResumeLayout(false);
            P_bebida.PerformLayout();
            this.P_platofuerte.ResumeLayout(false);
            this.P_platofuerte.PerformLayout();
            Postre.ResumeLayout(false);
            Postre.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private DataGridView carrito;
        private Button button2;
        private Label label2;
        private ComboBox menu;
        private Button button1;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox nombrebebida;
        private Label label5;
        private Panel P_bebida;
        private ComboBox presentacionml;
        private Label label7;
        private ComboBox tipobebida;
        private Label label6;
        private Panel panel1;
        private ComboBox comboBox6;
        private ComboBox acopañamiento;
        private Label label8;
        private Label label9;
        private Label preciobebida;
        private Label preciocarne;
        private Panel Postre;
        private Label label4;
        private ComboBox presentacion_postre;
        private Label label10;
        private ComboBox tipopostre;
        private ComboBox azucar;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label13;
        private TextBox textBox1;
        private Label label15;
        private ComboBox comboBox1;
        private Label label16;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label17;
        private Label label18;
        private Panel panel2;
        private Panel panel3;
        private Label label19;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private Label label24;
        private Label label25;
    }
}
