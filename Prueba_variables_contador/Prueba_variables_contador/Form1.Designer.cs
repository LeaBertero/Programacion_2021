
namespace Prueba_variables_contador
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.LblContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblContador2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Black;
            this.BtnCerrar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnCerrar.Location = new System.Drawing.Point(523, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(90, 40);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.Ivory;
            this.BtnInicio.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Location = new System.Drawing.Point(71, 119);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(125, 50);
            this.BtnInicio.TabIndex = 1;
            this.BtnInicio.Text = "Iniciar";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // LblContador
            // 
            this.LblContador.BackColor = System.Drawing.Color.Yellow;
            this.LblContador.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblContador.Location = new System.Drawing.Point(275, 112);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(228, 57);
            this.LblContador.TabIndex = 2;
            this.LblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblContador.Click += new System.EventHandler(this.LblContador_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contador de números";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblContador2
            // 
            this.LblContador2.BackColor = System.Drawing.Color.Yellow;
            this.LblContador2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblContador2.Location = new System.Drawing.Point(275, 195);
            this.LblContador2.Name = "LblContador2";
            this.LblContador2.Size = new System.Drawing.Size(228, 57);
            this.LblContador2.TabIndex = 4;
            this.LblContador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnInicio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(625, 307);
            this.ControlBox = false;
            this.Controls.Add(this.LblContador2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblContador);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.BtnCerrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label variable;
        private System.Windows.Forms.Label var;
        private System.Windows.Forms.Label LblContador2;
    }
}

