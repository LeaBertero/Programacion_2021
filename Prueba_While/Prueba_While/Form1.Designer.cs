
namespace Prueba_While
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
            this.LblRojo = new System.Windows.Forms.Label();
            this.LblAzul = new System.Windows.Forms.Label();
            this.BtnArranque = new System.Windows.Forms.Button();
            this.BtnAcomodar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Location = new System.Drawing.Point(445, 361);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(100, 54);
            this.LblRojo.TabIndex = 0;
            this.LblRojo.Visible = false;
            // 
            // LblAzul
            // 
            this.LblAzul.BackColor = System.Drawing.Color.DarkBlue;
            this.LblAzul.Location = new System.Drawing.Point(264, 361);
            this.LblAzul.Name = "LblAzul";
            this.LblAzul.Size = new System.Drawing.Size(100, 54);
            this.LblAzul.TabIndex = 1;
            // 
            // BtnArranque
            // 
            this.BtnArranque.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnArranque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArranque.Location = new System.Drawing.Point(630, 361);
            this.BtnArranque.Name = "BtnArranque";
            this.BtnArranque.Size = new System.Drawing.Size(148, 50);
            this.BtnArranque.TabIndex = 2;
            this.BtnArranque.Text = "Ir arriba";
            this.BtnArranque.UseVisualStyleBackColor = false;
            this.BtnArranque.Click += new System.EventHandler(this.BtnArranque_Click);
            // 
            // BtnAcomodar
            // 
            this.BtnAcomodar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAcomodar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcomodar.Location = new System.Drawing.Point(34, 352);
            this.BtnAcomodar.Name = "BtnAcomodar";
            this.BtnAcomodar.Size = new System.Drawing.Size(148, 50);
            this.BtnAcomodar.TabIndex = 3;
            this.BtnAcomodar.Text = "Posicion";
            this.BtnAcomodar.UseVisualStyleBackColor = false;
            this.BtnAcomodar.Click += new System.EventHandler(this.BtnAcomodar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAcomodar);
            this.Controls.Add(this.BtnArranque);
            this.Controls.Add(this.LblAzul);
            this.Controls.Add(this.LblRojo);
            this.Name = "Form1";
            this.Text = "Prueba_while";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Label LblAzul;
        private System.Windows.Forms.Button BtnArranque;
        private System.Windows.Forms.Button BtnAcomodar;
    }
}

