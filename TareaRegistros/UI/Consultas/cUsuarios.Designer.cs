namespace TareaRegistros.UI.Consultas
{
    partial class cUsuarios
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
            this.cUsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cUsuariodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cUsuariodataGridView
            // 
            this.cUsuariodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cUsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUsuariodataGridView.Location = new System.Drawing.Point(43, 105);
            this.cUsuariodataGridView.Name = "cUsuariodataGridView";
            this.cUsuariodataGridView.RowTemplate.Height = 24;
            this.cUsuariodataGridView.Size = new System.Drawing.Size(749, 225);
            this.cUsuariodataGridView.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Buscarbutton.Location = new System.Drawing.Point(717, 35);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(74, 37);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 365);
            this.Controls.Add(this.cUsuariodataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "cUsuarios";
            this.Text = "Consulta Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.cUsuariodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cUsuariodataGridView;
        private System.Windows.Forms.Button Buscarbutton;
    }
}