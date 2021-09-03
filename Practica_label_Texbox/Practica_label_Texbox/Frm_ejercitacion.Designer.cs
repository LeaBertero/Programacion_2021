
namespace Practica_label_Texbox
{
    partial class Form1
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblFraseOriginal = new System.Windows.Forms.Label();
            this.LblFraseResultado = new System.Windows.Forms.Label();
            this.TxTIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.DeepPink;
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(388, 116);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(131, 38);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblFraseOriginal
            // 
            this.LblFraseOriginal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LblFraseOriginal.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFraseOriginal.ForeColor = System.Drawing.Color.Green;
            this.LblFraseOriginal.Location = new System.Drawing.Point(12, 183);
            this.LblFraseOriginal.Name = "LblFraseOriginal";
            this.LblFraseOriginal.Size = new System.Drawing.Size(611, 38);
            this.LblFraseOriginal.TabIndex = 1;
            this.LblFraseOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFraseResultado
            // 
            this.LblFraseResultado.BackColor = System.Drawing.Color.LawnGreen;
            this.LblFraseResultado.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFraseResultado.ForeColor = System.Drawing.Color.Teal;
            this.LblFraseResultado.Location = new System.Drawing.Point(12, 254);
            this.LblFraseResultado.Name = "LblFraseResultado";
            this.LblFraseResultado.Size = new System.Drawing.Size(611, 42);
            this.LblFraseResultado.TabIndex = 2;
            this.LblFraseResultado.Text = " ";
            this.LblFraseResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFraseResultado.Click += new System.EventHandler(this.LblFraseResultado_Click);
            // 
            // TxTIngreso
            // 
            this.TxTIngreso.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTIngreso.Location = new System.Drawing.Point(18, 122);
            this.TxTIngreso.Name = "TxTIngreso";
            this.TxTIngreso.Size = new System.Drawing.Size(333, 31);
            this.TxTIngreso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = " Ingrese una fase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(630, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(592, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "Siguiente formulario";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(741, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxTIngreso);
            this.Controls.Add(this.LblFraseResultado);
            this.Controls.Add(this.LblFraseOriginal);
            this.Controls.Add(this.BtnAceptar);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario - ejercitación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblFraseOriginal;
        private System.Windows.Forms.Label LblFraseResultado;
        private System.Windows.Forms.TextBox TxTIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}