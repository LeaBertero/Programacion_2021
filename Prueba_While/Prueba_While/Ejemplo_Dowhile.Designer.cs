
namespace Prueba_While
{
    partial class Ejemplo_Dowhile
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
            this.BtnComenzar = new System.Windows.Forms.Button();
            this.LblWhite = new System.Windows.Forms.Label();
            this.LblBlack = new System.Windows.Forms.Label();
            this.BtNSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnComenzar
            // 
            this.BtnComenzar.BackColor = System.Drawing.Color.Blue;
            this.BtnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComenzar.Location = new System.Drawing.Point(24, 22);
            this.BtnComenzar.Name = "BtnComenzar";
            this.BtnComenzar.Size = new System.Drawing.Size(137, 41);
            this.BtnComenzar.TabIndex = 0;
            this.BtnComenzar.Text = "Mover";
            this.BtnComenzar.UseVisualStyleBackColor = false;
            this.BtnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // LblWhite
            // 
            this.LblWhite.BackColor = System.Drawing.Color.GhostWhite;
            this.LblWhite.Location = new System.Drawing.Point(537, 125);
            this.LblWhite.Name = "LblWhite";
            this.LblWhite.Size = new System.Drawing.Size(100, 23);
            this.LblWhite.TabIndex = 1;
            // 
            // LblBlack
            // 
            this.LblBlack.BackColor = System.Drawing.Color.Black;
            this.LblBlack.Location = new System.Drawing.Point(171, 125);
            this.LblBlack.Name = "LblBlack";
            this.LblBlack.Size = new System.Drawing.Size(100, 23);
            this.LblBlack.TabIndex = 2;
            // 
            // BtNSalir
            // 
            this.BtNSalir.BackColor = System.Drawing.Color.Blue;
            this.BtNSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNSalir.Location = new System.Drawing.Point(638, 253);
            this.BtNSalir.Name = "BtNSalir";
            this.BtNSalir.Size = new System.Drawing.Size(137, 41);
            this.BtNSalir.TabIndex = 3;
            this.BtNSalir.Text = "Salir";
            this.BtNSalir.UseVisualStyleBackColor = false;
            this.BtNSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejemplo_Dowhile
            // 
            this.AcceptButton = this.BtnComenzar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.BtNSalir);
            this.Controls.Add(this.LblBlack);
            this.Controls.Add(this.LblWhite);
            this.Controls.Add(this.BtnComenzar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Ejemplo_Dowhile";
            this.Text = "Ejemplo_Dowhile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnComenzar;
        private System.Windows.Forms.Label LblWhite;
        private System.Windows.Forms.Label LblBlack;
        private System.Windows.Forms.Button BtNSalir;
    }
}