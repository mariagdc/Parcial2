namespace parcial2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnImpo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbCuentacte = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCompras = new System.Windows.Forms.RadioButton();
            this.rbpagos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.controlOpenF = new System.Windows.Forms.OpenFileDialog();
            this.ControlguardarDOC = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(84, 49);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 0;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(417, 94);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(103, 57);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "TICKET";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnExpo
            // 
            this.btnExpo.Location = new System.Drawing.Point(417, 163);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(103, 54);
            this.btnExpo.TabIndex = 2;
            this.btnExpo.Text = "Exportar tickets";
            this.btnExpo.UseVisualStyleBackColor = true;
            this.btnExpo.Click += new System.EventHandler(this.btnExpo_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.Transparent;
            this.btnAtender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAtender.Location = new System.Drawing.Point(196, 289);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(78, 61);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "Atender Cliente";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnImpo
            // 
            this.btnImpo.Location = new System.Drawing.Point(417, 223);
            this.btnImpo.Name = "btnImpo";
            this.btnImpo.Size = new System.Drawing.Size(103, 61);
            this.btnImpo.TabIndex = 4;
            this.btnImpo.Text = "Importar Cuentas Corrientes";
            this.btnImpo.UseVisualStyleBackColor = true;
            this.btnImpo.Click += new System.EventHandler(this.btnImpo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Cuenta Cte";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbCuentacte
            // 
            this.tbCuentacte.Location = new System.Drawing.Point(124, 34);
            this.tbCuentacte.Name = "tbCuentacte";
            this.tbCuentacte.Size = new System.Drawing.Size(100, 20);
            this.tbCuentacte.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.tbCuentacte);
            this.groupBox1.Location = new System.Drawing.Point(38, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos:";
            // 
            // rbCompras
            // 
            this.rbCompras.AutoSize = true;
            this.rbCompras.Location = new System.Drawing.Point(29, 19);
            this.rbCompras.Name = "rbCompras";
            this.rbCompras.Size = new System.Drawing.Size(66, 17);
            this.rbCompras.TabIndex = 8;
            this.rbCompras.TabStop = true;
            this.rbCompras.Text = "Compras";
            this.rbCompras.UseVisualStyleBackColor = true;
            // 
            // rbpagos
            // 
            this.rbpagos.AutoSize = true;
            this.rbpagos.Location = new System.Drawing.Point(29, 42);
            this.rbpagos.Name = "rbpagos";
            this.rbpagos.Size = new System.Drawing.Size(55, 17);
            this.rbpagos.TabIndex = 9;
            this.rbpagos.TabStop = true;
            this.rbpagos.Text = "Pagos";
            this.rbpagos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbCompras);
            this.groupBox2.Controls.Add(this.rbpagos);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(38, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 66);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNI";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 95);
            this.listBox1.TabIndex = 12;
            // 
            // controlOpenF
            // 
            this.controlOpenF.FileName = "controlOpenF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(536, 357);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImpo);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnExpo);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.tbDni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnImpo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbCuentacte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCompras;
        private System.Windows.Forms.RadioButton rbpagos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog controlOpenF;
        private System.Windows.Forms.SaveFileDialog ControlguardarDOC;
    }
}

