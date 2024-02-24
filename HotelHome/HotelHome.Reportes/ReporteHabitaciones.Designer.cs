
namespace HotelHome.Reportes
{
    partial class ReporteHabitaciones
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
            this.crystalReportHabitaciones = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportHabitaciones1 = new HotelHome.Reportes.CrystalReportHabitaciones();
            this.SuspendLayout();
            // 
            // crystalReportHabitaciones
            // 
            this.crystalReportHabitaciones.ActiveViewIndex = 0;
            this.crystalReportHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportHabitaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportHabitaciones.Location = new System.Drawing.Point(0, 0);
            this.crystalReportHabitaciones.Name = "crystalReportHabitaciones";
            this.crystalReportHabitaciones.ReportSource = this.CrystalReportHabitaciones1;
            this.crystalReportHabitaciones.Size = new System.Drawing.Size(889, 508);
            this.crystalReportHabitaciones.TabIndex = 0;
            this.crystalReportHabitaciones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReporteHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 508);
            this.Controls.Add(this.crystalReportHabitaciones);
            this.Name = "ReporteHabitaciones";
            this.Text = "ReporteHabitaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportHabitaciones;
        private CrystalReportHabitaciones CrystalReportHabitaciones1;
    }
}