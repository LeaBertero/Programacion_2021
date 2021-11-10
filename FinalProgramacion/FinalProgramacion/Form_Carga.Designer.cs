
namespace FinalProgramacion
{
    partial class Form_Carga
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnDimensionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDimensionar = new System.Windows.Forms.TextBox();
            this.LblMostrarLista = new System.Windows.Forms.Label();
            this.BtnMostrarLista = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDirección = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLimpiarDatos = new System.Windows.Forms.Button();
            this.BtnCorregirNom = new System.Windows.Forms.Button();
            this.BtnCorregirAp = new System.Windows.Forms.Button();
            this.BtnCorregirDir = new System.Windows.Forms.Button();
            this.BtnCorregirDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(12, 65);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(114, 65);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(78, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // BtnDimensionar
            // 
            this.BtnDimensionar.Location = new System.Drawing.Point(12, 20);
            this.BtnDimensionar.Name = "BtnDimensionar";
            this.BtnDimensionar.Size = new System.Drawing.Size(75, 23);
            this.BtnDimensionar.TabIndex = 0;
            this.BtnDimensionar.Text = "Dimension";
            this.BtnDimensionar.UseVisualStyleBackColor = true;
            this.BtnDimensionar.Click += new System.EventHandler(this.BtnDimensionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dimensionar";
            // 
            // TxtDimensionar
            // 
            this.TxtDimensionar.Location = new System.Drawing.Point(114, 20);
            this.TxtDimensionar.Name = "TxtDimensionar";
            this.TxtDimensionar.Size = new System.Drawing.Size(50, 20);
            this.TxtDimensionar.TabIndex = 2;
            // 
            // LblMostrarLista
            // 
            this.LblMostrarLista.AutoSize = true;
            this.LblMostrarLista.Location = new System.Drawing.Point(557, 56);
            this.LblMostrarLista.Name = "LblMostrarLista";
            this.LblMostrarLista.Size = new System.Drawing.Size(29, 13);
            this.LblMostrarLista.TabIndex = 3;
            this.LblMostrarLista.Text = "Lista";
            // 
            // BtnMostrarLista
            // 
            this.BtnMostrarLista.Location = new System.Drawing.Point(550, 9);
            this.BtnMostrarLista.Name = "BtnMostrarLista";
            this.BtnMostrarLista.Size = new System.Drawing.Size(75, 44);
            this.BtnMostrarLista.TabIndex = 4;
            this.BtnMostrarLista.Text = "Mostrar Lista";
            this.BtnMostrarLista.UseVisualStyleBackColor = true;
            this.BtnMostrarLista.Click += new System.EventHandler(this.BtnMostrarLista_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(3, 338);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(109, 29);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Cerrar programa";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(198, 65);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(78, 20);
            this.TxtApellido.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // TxtDirección
            // 
            this.TxtDirección.Location = new System.Drawing.Point(282, 65);
            this.TxtDirección.Name = "TxtDirección";
            this.TxtDirección.Size = new System.Drawing.Size(78, 20);
            this.TxtDirección.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad de personas";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(366, 65);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(78, 20);
            this.TxtDocumento.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Documento";
            // 
            // BtnLimpiarDatos
            // 
            this.BtnLimpiarDatos.Location = new System.Drawing.Point(3, 42);
            this.BtnLimpiarDatos.Name = "BtnLimpiarDatos";
            this.BtnLimpiarDatos.Size = new System.Drawing.Size(93, 23);
            this.BtnLimpiarDatos.TabIndex = 14;
            this.BtnLimpiarDatos.Text = "Limpiar Datos";
            this.BtnLimpiarDatos.UseVisualStyleBackColor = true;
            this.BtnLimpiarDatos.Click += new System.EventHandler(this.BtnLimpiarDatos_Click);
            // 
            // BtnCorregirNom
            // 
            this.BtnCorregirNom.Location = new System.Drawing.Point(114, 91);
            this.BtnCorregirNom.Name = "BtnCorregirNom";
            this.BtnCorregirNom.Size = new System.Drawing.Size(75, 23);
            this.BtnCorregirNom.TabIndex = 15;
            this.BtnCorregirNom.Text = "Corregir";
            this.BtnCorregirNom.UseVisualStyleBackColor = true;
            this.BtnCorregirNom.Click += new System.EventHandler(this.BtnCorregirNom_Click);
            // 
            // BtnCorregirAp
            // 
            this.BtnCorregirAp.Location = new System.Drawing.Point(195, 91);
            this.BtnCorregirAp.Name = "BtnCorregirAp";
            this.BtnCorregirAp.Size = new System.Drawing.Size(75, 23);
            this.BtnCorregirAp.TabIndex = 16;
            this.BtnCorregirAp.Text = "Corregir";
            this.BtnCorregirAp.UseVisualStyleBackColor = true;
            this.BtnCorregirAp.Click += new System.EventHandler(this.BtnCorregirAp_Click);
            // 
            // BtnCorregirDir
            // 
            this.BtnCorregirDir.Location = new System.Drawing.Point(282, 91);
            this.BtnCorregirDir.Name = "BtnCorregirDir";
            this.BtnCorregirDir.Size = new System.Drawing.Size(75, 23);
            this.BtnCorregirDir.TabIndex = 17;
            this.BtnCorregirDir.Text = "Corregir";
            this.BtnCorregirDir.UseVisualStyleBackColor = true;
            this.BtnCorregirDir.Click += new System.EventHandler(this.BtnCorregirDir_Click);
            // 
            // BtnCorregirDoc
            // 
            this.BtnCorregirDoc.Location = new System.Drawing.Point(366, 91);
            this.BtnCorregirDoc.Name = "BtnCorregirDoc";
            this.BtnCorregirDoc.Size = new System.Drawing.Size(75, 23);
            this.BtnCorregirDoc.TabIndex = 18;
            this.BtnCorregirDoc.Text = "Corregir";
            this.BtnCorregirDoc.UseVisualStyleBackColor = true;
            this.BtnCorregirDoc.Click += new System.EventHandler(this.BtnCorregirDoc_Click);
            // 
            // Form_Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(747, 368);
            this.Controls.Add(this.BtnCorregirDoc);
            this.Controls.Add(this.BtnCorregirDir);
            this.Controls.Add(this.BtnCorregirAp);
            this.Controls.Add(this.BtnCorregirNom);
            this.Controls.Add(this.BtnLimpiarDatos);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDirección);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnMostrarLista);
            this.Controls.Add(this.LblMostrarLista);
            this.Controls.Add(this.TxtDimensionar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDimensionar);
            this.Controls.Add(this.BtnCargar);
            this.Name = "Form_Carga";
            this.Text = "Formulario de lista de personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnDimensionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDimensionar;
        private System.Windows.Forms.Label LblMostrarLista;
        private System.Windows.Forms.Button BtnMostrarLista;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDirección;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnLimpiarDatos;
        private System.Windows.Forms.Button BtnCorregirNom;
        private System.Windows.Forms.Button BtnCorregirAp;
        private System.Windows.Forms.Button BtnCorregirDir;
        private System.Windows.Forms.Button BtnCorregirDoc;
    }
}

