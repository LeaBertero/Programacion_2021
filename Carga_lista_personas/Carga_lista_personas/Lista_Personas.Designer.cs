
namespace Carga_lista_personas
{
    partial class Lista_Personas
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
            this.BtnCargar = new System.Windows.Forms.Button();
            this.TxtIngresoPers = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblTituloDim = new System.Windows.Forms.Label();
            this.TxtCarga = new System.Windows.Forms.TextBox();
            this.BtnDimensionar = new System.Windows.Forms.Button();
            this.LblCargaNombres = new System.Windows.Forms.Label();
            this.LblLista = new System.Windows.Forms.Label();
            this.BtnMostrarTitulo1 = new System.Windows.Forms.Button();
            this.BtnMostrarTitulo2 = new System.Windows.Forms.Button();
            this.LblCargaFinalizada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(460, 259);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(98, 31);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TxtIngresoPers
            // 
            this.TxtIngresoPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngresoPers.Location = new System.Drawing.Point(314, 263);
            this.TxtIngresoPers.Name = "TxtIngresoPers";
            this.TxtIngresoPers.Size = new System.Drawing.Size(100, 26);
            this.TxtIngresoPers.TabIndex = 1;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(593, 259);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(98, 31);
            this.BtnMostrar.TabIndex = 2;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(827, 376);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(76, 31);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblTituloDim
            // 
            this.LblTituloDim.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloDim.Location = new System.Drawing.Point(244, 23);
            this.LblTituloDim.Name = "LblTituloDim";
            this.LblTituloDim.Size = new System.Drawing.Size(535, 28);
            this.LblTituloDim.TabIndex = 8;
            this.LblTituloDim.Text = "Especifique con numeros, la cantidad de nombres a cargar";
            this.LblTituloDim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTituloDim.Visible = false;
            // 
            // TxtCarga
            // 
            this.TxtCarga.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarga.Location = new System.Drawing.Point(320, 83);
            this.TxtCarga.Name = "TxtCarga";
            this.TxtCarga.Size = new System.Drawing.Size(100, 36);
            this.TxtCarga.TabIndex = 7;
            // 
            // BtnDimensionar
            // 
            this.BtnDimensionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDimensionar.Location = new System.Drawing.Point(486, 83);
            this.BtnDimensionar.Name = "BtnDimensionar";
            this.BtnDimensionar.Size = new System.Drawing.Size(120, 38);
            this.BtnDimensionar.TabIndex = 6;
            this.BtnDimensionar.Text = "Dimensionar";
            this.BtnDimensionar.UseVisualStyleBackColor = true;
            this.BtnDimensionar.Click += new System.EventHandler(this.BtnDimensionar_Click);
            // 
            // LblCargaNombres
            // 
            this.LblCargaNombres.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargaNombres.Location = new System.Drawing.Point(244, 194);
            this.LblCargaNombres.Name = "LblCargaNombres";
            this.LblCargaNombres.Size = new System.Drawing.Size(554, 28);
            this.LblCargaNombres.TabIndex = 10;
            this.LblCargaNombres.Text = "Cargue todos los nombres que ha dimensionado anteriormente";
            this.LblCargaNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCargaNombres.Visible = false;
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Location = new System.Drawing.Point(457, 325);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(0, 13);
            this.LblLista.TabIndex = 11;
            // 
            // BtnMostrarTitulo1
            // 
            this.BtnMostrarTitulo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrarTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTitulo1.Location = new System.Drawing.Point(39, 20);
            this.BtnMostrarTitulo1.Name = "BtnMostrarTitulo1";
            this.BtnMostrarTitulo1.Size = new System.Drawing.Size(180, 31);
            this.BtnMostrarTitulo1.TabIndex = 12;
            this.BtnMostrarTitulo1.Text = "Ver especificacion";
            this.BtnMostrarTitulo1.UseVisualStyleBackColor = true;
            this.BtnMostrarTitulo1.Click += new System.EventHandler(this.BtnMostrarTitulo1_Click);
            // 
            // BtnMostrarTitulo2
            // 
            this.BtnMostrarTitulo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrarTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTitulo2.Location = new System.Drawing.Point(39, 191);
            this.BtnMostrarTitulo2.Name = "BtnMostrarTitulo2";
            this.BtnMostrarTitulo2.Size = new System.Drawing.Size(180, 31);
            this.BtnMostrarTitulo2.TabIndex = 13;
            this.BtnMostrarTitulo2.Text = "Ver especificacion";
            this.BtnMostrarTitulo2.UseVisualStyleBackColor = true;
            this.BtnMostrarTitulo2.Click += new System.EventHandler(this.BtnMostrarTitulo2_Click);
            // 
            // LblCargaFinalizada
            // 
            this.LblCargaFinalizada.AutoSize = true;
            this.LblCargaFinalizada.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargaFinalizada.Location = new System.Drawing.Point(356, 158);
            this.LblCargaFinalizada.Name = "LblCargaFinalizada";
            this.LblCargaFinalizada.Size = new System.Drawing.Size(0, 28);
            this.LblCargaFinalizada.TabIndex = 14;
            // 
            // Lista_Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(915, 419);
            this.Controls.Add(this.LblCargaFinalizada);
            this.Controls.Add(this.BtnMostrarTitulo2);
            this.Controls.Add(this.BtnMostrarTitulo1);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.LblCargaNombres);
            this.Controls.Add(this.LblTituloDim);
            this.Controls.Add(this.TxtCarga);
            this.Controls.Add(this.BtnDimensionar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.TxtIngresoPers);
            this.Controls.Add(this.BtnCargar);
            this.Name = "Lista_Personas";
            this.Text = "Carga lista de personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TxtIngresoPers;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblTituloDim;
        private System.Windows.Forms.TextBox TxtCarga;
        private System.Windows.Forms.Button BtnDimensionar;
        private System.Windows.Forms.Label LblCargaNombres;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Button BtnMostrarTitulo1;
        private System.Windows.Forms.Button BtnMostrarTitulo2;
        private System.Windows.Forms.Label LblCargaFinalizada;
    }
}

