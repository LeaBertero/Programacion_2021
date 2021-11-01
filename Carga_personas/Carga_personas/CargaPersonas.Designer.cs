
namespace Carga_personas
{
    partial class CargaPersonas
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
            this.TxtCargaPers = new System.Windows.Forms.TextBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblLista = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNacimiento = new System.Windows.Forms.TextBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnMostraFiltro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCargaPers
            // 
            this.TxtCargaPers.Location = new System.Drawing.Point(124, 66);
            this.TxtCargaPers.Name = "TxtCargaPers";
            this.TxtCargaPers.Size = new System.Drawing.Size(100, 20);
            this.TxtCargaPers.TabIndex = 1;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(23, 66);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 3;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLista.Location = new System.Drawing.Point(401, 27);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(265, 24);
            this.LblLista.TabIndex = 3;
            this.LblLista.Text = "Lista de personas cargadas";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(23, 108);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 4;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(23, 289);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nacimiento";
            // 
            // TxtNacimiento
            // 
            this.TxtNacimiento.Location = new System.Drawing.Point(247, 66);
            this.TxtNacimiento.Name = "TxtNacimiento";
            this.TxtNacimiento.Size = new System.Drawing.Size(71, 20);
            this.TxtNacimiento.TabIndex = 2;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(23, 155);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 8;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // BtnMostraFiltro
            // 
            this.BtnMostraFiltro.Location = new System.Drawing.Point(23, 201);
            this.BtnMostraFiltro.Name = "BtnMostraFiltro";
            this.BtnMostraFiltro.Size = new System.Drawing.Size(97, 23);
            this.BtnMostraFiltro.TabIndex = 9;
            this.BtnMostraFiltro.Text = "Mostrar con filtro";
            this.BtnMostraFiltro.UseVisualStyleBackColor = true;
            this.BtnMostraFiltro.Click += new System.EventHandler(this.BtnMostraFiltro_Click);
            // 
            // CargaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 324);
            this.Controls.Add(this.BtnMostraFiltro);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNacimiento);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TxtCargaPers);
            this.Name = "CargaPersonas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCargaPers;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNacimiento;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnMostraFiltro;
    }
}

