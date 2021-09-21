
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
            this.BtnMoverderecha = new System.Windows.Forms.Button();
            this.BtnMoverIzquierda = new System.Windows.Forms.Button();
            this.BtnArriba = new System.Windows.Forms.Button();
            this.BtnAbajo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_click
            // 
            this.Btn_click.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_click.Location = new System.Drawing.Point(215, 372);
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
            this.LblRojo.Location = new System.Drawing.Point(377, 308);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(100, 23);
            this.LblRojo.TabIndex = 1;
            // 
            // Btn_azul
            // 
            this.Btn_azul.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_azul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_azul.Location = new System.Drawing.Point(449, 381);
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
            this.LblBlanco.Location = new System.Drawing.Point(345, 234);
            this.LblBlanco.Name = "LblBlanco";
            this.LblBlanco.Size = new System.Drawing.Size(100, 23);
            this.LblBlanco.TabIndex = 3;
            // 
            // BtnMoverderecha
            // 
            this.BtnMoverderecha.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnMoverderecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMoverderecha.Location = new System.Drawing.Point(-1, -1);
            this.BtnMoverderecha.Name = "BtnMoverderecha";
            this.BtnMoverderecha.Size = new System.Drawing.Size(159, 50);
            this.BtnMoverderecha.TabIndex = 4;
            this.BtnMoverderecha.Text = "Deslizar a la derecha";
            this.BtnMoverderecha.UseVisualStyleBackColor = false;
            this.BtnMoverderecha.Click += new System.EventHandler(this.BtnMoverderecha_Click);
            this.BtnMoverderecha.MouseHover += new System.EventHandler(this.BtnMoverderecha_Click);
            // 
            // BtnMoverIzquierda
            // 
            this.BtnMoverIzquierda.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnMoverIzquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMoverIzquierda.Location = new System.Drawing.Point(642, -1);
            this.BtnMoverIzquierda.Name = "BtnMoverIzquierda";
            this.BtnMoverIzquierda.Size = new System.Drawing.Size(159, 50);
            this.BtnMoverIzquierda.TabIndex = 5;
            this.BtnMoverIzquierda.Text = "Deslizar a la izquierda";
            this.BtnMoverIzquierda.UseVisualStyleBackColor = false;
            this.BtnMoverIzquierda.Click += new System.EventHandler(this.BtnMoverIzquierda_Click);
            this.BtnMoverIzquierda.MouseHover += new System.EventHandler(this.BtnMoverIzquierda_Click);
            // 
            // BtnArriba
            // 
            this.BtnArriba.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnArriba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArriba.Location = new System.Drawing.Point(-1, 96);
            this.BtnArriba.Name = "BtnArriba";
            this.BtnArriba.Size = new System.Drawing.Size(159, 50);
            this.BtnArriba.TabIndex = 6;
            this.BtnArriba.Text = "Deslizar hacia abajo ";
            this.BtnArriba.UseVisualStyleBackColor = false;
            this.BtnArriba.Click += new System.EventHandler(this.button1_Click);
            this.BtnArriba.MouseHover += new System.EventHandler(this.button1_Click);
            // 
            // BtnAbajo
            // 
            this.BtnAbajo.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAbajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbajo.Location = new System.Drawing.Point(642, 436);
            this.BtnAbajo.Name = "BtnAbajo";
            this.BtnAbajo.Size = new System.Drawing.Size(159, 50);
            this.BtnAbajo.TabIndex = 7;
            this.BtnAbajo.Text = "Deslizar hacia arriba ";
            this.BtnAbajo.UseVisualStyleBackColor = false;
            this.BtnAbajo.Click += new System.EventHandler(this.BtnAbajo_Click);
            this.BtnAbajo.MouseHover += new System.EventHandler(this.BtnAbajo_Click);
            // 
            // Form_accion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.BtnAbajo);
            this.Controls.Add(this.BtnArriba);
            this.Controls.Add(this.BtnMoverIzquierda);
            this.Controls.Add(this.BtnMoverderecha);
            this.Controls.Add(this.LblBlanco);
            this.Controls.Add(this.Btn_azul);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.Btn_click);
            this.Name = "Form_accion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRORMULARIO DE PRRUEBA DE MOVIMIENTO DE LABEL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_click;
        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Button Btn_azul;
        private System.Windows.Forms.Label LblBlanco;
        private System.Windows.Forms.Button BtnMoverderecha;
        private System.Windows.Forms.Button BtnMoverIzquierda;
        private System.Windows.Forms.Button BtnArriba;
        private System.Windows.Forms.Button BtnAbajo;
    }
}

