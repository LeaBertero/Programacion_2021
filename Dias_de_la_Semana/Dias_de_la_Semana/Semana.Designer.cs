
namespace Dias_de_la_Semana
{
    partial class FormSemana
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
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.LblVerSemana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(55, 25);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(135, 40);
            this.BtnMostrar.TabIndex = 0;
            this.BtnMostrar.Text = "Mostrar semana";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // LblVerSemana
            // 
            this.LblVerSemana.BackColor = System.Drawing.Color.Salmon;
            this.LblVerSemana.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerSemana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblVerSemana.Location = new System.Drawing.Point(28, 104);
            this.LblVerSemana.Name = "LblVerSemana";
            this.LblVerSemana.Size = new System.Drawing.Size(196, 245);
            this.LblVerSemana.TabIndex = 1;
            this.LblVerSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblVerSemana.Visible = false;
            // 
            // FormSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 376);
            this.Controls.Add(this.LblVerSemana);
            this.Controls.Add(this.BtnMostrar);
            this.Name = "FormSemana";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label LblVerSemana;
    }
}

