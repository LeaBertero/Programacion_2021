
namespace Juego_atrape_el_ratón
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.BtnIgual = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.TxtSigno = new System.Windows.Forms.TextBox();
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnIgual
            // 
            this.BtnIgual.BackColor = System.Drawing.Color.Silver;
            this.BtnIgual.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.Location = new System.Drawing.Point(369, 30);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(122, 39);
            this.BtnIgual.TabIndex = 0;
            this.BtnIgual.Text = "Resulado";
            this.BtnIgual.UseVisualStyleBackColor = false;
            this.BtnIgual.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.Color.Orange;
            this.LblRes.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblRes.Location = new System.Drawing.Point(515, 30);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(130, 39);
            this.LblRes.TabIndex = 1;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSigno
            // 
            this.TxtSigno.BackColor = System.Drawing.Color.Red;
            this.TxtSigno.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSigno.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtSigno.Location = new System.Drawing.Point(127, 30);
            this.TxtSigno.Name = "TxtSigno";
            this.TxtSigno.Size = new System.Drawing.Size(100, 33);
            this.TxtSigno.TabIndex = 2;
            // 
            // TxtOper1
            // 
            this.TxtOper1.BackColor = System.Drawing.Color.Red;
            this.TxtOper1.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOper1.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtOper1.Location = new System.Drawing.Point(12, 30);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 33);
            this.TxtOper1.TabIndex = 3;
            // 
            // TxtOper2
            // 
            this.TxtOper2.BackColor = System.Drawing.Color.Red;
            this.TxtOper2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOper2.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtOper2.Location = new System.Drawing.Point(245, 30);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 33);
            this.TxtOper2.TabIndex = 4;
            // 
            // FrmCalculadora
            // 
            this.AcceptButton = this.BtnIgual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(670, 100);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.TxtOper1);
            this.Controls.Add(this.TxtSigno);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnIgual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.TextBox TxtSigno;
        private System.Windows.Forms.TextBox TxtOper1;
        private System.Windows.Forms.TextBox TxtOper2;
    }
}