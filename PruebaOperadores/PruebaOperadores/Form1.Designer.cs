namespace PruebaOperadores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtMulti = new System.Windows.Forms.Button();
            this.Txtoper1 = new System.Windows.Forms.TextBox();
            this.Txtoper2 = new System.Windows.Forms.TextBox();
            this.TxtRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtMulti
            // 
            this.BtMulti.Location = new System.Drawing.Point(38, 155);
            this.BtMulti.Name = "BtMulti";
            this.BtMulti.Size = new System.Drawing.Size(101, 40);
            this.BtMulti.TabIndex = 0;
            this.BtMulti.Text = "Multiplicar";
            this.BtMulti.UseVisualStyleBackColor = true;
            this.BtMulti.Click += new System.EventHandler(this.BtMulti_Click);
            // 
            // Txtoper1
            // 
            this.Txtoper1.Location = new System.Drawing.Point(136, 34);
            this.Txtoper1.Name = "Txtoper1";
            this.Txtoper1.Size = new System.Drawing.Size(100, 23);
            this.Txtoper1.TabIndex = 1;
            // 
            // Txtoper2
            // 
            this.Txtoper2.Location = new System.Drawing.Point(136, 84);
            this.Txtoper2.Name = "Txtoper2";
            this.Txtoper2.Size = new System.Drawing.Size(100, 23);
            this.Txtoper2.TabIndex = 2;
            // 
            // TxtRes
            // 
            this.TxtRes.Location = new System.Drawing.Point(145, 165);
            this.TxtRes.Name = "TxtRes";
            this.TxtRes.Size = new System.Drawing.Size(67, 23);
            this.TxtRes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operador 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtMulti;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRes);
            this.Controls.Add(this.Txtoper2);
            this.Controls.Add(this.Txtoper1);
            this.Controls.Add(this.BtMulti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtMulti;
        private System.Windows.Forms.TextBox Txtoper1;
        private System.Windows.Forms.TextBox Txtoper2;
        private System.Windows.Forms.TextBox TxtRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
