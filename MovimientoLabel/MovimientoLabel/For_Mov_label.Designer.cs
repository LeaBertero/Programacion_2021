
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
            this.BtnMovBlanco = new System.Windows.Forms.Button();
            this.LblBlanco = new System.Windows.Forms.Label();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMoverVerde
            // 
            this.BtnMoverVerde.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnMoverVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMoverVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoverVerde.Location = new System.Drawing.Point(802, 56);
            this.BtnMoverVerde.Name = "BtnMoverVerde";
            this.BtnMoverVerde.Size = new System.Drawing.Size(74, 61);
            this.BtnMoverVerde.TabIndex = 0;
            this.BtnMoverVerde.Text = "Mover azul";
            this.BtnMoverVerde.UseVisualStyleBackColor = false;
            this.BtnMoverVerde.Click += new System.EventHandler(this.BtnMover_Click);
            // 
            // LblVerde
            // 
            this.LblVerde.BackColor = System.Drawing.Color.DarkCyan;
            this.LblVerde.Location = new System.Drawing.Point(0, 83);
            this.LblVerde.Name = "LblVerde";
            this.LblVerde.Size = new System.Drawing.Size(48, 46);
            this.LblVerde.TabIndex = 1;
            this.LblVerde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Location = new System.Drawing.Point(278, 0);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(61, 57);
            this.LblRojo.TabIndex = 3;
            this.LblRojo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRojo.Visible = false;
            // 
            // BtnMoverRojo
            // 
            this.BtnMoverRojo.BackColor = System.Drawing.Color.Green;
            this.BtnMoverRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMoverRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoverRojo.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnMoverRojo.Location = new System.Drawing.Point(802, -1);
            this.BtnMoverRojo.Name = "BtnMoverRojo";
            this.BtnMoverRojo.Size = new System.Drawing.Size(74, 60);
            this.BtnMoverRojo.TabIndex = 2;
            this.BtnMoverRojo.Text = "Mover Rojo";
            this.BtnMoverRojo.UseVisualStyleBackColor = false;
            this.BtnMoverRojo.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMovBlanco
            // 
            this.BtnMovBlanco.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnMovBlanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMovBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovBlanco.Location = new System.Drawing.Point(802, 116);
            this.BtnMovBlanco.Name = "BtnMovBlanco";
            this.BtnMovBlanco.Size = new System.Drawing.Size(74, 61);
            this.BtnMovBlanco.TabIndex = 4;
            this.BtnMovBlanco.Text = "Mover blanco";
            this.BtnMovBlanco.UseVisualStyleBackColor = false;
            this.BtnMovBlanco.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LblBlanco
            // 
            this.LblBlanco.BackColor = System.Drawing.Color.Cornsilk;
            this.LblBlanco.Location = new System.Drawing.Point(24, 187);
            this.LblBlanco.Name = "LblBlanco";
            this.LblBlanco.Size = new System.Drawing.Size(63, 60);
            this.LblBlanco.TabIndex = 5;
            this.LblBlanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblBlanco.Visible = false;
            // 
            // TxtX
            // 
            this.TxtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtX.Location = new System.Drawing.Point(685, 138);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(100, 22);
            this.TxtX.TabIndex = 6;
            // 
            // For_Mov_label
            // 
            this.AcceptButton = this.BtnMovBlanco;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(876, 355);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.LblBlanco);
            this.Controls.Add(this.BtnMovBlanco);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.BtnMoverRojo);
            this.Controls.Add(this.LblVerde);
            this.Controls.Add(this.BtnMoverVerde);
            this.Name = "For_Mov_label";
            this.Text = "Prueba movimiento label";
            this.Load += new System.EventHandler(this.For_Mov_label_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMoverVerde;
        private System.Windows.Forms.Label LblVerde;
        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Button BtnMoverRojo;
        private System.Windows.Forms.Button BtnMovBlanco;
        private System.Windows.Forms.Label LblBlanco;
        private System.Windows.Forms.TextBox TxtX;
    }
}

