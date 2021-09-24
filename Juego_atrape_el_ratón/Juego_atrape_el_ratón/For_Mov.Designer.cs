
namespace Juego_atrape_el_ratón
{
    partial class For_Mov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(For_Mov));
            this.Btn_Ejecutar = new System.Windows.Forms.Button();
            this.LblMovimiento = new System.Windows.Forms.Label();
            this.TxtIngresar = new System.Windows.Forms.TextBox();
            this.BtnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Ejecutar
            // 
            this.Btn_Ejecutar.Location = new System.Drawing.Point(501, 12);
            this.Btn_Ejecutar.Name = "Btn_Ejecutar";
            this.Btn_Ejecutar.Size = new System.Drawing.Size(162, 57);
            this.Btn_Ejecutar.TabIndex = 0;
            this.Btn_Ejecutar.Text = "Ejecutar controles";
            this.Btn_Ejecutar.UseVisualStyleBackColor = true;
            this.Btn_Ejecutar.Click += new System.EventHandler(this.Btn_Ejecutar_Click);
            // 
            // LblMovimiento
            // 
            this.LblMovimiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblMovimiento.Location = new System.Drawing.Point(40, 161);
            this.LblMovimiento.Name = "LblMovimiento";
            this.LblMovimiento.Size = new System.Drawing.Size(146, 103);
            this.LblMovimiento.TabIndex = 1;
            this.LblMovimiento.Visible = false;
            // 
            // TxtIngresar
            // 
            this.TxtIngresar.BackColor = System.Drawing.Color.Red;
            this.TxtIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngresar.Location = new System.Drawing.Point(43, 113);
            this.TxtIngresar.Name = "TxtIngresar";
            this.TxtIngresar.Size = new System.Drawing.Size(143, 22);
            this.TxtIngresar.TabIndex = 2;
            this.TxtIngresar.Visible = false;
            // 
            // BtnMover
            // 
            this.BtnMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMover.Location = new System.Drawing.Point(43, 25);
            this.BtnMover.Name = "BtnMover";
            this.BtnMover.Size = new System.Drawing.Size(143, 57);
            this.BtnMover.TabIndex = 3;
            this.BtnMover.Text = "Mover cuadrado";
            this.BtnMover.UseVisualStyleBackColor = true;
            this.BtnMover.Click += new System.EventHandler(this.button1_Click);
            // 
            // For_Mov
            // 
            this.AcceptButton = this.BtnMover;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(675, 362);
            this.Controls.Add(this.BtnMover);
            this.Controls.Add(this.TxtIngresar);
            this.Controls.Add(this.LblMovimiento);
            this.Controls.Add(this.Btn_Ejecutar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "For_Mov";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objetos escondidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ejecutar;
        private System.Windows.Forms.Label LblMovimiento;
        private System.Windows.Forms.TextBox TxtIngresar;
        private System.Windows.Forms.Button BtnMover;
    }
}