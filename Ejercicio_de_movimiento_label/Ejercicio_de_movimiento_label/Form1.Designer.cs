
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
            this.Btn_azul = new System.Windows.Forms.Button();
            this.LblBlanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_click
            // 
            this.Btn_click.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_click.Location = new System.Drawing.Point(39, 294);
            this.Btn_click.Name = "Btn_click";
            this.Btn_click.Size = new System.Drawing.Size(133, 50);
            this.Btn_click.TabIndex = 0;
            this.Btn_click.Text = "Click 1";
            this.Btn_click.UseVisualStyleBackColor = false;
            this.Btn_click.Click += new System.EventHandler(this.Btn_click_Click);
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Location = new System.Drawing.Point(291, 303);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(100, 23);
            this.LblRojo.TabIndex = 1;
            this.LblRojo.Visible = false;
            // 
            // Btn_azul
            // 
            this.Btn_azul.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_azul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_azul.Location = new System.Drawing.Point(39, 372);
            this.Btn_azul.Name = "Btn_azul";
            this.Btn_azul.Size = new System.Drawing.Size(133, 50);
            this.Btn_azul.TabIndex = 2;
            this.Btn_azul.Text = "Click 2";
            this.Btn_azul.UseVisualStyleBackColor = false;
            this.Btn_azul.Click += new System.EventHandler(this.Btn_azul_Click);
            // 
            // LblBlanco
            // 
            this.LblBlanco.BackColor = System.Drawing.Color.White;
            this.LblBlanco.Location = new System.Drawing.Point(388, 391);
            this.LblBlanco.Name = "LblBlanco";
            this.LblBlanco.Size = new System.Drawing.Size(100, 23);
            this.LblBlanco.TabIndex = 3;
            // 
            // Form_accion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBlanco);
            this.Controls.Add(this.Btn_azul);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.Btn_click);
            this.Name = "Form_accion";
            this.Text = "PRORMULARIO DE PRRUEBA DE MOVIMIENTO DE LABEL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_click;
        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Button Btn_azul;
        private System.Windows.Forms.Label LblBlanco;
    }
}

