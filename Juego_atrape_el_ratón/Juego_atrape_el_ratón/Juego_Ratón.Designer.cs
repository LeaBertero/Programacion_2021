
namespace Juego_atrape_el_ratón
{
    partial class BtnClickAqui
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
            this.PicRaton = new System.Windows.Forms.PictureBox();
            this.BtnMensajeFalse = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnSi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lblmsj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicRaton)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRaton
            // 
            this.PicRaton.BackColor = System.Drawing.Color.Transparent;
            this.PicRaton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicRaton.Image = global::Juego_atrape_el_ratón.Properties.Resources.descargar__1_;
            this.PicRaton.Location = new System.Drawing.Point(734, 163);
            this.PicRaton.Name = "PicRaton";
            this.PicRaton.Size = new System.Drawing.Size(168, 164);
            this.PicRaton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRaton.TabIndex = 0;
            this.PicRaton.TabStop = false;
            this.PicRaton.Click += new System.EventHandler(this.PicRaton_Click);
            // 
            // BtnMensajeFalse
            // 
            this.BtnMensajeFalse.BackColor = System.Drawing.Color.Peru;
            this.BtnMensajeFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMensajeFalse.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMensajeFalse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnMensajeFalse.Location = new System.Drawing.Point(244, 311);
            this.BtnMensajeFalse.Name = "BtnMensajeFalse";
            this.BtnMensajeFalse.Size = new System.Drawing.Size(171, 58);
            this.BtnMensajeFalse.TabIndex = 1;
            this.BtnMensajeFalse.Text = "Click aquí";
            this.BtnMensajeFalse.UseVisualStyleBackColor = false;
            this.BtnMensajeFalse.Click += new System.EventHandler(this.BtnMensaje_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Peru;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSalir.Location = new System.Drawing.Point(12, 477);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(124, 58);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(571, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podrás atrapar a un raton?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.Peru;
            this.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNo.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnNo.Location = new System.Drawing.Point(631, 352);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(180, 67);
            this.BtnNo.TabIndex = 7;
            this.BtnNo.Text = "NO";
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnAtrapar_Click_1);
            // 
            // BtnSi
            // 
            this.BtnSi.BackColor = System.Drawing.Color.Peru;
            this.BtnSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSi.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSi.Location = new System.Drawing.Point(843, 352);
            this.BtnSi.Name = "BtnSi";
            this.BtnSi.Size = new System.Drawing.Size(180, 67);
            this.BtnSi.TabIndex = 8;
            this.BtnSi.Text = "SI";
            this.BtnSi.UseVisualStyleBackColor = false;
            this.BtnSi.Click += new System.EventHandler(this.BtnSi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(685, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vamos a jugar ??";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(154, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Click para lograrlo !!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblmsj
            // 
            this.Lblmsj.BackColor = System.Drawing.Color.DarkOrange;
            this.Lblmsj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lblmsj.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Lblmsj.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblmsj.Location = new System.Drawing.Point(89, 152);
            this.Lblmsj.Name = "Lblmsj";
            this.Lblmsj.Size = new System.Drawing.Size(488, 41);
            this.Lblmsj.TabIndex = 11;
            this.Lblmsj.Text = "Veo que no puedes atraparlo.. jaja";
            this.Lblmsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lblmsj.Visible = false;
            this.Lblmsj.Click += new System.EventHandler(this.Lblmsj_Click);
            // 
            // BtnClickAqui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1171, 547);
            this.Controls.Add(this.Lblmsj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSi);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMensajeFalse);
            this.Controls.Add(this.PicRaton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BtnClickAqui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BtnClickAqui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicRaton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRaton;
        private System.Windows.Forms.Button BtnMensajeFalse;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Button BtnSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lblmsj;
    }
}

