﻿namespace TareaRegistros.UI.Reportes
{
    partial class ReportePeliculas
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
            this.PeliculasreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // PeliculasreportViewer
            // 
            this.PeliculasreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeliculasreportViewer.Location = new System.Drawing.Point(0, 0);
            this.PeliculasreportViewer.Name = "PeliculasreportViewer";
            this.PeliculasreportViewer.Size = new System.Drawing.Size(1068, 468);
            this.PeliculasreportViewer.TabIndex = 0;
            // 
            // ReportePeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 468);
            this.Controls.Add(this.PeliculasreportViewer);
            this.Name = "ReportePeliculas";
            this.Text = "ReportePeliculas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportePeliculas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer PeliculasreportViewer;
    }
}