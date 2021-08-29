
namespace EjercicioDePruebaDeTextos
{
    partial class PruebaTextos
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
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.TxtDatoCadena = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblOrigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(439, 30);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(119, 32);
            this.BtnEjecutar.TabIndex = 0;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // TxtDatoCadena
            // 
            this.TxtDatoCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatoCadena.Location = new System.Drawing.Point(141, 33);
            this.TxtDatoCadena.Name = "TxtDatoCadena";
            this.TxtDatoCadena.Size = new System.Drawing.Size(230, 29);
            this.TxtDatoCadena.TabIndex = 1;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.BackColor = System.Drawing.Color.Chartreuse;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.Color.Black;
            this.LblResultado.Location = new System.Drawing.Point(135, 165);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 31);
            this.LblResultado.TabIndex = 2;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(141, 219);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(97, 32);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblOrigen
            // 
            this.LblOrigen.AutoSize = true;
            this.LblOrigen.BackColor = System.Drawing.Color.Yellow;
            this.LblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrigen.ForeColor = System.Drawing.Color.Black;
            this.LblOrigen.Location = new System.Drawing.Point(135, 86);
            this.LblOrigen.Name = "LblOrigen";
            this.LblOrigen.Size = new System.Drawing.Size(0, 31);
            this.LblOrigen.TabIndex = 4;
            // 
            // PruebaTextos
            // 
            this.AcceptButton = this.BtnEjecutar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(606, 333);
            this.Controls.Add(this.LblOrigen);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtDatoCadena);
            this.Controls.Add(this.BtnEjecutar);
            this.Name = "PruebaTextos";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PruebaTextos";
            this.Enter += new System.EventHandler(this.BtnEjecutar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.TextBox TxtDatoCadena;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblOrigen;
    }
}