
namespace Calculadora_prueba
{
    partial class Calculadora
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
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnSiete = new System.Windows.Forms.Button();
            this.BtnOcho = new System.Windows.Forms.Button();
            this.BtnNueve = new System.Windows.Forms.Button();
            this.BtnSeis = new System.Windows.Forms.Button();
            this.BtnCinco = new System.Windows.Forms.Button();
            this.BtnCuatro = new System.Windows.Forms.Button();
            this.BtnTres = new System.Windows.Forms.Button();
            this.BtnDos = new System.Windows.Forms.Button();
            this.BtnUno = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnBorrarTodo = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnCuadrado = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnRaizCuadrada = new System.Windows.Forms.Button();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.BtnCero = new System.Windows.Forms.Button();
            this.BtnSigno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtResultado
            // 
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.Location = new System.Drawing.Point(26, 22);
            this.TxtResultado.MaxLength = 21;
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(343, 41);
            this.TxtResultado.TabIndex = 0;
            this.TxtResultado.Text = "0";
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnSiete
            // 
            this.BtnSiete.BackColor = System.Drawing.Color.Black;
            this.BtnSiete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSiete.Location = new System.Drawing.Point(28, 144);
            this.BtnSiete.Name = "BtnSiete";
            this.BtnSiete.Size = new System.Drawing.Size(50, 38);
            this.BtnSiete.TabIndex = 1;
            this.BtnSiete.Text = "7";
            this.BtnSiete.UseVisualStyleBackColor = false;
            this.BtnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnOcho
            // 
            this.BtnOcho.BackColor = System.Drawing.Color.Black;
            this.BtnOcho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOcho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOcho.Location = new System.Drawing.Point(95, 144);
            this.BtnOcho.Name = "BtnOcho";
            this.BtnOcho.Size = new System.Drawing.Size(50, 38);
            this.BtnOcho.TabIndex = 2;
            this.BtnOcho.Text = "8";
            this.BtnOcho.UseVisualStyleBackColor = false;
            this.BtnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnNueve
            // 
            this.BtnNueve.BackColor = System.Drawing.Color.Black;
            this.BtnNueve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNueve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNueve.Location = new System.Drawing.Point(164, 144);
            this.BtnNueve.Name = "BtnNueve";
            this.BtnNueve.Size = new System.Drawing.Size(50, 38);
            this.BtnNueve.TabIndex = 3;
            this.BtnNueve.Text = "9";
            this.BtnNueve.UseVisualStyleBackColor = false;
            this.BtnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnSeis
            // 
            this.BtnSeis.BackColor = System.Drawing.Color.Black;
            this.BtnSeis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSeis.Location = new System.Drawing.Point(164, 201);
            this.BtnSeis.Name = "BtnSeis";
            this.BtnSeis.Size = new System.Drawing.Size(50, 38);
            this.BtnSeis.TabIndex = 6;
            this.BtnSeis.Text = "6";
            this.BtnSeis.UseVisualStyleBackColor = false;
            this.BtnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnCinco
            // 
            this.BtnCinco.BackColor = System.Drawing.Color.Black;
            this.BtnCinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCinco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCinco.Location = new System.Drawing.Point(95, 201);
            this.BtnCinco.Name = "BtnCinco";
            this.BtnCinco.Size = new System.Drawing.Size(50, 38);
            this.BtnCinco.TabIndex = 5;
            this.BtnCinco.Text = "5";
            this.BtnCinco.UseVisualStyleBackColor = false;
            this.BtnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnCuatro
            // 
            this.BtnCuatro.BackColor = System.Drawing.Color.Black;
            this.BtnCuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuatro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCuatro.Location = new System.Drawing.Point(28, 201);
            this.BtnCuatro.Name = "BtnCuatro";
            this.BtnCuatro.Size = new System.Drawing.Size(50, 38);
            this.BtnCuatro.TabIndex = 4;
            this.BtnCuatro.Text = "4";
            this.BtnCuatro.UseVisualStyleBackColor = false;
            this.BtnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnTres
            // 
            this.BtnTres.BackColor = System.Drawing.Color.Black;
            this.BtnTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTres.Location = new System.Drawing.Point(164, 262);
            this.BtnTres.Name = "BtnTres";
            this.BtnTres.Size = new System.Drawing.Size(50, 38);
            this.BtnTres.TabIndex = 9;
            this.BtnTres.Text = "3";
            this.BtnTres.UseVisualStyleBackColor = false;
            this.BtnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnDos
            // 
            this.BtnDos.BackColor = System.Drawing.Color.Black;
            this.BtnDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDos.Location = new System.Drawing.Point(95, 262);
            this.BtnDos.Name = "BtnDos";
            this.BtnDos.Size = new System.Drawing.Size(50, 38);
            this.BtnDos.TabIndex = 8;
            this.BtnDos.Text = "2";
            this.BtnDos.UseVisualStyleBackColor = false;
            this.BtnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnUno
            // 
            this.BtnUno.BackColor = System.Drawing.Color.Black;
            this.BtnUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUno.Location = new System.Drawing.Point(28, 262);
            this.BtnUno.Name = "BtnUno";
            this.BtnUno.Size = new System.Drawing.Size(50, 38);
            this.BtnUno.TabIndex = 7;
            this.BtnUno.Text = "1";
            this.BtnUno.UseVisualStyleBackColor = false;
            this.BtnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.Black;
            this.BtnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnQuitar.Location = new System.Drawing.Point(164, 83);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(50, 38);
            this.BtnQuitar.TabIndex = 12;
            this.BtnQuitar.Text = "<-";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            // 
            // BtnBorrarTodo
            // 
            this.BtnBorrarTodo.BackColor = System.Drawing.Color.Black;
            this.BtnBorrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarTodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBorrarTodo.Location = new System.Drawing.Point(95, 83);
            this.BtnBorrarTodo.Name = "BtnBorrarTodo";
            this.BtnBorrarTodo.Size = new System.Drawing.Size(50, 38);
            this.BtnBorrarTodo.TabIndex = 11;
            this.BtnBorrarTodo.Text = "C";
            this.BtnBorrarTodo.UseVisualStyleBackColor = false;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.Black;
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBorrar.Location = new System.Drawing.Point(28, 83);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(50, 38);
            this.BtnBorrar.TabIndex = 10;
            this.BtnBorrar.Text = "CE";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            // 
            // BtnCuadrado
            // 
            this.BtnCuadrado.BackColor = System.Drawing.Color.Black;
            this.BtnCuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuadrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCuadrado.Location = new System.Drawing.Point(315, 83);
            this.BtnCuadrado.Name = "BtnCuadrado";
            this.BtnCuadrado.Size = new System.Drawing.Size(54, 38);
            this.BtnCuadrado.TabIndex = 16;
            this.BtnCuadrado.Tag = "²";
            this.BtnCuadrado.Text = "x²";
            this.BtnCuadrado.UseVisualStyleBackColor = false;
            this.BtnCuadrado.Click += new System.EventHandler(this.ClickOperador);
            // 
            // BtnIgual
            // 
            this.BtnIgual.BackColor = System.Drawing.Color.Black;
            this.BtnIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIgual.Location = new System.Drawing.Point(252, 306);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(117, 53);
            this.BtnIgual.TabIndex = 15;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = false;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.BackColor = System.Drawing.Color.Black;
            this.BtnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnResta.Location = new System.Drawing.Point(315, 201);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(54, 99);
            this.BtnResta.TabIndex = 14;
            this.BtnResta.Tag = "-";
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = false;
            this.BtnResta.Click += new System.EventHandler(this.ClickOperador);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.BackColor = System.Drawing.Color.Black;
            this.BtnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMultiplicar.Location = new System.Drawing.Point(315, 144);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(54, 38);
            this.BtnMultiplicar.TabIndex = 13;
            this.BtnMultiplicar.Tag = "X";
            this.BtnMultiplicar.Text = "X";
            this.BtnMultiplicar.UseVisualStyleBackColor = false;
            this.BtnMultiplicar.Click += new System.EventHandler(this.ClickOperador);
            // 
            // BtnRaizCuadrada
            // 
            this.BtnRaizCuadrada.BackColor = System.Drawing.Color.Black;
            this.BtnRaizCuadrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRaizCuadrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRaizCuadrada.Location = new System.Drawing.Point(252, 83);
            this.BtnRaizCuadrada.Name = "BtnRaizCuadrada";
            this.BtnRaizCuadrada.Size = new System.Drawing.Size(57, 41);
            this.BtnRaizCuadrada.TabIndex = 20;
            this.BtnRaizCuadrada.Tag = "√";
            this.BtnRaizCuadrada.Text = "√";
            this.BtnRaizCuadrada.UseVisualStyleBackColor = false;
            this.BtnRaizCuadrada.Click += new System.EventHandler(this.ClickOperador);
            // 
            // BtnSumar
            // 
            this.BtnSumar.BackColor = System.Drawing.Color.Black;
            this.BtnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSumar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSumar.Location = new System.Drawing.Point(252, 201);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(57, 99);
            this.BtnSumar.TabIndex = 18;
            this.BtnSumar.Tag = "+";
            this.BtnSumar.Text = "+";
            this.BtnSumar.UseVisualStyleBackColor = false;
            this.BtnSumar.Click += new System.EventHandler(this.ClickOperador);
            // 
            // BtnDividir
            // 
            this.BtnDividir.BackColor = System.Drawing.Color.Black;
            this.BtnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDividir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDividir.Location = new System.Drawing.Point(252, 144);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(57, 38);
            this.BtnDividir.TabIndex = 17;
            this.BtnDividir.Tag = "/";
            this.BtnDividir.Text = "/";
            this.BtnDividir.UseVisualStyleBackColor = false;
            this.BtnDividir.Click += new System.EventHandler(this.ClickOperador);
            // 
            // BtnPunto
            // 
            this.BtnPunto.BackColor = System.Drawing.Color.Black;
            this.BtnPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPunto.Location = new System.Drawing.Point(164, 321);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(50, 38);
            this.BtnPunto.TabIndex = 23;
            this.BtnPunto.Text = ".";
            this.BtnPunto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPunto.UseVisualStyleBackColor = false;
            // 
            // BtnCero
            // 
            this.BtnCero.BackColor = System.Drawing.Color.Black;
            this.BtnCero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCero.Location = new System.Drawing.Point(95, 321);
            this.BtnCero.Name = "BtnCero";
            this.BtnCero.Size = new System.Drawing.Size(50, 38);
            this.BtnCero.TabIndex = 22;
            this.BtnCero.Text = "0";
            this.BtnCero.UseVisualStyleBackColor = false;
            this.BtnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // BtnSigno
            // 
            this.BtnSigno.BackColor = System.Drawing.Color.Black;
            this.BtnSigno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSigno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSigno.Location = new System.Drawing.Point(28, 321);
            this.BtnSigno.Name = "BtnSigno";
            this.BtnSigno.Size = new System.Drawing.Size(50, 38);
            this.BtnSigno.TabIndex = 21;
            this.BtnSigno.Text = "+/-";
            this.BtnSigno.UseVisualStyleBackColor = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(399, 402);
            this.Controls.Add(this.BtnPunto);
            this.Controls.Add(this.BtnCero);
            this.Controls.Add(this.BtnSigno);
            this.Controls.Add(this.BtnRaizCuadrada);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnCuadrado);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnBorrarTodo);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnTres);
            this.Controls.Add(this.BtnDos);
            this.Controls.Add(this.BtnUno);
            this.Controls.Add(this.BtnSeis);
            this.Controls.Add(this.BtnCinco);
            this.Controls.Add(this.BtnCuatro);
            this.Controls.Add(this.BtnNueve);
            this.Controls.Add(this.BtnOcho);
            this.Controls.Add(this.BtnSiete);
            this.Controls.Add(this.TxtResultado);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Calculadora";
            this.Text = "CALCULADORA";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnSiete;
        private System.Windows.Forms.Button BtnOcho;
        private System.Windows.Forms.Button BtnNueve;
        private System.Windows.Forms.Button BtnSeis;
        private System.Windows.Forms.Button BtnCinco;
        private System.Windows.Forms.Button BtnCuatro;
        private System.Windows.Forms.Button BtnTres;
        private System.Windows.Forms.Button BtnDos;
        private System.Windows.Forms.Button BtnUno;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnBorrarTodo;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnCuadrado;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnRaizCuadrada;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.Button BtnCero;
        private System.Windows.Forms.Button BtnSigno;
    }
}

