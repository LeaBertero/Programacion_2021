
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
            this.BtnAparecerRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Lbl1.Location = new System.Drawing.Point(49, 33);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(111, 40);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Número 1";
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl2
            // 
            this.Lbl2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Lbl2.Location = new System.Drawing.Point(368, 33);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(108, 40);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "Número 2";
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtOper1
            // 
            this.TxtOper1.Location = new System.Drawing.Point(52, 101);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 20);
            this.TxtOper1.TabIndex = 2;
            // 
            // TxtOperacion
            // 
            this.TxtOperacion.Location = new System.Drawing.Point(229, 101);
            this.TxtOperacion.Name = "TxtOperacion";
            this.TxtOperacion.Size = new System.Drawing.Size(100, 20);
            this.TxtOperacion.TabIndex = 3;
            // 
            // TxtOper2
            // 
            this.TxtOper2.Location = new System.Drawing.Point(371, 101);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 20);
            this.TxtOper2.TabIndex = 4;
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.Color.Ivory;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(759, 80);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(113, 58);
            this.LblRes.TabIndex = 5;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRes.Visible = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcular.Location = new System.Drawing.Point(524, 93);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(84, 35);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // BtnAparecerRes
            // 
            this.BtnAparecerRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAparecerRes.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAparecerRes.Location = new System.Drawing.Point(641, 80);
            this.BtnAparecerRes.Name = "BtnAparecerRes";
            this.BtnAparecerRes.Size = new System.Drawing.Size(97, 61);
            this.BtnAparecerRes.TabIndex = 7;
            this.BtnAparecerRes.Text = "Mostrar resultado";
            this.BtnAparecerRes.UseVisualStyleBackColor = true;
            this.BtnAparecerRes.Click += new System.EventHandler(this.BtnAparecerRes_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(913, 197);
            this.Controls.Add(this.BtnAparecerRes);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.TxtOperacion);
            this.Controls.Add(this.TxtOper1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Name = "Form1";
            this.Text = "Condicional";
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
        private System.Windows.Forms.Button BtnAparecerRes;
    }
}

