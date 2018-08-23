namespace figuras_21082018
{
    partial class Form1
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
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDato1 = new System.Windows.Forms.TextBox();
            this.tbDato2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbLista
            // 
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Items.AddRange(new object[] {
            "Circulo ",
            "Rectangulo",
            "Cuadrado"});
            this.cbLista.Location = new System.Drawing.Point(29, 26);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(121, 21);
            this.cbLista.TabIndex = 0;
            this.cbLista.SelectedIndexChanged += new System.EventHandler(this.cbLista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona una Figura";
            // 
            // tbDato1
            // 
            this.tbDato1.Enabled = false;
            this.tbDato1.Location = new System.Drawing.Point(271, 27);
            this.tbDato1.Name = "tbDato1";
            this.tbDato1.Size = new System.Drawing.Size(100, 20);
            this.tbDato1.TabIndex = 2;
            // 
            // tbDato2
            // 
            this.tbDato2.Enabled = false;
            this.tbDato2.Location = new System.Drawing.Point(271, 54);
            this.tbDato2.Name = "tbDato2";
            this.tbDato2.Size = new System.Drawing.Size(100, 20);
            this.tbDato2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dato 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dato 2";
            // 
            // btCalcular
            // 
            this.btCalcular.Enabled = false;
            this.btCalcular.Location = new System.Drawing.Point(284, 162);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Enabled = false;
            this.rbPerimetro.Location = new System.Drawing.Point(274, 95);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(69, 17);
            this.rbPerimetro.TabIndex = 7;
            this.rbPerimetro.TabStop = true;
            this.rbPerimetro.Text = "Perimetro";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Enabled = false;
            this.rbArea.Location = new System.Drawing.Point(274, 121);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(47, 17);
            this.rbArea.TabIndex = 8;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 208);
            this.Controls.Add(this.rbArea);
            this.Controls.Add(this.rbPerimetro);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDato2);
            this.Controls.Add(this.tbDato1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDato1;
        private System.Windows.Forms.TextBox tbDato2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.RadioButton rbArea;
    }
}

