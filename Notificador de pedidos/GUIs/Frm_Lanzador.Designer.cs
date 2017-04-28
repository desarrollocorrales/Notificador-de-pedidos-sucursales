namespace Notificador_de_pedidos.GUIs
{
    partial class Frm_Lanzador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Lanzador));
            this.alrtPedidos = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tmAccion = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txbSegundos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargarSucursales = new System.Windows.Forms.Button();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbBasesDeDatos = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPuerto = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.niIcono = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.bgwConsultar = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alrtPedidos
            // 
            this.alrtPedidos.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alrtPedidos.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.alrtPedidos.AppearanceCaption.Options.UseFont = true;
            this.alrtPedidos.AppearanceCaption.Options.UseForeColor = true;
            this.alrtPedidos.AppearanceCaption.Options.UseTextOptions = true;
            this.alrtPedidos.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alrtPedidos.AppearanceHotTrackedText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alrtPedidos.AppearanceHotTrackedText.ForeColor = System.Drawing.Color.Blue;
            this.alrtPedidos.AppearanceHotTrackedText.Options.UseFont = true;
            this.alrtPedidos.AppearanceHotTrackedText.Options.UseForeColor = true;
            this.alrtPedidos.AppearanceHotTrackedText.Options.UseTextOptions = true;
            this.alrtPedidos.AppearanceHotTrackedText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alrtPedidos.AppearanceText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alrtPedidos.AppearanceText.ForeColor = System.Drawing.Color.DarkBlue;
            this.alrtPedidos.AppearanceText.Options.UseFont = true;
            this.alrtPedidos.AppearanceText.Options.UseForeColor = true;
            this.alrtPedidos.AppearanceText.Options.UseTextOptions = true;
            this.alrtPedidos.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alrtPedidos.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alrtPedidos.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.alrtPedidos.FormMaxCount = 5;
            this.alrtPedidos.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alrtPedidos.LookAndFeel.SkinName = "Caramel";
            this.alrtPedidos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.alrtPedidos.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.alrtPedidos_AlertClick);
            this.alrtPedidos.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.alrtPedidos_BeforeFormShow);
            // 
            // tmAccion
            // 
            this.tmAccion.Interval = 5000;
            this.tmAccion.Tick += new System.EventHandler(this.tmAccion_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar la ventana cada:";
            // 
            // txbSegundos
            // 
            this.txbSegundos.Location = new System.Drawing.Point(272, 51);
            this.txbSegundos.Name = "txbSegundos";
            this.txbSegundos.Size = new System.Drawing.Size(75, 26);
            this.txbSegundos.TabIndex = 1;
            this.txbSegundos.Text = "120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "segundos";
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(126, 83);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(397, 26);
            this.txbURL.TabIndex = 4;
            this.txbURL.Text = "http://loscorrales.com.mx/sistema/pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL de pedidos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargarSucursales);
            this.groupBox1.Controls.Add(this.cmbSucursales);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.cmbBasesDeDatos);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbPuerto);
            this.groupBox1.Controls.Add(this.txbContraseña);
            this.groupBox1.Controls.Add(this.txbUsuario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbServidor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 272);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de datos";
            // 
            // btnCargarSucursales
            // 
            this.btnCargarSucursales.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarSucursales.Location = new System.Drawing.Point(431, 189);
            this.btnCargarSucursales.Name = "btnCargarSucursales";
            this.btnCargarSucursales.Size = new System.Drawing.Size(59, 28);
            this.btnCargarSucursales.TabIndex = 20;
            this.btnCargarSucursales.Text = "Cargar";
            this.btnCargarSucursales.UseVisualStyleBackColor = true;
            this.btnCargarSucursales.Click += new System.EventHandler(this.btnCargarSucursales_Click);
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(123, 190);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(302, 26);
            this.cmbSucursales.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Sucursal:";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(431, 157);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(59, 28);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbBasesDeDatos
            // 
            this.cmbBasesDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBasesDeDatos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBasesDeDatos.FormattingEnabled = true;
            this.cmbBasesDeDatos.Location = new System.Drawing.Point(123, 158);
            this.cmbBasesDeDatos.Name = "cmbBasesDeDatos";
            this.cmbBasesDeDatos.Size = new System.Drawing.Size(302, 26);
            this.cmbBasesDeDatos.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Notificador_de_pedidos.Properties.Resources.save_26;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(208, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 36);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Puerto:";
            // 
            // txbPuerto
            // 
            this.txbPuerto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPuerto.Location = new System.Drawing.Point(123, 126);
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(80, 26);
            this.txbPuerto.TabIndex = 12;
            this.txbPuerto.Text = "3306";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Location = new System.Drawing.Point(123, 94);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(191, 26);
            this.txbContraseña.TabIndex = 11;
            this.txbContraseña.Text = "acceso.2016";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(123, 62);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(191, 26);
            this.txbUsuario.TabIndex = 10;
            this.txbUsuario.Text = "corrales_tablero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Base de datos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Usuario:";
            // 
            // txbServidor
            // 
            this.txbServidor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServidor.Location = new System.Drawing.Point(123, 30);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(367, 26);
            this.txbServidor.TabIndex = 6;
            this.txbServidor.Text = "loscorrales.com.mx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Servidor:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(534, 40);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Configuración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mostrar ventanas cada:";
            // 
            // niIcono
            // 
            this.niIcono.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niIcono.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcono.Icon")));
            this.niIcono.Text = "Notificador de Pedidos";
            this.niIcono.Visible = true;
            this.niIcono.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niIcono_MouseDoubleClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(493, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 30);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bgwConsultar
            // 
            this.bgwConsultar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsultar_DoWork);
            this.bgwConsultar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsultar_RunWorkerCompleted);
            // 
            // Frm_Lanzador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 401);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSegundos);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 440);
            this.MinimumSize = new System.Drawing.Size(550, 440);
            this.Name = "Frm_Lanzador";
            this.Text = "Notificaciones de pedidos";
            this.Load += new System.EventHandler(this.Frm_Lanzador_Load);
            this.Shown += new System.EventHandler(this.Frm_Lanzador_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl alrtPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSegundos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbPuerto;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbBasesDeDatos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon niIcono;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCargarSucursales;
        public System.Windows.Forms.Timer tmAccion;
        private System.ComponentModel.BackgroundWorker bgwConsultar;
    }
}