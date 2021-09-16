
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
            this.BtnConMas = new System.Windows.Forms.Button();
            this.LblContadorblue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblContadorYellow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnContMenos = new System.Windows.Forms.Button();
            this.BtnMovAzul = new System.Windows.Forms.Button();
            this.MovAmarillo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblClose = new System.Windows.Forms.Label();
            this.BtnAparecer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCerrar.FlatAppearance.BorderSize = 40;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCerrar.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnCerrar.Location = new System.Drawing.Point(865, 469);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(152, 56);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.button1_Click);
            this.BtnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCerrar_MouseMove);
            // 
            // BtnConMas
            // 
            this.BtnConMas.BackColor = System.Drawing.Color.Ivory;
            this.BtnConMas.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConMas.Location = new System.Drawing.Point(57, 90);
            this.BtnConMas.Name = "BtnConMas";
            this.BtnConMas.Size = new System.Drawing.Size(202, 51);
            this.BtnConMas.TabIndex = 1;
            this.BtnConMas.Text = "Iniciar enteros (+)";
            this.BtnConMas.UseVisualStyleBackColor = false;
            this.BtnConMas.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // LblContadorblue
            // 
            this.LblContadorblue.BackColor = System.Drawing.Color.DodgerBlue;
            this.LblContadorblue.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContadorblue.ForeColor = System.Drawing.SystemColors.Control;
            this.LblContadorblue.Location = new System.Drawing.Point(539, 160);
            this.LblContadorblue.Name = "LblContadorblue";
            this.LblContadorblue.Size = new System.Drawing.Size(228, 53);
            this.LblContadorblue.TabIndex = 2;
            this.LblContadorblue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // LblContadorYellow
            // 
            this.LblContadorYellow.BackColor = System.Drawing.Color.Yellow;
            this.LblContadorYellow.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContadorYellow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblContadorYellow.Location = new System.Drawing.Point(204, 160);
            this.LblContadorYellow.Name = "LblContadorYellow";
            this.LblContadorYellow.Size = new System.Drawing.Size(228, 53);
            this.LblContadorYellow.TabIndex = 4;
            this.LblContadorYellow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // BtnContMenos
            // 
            this.BtnContMenos.BackColor = System.Drawing.Color.Ivory;
            this.BtnContMenos.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContMenos.Location = new System.Drawing.Point(742, 90);
            this.BtnContMenos.Name = "BtnContMenos";
            this.BtnContMenos.Size = new System.Drawing.Size(202, 53);
            this.BtnContMenos.TabIndex = 6;
            this.BtnContMenos.Text = "Iniciar enteros (-)";
            this.BtnContMenos.UseVisualStyleBackColor = false;
            this.BtnContMenos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnMovAzul
            // 
            this.BtnMovAzul.BackColor = System.Drawing.Color.Ivory;
            this.BtnMovAzul.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovAzul.Location = new System.Drawing.Point(12, 339);
            this.BtnMovAzul.Name = "BtnMovAzul";
            this.BtnMovAzul.Size = new System.Drawing.Size(202, 83);
            this.BtnMovAzul.TabIndex = 7;
            this.BtnMovAzul.Text = "Mover rectángulo azul";
            this.BtnMovAzul.UseVisualStyleBackColor = false;
            this.BtnMovAzul.Click += new System.EventHandler(this.button2_Click);
            // 
            // MovAmarillo
            // 
            this.MovAmarillo.BackColor = System.Drawing.Color.Ivory;
            this.MovAmarillo.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovAmarillo.Location = new System.Drawing.Point(12, 442);
            this.MovAmarillo.Name = "MovAmarillo";
            this.MovAmarillo.Size = new System.Drawing.Size(202, 83);
            this.MovAmarillo.TabIndex = 8;
            this.MovAmarillo.Text = "Mover rectángulo amarillo";
            this.MovAmarillo.UseVisualStyleBackColor = false;
            this.MovAmarillo.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Lime;
            this.BtnSalir.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnSalir.Location = new System.Drawing.Point(421, 18);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(161, 98);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Utilice el botón ROJO para salir del programa";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblClose
            // 
            this.LblClose.BackColor = System.Drawing.Color.DarkOrange;
            this.LblClose.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblClose.Location = new System.Drawing.Point(204, 186);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(563, 53);
            this.LblClose.TabIndex = 10;
            this.LblClose.Text = "El botón verde, cierra el programa";
            this.LblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblClose.Visible = false;
            // 
            // BtnAparecer
            // 
            this.BtnAparecer.BackColor = System.Drawing.Color.Black;
            this.BtnAparecer.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAparecer.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnAparecer.Location = new System.Drawing.Point(815, 160);
            this.BtnAparecer.Name = "BtnAparecer";
            this.BtnAparecer.Size = new System.Drawing.Size(116, 53);
            this.BtnAparecer.TabIndex = 11;
            this.BtnAparecer.Text = "Click aqui !";
            this.BtnAparecer.UseVisualStyleBackColor = false;
            this.BtnAparecer.Click += new System.EventHandler(this.BtnAparecer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1029, 537);
            this.ControlBox = false;
            this.Controls.Add(this.BtnAparecer);
            this.Controls.Add(this.LblClose);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.MovAmarillo);
            this.Controls.Add(this.BtnMovAzul);
            this.Controls.Add(this.BtnContMenos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblContadorYellow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConMas);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblContadorblue);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConMas;
        private System.Windows.Forms.Label LblContadorblue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label variable;
        private System.Windows.Forms.Label var;
        private System.Windows.Forms.Label LblContadorYellow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnContMenos;
        private System.Windows.Forms.Button BtnMovAzul;
        private System.Windows.Forms.Button MovAmarillo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.Button BtnAparecer;
    }
}

