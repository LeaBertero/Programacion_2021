
namespace Intrucciones_de_control_Prueba
{
    partial class Frm_instrucciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.TxtOp2 = new System.Windows.Forms.TextBox();
            this.TxtOperacion = new System.Windows.Forms.TextBox();
            this.TxtOp1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(606, 80);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(96, 43);
            this.LblRes.TabIndex = 0;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIgual
            // 
            this.BtnIgual.Location = new System.Drawing.Point(466, 80);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(100, 43);
            this.BtnIgual.TabIndex = 4;
            this.BtnIgual.Text = "Igual";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // TxtOp2
            // 
            this.TxtOp2.Location = new System.Drawing.Point(324, 92);
            this.TxtOp2.Name = "TxtOp2";
            this.TxtOp2.Size = new System.Drawing.Size(100, 20);
            this.TxtOp2.TabIndex = 5;
            // 
            // TxtOperacion
            // 
            this.TxtOperacion.Location = new System.Drawing.Point(174, 92);
            this.TxtOperacion.Name = "TxtOperacion";
            this.TxtOperacion.Size = new System.Drawing.Size(100, 20);
            this.TxtOperacion.TabIndex = 6;
            // 
            // TxtOp1
            // 
            this.TxtOp1.Location = new System.Drawing.Point(32, 92);
            this.TxtOp1.Name = "TxtOp1";
            this.TxtOp1.Size = new System.Drawing.Size(100, 20);
            this.TxtOp1.TabIndex = 7;
            // 
            // Frm_instrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(726, 178);
            this.Controls.Add(this.TxtOp1);
            this.Controls.Add(this.TxtOperacion);
            this.Controls.Add(this.TxtOp2);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRes);
            this.Name = "Frm_instrucciones";
            this.Opacity = 0.8D;
            this.Text = " Instrucciones de control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.TextBox TxtOp2;
        private System.Windows.Forms.TextBox TxtOperacion;
        private System.Windows.Forms.TextBox TxtOp1;
    }
}