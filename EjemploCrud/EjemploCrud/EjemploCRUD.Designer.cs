namespace EjemploCrud
{
    partial class EjemploCRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgDatos = new System.Windows.Forms.DataGridView();
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnFormDettales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgDatos
            // 
            this.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatos.Location = new System.Drawing.Point(51, 189);
            this.DgDatos.Name = "DgDatos";
            this.DgDatos.RowTemplate.Height = 25;
            this.DgDatos.Size = new System.Drawing.Size(703, 228);
            this.DgDatos.TabIndex = 0;
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.AutoSize = true;
            this.LblBusqueda.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBusqueda.Location = new System.Drawing.Point(12, 143);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(120, 27);
            this.LblBusqueda.TabIndex = 1;
            this.LblBusqueda.Text = "Buscar --->";
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.AcceptsTab = true;
            this.TxtIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIngreso.Location = new System.Drawing.Point(148, 143);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(380, 29);
            this.TxtIngreso.TabIndex = 2;
            this.TxtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Location = new System.Drawing.Point(557, 132);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(88, 51);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(651, 131);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(88, 51);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnFormDettales
            // 
            this.BtnFormDettales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFormDettales.Location = new System.Drawing.Point(12, 2);
            this.BtnFormDettales.Name = "BtnFormDettales";
            this.BtnFormDettales.Size = new System.Drawing.Size(200, 32);
            this.BtnFormDettales.TabIndex = 5;
            this.BtnFormDettales.Text = "Formulario detalles";
            this.BtnFormDettales.UseVisualStyleBackColor = true;
            this.BtnFormDettales.Click += new System.EventHandler(this.BtnFormDettales_Click);
            // 
            // EjemploCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFormDettales);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.LblBusqueda);
            this.Controls.Add(this.DgDatos);
            this.Name = "EjemploCRUD";
            this.Text = "Ejemplo CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgDatos;
        private System.Windows.Forms.Label LblBusqueda;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnFormDettales;
    }
}
