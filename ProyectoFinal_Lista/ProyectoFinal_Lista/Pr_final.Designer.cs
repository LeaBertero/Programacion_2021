﻿
namespace ProyectoFinal_Lista
{
    partial class Pr_final
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
            this.BtnDim = new System.Windows.Forms.Button();
            this.TxtDim = new System.Windows.Forms.TextBox();
            this.TxtAgregar = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.LblLista = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtCarga2 = new System.Windows.Forms.TextBox();
            this.BtnCargar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblLista2 = new System.Windows.Forms.Label();
            this.BtnMostrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDim
            // 
            this.BtnDim.Location = new System.Drawing.Point(5, 37);
            this.BtnDim.Name = "BtnDim";
            this.BtnDim.Size = new System.Drawing.Size(78, 23);
            this.BtnDim.TabIndex = 0;
            this.BtnDim.Text = "Dimensionar";
            this.BtnDim.UseVisualStyleBackColor = true;
            this.BtnDim.Click += new System.EventHandler(this.BtnDim_Click);
            // 
            // TxtDim
            // 
            this.TxtDim.Location = new System.Drawing.Point(89, 37);
            this.TxtDim.Name = "TxtDim";
            this.TxtDim.Size = new System.Drawing.Size(100, 20);
            this.TxtDim.TabIndex = 1;
            // 
            // TxtAgregar
            // 
            this.TxtAgregar.Location = new System.Drawing.Point(89, 63);
            this.TxtAgregar.Name = "TxtAgregar";
            this.TxtAgregar.Size = new System.Drawing.Size(100, 20);
            this.TxtAgregar.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(5, 61);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(78, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Cargar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dimensione la cantidad a cargar";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(5, 87);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(78, 23);
            this.BtnMostrar.TabIndex = 5;
            this.BtnMostrar.Text = "Lista";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Location = new System.Drawing.Point(16, 145);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(0, 13);
            this.LblLista.TabIndex = 6;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(341, 10);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(78, 23);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtCarga2
            // 
            this.TxtCarga2.Location = new System.Drawing.Point(693, 37);
            this.TxtCarga2.Name = "TxtCarga2";
            this.TxtCarga2.Size = new System.Drawing.Size(100, 20);
            this.TxtCarga2.TabIndex = 9;
            // 
            // BtnCargar2
            // 
            this.BtnCargar2.Location = new System.Drawing.Point(609, 37);
            this.BtnCargar2.Name = "BtnCargar2";
            this.BtnCargar2.Size = new System.Drawing.Size(78, 23);
            this.BtnCargar2.TabIndex = 8;
            this.BtnCargar2.Text = "Cargar2";
            this.BtnCargar2.UseVisualStyleBackColor = true;
            this.BtnCargar2.Click += new System.EventHandler(this.BtnCargar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombres";
            // 
            // LblLista2
            // 
            this.LblLista2.AutoSize = true;
            this.LblLista2.Location = new System.Drawing.Point(606, 109);
            this.LblLista2.Name = "LblLista2";
            this.LblLista2.Size = new System.Drawing.Size(29, 13);
            this.LblLista2.TabIndex = 11;
            this.LblLista2.Text = "Lista";
            // 
            // BtnMostrar2
            // 
            this.BtnMostrar2.Location = new System.Drawing.Point(609, 63);
            this.BtnMostrar2.Name = "BtnMostrar2";
            this.BtnMostrar2.Size = new System.Drawing.Size(78, 23);
            this.BtnMostrar2.TabIndex = 12;
            this.BtnMostrar2.Text = "Lista2";
            this.BtnMostrar2.UseVisualStyleBackColor = true;
            this.BtnMostrar2.Click += new System.EventHandler(this.BtnMostrar2_Click);
            // 
            // Pr_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(797, 311);
            this.Controls.Add(this.BtnMostrar2);
            this.Controls.Add(this.LblLista2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCarga2);
            this.Controls.Add(this.BtnCargar2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAgregar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtDim);
            this.Controls.Add(this.BtnDim);
            this.Name = "Pr_final";
            this.Text = "Proyecto Final  - Programacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDim;
        private System.Windows.Forms.TextBox TxtDim;
        private System.Windows.Forms.TextBox TxtAgregar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtCarga2;
        private System.Windows.Forms.Button BtnCargar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblLista2;
        private System.Windows.Forms.Button BtnMostrar2;
    }
}
