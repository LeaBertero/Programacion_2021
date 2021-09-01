
namespace condicional
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.TxtOperacion = new System.Windows.Forms.TextBox();
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(85, 27);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(61, 13);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "operando 1";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(365, 27);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(58, 13);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "operador 2";
            // 
            // TxtOper1
            // 
            this.TxtOper1.Location = new System.Drawing.Point(88, 68);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 20);
            this.TxtOper1.TabIndex = 2;
            // 
            // TxtOperacion
            // 
            this.TxtOperacion.Location = new System.Drawing.Point(228, 68);
            this.TxtOperacion.Name = "TxtOperacion";
            this.TxtOperacion.Size = new System.Drawing.Size(100, 20);
            this.TxtOperacion.TabIndex = 3;
            // 
            // TxtOper2
            // 
            this.TxtOper2.Location = new System.Drawing.Point(368, 68);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 20);
            this.TxtOper2.TabIndex = 4;
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(620, 75);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(35, 13);
            this.LblRes.TabIndex = 5;
            this.LblRes.Text = "label3";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcular.Location = new System.Drawing.Point(504, 60);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(84, 35);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(751, 159);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.TxtOperacion);
            this.Controls.Add(this.TxtOper1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox TxtOper1;
        private System.Windows.Forms.TextBox TxtOperacion;
        private System.Windows.Forms.TextBox TxtOper2;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

