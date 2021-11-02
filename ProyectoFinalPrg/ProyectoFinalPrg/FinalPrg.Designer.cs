
namespace ProyectoFinalPrg
{
    partial class FinalPrg
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
            this.BtnCarga = new System.Windows.Forms.Button();
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnClickLista = new System.Windows.Forms.Button();
            this.LblMostrarLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCarga
            // 
            this.BtnCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarga.Location = new System.Drawing.Point(79, 67);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(75, 36);
            this.BtnCarga.TabIndex = 18;
            this.BtnCarga.Text = "Cargar";
            this.BtnCarga.UseVisualStyleBackColor = true;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngreso.Location = new System.Drawing.Point(42, 29);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(159, 32);
            this.TxtIngreso.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cargue aquí sus 5  jugadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Presione el botón para mostrar la lista cargada";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(876, 395);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 54);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Salir del programa";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnClickLista
            // 
            this.BtnClickLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClickLista.Location = new System.Drawing.Point(42, 165);
            this.BtnClickLista.Name = "BtnClickLista";
            this.BtnClickLista.Size = new System.Drawing.Size(252, 32);
            this.BtnClickLista.TabIndex = 21;
            this.BtnClickLista.Text = "Mostrar lista";
            this.BtnClickLista.UseVisualStyleBackColor = true;
            this.BtnClickLista.Click += new System.EventHandler(this.BtnClickLista_Click);
            // 
            // LblMostrarLista
            // 
            this.LblMostrarLista.BackColor = System.Drawing.Color.Chartreuse;
            this.LblMostrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarLista.ForeColor = System.Drawing.Color.Black;
            this.LblMostrarLista.Location = new System.Drawing.Point(37, 200);
            this.LblMostrarLista.Name = "LblMostrarLista";
            this.LblMostrarLista.Size = new System.Drawing.Size(257, 195);
            this.LblMostrarLista.TabIndex = 20;
            this.LblMostrarLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalPrg
            // 
            this.AcceptButton = this.BtnCarga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCarga);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnClickLista);
            this.Controls.Add(this.LblMostrarLista);
            this.Name = "FinalPrg";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCarga;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnClickLista;
        private System.Windows.Forms.Label LblMostrarLista;
    }
}

