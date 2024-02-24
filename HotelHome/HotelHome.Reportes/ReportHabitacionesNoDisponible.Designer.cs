
namespace HotelHome.Reportes
{
    partial class ReportHabitacionesNoDisponible
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
            this.crystalReportHabitacionNodisponible = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportHabitacionNoDisponible1 = new HotelHome.Reportes.CrystalReportHabitacionNoDisponible();
            this.SuspendLayout();
            // 
            // crystalReportHabitacionNodisponible
            // 
            this.crystalReportHabitacionNodisponible.ActiveViewIndex = 0;
            this.crystalReportHabitacionNodisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportHabitacionNodisponible.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportHabitacionNodisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportHabitacionNodisponible.Location = new System.Drawing.Point(0, 0);
            this.crystalReportHabitacionNodisponible.Name = "crystalReportHabitacionNodisponible";
            this.crystalReportHabitacionNodisponible.ReportSource = this.CrystalReportHabitacionNoDisponible1;
            this.crystalReportHabitacionNodisponible.Size = new System.Drawing.Size(800, 450);
            this.crystalReportHabitacionNodisponible.TabIndex = 0;
            this.crystalReportHabitacionNodisponible.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportHabitacionesNoDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportHabitacionNodisponible);
            this.Name = "ReportHabitacionesNoDisponible";
            this.Text = "ReportHabitacionesNoDisponible";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportHabitacionNodisponible;
        private CrystalReportHabitacionNoDisponible CrystalReportHabitacionNoDisponible1;
    }
}