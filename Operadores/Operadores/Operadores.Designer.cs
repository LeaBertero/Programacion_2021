
namespace Operadores
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
            this.LblRes = new System.Windows.Forms.Label();
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.TxtOperador = new System.Windows.Forms.TextBox();
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRes
            // 
            this.BtnRes.Location = new System.Drawing.Point(36, 180);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(104, 52);
            this.BtnRes.TabIndex = 0;
            this.BtnRes.Text = "Calcular";
            this.BtnRes.UseVisualStyleBackColor = true;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.Color.LightCoral;
            this.LblRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblRes.Location = new System.Drawing.Point(37, 256);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(105, 52);
            this.LblRes.TabIndex = 1;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtOper2
            // 
            this.TxtOper2.Location = new System.Drawing.Point(40, 126);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 20);
            this.TxtOper2.TabIndex = 2;
            // 
            // TxtOperador
            // 
            this.TxtOperador.Location = new System.Drawing.Point(40, 77);
            this.TxtOperador.Name = "TxtOperador";
            this.TxtOperador.Size = new System.Drawing.Size(100, 20);
            this.TxtOperador.TabIndex = 3;
            // 
            // TxtOper1
            // 
            this.TxtOper1.Location = new System.Drawing.Point(40, 24);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 20);
            this.TxtOper1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(183, 327);
            this.Controls.Add(this.TxtOper1);
            this.Controls.Add(this.TxtOperador);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnRes);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.TextBox TxtOper2;
        private System.Windows.Forms.TextBox TxtOperador;
        private System.Windows.Forms.TextBox TxtOper1;
    }
}

