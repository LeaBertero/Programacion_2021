
namespace ArregloNombres
{
    partial class Frm_Arreglo_Nombres
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
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnListar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDimensionar = new System.Windows.Forms.TextBox();
            this.BtnDimensionar = new System.Windows.Forms.Button();
            this.LbListaPers = new System.Windows.Forms.Label();
            this.BtnNewProgram = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Location = new System.Drawing.Point(482, 16);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(126, 121);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 1;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TxtCargar
            // 
            this.TxtCargar.Location = new System.Drawing.Point(10, 121);
            this.TxtCargar.Name = "TxtCargar";
            this.TxtCargar.Size = new System.Drawing.Size(100, 20);
            this.TxtCargar.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 165);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Lista de Personas";
            // 
            // BtnListar
            // 
            this.BtnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListar.Location = new System.Drawing.Point(126, 160);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 6;
            this.BtnListar.Text = "Mostrar Lista";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cargue aquí una lista de 5 personas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dimensionar";
            // 
            // TxtDimensionar
            // 
            this.TxtDimensionar.Location = new System.Drawing.Point(10, 36);
            this.TxtDimensionar.Name = "TxtDimensionar";
            this.TxtDimensionar.Size = new System.Drawing.Size(100, 20);
            this.TxtDimensionar.TabIndex = 9;
            // 
            // BtnDimensionar
            // 
            this.BtnDimensionar.Location = new System.Drawing.Point(126, 36);
            this.BtnDimensionar.Name = "BtnDimensionar";
            this.BtnDimensionar.Size = new System.Drawing.Size(75, 23);
            this.BtnDimensionar.TabIndex = 8;
            this.BtnDimensionar.Text = "Dimensionar";
            this.BtnDimensionar.UseVisualStyleBackColor = true;
            this.BtnDimensionar.Click += new System.EventHandler(this.BtnDimensionar_Click);
            // 
            // LbListaPers
            // 
            this.LbListaPers.AutoSize = true;
            this.LbListaPers.Location = new System.Drawing.Point(7, 192);
            this.LbListaPers.Name = "LbListaPers";
            this.LbListaPers.Size = new System.Drawing.Size(0, 13);
            this.LbListaPers.TabIndex = 11;
            // 
            // BtnNewProgram
            // 
            this.BtnNewProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewProgram.Location = new System.Drawing.Point(432, 204);
            this.BtnNewProgram.Name = "BtnNewProgram";
            this.BtnNewProgram.Size = new System.Drawing.Size(125, 46);
            this.BtnNewProgram.TabIndex = 12;
            this.BtnNewProgram.Text = "Programa - Lista de Productos";
            this.BtnNewProgram.UseVisualStyleBackColor = true;
            this.BtnNewProgram.Click += new System.EventHandler(this.BtnNewProgram_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Programa Carga de productos";
            // 
            // Frm_Arreglo_Nombres
            // 
            this.AcceptButton = this.BtnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(569, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnNewProgram);
            this.Controls.Add(this.LbListaPers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDimensionar);
            this.Controls.Add(this.BtnDimensionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtCargar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "Frm_Arreglo_Nombres";
            this.Text = "FrmArreglo_Al";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TxtCargar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDimensionar;
        private System.Windows.Forms.Button BtnDimensionar;
        private System.Windows.Forms.Label LbListaPers;
        private System.Windows.Forms.Button BtnNewProgram;
        private System.Windows.Forms.Label label4;
    }
}