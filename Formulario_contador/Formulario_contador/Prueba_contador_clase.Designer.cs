
namespace Formulario_contador
{
    partial class Prueba_contador_clase
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
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LblContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(59, 22);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Aceptar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblContador
            // 
            this.LblContador.AutoSize = true;
            this.LblContador.Location = new System.Drawing.Point(56, 132);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(29, 13);
            this.LblContador.TabIndex = 1;
            this.LblContador.Text = "Hola";
            this.LblContador.Click += new System.EventHandler(this.label1_Click);
            // 
            // Prueba_contador_clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 212);
            this.Controls.Add(this.LblContador);
            this.Controls.Add(this.BtnIniciar);
            this.Name = "Prueba_contador_clase";
            this.Text = "Prueba_contador_clase";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label LblContador;
    }
}