
namespace Prueba_variables_contador
{
    partial class Contadores_pos_neg
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEntMas = new System.Windows.Forms.Button();
            this.LblContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblContador2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEnTMenos = new System.Windows.Forms.Button();
            this.BtnAzul = new System.Windows.Forms.Button();
            this.BtnAmarillo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnCerrar.Location = new System.Drawing.Point(421, 260);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(176, 143);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.button1_Click);
            this.BtnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCerrar_MouseMove);
            // 
            // BtnEntMas
            // 
            this.BtnEntMas.BackColor = System.Drawing.Color.Ivory;
            this.BtnEntMas.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntMas.Location = new System.Drawing.Point(57, 90);
            this.BtnEntMas.Name = "BtnEntMas";
            this.BtnEntMas.Size = new System.Drawing.Size(202, 51);
            this.BtnEntMas.TabIndex = 1;
            this.BtnEntMas.Text = "Iniciar enteros (+)";
            this.BtnEntMas.UseVisualStyleBackColor = false;
            this.BtnEntMas.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // LblContador
            // 
            this.LblContador.BackColor = System.Drawing.Color.DodgerBlue;
            this.LblContador.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador.ForeColor = System.Drawing.SystemColors.Control;
            this.LblContador.Location = new System.Drawing.Point(553, 162);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(228, 51);
            this.LblContador.TabIndex = 2;
            this.LblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contador de números enteros positivos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblContador2
            // 
            this.LblContador2.BackColor = System.Drawing.Color.Yellow;
            this.LblContador2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblContador2.Location = new System.Drawing.Point(218, 160);
            this.LblContador2.Name = "LblContador2";
            this.LblContador2.Size = new System.Drawing.Size(228, 53);
            this.LblContador2.TabIndex = 4;
            this.LblContador2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(661, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 58);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contador de números enteros negativo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEnTMenos
            // 
            this.BtnEnTMenos.BackColor = System.Drawing.Color.Ivory;
            this.BtnEnTMenos.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnTMenos.Location = new System.Drawing.Point(742, 90);
            this.BtnEnTMenos.Name = "BtnEnTMenos";
            this.BtnEnTMenos.Size = new System.Drawing.Size(202, 53);
            this.BtnEnTMenos.TabIndex = 6;
            this.BtnEnTMenos.Text = "Iniciar enteros (-)";
            this.BtnEnTMenos.UseVisualStyleBackColor = false;
            this.BtnEnTMenos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnAzul
            // 
            this.BtnAzul.BackColor = System.Drawing.Color.Ivory;
            this.BtnAzul.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAzul.Location = new System.Drawing.Point(815, 319);
            this.BtnAzul.Name = "BtnAzul";
            this.BtnAzul.Size = new System.Drawing.Size(202, 83);
            this.BtnAzul.TabIndex = 7;
            this.BtnAzul.Text = "Mover rectángulo azul";
            this.BtnAzul.UseVisualStyleBackColor = false;
            this.BtnAzul.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAmarillo
            // 
            this.BtnAmarillo.BackColor = System.Drawing.Color.Ivory;
            this.BtnAmarillo.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAmarillo.Location = new System.Drawing.Point(12, 320);
            this.BtnAmarillo.Name = "BtnAmarillo";
            this.BtnAmarillo.Size = new System.Drawing.Size(202, 83);
            this.BtnAmarillo.TabIndex = 8;
            this.BtnAmarillo.Text = "Mover rectángulo amarillo";
            this.BtnAmarillo.UseVisualStyleBackColor = false;
            this.BtnAmarillo.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Black;
            this.BtnSalir.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnSalir.Location = new System.Drawing.Point(421, 18);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(170, 125);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Utilice el botón ROJO para salir del programa";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Contadores_pos_neg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1029, 414);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAmarillo);
            this.Controls.Add(this.BtnAzul);
            this.Controls.Add(this.BtnEnTMenos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblContador2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEntMas);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblContador);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Contadores_pos_neg";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEntMas;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label variable;
        private System.Windows.Forms.Label var;
        private System.Windows.Forms.Label LblContador2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEnTMenos;
        private System.Windows.Forms.Button BtnAzul;
        private System.Windows.Forms.Button BtnAmarillo;
        private System.Windows.Forms.Button BtnSalir;
    }
}

