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
            Postre = new Panel();
            label4 = new Label();
            presentacion_postre = new ComboBox();
            label10 = new Label();
            tipopostre = new ComboBox();
            azucar = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            P_bebida = new Panel();
            P_platofuerte = new Panel();
            preciocarne = new Label();
            tipocarne = new ComboBox();
            acopañamiento = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            preciobebida = new Label();
            presentacionml = new ComboBox();
            label7 = new Label();
            tipobebida = new ComboBox();
            nombrebebida = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            carrito = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            menu = new ComboBox();
            aceptar = new Button();
            label1 = new Label();
            lblPrecioSeleccionado = new Label();
            tabPage2 = new TabPage();
            btnGuardarNuevo = new Button();
            txtPrecioNuevo = new TextBox();
            txtCodigoNuevo = new TextBox();
            cmbNombreNuevo = new ComboBox();
            cmbTipoNuevo = new ComboBox();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label13 = new Label();
            pnlPostreNuevo = new Panel();
            cmbPresentacionPostreNuevo = new ComboBox();
            label16 = new Label();
            cmbAzucarNuevo = new ComboBox();
            label18 = new Label();
            pnlBebidaNuevo = new Panel();
            pnlPlatoNuevo = new Panel();
            cmbCarneNuevo = new ComboBox();
            cmbAcompañamientoNuevo = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            cmbPresentacionBebidaNuevo = new ComboBox();
            label23 = new Label();
            cmbTipoBebidaNuevo = new ComboBox();
            label24 = new Label();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            Postre.SuspendLayout();
            P_bebida.SuspendLayout();
            P_platofuerte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carrito).BeginInit();
            tabPage2.SuspendLayout();
            pnlPostreNuevo.SuspendLayout();
            pnlBebidaNuevo.SuspendLayout();
            pnlPlatoNuevo.SuspendLayout();
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
            tabPage1.Controls.Add(aceptar);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(767, 774);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Menú";
            tabPage1.UseVisualStyleBackColor = true;
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
            // P_bebida
            // 
            P_bebida.Controls.Add(P_platofuerte);
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
            // P_platofuerte
            // 
            P_platofuerte.Controls.Add(preciocarne);
            P_platofuerte.Controls.Add(tipocarne);
            P_platofuerte.Controls.Add(acopañamiento);
            P_platofuerte.Controls.Add(label8);
            P_platofuerte.Controls.Add(label9);
            P_platofuerte.Location = new Point(0, 0);
            P_platofuerte.Name = "P_platofuerte";
            P_platofuerte.Size = new Size(291, 444);
            P_platofuerte.TabIndex = 23;
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
            // tipocarne
            // 
            tipocarne.FormattingEnabled = true;
            tipocarne.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            tipocarne.Location = new Point(17, 64);
            tipocarne.Name = "tipocarne";
            tipocarne.Size = new Size(127, 28);
            tipocarne.TabIndex = 20;
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
            // tipobebida
            // 
            tipobebida.FormattingEnabled = true;
            tipobebida.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            tipobebida.Location = new Point(17, 64);
            tipobebida.Name = "tipobebida";
            tipobebida.Size = new Size(127, 28);
            tipobebida.TabIndex = 20;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 28);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 0;
            label6.Text = "Tipo de bebida:";
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
            // aceptar
            // 
            aceptar.Location = new Point(26, 636);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(94, 29);
            aceptar.TabIndex = 11;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioSeleccionado
            // 
            lblPrecioSeleccionado.AutoSize = true;
            lblPrecioSeleccionado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrecioSeleccionado.Location = new Point(135, 636);
            lblPrecioSeleccionado.Name = "lblPrecioSeleccionado";
            lblPrecioSeleccionado.Size = new Size(130, 28);
            lblPrecioSeleccionado.TabIndex = 25;
            lblPrecioSeleccionado.Text = "Precio: Q0.00";
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
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGuardarNuevo);
            tabPage2.Controls.Add(txtPrecioNuevo);
            tabPage2.Controls.Add(txtCodigoNuevo);
            tabPage2.Controls.Add(cmbNombreNuevo);
            tabPage2.Controls.Add(cmbTipoNuevo);
            tabPage2.Controls.Add(label28);
            tabPage2.Controls.Add(label27);
            tabPage2.Controls.Add(label26);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(pnlPostreNuevo);
            tabPage2.Controls.Add(pnlBebidaNuevo);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(767, 774);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlPostreNuevo
            // 
            pnlPostreNuevo.Controls.Add(cmbPresentacionPostreNuevo);
            pnlPostreNuevo.Controls.Add(label16);
            pnlPostreNuevo.Controls.Add(cmbAzucarNuevo);
            pnlPostreNuevo.Controls.Add(label18);
            pnlPostreNuevo.Location = new Point(36, 250);
            pnlPostreNuevo.Name = "pnlPostreNuevo";
            pnlPostreNuevo.Size = new Size(291, 250);
            pnlPostreNuevo.TabIndex = 26;
            // 
            // cmbPresentacionPostreNuevo
            // 
            cmbPresentacionPostreNuevo.FormattingEnabled = true;
            cmbPresentacionPostreNuevo.Location = new Point(17, 120);
            cmbPresentacionPostreNuevo.Name = "cmbPresentacionPostreNuevo";
            cmbPresentacionPostreNuevo.Size = new Size(156, 28);
            cmbPresentacionPostreNuevo.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 85);
            label16.Name = "label16";
            label16.Size = new Size(96, 20);
            label16.TabIndex = 21;
            label16.Text = "Presentacion:";
            // 
            // cmbAzucarNuevo
            // 
            cmbAzucarNuevo.FormattingEnabled = true;
            cmbAzucarNuevo.Location = new Point(17, 40);
            cmbAzucarNuevo.Name = "cmbAzucarNuevo";
            cmbAzucarNuevo.Size = new Size(156, 28);
            cmbAzucarNuevo.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 15);
            label18.Name = "label18";
            label18.Size = new Size(118, 20);
            label18.TabIndex = 20;
            label18.Text = "Contiene azucar:";
            // 
            // pnlBebidaNuevo
            // 
            pnlBebidaNuevo.Controls.Add(pnlPlatoNuevo);
            pnlBebidaNuevo.Controls.Add(cmbPresentacionBebidaNuevo);
            pnlBebidaNuevo.Controls.Add(label23);
            pnlBebidaNuevo.Controls.Add(cmbTipoBebidaNuevo);
            pnlBebidaNuevo.Controls.Add(label24);
            pnlBebidaNuevo.Location = new Point(36, 250);
            pnlBebidaNuevo.Name = "pnlBebidaNuevo";
            pnlBebidaNuevo.Size = new Size(291, 250);
            pnlBebidaNuevo.TabIndex = 25;
            // 
            // pnlPlatoNuevo
            // 
            pnlPlatoNuevo.Controls.Add(cmbCarneNuevo);
            pnlPlatoNuevo.Controls.Add(cmbAcompañamientoNuevo);
            pnlPlatoNuevo.Controls.Add(label20);
            pnlPlatoNuevo.Controls.Add(label21);
            pnlPlatoNuevo.Location = new Point(0, 0);
            pnlPlatoNuevo.Name = "pnlPlatoNuevo";
            pnlPlatoNuevo.Size = new Size(291, 250);
            pnlPlatoNuevo.TabIndex = 23;
            // 
            // cmbCarneNuevo
            // 
            cmbCarneNuevo.FormattingEnabled = true;
            cmbCarneNuevo.Location = new Point(17, 40);
            cmbCarneNuevo.Name = "cmbCarneNuevo";
            cmbCarneNuevo.Size = new Size(127, 28);
            cmbCarneNuevo.TabIndex = 20;
            // 
            // cmbAcompañamientoNuevo
            // 
            cmbAcompañamientoNuevo.FormattingEnabled = true;
            cmbAcompañamientoNuevo.Location = new Point(17, 120);
            cmbAcompañamientoNuevo.Name = "cmbAcompañamientoNuevo";
            cmbAcompañamientoNuevo.Size = new Size(156, 28);
            cmbAcompañamientoNuevo.TabIndex = 21;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 15);
            label20.Name = "label20";
            label20.Size = new Size(103, 20);
            label20.TabIndex = 0;
            label20.Text = "Tipo de carne:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(17, 85);
            label21.Name = "label21";
            label21.Size = new Size(128, 20);
            label21.TabIndex = 20;
            label21.Text = "Acompañamiento";
            // 
            // cmbPresentacionBebidaNuevo
            // 
            cmbPresentacionBebidaNuevo.FormattingEnabled = true;
            cmbPresentacionBebidaNuevo.Location = new Point(17, 120);
            cmbPresentacionBebidaNuevo.Name = "cmbPresentacionBebidaNuevo";
            cmbPresentacionBebidaNuevo.Size = new Size(156, 28);
            cmbPresentacionBebidaNuevo.TabIndex = 22;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(17, 85);
            label23.Name = "label23";
            label23.Size = new Size(127, 20);
            label23.TabIndex = 21;
            label23.Text = "Presentacion (ml):";
            // 
            // cmbTipoBebidaNuevo
            // 
            cmbTipoBebidaNuevo.FormattingEnabled = true;
            cmbTipoBebidaNuevo.Location = new Point(17, 40);
            cmbTipoBebidaNuevo.Name = "cmbTipoBebidaNuevo";
            cmbTipoBebidaNuevo.Size = new Size(127, 28);
            cmbTipoBebidaNuevo.TabIndex = 20;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(17, 15);
            label24.Name = "label24";
            label24.Size = new Size(114, 20);
            label24.TabIndex = 0;
            label24.Text = "Tipo de bebida:";
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Location = new Point(36, 520);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(120, 40);
            btnGuardarNuevo.TabIndex = 30;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            // 
            // txtPrecioNuevo
            // 
            txtPrecioNuevo.Location = new Point(200, 150);
            txtPrecioNuevo.Name = "txtPrecioNuevo";
            txtPrecioNuevo.Size = new Size(125, 27);
            txtPrecioNuevo.TabIndex = 29;
            // 
            // txtCodigoNuevo
            // 
            txtCodigoNuevo.Location = new Point(36, 150);
            txtCodigoNuevo.Name = "txtCodigoNuevo";
            txtCodigoNuevo.Size = new Size(125, 27);
            txtCodigoNuevo.TabIndex = 28;
            // 
            // cmbNombreNuevo
            // 
            cmbNombreNuevo.FormattingEnabled = true;
            cmbNombreNuevo.Location = new Point(200, 70);
            cmbNombreNuevo.Name = "cmbNombreNuevo";
            cmbNombreNuevo.Size = new Size(150, 28);
            cmbNombreNuevo.TabIndex = 27;
            // 
            // cmbTipoNuevo
            // 
            cmbTipoNuevo.FormattingEnabled = true;
            cmbTipoNuevo.Items.AddRange(new object[] { "Bebida", "Plato fuerte", "Postre" });
            cmbTipoNuevo.Location = new Point(36, 70);
            cmbTipoNuevo.Name = "cmbTipoNuevo";
            cmbTipoNuevo.Size = new Size(125, 28);
            cmbTipoNuevo.TabIndex = 0;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(200, 120);
            label28.Name = "label28";
            label28.Size = new Size(53, 20);
            label28.TabIndex = 33;
            label28.Text = "Precio:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(36, 120);
            label27.Name = "label27";
            label27.Size = new Size(61, 20);
            label27.TabIndex = 32;
            label27.Text = "Código:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(200, 40);
            label26.Name = "label26";
            label26.Size = new Size(67, 20);
            label26.TabIndex = 31;
            label26.Text = "Nombre:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 40);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 1;
            label13.Text = "Tipo:";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(767, 774);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Buscar";
            tabPage3.UseVisualStyleBackColor = true;
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
            Postre.ResumeLayout(false);
            Postre.PerformLayout();
            P_bebida.ResumeLayout(false);
            P_bebida.PerformLayout();
            P_platofuerte.ResumeLayout(false);
            P_platofuerte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carrito).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pnlPostreNuevo.ResumeLayout(false);
            pnlPostreNuevo.PerformLayout();
            pnlBebidaNuevo.ResumeLayout(false);
            pnlBebidaNuevo.PerformLayout();
            pnlPlatoNuevo.ResumeLayout(false);
            pnlPlatoNuevo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox tipocarne;
        private Panel P_platofuerte;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private DataGridView carrito;
        private Button button2;
        private Label label2;
        private ComboBox menu;
        private Button aceptar;
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
        private Label label13;
        private Label lblPrecioSeleccionado;

        // Nuevos controles para pestaña Agregar
        private ComboBox cmbTipoNuevo;
        private ComboBox cmbNombreNuevo;
        private TextBox txtCodigoNuevo;
        private TextBox txtPrecioNuevo;
        private Button btnGuardarNuevo;
        private Label label26;
        private Label label27;
        private Label label28;
        
        private Panel pnlBebidaNuevo;
        private ComboBox cmbTipoBebidaNuevo;
        private ComboBox cmbPresentacionBebidaNuevo;
        private Label label24;
        private Label label23;

        private Panel pnlPlatoNuevo;
        private ComboBox cmbCarneNuevo;
        private ComboBox cmbAcompañamientoNuevo;
        private Label label20;
        private Label label21;

        private Panel pnlPostreNuevo;
        private ComboBox cmbAzucarNuevo;
        private ComboBox cmbPresentacionPostreNuevo;
        private Label label18;
        private Label label16;
    }
}
