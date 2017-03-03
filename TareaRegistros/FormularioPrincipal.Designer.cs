namespace TareaRegistros
{
    partial class FormularioPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.peliculaToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.peliculaToolStripMenuItem.Text = "Peliculas";
            this.peliculaToolStripMenuItem.Click += new System.EventHandler(this.peliculaToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaUsuariosToolStripMenuItem,
            this.consultaPeliculasToolStripMenuItem,
            this.consultaCategoriasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaUsuariosToolStripMenuItem
            // 
            this.consultaUsuariosToolStripMenuItem.Name = "consultaUsuariosToolStripMenuItem";
            this.consultaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultaUsuariosToolStripMenuItem.Text = "Consulta Usuarios";
            this.consultaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultaUsuariosToolStripMenuItem_Click);
            // 
            // consultaPeliculasToolStripMenuItem
            // 
            this.consultaPeliculasToolStripMenuItem.Name = "consultaPeliculasToolStripMenuItem";
            this.consultaPeliculasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultaPeliculasToolStripMenuItem.Text = "Consulta Peliculas";
            this.consultaPeliculasToolStripMenuItem.Click += new System.EventHandler(this.consultaPeliculasToolStripMenuItem_Click);
            // 
            // consultaCategoriasToolStripMenuItem
            // 
            this.consultaCategoriasToolStripMenuItem.Name = "consultaCategoriasToolStripMenuItem";
            this.consultaCategoriasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultaCategoriasToolStripMenuItem.Text = "Consulta Categorias";
            this.consultaCategoriasToolStripMenuItem.Click += new System.EventHandler(this.consultaCategoriasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // peliculasReportesToolStripMenuItem
            // 
            this.peliculasReportesToolStripMenuItem.Name = "peliculasReportesToolStripMenuItem";
            this.peliculasReportesToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.peliculasReportesToolStripMenuItem.Text = "Peliculas Reportes";
            this.peliculasReportesToolStripMenuItem.Click += new System.EventHandler(this.peliculasReportesToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 482);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Tarea de Registros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasReportesToolStripMenuItem;
    }
}

