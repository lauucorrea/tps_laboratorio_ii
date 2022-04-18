namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDecimalBinario = new System.Windows.Forms.Button();
            this.btnBinarioDecimal = new System.Windows.Forms.Button();
            this.lstoperaciones = new System.Windows.Forms.ListBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperar.Location = new System.Drawing.Point(36, 251);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(155, 48);
            this.btnOperar.TabIndex = 1;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(211, 251);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 48);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(384, 251);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 48);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDecimalBinario
            // 
            this.btnDecimalBinario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecimalBinario.Location = new System.Drawing.Point(36, 331);
            this.btnDecimalBinario.Name = "btnDecimalBinario";
            this.btnDecimalBinario.Size = new System.Drawing.Size(242, 48);
            this.btnDecimalBinario.TabIndex = 4;
            this.btnDecimalBinario.Text = "ConvertirABinario";
            this.btnDecimalBinario.UseVisualStyleBackColor = true;
            this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBinarioDecimal.Location = new System.Drawing.Point(297, 331);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(242, 48);
            this.btnBinarioDecimal.TabIndex = 5;
            this.btnBinarioDecimal.Text = "ConvertirADecimal";
            this.btnBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // lstoperaciones
            // 
            this.lstoperaciones.FormattingEnabled = true;
            this.lstoperaciones.ItemHeight = 15;
            this.lstoperaciones.Location = new System.Drawing.Point(582, 13);
            this.lstoperaciones.Name = "lstoperaciones";
            this.lstoperaciones.Size = new System.Drawing.Size(206, 424);
            this.lstoperaciones.TabIndex = 7;
            // 
            // cmbOperador
            // 
            this.cmbOperador.AutoCompleteCustomSource.AddRange(new string[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.ItemHeight = 47;
            this.cmbOperador.Items.AddRange(new object[] {
            " ",
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(249, 134);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(94, 55);
            this.cmbOperador.TabIndex = 8;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(62, 134);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 53);
            this.txtNumero1.TabIndex = 9;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtOperando1_TextChanged);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(412, 134);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 53);
            this.txtNumero2.TabIndex = 10;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero2_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResultado.Location = new System.Drawing.Point(438, 39);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(74, 29);
            this.txtResultado.TabIndex = 11;
            this.txtResultado.Text = "label1";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.lstoperaciones);
            this.Controls.Add(this.btnBinarioDecimal);
            this.Controls.Add(this.btnDecimalBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calculadora de Lautaro Correa 2E";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDecimalBinario;
        private System.Windows.Forms.Button btnBinarioDecimal;
        private System.Windows.Forms.ListBox lstoperaciones;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label txtResultado;
    }
}
