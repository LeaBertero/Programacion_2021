
namespace Practica_label_Texbox
{
    partial class FrmSiguiente
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtIngresoFrase = new System.Windows.Forms.TextBox();
            this.BtnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblOriginal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnCerrar.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(364, 289);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(101, 43);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtIngresoFrase
            // 
            this.TxtIngresoFrase.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngresoFrase.Location = new System.Drawing.Point(17, 64);
            this.TxtIngresoFrase.Name = "TxtIngresoFrase";
            this.TxtIngresoFrase.Size = new System.Drawing.Size(250, 41);
            this.TxtIngresoFrase.TabIndex = 1;
            // 
            // BtnClick
            // 
            this.BtnClick.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnClick.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClick.Location = new System.Drawing.Point(308, 62);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(143, 43);
            this.BtnClick.TabIndex = 2;
            this.BtnClick.Text = "Aceptar";
            this.BtnClick.UseVisualStyleBackColor = false;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese Frase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblResultado
            // 
            this.LblResultado.BackColor = System.Drawing.Color.Black;
            this.LblResultado.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.ForeColor = System.Drawing.SystemColors.Info;
            this.LblResultado.Location = new System.Drawing.Point(12, 231);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(255, 43);
            this.LblResultado.TabIndex = 4;
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOriginal
            // 
            this.LblOriginal.BackColor = System.Drawing.Color.Ivory;
            this.LblOriginal.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOriginal.Location = new System.Drawing.Point(12, 173);
            this.LblOriginal.Name = "LblOriginal";
            this.LblOriginal.Size = new System.Drawing.Size(255, 40);
            this.LblOriginal.TabIndex = 5;
            this.LblOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSiguiente
            // 
            this.AcceptButton = this.BtnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(477, 344);
            this.Controls.Add(this.LblOriginal);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClick);
            this.Controls.Add(this.TxtIngresoFrase);
            this.Controls.Add(this.BtnCerrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FrmSiguiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo ejemplo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TxtIngresoFrase;
        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblOriginal;
    }
}