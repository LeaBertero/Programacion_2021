
namespace Prueba_Try_catch
{
    partial class Prueba_Try_Catch
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
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBorrarMensaje = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNum2
            // 
            this.TxtNum2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum2.Location = new System.Drawing.Point(298, 176);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 32);
            this.TxtNum2.TabIndex = 0;
            // 
            // TxtNum1
            // 
            this.TxtNum1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum1.Location = new System.Drawing.Point(104, 176);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 32);
            this.TxtNum1.TabIndex = 1;
           
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEjecutar.Location = new System.Drawing.Point(450, 173);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(84, 31);
            this.BtnEjecutar.TabIndex = 2;
            this.BtnEjecutar.Text = "=";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // LblRes
            // 
            this.LblRes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRes.Location = new System.Drawing.Point(603, 159);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(128, 45);
            this.LblRes.TabIndex = 3;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // LblError
            // 
            this.LblError.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(100, 249);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(231, 46);
            this.LblError.TabIndex = 4;
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblError.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Programa - Prueba de Try Catch (Prueba de errores)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBorrarMensaje
            // 
            this.BtnBorrarMensaje.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBorrarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarMensaje.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarMensaje.ForeColor = System.Drawing.Color.Gold;
            this.BtnBorrarMensaje.Location = new System.Drawing.Point(33, 395);
            this.BtnBorrarMensaje.Name = "BtnBorrarMensaje";
            this.BtnBorrarMensaje.Size = new System.Drawing.Size(199, 29);
            this.BtnBorrarMensaje.TabIndex = 7;
            this.BtnBorrarMensaje.Text = " Borrar mensaje de error";
            this.BtnBorrarMensaje.UseVisualStyleBackColor = false;
            this.BtnBorrarMensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Gold;
            this.BtnCerrar.Location = new System.Drawing.Point(666, 389);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(128, 55);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Prueba_Try_Catch
            // 
            this.AcceptButton = this.BtnEjecutar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrarMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.TxtNum2);
            this.Name = "Prueba_Try_Catch";
            this.Text = "Prueba_Try_Catch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBorrarMensaje;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

