
namespace FormOperadores
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
            this.BtnRes = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.TxtOperador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnRes.Location = new System.Drawing.Point(45, 226);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(100, 34);
            this.BtnRes.TabIndex = 0;
            this.BtnRes.Text = "Calcular";
            this.BtnRes.UseVisualStyleBackColor = false;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.Color.LightCoral;
            this.LblResultado.Location = new System.Drawing.Point(45, 291);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(100, 39);
            this.LblResultado.TabIndex = 1;
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtOper1
            // 
            this.TxtOper1.Location = new System.Drawing.Point(45, 27);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 20);
            this.TxtOper1.TabIndex = 2;
            // 
            // TxtOper2
            // 
            this.TxtOper2.Location = new System.Drawing.Point(45, 161);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 20);
            this.TxtOper2.TabIndex = 3;
            // 
            // TxtOperador
            // 
            this.TxtOperador.Location = new System.Drawing.Point(45, 94);
            this.TxtOperador.Name = "TxtOperador";
            this.TxtOperador.Size = new System.Drawing.Size(100, 20);
            this.TxtOperador.TabIndex = 4;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(207, 359);
            this.Controls.Add(this.TxtOperador);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.TxtOper1);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnRes);
            this.Name = "Form1";
            this.Text = "Operadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtOper1;
        private System.Windows.Forms.TextBox TxtOper2;
        private System.Windows.Forms.TextBox TxtOperador;
    }
}

