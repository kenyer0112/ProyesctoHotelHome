
namespace HotelHome.Reportes
{
    partial class ReportReserva
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
            this.crystalReportReservas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportReservas1 = new HotelHome.Reportes.CrystalReportReservas();
            this.SuspendLayout();
            // 
            // crystalReportReservas
            // 
            this.crystalReportReservas.ActiveViewIndex = 0;
            this.crystalReportReservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportReservas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportReservas.Location = new System.Drawing.Point(0, 0);
            this.crystalReportReservas.Name = "crystalReportReservas";
            this.crystalReportReservas.ReportSource = this.CrystalReportReservas1;
            this.crystalReportReservas.Size = new System.Drawing.Size(800, 450);
            this.crystalReportReservas.TabIndex = 0;
            // 
            // ReportReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportReservas);
            this.Name = "ReportReserva";
            this.Text = "ReportReserva";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportReservas;
        private CrystalReportReservas CrystalReportReservas1;
    }
}