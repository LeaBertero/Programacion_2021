
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
            this.LblBlanco = new System.Windows.Forms.Label();
            this.BtnMoverderecha = new System.Windows.Forms.Button();
            this.BtnMoverIzquierda = new System.Windows.Forms.Button();
            this.Btn_abajo = new System.Windows.Forms.Button();
            this.BtnAbajo = new System.Windows.Forms.Button();
            this.Lblprueba = new System.Windows.Forms.Label();
            this.BtnPrueba = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_click
            // 
            this.Btn_click.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_click.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_click.Location = new System.Drawing.Point(354, 283);
            this.Btn_click.Name = "Btn_click";
            this.Btn_click.Size = new System.Drawing.Size(133, 71);
            this.Btn_click.TabIndex = 0;
            this.Btn_click.Text = "Mover cuadrado blanco";
            this.Btn_click.UseVisualStyleBackColor = false;
            this.Btn_click.Click += new System.EventHandler(this.Btn_click_Click);
            // 
            // LblBlanco
            // 
            this.LblBlanco.BackColor = System.Drawing.Color.White;
            this.LblBlanco.Location = new System.Drawing.Point(746, 179);
            this.LblBlanco.Name = "LblBlanco";
            this.LblBlanco.Size = new System.Drawing.Size(100, 86);
            this.LblBlanco.TabIndex = 3;
            // 
            // BtnMoverderecha
            // 
            this.BtnMoverderecha.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnMoverderecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMoverderecha.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoverderecha.Location = new System.Drawing.Point(-1, 436);
            this.BtnMoverderecha.Name = "BtnMoverderecha";
            this.BtnMoverderecha.Size = new System.Drawing.Size(250, 50);
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
            this.BtnMoverIzquierda.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoverIzquierda.Location = new System.Drawing.Point(593, -1);
            this.BtnMoverIzquierda.Name = "BtnMoverIzquierda";
            this.BtnMoverIzquierda.Size = new System.Drawing.Size(255, 50);
            this.BtnMoverIzquierda.TabIndex = 5;
            this.BtnMoverIzquierda.Text = "Deslizar a la izquierda";
            this.BtnMoverIzquierda.UseVisualStyleBackColor = false;
            this.BtnMoverIzquierda.Click += new System.EventHandler(this.BtnMoverIzquierda_Click);
            this.BtnMoverIzquierda.MouseHover += new System.EventHandler(this.BtnMoverIzquierda_Click);
            // 
            // Btn_abajo
            // 
            this.Btn_abajo.BackColor = System.Drawing.Color.Chartreuse;
            this.Btn_abajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_abajo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_abajo.Location = new System.Drawing.Point(593, 60);
            this.Btn_abajo.Name = "Btn_abajo";
            this.Btn_abajo.Size = new System.Drawing.Size(255, 50);
            this.Btn_abajo.TabIndex = 6;
            this.Btn_abajo.Text = "Deslizar hacia abajo ";
            this.Btn_abajo.UseVisualStyleBackColor = false;
            this.Btn_abajo.Click += new System.EventHandler(this.button1_Click);
            this.Btn_abajo.MouseHover += new System.EventHandler(this.button1_Click);
            // 
            // BtnAbajo
            // 
            this.BtnAbajo.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAbajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbajo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbajo.Location = new System.Drawing.Point(-1, 375);
            this.BtnAbajo.Name = "BtnAbajo";
            this.BtnAbajo.Size = new System.Drawing.Size(250, 50);
            this.BtnAbajo.TabIndex = 7;
            this.BtnAbajo.Text = "Deslizar hacia arriba ";
            this.BtnAbajo.UseVisualStyleBackColor = false;
            this.BtnAbajo.Click += new System.EventHandler(this.BtnAbajo_Click);
            this.BtnAbajo.MouseHover += new System.EventHandler(this.BtnAbajo_Click);
            // 
            // Lblprueba
            // 
            this.Lblprueba.BackColor = System.Drawing.Color.Red;
            this.Lblprueba.Location = new System.Drawing.Point(1, 179);
            this.Lblprueba.Name = "Lblprueba";
            this.Lblprueba.Size = new System.Drawing.Size(100, 86);
            this.Lblprueba.TabIndex = 9;
            // 
            // BtnPrueba
            // 
            this.BtnPrueba.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnPrueba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrueba.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrueba.Location = new System.Drawing.Point(354, 138);
            this.BtnPrueba.Name = "BtnPrueba";
            this.BtnPrueba.Size = new System.Drawing.Size(133, 71);
            this.BtnPrueba.TabIndex = 8;
            this.BtnPrueba.Text = "Mover cuadrado rojo";
            this.BtnPrueba.UseVisualStyleBackColor = false;
            this.BtnPrueba.Click += new System.EventHandler(this.BtnPrueba_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 10;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.BtnSalir.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.MediumBlue;
            this.BtnSalir.Location = new System.Drawing.Point(354, 225);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(133, 39);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form_accion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(847, 485);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Btn_click);
            this.Controls.Add(this.BtnPrueba);
            this.Controls.Add(this.BtnMoverderecha);
            this.Controls.Add(this.BtnAbajo);
            this.Controls.Add(this.Btn_abajo);
            this.Controls.Add(this.BtnMoverIzquierda);
            this.Controls.Add(this.Lblprueba);
            this.Controls.Add(this.LblBlanco);
            this.Name = "Form_accion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRORMULARIO DE PRRUEBA DE MOVIMIENTO DE LABEL";
            this.Load += new System.EventHandler(this.Form_accion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_click;
        private System.Windows.Forms.Label LblBlanco;
        private System.Windows.Forms.Button BtnMoverderecha;
        private System.Windows.Forms.Button BtnMoverIzquierda;
        private System.Windows.Forms.Button Btn_abajo;
        private System.Windows.Forms.Button BtnAbajo;
        private System.Windows.Forms.Label Lblprueba;
        private System.Windows.Forms.Button BtnPrueba;
        private System.Windows.Forms.Button BtnSalir;
    }
}

