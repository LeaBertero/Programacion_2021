
namespace Dia_Mes_Año
{
    partial class ProyectoDia_Mes
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
            this.BtnSemana = new System.Windows.Forms.Button();
            this.BtnMes = new System.Windows.Forms.Button();
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.TxtMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.BtnAño = new System.Windows.Forms.Button();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.LblDia = new System.Windows.Forms.Label();
            this.LblMes = new System.Windows.Forms.Label();
            this.LblAño = new System.Windows.Forms.Label();
            this.btincrementoDia = new System.Windows.Forms.Button();
            this.BtincrementoAño = new System.Windows.Forms.Button();
            this.BtDecrementarDia = new System.Windows.Forms.Button();
            this.BtIncrementoMes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSemana
            // 
            this.BtnSemana.Location = new System.Drawing.Point(428, 66);
            this.BtnSemana.Name = "BtnSemana";
            this.BtnSemana.Size = new System.Drawing.Size(75, 23);
            this.BtnSemana.TabIndex = 0;
            this.BtnSemana.Text = "Ingresar";
            this.BtnSemana.UseVisualStyleBackColor = true;
            this.BtnSemana.Click += new System.EventHandler(this.BtnSemana_Click);
            // 
            // BtnMes
            // 
            this.BtnMes.Location = new System.Drawing.Point(428, 116);
            this.BtnMes.Name = "BtnMes";
            this.BtnMes.Size = new System.Drawing.Size(75, 23);
            this.BtnMes.TabIndex = 1;
            this.BtnMes.Text = "Ingresar";
            this.BtnMes.UseVisualStyleBackColor = true;
            this.BtnMes.Click += new System.EventHandler(this.BtnMes_Click);
            // 
            // TxtDia
            // 
            this.TxtDia.Location = new System.Drawing.Point(309, 68);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(100, 20);
            this.TxtDia.TabIndex = 2;
            // 
            // TxtMes
            // 
            this.TxtMes.Location = new System.Drawing.Point(309, 116);
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(100, 20);
            this.TxtMes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el día (Expresado en numero)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el mes (Expresado en numero)";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(87, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(436, 23);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar programa";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese el año, (expresado en numero)";
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(309, 161);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(100, 20);
            this.TxtAño.TabIndex = 8;
            // 
            // BtnAño
            // 
            this.BtnAño.Location = new System.Drawing.Point(428, 161);
            this.BtnAño.Name = "BtnAño";
            this.BtnAño.Size = new System.Drawing.Size(75, 20);
            this.BtnAño.TabIndex = 9;
            this.BtnAño.Text = "Ingresar";
            this.BtnAño.UseVisualStyleBackColor = true;
            this.BtnAño.Click += new System.EventHandler(this.BtnAño_Click);
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(87, 216);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(436, 23);
            this.BtLimpiar.TabIndex = 10;
            this.BtLimpiar.Text = "Limpiar datos ingresados";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // LblDia
            // 
            this.LblDia.AutoSize = true;
            this.LblDia.Location = new System.Drawing.Point(84, 265);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(0, 13);
            this.LblDia.TabIndex = 11;
            // 
            // LblMes
            // 
            this.LblMes.AutoSize = true;
            this.LblMes.Location = new System.Drawing.Point(166, 265);
            this.LblMes.Name = "LblMes";
            this.LblMes.Size = new System.Drawing.Size(0, 13);
            this.LblMes.TabIndex = 12;
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Location = new System.Drawing.Point(237, 265);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(0, 13);
            this.LblAño.TabIndex = 13;
            // 
            // btincrementoDia
            // 
            this.btincrementoDia.Location = new System.Drawing.Point(518, 65);
            this.btincrementoDia.Name = "btincrementoDia";
            this.btincrementoDia.Size = new System.Drawing.Size(98, 23);
            this.btincrementoDia.TabIndex = 14;
            this.btincrementoDia.Text = "Incrementar Dia";
            this.btincrementoDia.UseVisualStyleBackColor = true;
            this.btincrementoDia.Click += new System.EventHandler(this.btincrementoDia_Click);
            // 
            // BtincrementoAño
            // 
            this.BtincrementoAño.Location = new System.Drawing.Point(518, 158);
            this.BtincrementoAño.Name = "BtincrementoAño";
            this.BtincrementoAño.Size = new System.Drawing.Size(75, 23);
            this.BtincrementoAño.TabIndex = 14;
            this.BtincrementoAño.Text = "Incrementar";
            this.BtincrementoAño.UseVisualStyleBackColor = true;
            this.BtincrementoAño.Click += new System.EventHandler(this.BtincrementoAño_Click);
            // 
            // BtDecrementarDia
            // 
            this.BtDecrementarDia.Enabled = false;
            this.BtDecrementarDia.Location = new System.Drawing.Point(632, 66);
            this.BtDecrementarDia.Name = "BtDecrementarDia";
            this.BtDecrementarDia.Size = new System.Drawing.Size(98, 23);
            this.BtDecrementarDia.TabIndex = 15;
            this.BtDecrementarDia.Text = "Decrementar día";
            this.BtDecrementarDia.UseVisualStyleBackColor = true;
            // 
            // BtIncrementoMes
            // 
            this.BtIncrementoMes.Location = new System.Drawing.Point(518, 114);
            this.BtIncrementoMes.Name = "BtIncrementoMes";
            this.BtIncrementoMes.Size = new System.Drawing.Size(98, 23);
            this.BtIncrementoMes.TabIndex = 16;
            this.BtIncrementoMes.Text = "Incrementar mes";
            this.BtIncrementoMes.UseVisualStyleBackColor = true;
            this.BtIncrementoMes.Click += new System.EventHandler(this.BtIncrementoMes_Click);
            // 
            // ProyectoDia_Mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(808, 315);
            this.Controls.Add(this.BtIncrementoMes);
            this.Controls.Add(this.BtDecrementarDia);
            this.Controls.Add(this.BtincrementoAño);
            this.Controls.Add(this.btincrementoDia);
            this.Controls.Add(this.LblAño);
            this.Controls.Add(this.LblMes);
            this.Controls.Add(this.LblDia);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtnAño);
            this.Controls.Add(this.TxtAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMes);
            this.Controls.Add(this.TxtDia);
            this.Controls.Add(this.BtnMes);
            this.Controls.Add(this.BtnSemana);
            this.Name = "ProyectoDia_Mes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa Dia_Mes_Año";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSemana;
        private System.Windows.Forms.Button BtnMes;
        private System.Windows.Forms.TextBox TxtDia;
        private System.Windows.Forms.TextBox TxtMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.Button BtnAño;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Label LblDia;
        private System.Windows.Forms.Label LblMes;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.Button btincrementoDia;
        private System.Windows.Forms.Button BtincrementoAño;
        private System.Windows.Forms.Button BtDecrementarDia;
        private System.Windows.Forms.Button BtIncrementoMes;
    }
}

