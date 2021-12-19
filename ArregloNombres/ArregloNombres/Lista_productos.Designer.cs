
namespace ArregloNombres
{
    partial class Lista_productos
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
            this.BtAceptar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblListaPrecio = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtAceptar
            // 
            this.BtAceptar.Location = new System.Drawing.Point(396, 43);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtAceptar.TabIndex = 0;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(52, 82);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 32);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Mostrar Lista";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(294, 46);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(68, 20);
            this.TxtPrecio.TabIndex = 2;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(164, 46);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtProducto.TabIndex = 3;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(56, 46);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(71, 20);
            this.TxtCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // LblListaPrecio
            // 
            this.LblListaPrecio.AutoSize = true;
            this.LblListaPrecio.Location = new System.Drawing.Point(53, 138);
            this.LblListaPrecio.Name = "LblListaPrecio";
            this.LblListaPrecio.Size = new System.Drawing.Size(61, 13);
            this.LblListaPrecio.TabIndex = 8;
            this.LblListaPrecio.Text = "Lista precio";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(603, 11);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 32);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(410, 177);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 10;
            // 
            // Lista_productos
            // 
            this.AcceptButton = this.BtAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(702, 311);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblListaPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtAceptar);
            this.Name = "Lista_productos";
            this.Text = "Lista_productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblListaPrecio;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblerror;
    }
}