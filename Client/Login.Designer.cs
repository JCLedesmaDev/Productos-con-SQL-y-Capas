namespace Client
{
    partial class Login
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
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabC_Producto = new System.Windows.Forms.TabControl();
            this.tabC_Control = new System.Windows.Forms.TabPage();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btCargar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_StockMov = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.rbEgreso = new System.Windows.Forms.RadioButton();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripMov = new System.Windows.Forms.Label();
            this.lblCodigoMov = new System.Windows.Forms.Label();
            this.navLoginRegistro = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.MASKEDTXTUSUARIO = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.maskedemailRegister = new System.Windows.Forms.MaskedTextBox();
            this.txtRepeContra = new System.Windows.Forms.TextBox();
            this.txtContraRegister = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lBLREPCONTRA = new System.Windows.Forms.Label();
            this.lBLCONTRA = new System.Windows.Forms.Label();
            this.lBLNOMYAPELL = new System.Windows.Forms.Label();
            this.lBLEMAIL = new System.Windows.Forms.Label();
            this.btnregistro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.panel1.SuspendLayout();
            this.tabC_Producto.SuspendLayout();
            this.tabC_Control.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.navLoginRegistro.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(193, 191);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(199, 22);
            this.txtcontraseña.TabIndex = 0;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(147, 330);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(183, 49);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Iniciar Sesión";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(33, 63);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 16);
            this.lblusuario.TabIndex = 3;
            this.lblusuario.Text = "EMAIL";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(33, 199);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(101, 16);
            this.lblcontraseña.TabIndex = 4;
            this.lblcontraseña.Text = "CONTRASEÑA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = global::Client.Properties.Resources.logo_JV;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tabC_Producto);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 569);
            this.panel1.TabIndex = 5;
            // 
            // tabC_Producto
            // 
            this.tabC_Producto.Controls.Add(this.tabC_Control);
            this.tabC_Producto.Controls.Add(this.tabPage2);
            this.tabC_Producto.Location = new System.Drawing.Point(441, 79);
            this.tabC_Producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabC_Producto.Name = "tabC_Producto";
            this.tabC_Producto.SelectedIndex = 0;
            this.tabC_Producto.Size = new System.Drawing.Size(535, 262);
            this.tabC_Producto.TabIndex = 10;
            // 
            // tabC_Control
            // 
            this.tabC_Control.Controls.Add(this.lblCodigo);
            this.tabC_Control.Controls.Add(this.lblDescripcion);
            this.tabC_Control.Controls.Add(this.btCargar);
            this.tabC_Control.Controls.Add(this.txtStock);
            this.tabC_Control.Controls.Add(this.lblStock);
            this.tabC_Control.Controls.Add(this.txtDescripcion);
            this.tabC_Control.Controls.Add(this.txtCodigo);
            this.tabC_Control.Location = new System.Drawing.Point(4, 25);
            this.tabC_Control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabC_Control.Name = "tabC_Control";
            this.tabC_Control.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabC_Control.Size = new System.Drawing.Size(527, 233);
            this.tabC_Control.TabIndex = 0;
            this.tabC_Control.Text = "Carga de Productos";
            this.tabC_Control.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(48, 57);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(48, 107);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(703, 153);
            this.btCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(100, 28);
            this.btCargar.TabIndex = 3;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(188, 156);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(257, 22);
            this.txtStock.TabIndex = 6;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(55, 165);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(188, 98);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(257, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(188, 48);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(257, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_StockMov);
            this.tabPage2.Controls.Add(this.btAceptar);
            this.tabPage2.Controls.Add(this.rbEgreso);
            this.tabPage2.Controls.Add(this.rbIngreso);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.lblCantidad);
            this.tabPage2.Controls.Add(this.lblDescripMov);
            this.tabPage2.Controls.Add(this.lblCodigoMov);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(527, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimiento de productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_StockMov
            // 
            this.lbl_StockMov.AutoSize = true;
            this.lbl_StockMov.Location = new System.Drawing.Point(75, 103);
            this.lbl_StockMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StockMov.Name = "lbl_StockMov";
            this.lbl_StockMov.Size = new System.Drawing.Size(44, 16);
            this.lbl_StockMov.TabIndex = 7;
            this.lbl_StockMov.Text = "label2";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(660, 160);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(115, 36);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // rbEgreso
            // 
            this.rbEgreso.AutoSize = true;
            this.rbEgreso.Location = new System.Drawing.Point(484, 118);
            this.rbEgreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEgreso.Name = "rbEgreso";
            this.rbEgreso.Size = new System.Drawing.Size(72, 20);
            this.rbEgreso.TabIndex = 5;
            this.rbEgreso.TabStop = true;
            this.rbEgreso.Text = "Egreso";
            this.rbEgreso.UseVisualStyleBackColor = true;
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Location = new System.Drawing.Point(461, 59);
            this.rbIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(73, 20);
            this.rbIngreso.TabIndex = 4;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "Ingreso";
            this.rbIngreso.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(193, 160);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(199, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(75, 164);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripMov
            // 
            this.lblDescripMov.AutoSize = true;
            this.lblDescripMov.Location = new System.Drawing.Point(75, 64);
            this.lblDescripMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripMov.Name = "lblDescripMov";
            this.lblDescripMov.Size = new System.Drawing.Size(44, 16);
            this.lblDescripMov.TabIndex = 1;
            this.lblDescripMov.Text = "label2";
            // 
            // lblCodigoMov
            // 
            this.lblCodigoMov.AutoSize = true;
            this.lblCodigoMov.Location = new System.Drawing.Point(75, 27);
            this.lblCodigoMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMov.Name = "lblCodigoMov";
            this.lblCodigoMov.Size = new System.Drawing.Size(44, 16);
            this.lblCodigoMov.TabIndex = 0;
            this.lblCodigoMov.Text = "label1";
            // 
            // navLoginRegistro
            // 
            this.navLoginRegistro.Controls.Add(this.tabLogin);
            this.navLoginRegistro.Controls.Add(this.tabRegistro);
            this.navLoginRegistro.Location = new System.Drawing.Point(455, 44);
            this.navLoginRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navLoginRegistro.Name = "navLoginRegistro";
            this.navLoginRegistro.SelectedIndex = 0;
            this.navLoginRegistro.Size = new System.Drawing.Size(489, 480);
            this.navLoginRegistro.TabIndex = 10;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.DarkGray;
            this.tabLogin.Controls.Add(this.MASKEDTXTUSUARIO);
            this.tabLogin.Controls.Add(this.button2);
            this.tabLogin.Controls.Add(this.lblcontraseña);
            this.tabLogin.Controls.Add(this.txtcontraseña);
            this.tabLogin.Controls.Add(this.lblusuario);
            this.tabLogin.Controls.Add(this.radioButton1);
            this.tabLogin.Controls.Add(this.btnlogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 25);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLogin.Size = new System.Drawing.Size(481, 451);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "INICIO DE SESION";
            // 
            // MASKEDTXTUSUARIO
            // 
            this.MASKEDTXTUSUARIO.Location = new System.Drawing.Point(193, 64);
            this.MASKEDTXTUSUARIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MASKEDTXTUSUARIO.Mask = "LLLLLL000@LLLLL.LLL";
            this.MASKEDTXTUSUARIO.Name = "MASKEDTXTUSUARIO";
            this.MASKEDTXTUSUARIO.Size = new System.Drawing.Size(199, 22);
            this.MASKEDTXTUSUARIO.TabIndex = 7;
            this.MASKEDTXTUSUARIO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(484, 118);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 20);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Egreso";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabRegistro
            // 
            this.tabRegistro.BackColor = System.Drawing.Color.DarkGray;
            this.tabRegistro.Controls.Add(this.maskedemailRegister);
            this.tabRegistro.Controls.Add(this.txtRepeContra);
            this.tabRegistro.Controls.Add(this.txtContraRegister);
            this.tabRegistro.Controls.Add(this.txtNombreCompleto);
            this.tabRegistro.Controls.Add(this.lBLREPCONTRA);
            this.tabRegistro.Controls.Add(this.lBLCONTRA);
            this.tabRegistro.Controls.Add(this.lBLNOMYAPELL);
            this.tabRegistro.Controls.Add(this.lBLEMAIL);
            this.tabRegistro.Controls.Add(this.btnregistro);
            this.tabRegistro.Controls.Add(this.button1);
            this.tabRegistro.Location = new System.Drawing.Point(4, 25);
            this.tabRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRegistro.Size = new System.Drawing.Size(481, 451);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "REGISTRARSE";
            // 
            // maskedemailRegister
            // 
            this.maskedemailRegister.Location = new System.Drawing.Point(240, 43);
            this.maskedemailRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedemailRegister.Mask = "LLLLLL000@LLLLL.LLL";
            this.maskedemailRegister.Name = "maskedemailRegister";
            this.maskedemailRegister.Size = new System.Drawing.Size(199, 22);
            this.maskedemailRegister.TabIndex = 11;
            // 
            // txtRepeContra
            // 
            this.txtRepeContra.Location = new System.Drawing.Point(240, 246);
            this.txtRepeContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepeContra.Name = "txtRepeContra";
            this.txtRepeContra.PasswordChar = '*';
            this.txtRepeContra.Size = new System.Drawing.Size(199, 22);
            this.txtRepeContra.TabIndex = 12;
            // 
            // txtContraRegister
            // 
            this.txtContraRegister.Location = new System.Drawing.Point(240, 175);
            this.txtContraRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraRegister.Name = "txtContraRegister";
            this.txtContraRegister.PasswordChar = '*';
            this.txtContraRegister.Size = new System.Drawing.Size(199, 22);
            this.txtContraRegister.TabIndex = 11;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(240, 107);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(199, 22);
            this.txtNombreCompleto.TabIndex = 10;
            // 
            // lBLREPCONTRA
            // 
            this.lBLREPCONTRA.AutoSize = true;
            this.lBLREPCONTRA.Location = new System.Drawing.Point(33, 255);
            this.lBLREPCONTRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBLREPCONTRA.Name = "lBLREPCONTRA";
            this.lBLREPCONTRA.Size = new System.Drawing.Size(163, 16);
            this.lBLREPCONTRA.TabIndex = 8;
            this.lBLREPCONTRA.Text = "REPETIR CONTRASEÑA";
            // 
            // lBLCONTRA
            // 
            this.lBLCONTRA.AutoSize = true;
            this.lBLCONTRA.Location = new System.Drawing.Point(33, 183);
            this.lBLCONTRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBLCONTRA.Name = "lBLCONTRA";
            this.lBLCONTRA.Size = new System.Drawing.Size(101, 16);
            this.lBLCONTRA.TabIndex = 7;
            this.lBLCONTRA.Text = "CONTRASEÑA";
            // 
            // lBLNOMYAPELL
            // 
            this.lBLNOMYAPELL.AutoSize = true;
            this.lBLNOMYAPELL.Location = new System.Drawing.Point(33, 116);
            this.lBLNOMYAPELL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBLNOMYAPELL.Name = "lBLNOMYAPELL";
            this.lBLNOMYAPELL.Size = new System.Drawing.Size(145, 16);
            this.lBLNOMYAPELL.TabIndex = 6;
            this.lBLNOMYAPELL.Text = "NOMBRE Y APELLIDO";
            // 
            // lBLEMAIL
            // 
            this.lBLEMAIL.AutoSize = true;
            this.lBLEMAIL.Location = new System.Drawing.Point(33, 39);
            this.lBLEMAIL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBLEMAIL.Name = "lBLEMAIL";
            this.lBLEMAIL.Size = new System.Drawing.Size(46, 16);
            this.lBLEMAIL.TabIndex = 5;
            this.lBLEMAIL.Text = "EMAIL";
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(140, 329);
            this.btnregistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(183, 49);
            this.btnregistro.TabIndex = 4;
            this.btnregistro.Text = "Registrarse";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(960, 561);
            this.Controls.Add(this.navLoginRegistro);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.tabC_Producto.ResumeLayout(false);
            this.tabC_Control.ResumeLayout(false);
            this.tabC_Control.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.navLoginRegistro.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabC_Producto;
        private System.Windows.Forms.TabPage tabC_Control;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_StockMov;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.RadioButton rbEgreso;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripMov;
        private System.Windows.Forms.Label lblCodigoMov;
        private System.Windows.Forms.TabControl navLoginRegistro;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtRepeContra;
        private System.Windows.Forms.TextBox txtContraRegister;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lBLREPCONTRA;
        private System.Windows.Forms.Label lBLCONTRA;
        private System.Windows.Forms.Label lBLNOMYAPELL;
        private System.Windows.Forms.Label lBLEMAIL;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.MaskedTextBox MASKEDTXTUSUARIO;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.MaskedTextBox maskedemailRegister;
    }
}