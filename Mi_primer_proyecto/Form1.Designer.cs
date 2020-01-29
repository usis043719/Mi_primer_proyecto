namespace Mi_primer_proyecto
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.grboperaciones = new System.Windows.Forms.GroupBox();
            this.optsuma = new System.Windows.Forms.RadioButton();
            this.optresta = new System.Windows.Forms.RadioButton();
            this.optmultiplicacion = new System.Windows.Forms.RadioButton();
            this.optdividir = new System.Windows.Forms.RadioButton();
            this.grboperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(12, 114);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(36, 13);
            this.lblnum1.TabIndex = 2;
            this.lblnum1.Text = "num 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(148, 121);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(36, 13);
            this.lblnum2.TabIndex = 3;
            this.lblnum2.Text = "num 2";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(107, 202);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblrespuesta.TabIndex = 4;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(93, 248);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(75, 23);
            this.bt.TabIndex = 5;
            this.bt.Text = "procesar";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(54, 114);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(53, 20);
            this.txtnum1.TabIndex = 6;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(197, 121);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(51, 20);
            this.txtnum2.TabIndex = 7;
            // 
            // grboperaciones
            // 
            this.grboperaciones.Controls.Add(this.optdividir);
            this.grboperaciones.Controls.Add(this.optmultiplicacion);
            this.grboperaciones.Controls.Add(this.optresta);
            this.grboperaciones.Controls.Add(this.optsuma);
            this.grboperaciones.Location = new System.Drawing.Point(296, 68);
            this.grboperaciones.Name = "grboperaciones";
            this.grboperaciones.Size = new System.Drawing.Size(175, 289);
            this.grboperaciones.TabIndex = 8;
            this.grboperaciones.TabStop = false;
            this.grboperaciones.Text = "operaciones";
            // 
            // optsuma
            // 
            this.optsuma.AutoSize = true;
            this.optsuma.Checked = true;
            this.optsuma.Location = new System.Drawing.Point(22, 46);
            this.optsuma.Name = "optsuma";
            this.optsuma.Size = new System.Drawing.Size(50, 17);
            this.optsuma.TabIndex = 0;
            this.optsuma.TabStop = true;
            this.optsuma.Text = "suma\r\n";
            this.optsuma.UseVisualStyleBackColor = true;
            // 
            // optresta
            // 
            this.optresta.AutoSize = true;
            this.optresta.Location = new System.Drawing.Point(22, 90);
            this.optresta.Name = "optresta";
            this.optresta.Size = new System.Drawing.Size(48, 17);
            this.optresta.TabIndex = 1;
            this.optresta.Text = "resta";
            this.optresta.UseVisualStyleBackColor = true;
            // 
            // optmultiplicacion
            // 
            this.optmultiplicacion.AutoSize = true;
            this.optmultiplicacion.Location = new System.Drawing.Point(22, 134);
            this.optmultiplicacion.Name = "optmultiplicacion";
            this.optmultiplicacion.Size = new System.Drawing.Size(88, 17);
            this.optmultiplicacion.TabIndex = 2;
            this.optmultiplicacion.Text = "multiplicacion";
            this.optmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optdividir
            // 
            this.optdividir.AutoSize = true;
            this.optdividir.Location = new System.Drawing.Point(22, 185);
            this.optdividir.Name = "optdividir";
            this.optdividir.Size = new System.Drawing.Size(52, 17);
            this.optdividir.TabIndex = 3;
            this.optdividir.Text = "dividir";
            this.optdividir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 439);
            this.Controls.Add(this.grboperaciones);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grboperaciones.ResumeLayout(false);
            this.grboperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.GroupBox grboperaciones;
        private System.Windows.Forms.RadioButton optdividir;
        private System.Windows.Forms.RadioButton optmultiplicacion;
        private System.Windows.Forms.RadioButton optresta;
        private System.Windows.Forms.RadioButton optsuma;
    }
}

