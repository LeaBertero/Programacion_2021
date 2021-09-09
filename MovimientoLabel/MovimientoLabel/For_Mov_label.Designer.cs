
namespace MovimientoLabel
{
    partial class For_Mov_label
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
            this.BtnMoverVerde = new System.Windows.Forms.Button();
            this.LblVerde = new System.Windows.Forms.Label();
            this.LblRojo = new System.Windows.Forms.Label();
            this.BtnMoverRojo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMoverVerde
            // 
            this.BtnMoverVerde.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnMoverVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMoverVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoverVerde.Location = new System.Drawing.Point(12, 216);
            this.BtnMoverVerde.Name = "BtnMoverVerde";
            this.BtnMoverVerde.Size = new System.Drawing.Size(169, 57);
            this.BtnMoverVerde.TabIndex = 0;
            this.BtnMoverVerde.Text = "Mover azul";
            this.BtnMoverVerde.UseVisualStyleBackColor = false;
            this.BtnMoverVerde.Click += new System.EventHandler(this.BtnMover_Click);
            // 
            // LblVerde
            // 
            this.LblVerde.BackColor = System.Drawing.Color.DarkCyan;
            this.LblVerde.Location = new System.Drawing.Point(0, 59);
            this.LblVerde.Name = "LblVerde";
            this.LblVerde.Size = new System.Drawing.Size(100, 42);
            this.LblVerde.TabIndex = 1;
            this.LblVerde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Location = new System.Drawing.Point(277, 0);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(100, 42);
            this.LblRojo.TabIndex = 3;
            this.LblRojo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMoverRojo
            // 
            this.BtnMoverRojo.BackColor = System.Drawing.Color.Green;
            this.BtnMoverRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMoverRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoverRojo.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnMoverRojo.Location = new System.Drawing.Point(480, 213);
            this.BtnMoverRojo.Name = "BtnMoverRojo";
            this.BtnMoverRojo.Size = new System.Drawing.Size(169, 60);
            this.BtnMoverRojo.TabIndex = 2;
            this.BtnMoverRojo.Text = "Mover Rojo";
            this.BtnMoverRojo.UseVisualStyleBackColor = false;
            this.BtnMoverRojo.Click += new System.EventHandler(this.button1_Click);
            // 
            // For_Mov_label
            // 
            this.AcceptButton = this.BtnMoverVerde;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(661, 285);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.BtnMoverRojo);
            this.Controls.Add(this.LblVerde);
            this.Controls.Add(this.BtnMoverVerde);
            this.Name = "For_Mov_label";
            this.Text = "Prueba movimiento label";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMoverVerde;
        private System.Windows.Forms.Label LblVerde;
        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Button BtnMoverRojo;
    }
}

