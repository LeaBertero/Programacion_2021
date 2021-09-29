
namespace Repeticion_Aleatoria
{
    partial class Movimiento_aleatorio
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
            this.Lbl_aleatorio = new System.Windows.Forms.Label();
            this.Btn_comenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_aleatorio
            // 
            this.Lbl_aleatorio.BackColor = System.Drawing.Color.Red;
            this.Lbl_aleatorio.Location = new System.Drawing.Point(12, 9);
            this.Lbl_aleatorio.Name = "Lbl_aleatorio";
            this.Lbl_aleatorio.Size = new System.Drawing.Size(58, 57);
            this.Lbl_aleatorio.TabIndex = 0;
            // 
            // Btn_comenzar
            // 
            this.Btn_comenzar.Location = new System.Drawing.Point(526, 58);
            this.Btn_comenzar.Name = "Btn_comenzar";
            this.Btn_comenzar.Size = new System.Drawing.Size(95, 54);
            this.Btn_comenzar.TabIndex = 1;
            this.Btn_comenzar.Text = "Comenzar";
            this.Btn_comenzar.UseVisualStyleBackColor = true;
            this.Btn_comenzar.Click += new System.EventHandler(this.Btn_comenzar_Click);
            // 
            // Movimiento_aleatorio
            // 
            this.AcceptButton = this.Btn_comenzar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_comenzar);
            this.Controls.Add(this.Lbl_aleatorio);
            this.Name = "Movimiento_aleatorio";
            this.Text = "Repeticion aleatoria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_aleatorio;
        private System.Windows.Forms.Button Btn_comenzar;
    }
}

