namespace TareaRegistros.UI.Consultas
{
    partial class cPeliculas
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
            this.PeliculasdataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Filtarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeliculasdataGridView
            // 
            this.PeliculasdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PeliculasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculasdataGridView.Location = new System.Drawing.Point(85, 175);
            this.PeliculasdataGridView.Name = "PeliculasdataGridView";
            this.PeliculasdataGridView.RowTemplate.Height = 24;
            this.PeliculasdataGridView.Size = new System.Drawing.Size(684, 225);
            this.PeliculasdataGridView.TabIndex = 5;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Location = new System.Drawing.Point(517, 43);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(84, 38);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasta:";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.AccessibleDescription = "";
            this.DesdedateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdedateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(176, 115);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(115, 22);
            this.DesdedateTimePicker.TabIndex = 12;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.AccessibleDescription = "";
            this.HastadateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HastadateTimePicker.Location = new System.Drawing.Point(374, 115);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(115, 22);
            this.HastadateTimePicker.TabIndex = 13;
            // 
            // Filtarbutton
            // 
            this.Filtarbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Filtarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtarbutton.Location = new System.Drawing.Point(517, 99);
            this.Filtarbutton.Name = "Filtarbutton";
            this.Filtarbutton.Size = new System.Drawing.Size(84, 38);
            this.Filtarbutton.TabIndex = 14;
            this.Filtarbutton.Text = "Filtrar";
            this.Filtarbutton.UseVisualStyleBackColor = true;
            this.Filtarbutton.Click += new System.EventHandler(this.Filtarbutton_Click);
            // 
            // cPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 445);
            this.Controls.Add(this.Filtarbutton);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeliculasdataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "cPeliculas";
            this.Text = "cPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PeliculasdataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Button Filtarbutton;
    }
}