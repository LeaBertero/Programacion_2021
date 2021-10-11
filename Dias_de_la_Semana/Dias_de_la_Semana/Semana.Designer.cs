
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(23, 29);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(140, 40);
            this.BtnMostrar.TabIndex = 0;
            this.BtnMostrar.Text = "Mostrar semana";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // LblVerSemana
            // 
            this.LblVerSemana.BackColor = System.Drawing.Color.Salmon;
            this.LblVerSemana.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerSemana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblVerSemana.Location = new System.Drawing.Point(94, 112);
            this.LblVerSemana.Name = "LblVerSemana";
            this.LblVerSemana.Size = new System.Drawing.Size(196, 282);
            this.LblVerSemana.TabIndex = 1;
            this.LblVerSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblVerSemana.Visible = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(321, 404);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(69, 32);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(234, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ocultar semana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(402, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblVerSemana);
            this.Controls.Add(this.BtnMostrar);
            this.Name = "FormSemana";
            this.Text = "Dias de la semana y semana completa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label LblVerSemana;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button button1;
    }
}

