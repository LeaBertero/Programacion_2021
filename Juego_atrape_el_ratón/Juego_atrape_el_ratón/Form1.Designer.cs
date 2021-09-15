
namespace Juego_atrape_el_ratón
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
            this.PicRaton = new System.Windows.Forms.PictureBox();
            this.BtnAtrapar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicRaton)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRaton
            // 
            this.PicRaton.Image = global::Juego_atrape_el_ratón.Properties.Resources.descargar__1_;
            this.PicRaton.Location = new System.Drawing.Point(913, 294);
            this.PicRaton.Name = "PicRaton";
            this.PicRaton.Size = new System.Drawing.Size(107, 121);
            this.PicRaton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRaton.TabIndex = 0;
            this.PicRaton.TabStop = false;
            // 
            // BtnAtrapar
            // 
            this.BtnAtrapar.BackColor = System.Drawing.Color.Peru;
            this.BtnAtrapar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrapar.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtrapar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAtrapar.Location = new System.Drawing.Point(62, 84);
            this.BtnAtrapar.Name = "BtnAtrapar";
            this.BtnAtrapar.Size = new System.Drawing.Size(124, 58);
            this.BtnAtrapar.TabIndex = 1;
            this.BtnAtrapar.Text = "Salir";
            this.BtnAtrapar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deslice el mouse sobre el ratón para atraparlo.. buena suerte !!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Peru;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalir.Location = new System.Drawing.Point(12, 380);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(124, 58);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Atrapar";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAtrapar);
            this.Controls.Add(this.PicRaton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicRaton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRaton;
        private System.Windows.Forms.Button BtnAtrapar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalir;
    }
}

