
namespace Carga_de_personas_mostrar
{
    partial class Carga_lista_personas
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
            this.LbllistaMostrar = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtCargaNombre = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtDimension = new System.Windows.Forms.TextBox();
            this.BtDimensionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiar1 = new System.Windows.Forms.Button();
            this.BtnLimpiar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(236, 227);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(89, 48);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // LbllistaMostrar
            // 
            this.LbllistaMostrar.BackColor = System.Drawing.Color.Pink;
            this.LbllistaMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbllistaMostrar.Location = new System.Drawing.Point(232, 296);
            this.LbllistaMostrar.Name = "LbllistaMostrar";
            this.LbllistaMostrar.Size = new System.Drawing.Size(342, 194);
            this.LbllistaMostrar.TabIndex = 1;
            this.LbllistaMostrar.Text = " ";
            this.LbllistaMostrar.Visible = false;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(485, 227);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(89, 48);
            this.BtnMostrar.TabIndex = 2;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TxtCargaNombre
            // 
            this.TxtCargaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCargaNombre.Location = new System.Drawing.Point(236, 192);
            this.TxtCargaNombre.Name = "TxtCargaNombre";
            this.TxtCargaNombre.Size = new System.Drawing.Size(338, 29);
            this.TxtCargaNombre.TabIndex = 3;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(339, 544);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(133, 48);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtDimension
            // 
            this.TxtDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDimension.Location = new System.Drawing.Point(272, 61);
            this.TxtDimension.Name = "TxtDimension";
            this.TxtDimension.Size = new System.Drawing.Size(100, 29);
            this.TxtDimension.TabIndex = 6;
            // 
            // BtDimensionar
            // 
            this.BtDimensionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDimensionar.Location = new System.Drawing.Point(390, 61);
            this.BtDimensionar.Name = "BtDimensionar";
            this.BtDimensionar.Size = new System.Drawing.Size(126, 29);
            this.BtDimensionar.TabIndex = 5;
            this.BtDimensionar.Text = "Dimensionar";
            this.BtDimensionar.UseVisualStyleBackColor = true;
            this.BtDimensionar.Click += new System.EventHandler(this.BtDimensionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "cantidad de personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargue aquí la cantidad de personas indicadas en la dimensión";
            // 
            // BtnLimpiar1
            // 
            this.BtnLimpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar1.Location = new System.Drawing.Point(272, 105);
            this.BtnLimpiar1.Name = "BtnLimpiar1";
            this.BtnLimpiar1.Size = new System.Drawing.Size(244, 37);
            this.BtnLimpiar1.TabIndex = 9;
            this.BtnLimpiar1.Text = "Limpiar";
            this.BtnLimpiar1.UseVisualStyleBackColor = true;
            this.BtnLimpiar1.Click += new System.EventHandler(this.BtnLimpiar1_Click);
            // 
            // BtnLimpiar2
            // 
            this.BtnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar2.Location = new System.Drawing.Point(339, 227);
            this.BtnLimpiar2.Name = "BtnLimpiar2";
            this.BtnLimpiar2.Size = new System.Drawing.Size(133, 48);
            this.BtnLimpiar2.TabIndex = 10;
            this.BtnLimpiar2.Text = "Limpiar";
            this.BtnLimpiar2.UseVisualStyleBackColor = true;
            this.BtnLimpiar2.Click += new System.EventHandler(this.BtnLimpiar2_Click);
            // 
            // Carga_lista_personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.BtnLimpiar2);
            this.Controls.Add(this.BtnLimpiar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDimension);
            this.Controls.Add(this.BtDimensionar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtCargaNombre);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LbllistaMostrar);
            this.Controls.Add(this.BtnCargar);
            this.Name = "Carga_lista_personas";
            this.Text = "Carga de personas y mostrar en pantalla, la lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Label LbllistaMostrar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtCargaNombre;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtDimension;
        private System.Windows.Forms.Button BtDimensionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpiar1;
        private System.Windows.Forms.Button BtnLimpiar2;
    }
}

