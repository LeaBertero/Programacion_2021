
namespace ProyectoFinal_Lista
{
    partial class Pr_final
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGrid DG;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pr_final));
            this.BtnDim = new System.Windows.Forms.Button();
            this.TxtDim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.LblLista = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDim
            // 
            this.BtnDim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDim.Location = new System.Drawing.Point(5, 37);
            this.BtnDim.Name = "BtnDim";
            this.BtnDim.Size = new System.Drawing.Size(78, 23);
            this.BtnDim.TabIndex = 0;
            this.BtnDim.Text = "Dimensionar";
            this.BtnDim.UseVisualStyleBackColor = true;
            this.BtnDim.Click += new System.EventHandler(this.BtnDim_Click);
            // 
            // TxtDim
            // 
            this.TxtDim.Location = new System.Drawing.Point(89, 37);
            this.TxtDim.Name = "TxtDim";
            this.TxtDim.Size = new System.Drawing.Size(100, 20);
            this.TxtDim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dimensione las personas a cargar";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrar.Location = new System.Drawing.Point(12, 146);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(78, 23);
            this.BtnMostrar.TabIndex = 5;
            this.BtnMostrar.Text = "Lista";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.Location = new System.Drawing.Point(9, 172);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(71, 13);
            this.LblLista.TabIndex = 6;
            this.LblLista.Text = "Lista principal";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Location = new System.Drawing.Point(334, 146);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(78, 23);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingrese los datos requeridos en los campos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Click en \"LISTA\", paa ver lista completa";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Location = new System.Drawing.Point(242, 37);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(78, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Cargar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(326, 37);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(86, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre y apellido";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.Location = new System.Drawing.Point(242, 12);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(78, 23);
            this.BtnBorrar.TabIndex = 20;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // Pr_final
            // 
            this.AcceptButton = this.BtnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(433, 367);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtDim);
            this.Controls.Add(this.BtnDim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pr_final";
            this.Text = "Proyecto Final  - Programacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDim;
        private System.Windows.Forms.TextBox TxtDim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBorrar;
    }
}

