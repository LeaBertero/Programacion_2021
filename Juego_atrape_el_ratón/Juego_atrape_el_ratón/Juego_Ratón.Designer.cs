
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtnClickAqui));
            this.PicRaton = new System.Windows.Forms.PictureBox();
            this.BtnMensajeFalse = new System.Windows.Forms.Button();
            this.LblCondicion = new System.Windows.Forms.Label();
            this.BtnSi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lblmsj = new System.Windows.Forms.Label();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnCalculadora = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTexto = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicRaton)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRaton
            // 
            this.PicRaton.BackColor = System.Drawing.Color.Transparent;
            this.PicRaton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicRaton.Image = global::Juego_atrape_el_ratón.Properties.Resources.descargar__1_;
            this.PicRaton.Location = new System.Drawing.Point(740, 287);
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
            this.BtnMensajeFalse.Location = new System.Drawing.Point(103, 209);
            this.BtnMensajeFalse.Name = "BtnMensajeFalse";
            this.BtnMensajeFalse.Size = new System.Drawing.Size(223, 46);
            this.BtnMensajeFalse.TabIndex = 1;
            this.BtnMensajeFalse.Text = "Atrapar al ratón";
            this.BtnMensajeFalse.UseVisualStyleBackColor = false;
            this.BtnMensajeFalse.Click += new System.EventHandler(this.BtnMensaje_Click);
            // 
            // LblCondicion
            // 
            this.LblCondicion.AutoSize = true;
            this.LblCondicion.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCondicion.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCondicion.Location = new System.Drawing.Point(595, 55);
            this.LblCondicion.Name = "LblCondicion";
            this.LblCondicion.Size = new System.Drawing.Size(443, 35);
            this.LblCondicion.TabIndex = 6;
            this.LblCondicion.Text = "Podrás atrapar a un raton?";
            this.LblCondicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSi
            // 
            this.BtnSi.BackColor = System.Drawing.Color.Peru;
            this.BtnSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSi.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSi.Location = new System.Drawing.Point(932, 384);
            this.BtnSi.Name = "BtnSi";
            this.BtnSi.Size = new System.Drawing.Size(180, 67);
            this.BtnSi.TabIndex = 8;
            this.BtnSi.Text = "SI";
            this.BtnSi.UseVisualStyleBackColor = false;
            this.BtnSi.Click += new System.EventHandler(this.BtnSi_Click);
            this.BtnSi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSi_MouseMove);
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
            this.label3.Location = new System.Drawing.Point(73, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Para que no escape, click aqui !!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblmsj
            // 
            this.Lblmsj.BackColor = System.Drawing.Color.DarkOrange;
            this.Lblmsj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lblmsj.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Lblmsj.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblmsj.Location = new System.Drawing.Point(18, 78);
            this.Lblmsj.Name = "Lblmsj";
            this.Lblmsj.Size = new System.Drawing.Size(488, 41);
            this.Lblmsj.TabIndex = 11;
            this.Lblmsj.Text = "Veo que no puedes con tu genio !";
            this.Lblmsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lblmsj.Visible = false;
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.Peru;
            this.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNo.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnNo.Location = new System.Drawing.Point(534, 384);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(180, 67);
            this.BtnNo.TabIndex = 7;
            this.BtnNo.Text = "NO";
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // BtnCalculadora
            // 
            this.BtnCalculadora.BackColor = System.Drawing.Color.Black;
            this.BtnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculadora.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculadora.ForeColor = System.Drawing.Color.Red;
            this.BtnCalculadora.Location = new System.Drawing.Point(12, 12);
            this.BtnCalculadora.Name = "BtnCalculadora";
            this.BtnCalculadora.Size = new System.Drawing.Size(223, 46);
            this.BtnCalculadora.TabIndex = 12;
            this.BtnCalculadora.Text = "Calculadora";
            this.BtnCalculadora.UseVisualStyleBackColor = false;
            this.BtnCalculadora.Click += new System.EventHandler(this.BtnCalculadora_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(393, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trata de agarrar al botón correcto y atrápalo !!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTexto
            // 
            this.LblTexto.BackColor = System.Drawing.Color.DarkOrange;
            this.LblTexto.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTexto.Location = new System.Drawing.Point(588, 470);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(466, 68);
            this.LblTexto.TabIndex = 14;
            this.LblTexto.Text = "Eres un cobarde.. no puedes contra un simple ratonsito? Indique al boton \"Sí\" !!";
            this.LblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTexto.Visible = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnCerrar.Location = new System.Drawing.Point(18, 479);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(136, 51);
            this.BtnCerrar.TabIndex = 15;
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnClickAqui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1171, 547);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCalculadora);
            this.Controls.Add(this.Lblmsj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSi);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.LblCondicion);
            this.Controls.Add(this.BtnMensajeFalse);
            this.Controls.Add(this.PicRaton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BtnClickAqui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podrás atraparme ?";
            ((System.ComponentModel.ISupportInitialize)(this.PicRaton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicRaton;
        private System.Windows.Forms.Button BtnMensajeFalse;
        private System.Windows.Forms.Label LblCondicion;
        private System.Windows.Forms.Button BtnSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lblmsj;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Button BtnCalculadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

