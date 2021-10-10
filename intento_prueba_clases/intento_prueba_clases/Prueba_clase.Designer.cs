
namespace intento_prueba_clases
{
    partial class Prueba_clase
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
            this.components = new System.ComponentModel.Container();
            this.BtnClick = new System.Windows.Forms.Button();
            this.TimerOne = new System.Windows.Forms.Timer(this.components);
            this.LblMundo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAzul = new System.Windows.Forms.Button();
            this.LblAzul = new System.Windows.Forms.Label();
            this.LblRojo = new System.Windows.Forms.Label();
            this.BtnRojo = new System.Windows.Forms.Button();
            this.BtnAparecercontroles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClick
            // 
            this.BtnClick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnClick.Location = new System.Drawing.Point(284, 85);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(85, 55);
            this.BtnClick.TabIndex = 0;
            this.BtnClick.Text = "Click";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // TimerOne
            // 
            this.TimerOne.Enabled = true;
            this.TimerOne.Interval = 500;
            // 
            // LblMundo
            // 
            this.LblMundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMundo.Location = new System.Drawing.Point(3, 85);
            this.LblMundo.Name = "LblMundo";
            this.LblMundo.Size = new System.Drawing.Size(261, 55);
            this.LblMundo.TabIndex = 1;
            this.LblMundo.Text = "Click sobre --> ese botón para mostrar el mensaje";
            this.LblMundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMundo.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = " Aparecer mensaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(846, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tratar de salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAzul
            // 
            this.BtnAzul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAzul.Location = new System.Drawing.Point(21, 215);
            this.BtnAzul.Name = "BtnAzul";
            this.BtnAzul.Size = new System.Drawing.Size(85, 55);
            this.BtnAzul.TabIndex = 4;
            this.BtnAzul.Text = "Ejecutar Azul";
            this.BtnAzul.UseVisualStyleBackColor = true;
            this.BtnAzul.Click += new System.EventHandler(this.BtnAzul_Click);
            // 
            // LblAzul
            // 
            this.LblAzul.BackColor = System.Drawing.Color.Blue;
            this.LblAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAzul.Location = new System.Drawing.Point(17, 291);
            this.LblAzul.Name = "LblAzul";
            this.LblAzul.Size = new System.Drawing.Size(261, 55);
            this.LblAzul.TabIndex = 5;
            this.LblAzul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAzul.Visible = false;
            // 
            // LblRojo
            // 
            this.LblRojo.BackColor = System.Drawing.Color.Red;
            this.LblRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRojo.Location = new System.Drawing.Point(680, 290);
            this.LblRojo.Name = "LblRojo";
            this.LblRojo.Size = new System.Drawing.Size(261, 55);
            this.LblRojo.TabIndex = 6;
            this.LblRojo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRojo.Visible = false;
            // 
            // BtnRojo
            // 
            this.BtnRojo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnRojo.Location = new System.Drawing.Point(846, 215);
            this.BtnRojo.Name = "BtnRojo";
            this.BtnRojo.Size = new System.Drawing.Size(85, 55);
            this.BtnRojo.TabIndex = 7;
            this.BtnRojo.Text = "Ejecutar Rojo";
            this.BtnRojo.UseVisualStyleBackColor = true;
            this.BtnRojo.Click += new System.EventHandler(this.BtnRojo_Click);
            // 
            // BtnAparecercontroles
            // 
            this.BtnAparecercontroles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAparecercontroles.Location = new System.Drawing.Point(432, 226);
            this.BtnAparecercontroles.Name = "BtnAparecercontroles";
            this.BtnAparecercontroles.Size = new System.Drawing.Size(113, 44);
            this.BtnAparecercontroles.TabIndex = 8;
            this.BtnAparecercontroles.Text = "Ejecutar controles";
            this.BtnAparecercontroles.UseVisualStyleBackColor = true;
            this.BtnAparecercontroles.Click += new System.EventHandler(this.BtnAparecercontroles_Click);
            // 
            // Prueba_clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(965, 389);
            this.Controls.Add(this.BtnAparecercontroles);
            this.Controls.Add(this.BtnRojo);
            this.Controls.Add(this.LblRojo);
            this.Controls.Add(this.LblAzul);
            this.Controls.Add(this.BtnAzul);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblMundo);
            this.Controls.Add(this.BtnClick);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Prueba_clase";
            this.Text = "Prueba clases";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.Timer TimerOne;
        private System.Windows.Forms.Label LblMundo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAzul;
        private System.Windows.Forms.Label LblAzul;
        private System.Windows.Forms.Label LblRojo;
        private System.Windows.Forms.Button BtnRojo;
        private System.Windows.Forms.Button BtnAparecercontroles;
    }
}

