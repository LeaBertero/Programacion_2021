﻿
namespace Prg.Final.Clase
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClickLista = new System.Windows.Forms.Button();
            this.LblMostrarLista = new System.Windows.Forms.Label();
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.BtnCarga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(511, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Presione el botón para mostrar la lista cargada";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(779, 295);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 58);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "Salir del programa";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Atención : Puede cargar hasta 5 jugadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cargue aquí sus jugadores";
            // 
            // BtnClickLista
            // 
            this.BtnClickLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClickLista.Location = new System.Drawing.Point(548, 135);
            this.BtnClickLista.Name = "BtnClickLista";
            this.BtnClickLista.Size = new System.Drawing.Size(125, 32);
            this.BtnClickLista.TabIndex = 12;
            this.BtnClickLista.Text = "Mostrar lista";
            this.BtnClickLista.UseVisualStyleBackColor = true;
            // 
            // LblMostrarLista
            // 
            this.LblMostrarLista.BackColor = System.Drawing.Color.Chartreuse;
            this.LblMostrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarLista.ForeColor = System.Drawing.Color.Black;
            this.LblMostrarLista.Location = new System.Drawing.Point(489, 183);
            this.LblMostrarLista.Name = "LblMostrarLista";
            this.LblMostrarLista.Size = new System.Drawing.Size(257, 172);
            this.LblMostrarLista.TabIndex = 11;
            this.LblMostrarLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngreso.Location = new System.Drawing.Point(108, 60);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(100, 32);
            this.TxtIngreso.TabIndex = 10;
            // 
            // BtnCarga
            // 
            this.BtnCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarga.Location = new System.Drawing.Point(12, 61);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(75, 32);
            this.BtnCarga.TabIndex = 9;
            this.BtnCarga.Text = "Cargar";
            this.BtnCarga.UseVisualStyleBackColor = true;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnCarga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 361);
            this.Controls.Add(this.BtnCarga);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnClickLista);
            this.Controls.Add(this.LblMostrarLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClickLista;
        private System.Windows.Forms.Label LblMostrarLista;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Button BtnCarga;
    }
}

