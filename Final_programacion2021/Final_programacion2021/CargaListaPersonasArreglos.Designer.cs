
namespace Final_programacion2021
{
    partial class CargaListaPersonasArreglos
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
            this.BtnCarga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCarga = new System.Windows.Forms.TextBox();
            this.TxtDim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDimensionar = new System.Windows.Forms.Button();
            this.LblLista = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCarga
            // 
            this.BtnCarga.Location = new System.Drawing.Point(246, 55);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(75, 23);
            this.BtnCarga.TabIndex = 0;
            this.BtnCarga.Text = "Cargar";
            this.BtnCarga.UseVisualStyleBackColor = true;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carga de personas";
            // 
            // TxtCarga
            // 
            this.TxtCarga.Location = new System.Drawing.Point(327, 57);
            this.TxtCarga.Name = "TxtCarga";
            this.TxtCarga.Size = new System.Drawing.Size(100, 20);
            this.TxtCarga.TabIndex = 2;
            // 
            // TxtDim
            // 
            this.TxtDim.Location = new System.Drawing.Point(108, 57);
            this.TxtDim.Name = "TxtDim";
            this.TxtDim.Size = new System.Drawing.Size(100, 20);
            this.TxtDim.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de personas";
            // 
            // BtnDimensionar
            // 
            this.BtnDimensionar.Location = new System.Drawing.Point(15, 54);
            this.BtnDimensionar.Name = "BtnDimensionar";
            this.BtnDimensionar.Size = new System.Drawing.Size(75, 23);
            this.BtnDimensionar.TabIndex = 3;
            this.BtnDimensionar.Text = "Dimensionar";
            this.BtnDimensionar.UseVisualStyleBackColor = true;
            this.BtnDimensionar.Click += new System.EventHandler(this.BtnDimensionar_Click);
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Location = new System.Drawing.Point(447, 30);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(62, 13);
            this.LblLista.TabIndex = 7;
            this.LblLista.Text = "mostrar lista";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(246, 84);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 6;
            this.BtnCargar.Text = "Mostrar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // CargaListaPersonasArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 250);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TxtDim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDimensionar);
            this.Controls.Add(this.TxtCarga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCarga);
            this.Name = "CargaListaPersonasArreglos";
            this.Text = "Arreglos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCarga;
        private System.Windows.Forms.TextBox TxtDim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDimensionar;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Button BtnCargar;
    }
}

