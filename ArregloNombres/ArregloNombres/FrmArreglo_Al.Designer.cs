
namespace ArregloNombres
{
    partial class FrmArreglo_Al
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
            this.BtnCargar = new System.Windows.Forms.Button();
            this.TxtCargar = new System.Windows.Forms.TextBox();
            this.LblLista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Location = new System.Drawing.Point(453, 266);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(35, 60);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 1;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TxtCargar
            // 
            this.TxtCargar.Location = new System.Drawing.Point(157, 60);
            this.TxtCargar.Name = "TxtCargar";
            this.TxtCargar.Size = new System.Drawing.Size(100, 20);
            this.TxtCargar.TabIndex = 2;
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Location = new System.Drawing.Point(310, 93);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(0, 13);
            this.LblLista.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Personas";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(154, 215);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 13);
            this.LblRes.TabIndex = 5;
            // 
            // FrmArreglo_Al
            // 
            this.AcceptButton = this.BtnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 301);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.TxtCargar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FrmArreglo_Al";
            this.Text = "FrmArreglo_Al";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TxtCargar;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRes;
    }
}