
namespace HotelHome.UI
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panelSubReportes = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelSubMantenimiento = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.StatusRoom = new System.Windows.Forms.Button();
            this.btnPiso = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.panelSubGestor = new System.Windows.Forms.Panel();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnRecepcion = new System.Windows.Forms.Button();
            this.btnGestor = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.panelSubMantenimiento.SuspendLayout();
            this.panelSubGestor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.btnSalir);
            this.PanelMenu.Controls.Add(this.btnAyuda);
            this.PanelMenu.Controls.Add(this.btnUsuario);
            this.PanelMenu.Controls.Add(this.panelSubReportes);
            this.PanelMenu.Controls.Add(this.btnReportes);
            this.PanelMenu.Controls.Add(this.panelSubMantenimiento);
            this.PanelMenu.Controls.Add(this.btnMantenimiento);
            this.PanelMenu.Controls.Add(this.panelSubGestor);
            this.PanelMenu.Controls.Add(this.btnGestor);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(250, 665);
            this.PanelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 657);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ayuda ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(0, 702);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(233, 143);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.Location = new System.Drawing.Point(0, 612);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(233, 45);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Consultas";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.Location = new System.Drawing.Point(0, 567);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(233, 45);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panelSubReportes
            // 
            this.panelSubReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panelSubReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubReportes.Location = new System.Drawing.Point(0, 522);
            this.panelSubReportes.Name = "panelSubReportes";
            this.panelSubReportes.Size = new System.Drawing.Size(233, 45);
            this.panelSubReportes.TabIndex = 5;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.Location = new System.Drawing.Point(0, 477);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(233, 45);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes ";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSubMantenimiento
            // 
            this.panelSubMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panelSubMantenimiento.Controls.Add(this.btnCliente);
            this.panelSubMantenimiento.Controls.Add(this.StatusRoom);
            this.panelSubMantenimiento.Controls.Add(this.btnPiso);
            this.panelSubMantenimiento.Controls.Add(this.btnCategorias);
            this.panelSubMantenimiento.Controls.Add(this.btnHabitaciones);
            this.panelSubMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMantenimiento.Location = new System.Drawing.Point(0, 272);
            this.panelSubMantenimiento.Name = "panelSubMantenimiento";
            this.panelSubMantenimiento.Size = new System.Drawing.Size(233, 205);
            this.panelSubMantenimiento.TabIndex = 3;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.Location = new System.Drawing.Point(0, 160);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(233, 45);
            this.btnCliente.TabIndex = 8;
            this.btnCliente.Text = "Cliente ";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // StatusRoom
            // 
            this.StatusRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusRoom.FlatAppearance.BorderSize = 0;
            this.StatusRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusRoom.ForeColor = System.Drawing.Color.LightGray;
            this.StatusRoom.Image = ((System.Drawing.Image)(resources.GetObject("StatusRoom.Image")));
            this.StatusRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatusRoom.Location = new System.Drawing.Point(0, 120);
            this.StatusRoom.Name = "StatusRoom";
            this.StatusRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.StatusRoom.Size = new System.Drawing.Size(233, 40);
            this.StatusRoom.TabIndex = 4;
            this.StatusRoom.Text = "StatusRoom";
            this.StatusRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusRoom.UseVisualStyleBackColor = true;
            this.StatusRoom.Click += new System.EventHandler(this.StatusRoom_Click);
            // 
            // btnPiso
            // 
            this.btnPiso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPiso.FlatAppearance.BorderSize = 0;
            this.btnPiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPiso.ForeColor = System.Drawing.Color.LightGray;
            this.btnPiso.Image = ((System.Drawing.Image)(resources.GetObject("btnPiso.Image")));
            this.btnPiso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPiso.Location = new System.Drawing.Point(0, 80);
            this.btnPiso.Name = "btnPiso";
            this.btnPiso.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPiso.Size = new System.Drawing.Size(233, 40);
            this.btnPiso.TabIndex = 3;
            this.btnPiso.Text = "Piso";
            this.btnPiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPiso.UseVisualStyleBackColor = true;
            this.btnPiso.Click += new System.EventHandler(this.btnPiso_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.LightGray;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategorias.Location = new System.Drawing.Point(0, 40);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(233, 40);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias ";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.ForeColor = System.Drawing.Color.LightGray;
            this.btnHabitaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnHabitaciones.Image")));
            this.btnHabitaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHabitaciones.Location = new System.Drawing.Point(0, 0);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHabitaciones.Size = new System.Drawing.Size(233, 40);
            this.btnHabitaciones.TabIndex = 1;
            this.btnHabitaciones.Text = "Habitaciones ";
            this.btnHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 227);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMantenimiento.Size = new System.Drawing.Size(233, 45);
            this.btnMantenimiento.TabIndex = 2;
            this.btnMantenimiento.Text = "Mantenimiento ";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // panelSubGestor
            // 
            this.panelSubGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panelSubGestor.Controls.Add(this.btnSalida);
            this.panelSubGestor.Controls.Add(this.btnRecepcion);
            this.panelSubGestor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGestor.Location = new System.Drawing.Point(0, 145);
            this.panelSubGestor.Name = "panelSubGestor";
            this.panelSubGestor.Size = new System.Drawing.Size(233, 82);
            this.panelSubGestor.TabIndex = 1;
            // 
            // btnSalida
            // 
            this.btnSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnSalida.Image")));
            this.btnSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalida.Location = new System.Drawing.Point(0, 40);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSalida.Size = new System.Drawing.Size(233, 42);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "Vista ";
            this.btnSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecepcion.FlatAppearance.BorderSize = 0;
            this.btnRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepcion.ForeColor = System.Drawing.Color.LightGray;
            this.btnRecepcion.Image = ((System.Drawing.Image)(resources.GetObject("btnRecepcion.Image")));
            this.btnRecepcion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecepcion.Location = new System.Drawing.Point(0, 0);
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRecepcion.Size = new System.Drawing.Size(233, 40);
            this.btnRecepcion.TabIndex = 1;
            this.btnRecepcion.Text = "Recepcion";
            this.btnRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecepcion.UseVisualStyleBackColor = true;
            this.btnRecepcion.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // btnGestor
            // 
            this.btnGestor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestor.FlatAppearance.BorderSize = 0;
            this.btnGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestor.Image = ((System.Drawing.Image)(resources.GetObject("btnGestor.Image")));
            this.btnGestor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestor.Location = new System.Drawing.Point(0, 100);
            this.btnGestor.Name = "btnGestor";
            this.btnGestor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestor.Size = new System.Drawing.Size(233, 45);
            this.btnGestor.TabIndex = 1;
            this.btnGestor.Text = "Gestor ";
            this.btnGestor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestor.UseVisualStyleBackColor = true;
            this.btnGestor.Click += new System.EventHandler(this.btnGestor_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLogo.BackgroundImage")));
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(233, 100);
            this.PanelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(250, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 143);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Chocolate;
            this.lblFecha.Location = new System.Drawing.Point(57, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 31);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblHora.Location = new System.Drawing.Point(57, 15);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(129, 55);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // panelFormulario
            // 
            this.panelFormulario.AutoSize = true;
            this.panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelFormulario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFormulario.BackgroundImage")));
            this.panelFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFormulario.Controls.Add(this.textBox1);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormulario.Location = new System.Drawing.Point(250, 0);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(8);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(792, 522);
            this.panelFormulario.TabIndex = 2;
            this.panelFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormulario_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox1.Location = new System.Drawing.Point(143, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Hotel Home";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1042, 665);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Hotelero (Hotel Home)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load_2);
            this.PanelMenu.ResumeLayout(false);
            this.panelSubMantenimiento.ResumeLayout(false);
            this.panelSubGestor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelSubGestor;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnRecepcion;
        private System.Windows.Forms.Button btnGestor;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panelSubReportes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelSubMantenimiento;
        private System.Windows.Forms.Button btnPiso;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Button StatusRoom;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button button1;
    }
}

