
namespace Proyecto_pruebaMovimiento_clase
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
            this.BtnMover = new System.Windows.Forms.Button();
            this.LblMov = new System.Windows.Forms.Label();
            this.TxtBoxUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMover
            // 
            this.BtnMover.Location = new System.Drawing.Point(152, 12);
            this.BtnMover.Name = "BtnMover";
            this.BtnMover.Size = new System.Drawing.Size(89, 43);
            this.BtnMover.TabIndex = 0;
            this.BtnMover.Text = "Mover";
            this.BtnMover.UseVisualStyleBackColor = true;
            this.BtnMover.Click += new System.EventHandler(this.BtnMover_Click);
            // 
            // LblMov
            // 
            this.LblMov.BackColor = System.Drawing.Color.Red;
            this.LblMov.ForeColor = System.Drawing.Color.Plum;
            this.LblMov.Location = new System.Drawing.Point(1, 101);
            this.LblMov.Name = "LblMov";
            this.LblMov.Size = new System.Drawing.Size(40, 40);
            this.LblMov.TabIndex = 1;
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.Location = new System.Drawing.Point(27, 24);
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxUser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 164);
            this.Controls.Add(this.TxtBoxUser);
            this.Controls.Add(this.LblMov);
            this.Controls.Add(this.BtnMover);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMover;
        private System.Windows.Forms.Label LblMov;
        private System.Windows.Forms.TextBox TxtBoxUser;
    }
}

