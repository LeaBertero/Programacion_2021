﻿
namespace OPERADOR_PARTE_2
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
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.TxtOperador = new System.Windows.Forms.TextBox();
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnRes.Location = new System.Drawing.Point(416, 120);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(104, 40);
            this.BtnRes.TabIndex = 0;
            this.BtnRes.Text = "Resultado";
            this.BtnRes.UseVisualStyleBackColor = false;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // TxtOper2
            // 
            this.TxtOper2.BackColor = System.Drawing.Color.Turquoise;
            this.TxtOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOper2.ForeColor = System.Drawing.Color.Black;
            this.TxtOper2.Location = new System.Drawing.Point(289, 126);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 26);
            this.TxtOper2.TabIndex = 1;
            this.TxtOper2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtOperador
            // 
            this.TxtOperador.BackColor = System.Drawing.Color.Turquoise;
            this.TxtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOperador.ForeColor = System.Drawing.Color.Black;
            this.TxtOperador.Location = new System.Drawing.Point(160, 126);
            this.TxtOperador.Name = "TxtOperador";
            this.TxtOperador.Size = new System.Drawing.Size(100, 26);
            this.TxtOperador.TabIndex = 2;
            this.TxtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtOper1
            // 
            this.TxtOper1.BackColor = System.Drawing.Color.Turquoise;
            this.TxtOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOper1.ForeColor = System.Drawing.Color.Black;
            this.TxtOper1.Location = new System.Drawing.Point(37, 126);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 26);
            this.TxtOper1.TabIndex = 3;
            this.TxtOper1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.Color.OldLace;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(548, 119);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(111, 40);
            this.LblRes.TabIndex = 4;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operador 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operación";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnRes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(697, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.TxtOper1);
            this.Controls.Add(this.TxtOperador);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.BtnRes);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Name = "Form1";
            this.Text = "Operadores - Parte 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.TextBox TxtOper2;
        private System.Windows.Forms.TextBox TxtOperador;
        private System.Windows.Forms.TextBox TxtOper1;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

