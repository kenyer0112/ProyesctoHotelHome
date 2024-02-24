
namespace HotelHome.Reportes
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnDisponibles = new System.Windows.Forms.Button();
            this.btnNodisponible = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.ForeColor = System.Drawing.Color.DarkGray;
            this.btnHabitaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnHabitaciones.Image")));
            this.btnHabitaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHabitaciones.Location = new System.Drawing.Point(102, 94);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(188, 100);
            this.btnHabitaciones.TabIndex = 0;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.DarkGray;
            this.btnReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnReservas.Image")));
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservas.Location = new System.Drawing.Point(312, 94);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(188, 100);
            this.btnReservas.TabIndex = 1;
            this.btnReservas.Text = "Reporte Reserva";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnDisponibles
            // 
            this.btnDisponibles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibles.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDisponibles.Location = new System.Drawing.Point(525, 94);
            this.btnDisponibles.Name = "btnDisponibles";
            this.btnDisponibles.Size = new System.Drawing.Size(188, 100);
            this.btnDisponibles.TabIndex = 2;
            this.btnDisponibles.Text = "Habitaciones Disponibles";
            this.btnDisponibles.UseVisualStyleBackColor = true;
            this.btnDisponibles.Click += new System.EventHandler(this.btnDisponibles_Click);
            // 
            // btnNodisponible
            // 
            this.btnNodisponible.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNodisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodisponible.ForeColor = System.Drawing.Color.DarkGray;
            this.btnNodisponible.Location = new System.Drawing.Point(312, 218);
            this.btnNodisponible.Name = "btnNodisponible";
            this.btnNodisponible.Size = new System.Drawing.Size(188, 100);
            this.btnNodisponible.TabIndex = 3;
            this.btnNodisponible.Text = "Reporte Habitaciones No Disponible";
            this.btnNodisponible.UseVisualStyleBackColor = true;
            this.btnNodisponible.Click += new System.EventHandler(this.btnNodisponible_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 40;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNodisponible);
            this.Controls.Add(this.btnDisponibles);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnHabitaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnDisponibles;
        private System.Windows.Forms.Button btnNodisponible;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button button1;
    }
}

