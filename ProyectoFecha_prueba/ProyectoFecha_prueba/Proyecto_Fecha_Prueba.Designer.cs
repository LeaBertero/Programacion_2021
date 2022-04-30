
namespace ProyectoFecha_prueba
{
    partial class Proyecto_Fecha_Prueba
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
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(49, 65);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(95, 35);
            this.BtnIniciar.TabIndex = 0;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // TxtDia
            // 
            this.TxtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDia.Location = new System.Drawing.Point(175, 65);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(100, 35);
            this.TxtDia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese un número para la semana";
            // 
            // LblDia
            // 
            this.LblDia.BackColor = System.Drawing.Color.Lime;
            this.LblDia.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDia.Location = new System.Drawing.Point(45, 125);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(230, 49);
            this.LblDia.TabIndex = 3;
            this.LblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Proyecto_Fecha_Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 277);
            this.Controls.Add(this.LblDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDia);
            this.Controls.Add(this.BtnIniciar);
            this.Name = "Proyecto_Fecha_Prueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto_Fecha_Prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox TxtDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDia;
    }
}