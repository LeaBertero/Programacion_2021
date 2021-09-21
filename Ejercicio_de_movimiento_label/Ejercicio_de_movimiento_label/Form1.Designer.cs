
namespace Ejercicio_de_movimiento_label
{
    partial class Form_accion
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
            this.Btn_click = new System.Windows.Forms.Button();
            this.LblRojo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_click
            // 
            this.Btn_click.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_click.Location = new System.Drawing.Point(55, 45);
            this.Btn_click.Name = "Btn_click";
            this.Btn_click.Size = new System.Drawing.Size(133, 50);
            this.Btn_click.TabIndex = 0;
            this.Btn_click.Text = "Click";
            this.Btn_click.UseVisualStyleBackColor = false;
            this.Btn_click.Click += new System.EventHandler(this.Btn_click_Click);
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Location = new System.Drawing.Point(311, 395);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(100, 23);
            this.LblRojo.TabIndex = 1;
            this.LblRojo.Visible = false;
            // 
            // Form_accion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.Btn_click);
            this.Name = "Form_accion";
            this.Text = "PRORMULARIO DE PRRUEBA DE MOVIMIENTO DE LABEL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_click;
        private System.Windows.Forms.Label LblRojo;
    }
}

