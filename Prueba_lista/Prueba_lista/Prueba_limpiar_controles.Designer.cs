
namespace Prueba_lista
{
    partial class Prueba_limpiar_controles
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
            this.BtnAparecer = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.ClickLimpiar = new System.Windows.Forms.Button();
            this.BtnDeshabilitar = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnHabilitar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAparecer
            // 
            this.BtnAparecer.Location = new System.Drawing.Point(49, 33);
            this.BtnAparecer.Name = "BtnAparecer";
            this.BtnAparecer.Size = new System.Drawing.Size(137, 32);
            this.BtnAparecer.TabIndex = 9;
            this.BtnAparecer.Text = "Click aparecer";
            this.BtnAparecer.UseVisualStyleBackColor = true;
            this.BtnAparecer.Click += new System.EventHandler(this.button3_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblMensaje.ForeColor = System.Drawing.SystemColors.Control;
            this.LblMensaje.Location = new System.Drawing.Point(46, 84);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(203, 42);
            this.LblMensaje.TabIndex = 10;
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMensaje.Visible = false;
            // 
            // ClickLimpiar
            // 
            this.ClickLimpiar.Location = new System.Drawing.Point(49, 157);
            this.ClickLimpiar.Name = "ClickLimpiar";
            this.ClickLimpiar.Size = new System.Drawing.Size(96, 37);
            this.ClickLimpiar.TabIndex = 11;
            this.ClickLimpiar.Text = "Click limpiar";
            this.ClickLimpiar.UseVisualStyleBackColor = true;
            this.ClickLimpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnDeshabilitar
            // 
            this.BtnDeshabilitar.Location = new System.Drawing.Point(558, 89);
            this.BtnDeshabilitar.Name = "BtnDeshabilitar";
            this.BtnDeshabilitar.Size = new System.Drawing.Size(119, 37);
            this.BtnDeshabilitar.TabIndex = 13;
            this.BtnDeshabilitar.Text = "Click deshabilitar";
            this.BtnDeshabilitar.UseVisualStyleBackColor = true;
            this.BtnDeshabilitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(369, 27);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(137, 32);
            this.BtnIniciar.TabIndex = 12;
            this.BtnIniciar.Text = "Click iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(545, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 36);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.Location = new System.Drawing.Point(378, 89);
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(119, 37);
            this.BtnHabilitar.TabIndex = 16;
            this.BtnHabilitar.Text = "Click habilitar";
            this.BtnHabilitar.UseVisualStyleBackColor = true;
            this.BtnHabilitar.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(460, 172);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(119, 37);
            this.BtnLimpiar.TabIndex = 17;
            this.BtnLimpiar.Text = "Click limpiar control";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.button6_Click);
            // 
            // Prueba_limpiar_controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 244);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnHabilitar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnDeshabilitar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.ClickLimpiar);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.BtnAparecer);
            this.Name = "Prueba_limpiar_controles";
            this.Text = "Lista de personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAparecer;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Button ClickLimpiar;
        private System.Windows.Forms.Button BtnDeshabilitar;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnHabilitar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

