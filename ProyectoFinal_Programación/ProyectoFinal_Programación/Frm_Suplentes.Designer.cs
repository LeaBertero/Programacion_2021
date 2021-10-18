
namespace ProyectoFinal_Programación
{
    partial class Frm_Suplentes
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
            this.BtnAgregarSup = new System.Windows.Forms.Button();
            this.TxtAgregarSuplentes = new System.Windows.Forms.TextBox();
            this.LblListaSuplentes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAgregarSup
            // 
            this.BtnAgregarSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarSup.Location = new System.Drawing.Point(90, 98);
            this.BtnAgregarSup.Name = "BtnAgregarSup";
            this.BtnAgregarSup.Size = new System.Drawing.Size(184, 45);
            this.BtnAgregarSup.TabIndex = 0;
            this.BtnAgregarSup.Text = "Lista de suplentes";
            this.BtnAgregarSup.UseVisualStyleBackColor = true;
            // 
            // TxtAgregarSuplentes
            // 
            this.TxtAgregarSuplentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAgregarSuplentes.Location = new System.Drawing.Point(304, 107);
            this.TxtAgregarSuplentes.Name = "TxtAgregarSuplentes";
            this.TxtAgregarSuplentes.Size = new System.Drawing.Size(100, 26);
            this.TxtAgregarSuplentes.TabIndex = 1;
            // 
            // LblListaSuplentes
            // 
            this.LblListaSuplentes.BackColor = System.Drawing.Color.LimeGreen;
            this.LblListaSuplentes.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaSuplentes.ForeColor = System.Drawing.Color.White;
            this.LblListaSuplentes.Location = new System.Drawing.Point(85, 160);
            this.LblListaSuplentes.Name = "LblListaSuplentes";
            this.LblListaSuplentes.Size = new System.Drawing.Size(215, 317);
            this.LblListaSuplentes.TabIndex = 7;
            this.LblListaSuplentes.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.ForestGreen;
            this.label4.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 39);
            this.label4.TabIndex = 20;
            this.label4.Text = "Agregar lista de suplentes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(841, 489);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(93, 31);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Atrás";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Frm_Suplentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_Programación.Properties.Resources._2013_06_03_15_22_06_sup_jpg;
            this.ClientSize = new System.Drawing.Size(946, 532);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblListaSuplentes);
            this.Controls.Add(this.TxtAgregarSuplentes);
            this.Controls.Add(this.BtnAgregarSup);
            this.Name = "Frm_Suplentes";
            this.Text = "Suplentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarSup;
        private System.Windows.Forms.TextBox TxtAgregarSuplentes;
        private System.Windows.Forms.Label LblListaSuplentes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
    }
}