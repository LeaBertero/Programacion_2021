
namespace Prg.Final
{
    partial class Form1
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
            this.LblMostrar = new System.Windows.Forms.Label();
            this.BtnMostrarLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCarga
            // 
            this.BtnCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarga.Location = new System.Drawing.Point(5, 49);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(75, 32);
            this.BtnCarga.TabIndex = 0;
            this.BtnCarga.Text = "Cargar";
            this.BtnCarga.UseVisualStyleBackColor = true;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngreso.Location = new System.Drawing.Point(103, 47);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(100, 32);
            this.TxtIngreso.TabIndex = 1;
            // 
            // LblMostrar
            // 
            this.LblMostrar.BackColor = System.Drawing.Color.Chartreuse;
            this.LblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrar.ForeColor = System.Drawing.Color.Black;
            this.LblMostrar.Location = new System.Drawing.Point(539, 127);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(257, 172);
            this.LblMostrar.TabIndex = 2;
            this.LblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMostrarLista
            // 
            this.BtnMostrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarLista.Location = new System.Drawing.Point(12, 157);
            this.BtnMostrarLista.Name = "BtnMostrarLista";
            this.BtnMostrarLista.Size = new System.Drawing.Size(125, 32);
            this.BtnMostrarLista.TabIndex = 3;
            this.BtnMostrarLista.Text = "Mostrar lista";
            this.BtnMostrarLista.UseVisualStyleBackColor = true;
            this.BtnMostrarLista.Click += new System.EventHandler(this.BtnMostrarLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cargue aquí sus jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Presione para mostrar la lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Atención : Puede cargar hasta 5 jugadores";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(970, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir del programa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista de jugadores cargados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnCarga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMostrarLista);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.BtnCarga);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Proyecto final - Programacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCarga;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.Button BtnMostrarLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

