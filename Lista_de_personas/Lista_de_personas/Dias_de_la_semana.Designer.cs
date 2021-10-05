
namespace Lista_de_personas
{
    partial class Dias_de_la_semana
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
            this.BtnSemana = new System.Windows.Forms.Button();
            this.LblSemana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSemana
            // 
            this.BtnSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSemana.Location = new System.Drawing.Point(103, 104);
            this.BtnSemana.Name = "BtnSemana";
            this.BtnSemana.Size = new System.Drawing.Size(205, 41);
            this.BtnSemana.TabIndex = 0;
            this.BtnSemana.Text = "Inciar dia de la semana";
            this.BtnSemana.UseVisualStyleBackColor = true;
            this.BtnSemana.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblSemana
            // 
            this.LblSemana.BackColor = System.Drawing.Color.LightCoral;
            this.LblSemana.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblSemana.Location = new System.Drawing.Point(122, 181);
            this.LblSemana.Name = "LblSemana";
            this.LblSemana.Size = new System.Drawing.Size(176, 54);
            this.LblSemana.TabIndex = 1;
            this.LblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSemana.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Días de la semana -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dias_de_la_semana
            // 
            this.AcceptButton = this.BtnSemana;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSemana);
            this.Controls.Add(this.BtnSemana);
            this.Name = "Dias_de_la_semana";
            this.Text = "Dias de la semana";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSemana;
        private System.Windows.Forms.Label LblSemana;
        private System.Windows.Forms.Label label1;
    }
}

