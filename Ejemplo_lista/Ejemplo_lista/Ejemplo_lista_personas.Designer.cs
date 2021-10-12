
namespace Ejemplo_lista
{
    partial class Ejemplo_lista_personas
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
            this.BtnCargar = new System.Windows.Forms.Button();
            this.TxtCarga = new System.Windows.Forms.TextBox();
            this.LblLista = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(64, 133);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(92, 35);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TxtCarga
            // 
            this.TxtCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarga.Location = new System.Drawing.Point(62, 79);
            this.TxtCarga.Name = "TxtCarga";
            this.TxtCarga.Size = new System.Drawing.Size(126, 26);
            this.TxtCarga.TabIndex = 1;
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLista.Location = new System.Drawing.Point(427, 20);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(188, 33);
            this.LblLista.TabIndex = 3;
            this.LblLista.Text = "Lista de personas:";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(213, 133);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(92, 35);
            this.BtnMostrar.TabIndex = 4;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nacimiento";
            // 
            // TxtAño
            // 
            this.TxtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAño.Location = new System.Drawing.Point(251, 79);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(63, 26);
            this.TxtAño.TabIndex = 7;
            this.TxtAño.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ejemplo_lista_personas
            // 
            this.AcceptButton = this.BtnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(644, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.TxtCarga);
            this.Controls.Add(this.BtnCargar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Ejemplo_lista_personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Programa - Ejemplo carga de una lista de personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TxtCarga;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAño;
    }
}

