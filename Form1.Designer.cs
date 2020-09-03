namespace CalcTemp
{
    partial class F_TempCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_celsius = new System.Windows.Forms.Label();
            this.lb_fahrenheit = new System.Windows.Forms.Label();
            this.lb_kelvin = new System.Windows.Forms.Label();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_fahrenheit = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lb_tuto = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lb_dica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_celsius
            // 
            this.lb_celsius.AutoSize = true;
            this.lb_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_celsius.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_celsius.Location = new System.Drawing.Point(11, 94);
            this.lb_celsius.Name = "lb_celsius";
            this.lb_celsius.Size = new System.Drawing.Size(74, 15);
            this.lb_celsius.TabIndex = 0;
            this.lb_celsius.Text = "Celsius (°C):";
            // 
            // lb_fahrenheit
            // 
            this.lb_fahrenheit.AutoSize = true;
            this.lb_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fahrenheit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_fahrenheit.Location = new System.Drawing.Point(11, 120);
            this.lb_fahrenheit.Name = "lb_fahrenheit";
            this.lb_fahrenheit.Size = new System.Drawing.Size(92, 15);
            this.lb_fahrenheit.TabIndex = 1;
            this.lb_fahrenheit.Text = "Fahrenheit (°F):";
            // 
            // lb_kelvin
            // 
            this.lb_kelvin.AutoSize = true;
            this.lb_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kelvin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_kelvin.Location = new System.Drawing.Point(12, 146);
            this.lb_kelvin.Name = "lb_kelvin";
            this.lb_kelvin.Size = new System.Drawing.Size(43, 15);
            this.lb_kelvin.TabIndex = 2;
            this.lb_kelvin.Text = "Kelvin:";
            // 
            // txt_celsius
            // 
            this.txt_celsius.BackColor = System.Drawing.SystemColors.Window;
            this.txt_celsius.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_celsius.Location = new System.Drawing.Point(106, 93);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(100, 20);
            this.txt_celsius.TabIndex = 3;
            this.txt_celsius.TextChanged += new System.EventHandler(this.txt_celsius_TextChanged);
            // 
            // txt_fahrenheit
            // 
            this.txt_fahrenheit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fahrenheit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_fahrenheit.Location = new System.Drawing.Point(106, 119);
            this.txt_fahrenheit.Name = "txt_fahrenheit";
            this.txt_fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txt_fahrenheit.TabIndex = 4;
            this.txt_fahrenheit.TextChanged += new System.EventHandler(this.txt_fahrenheit_TextChanged);
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.BackColor = System.Drawing.SystemColors.Window;
            this.txt_kelvin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_kelvin.Location = new System.Drawing.Point(106, 145);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(100, 20);
            this.txt_kelvin.TabIndex = 5;
            this.txt_kelvin.TextChanged += new System.EventHandler(this.txt_kelvin_TextChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.Location = new System.Drawing.Point(131, 171);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_tuto
            // 
            this.lb_tuto.AutoSize = true;
            this.lb_tuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_tuto.Location = new System.Drawing.Point(12, 64);
            this.lb_tuto.Name = "lb_tuto";
            this.lb_tuto.Size = new System.Drawing.Size(200, 26);
            this.lb_tuto.TabIndex = 7;
            this.lb_tuto.Text = "Digite o valor que você possui no campo\r\ncerto e a conversão será feita:\r\n";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.White;
            this.lb_titulo.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_titulo.Location = new System.Drawing.Point(38, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(153, 50);
            this.lb_titulo.TabIndex = 8;
            this.lb_titulo.Text = "Conversor de \r\ntemperatura";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.Location = new System.Drawing.Point(131, 200);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lb_dica
            // 
            this.lb_dica.AutoSize = true;
            this.lb_dica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dica.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_dica.Location = new System.Drawing.Point(11, 193);
            this.lb_dica.Name = "lb_dica";
            this.lb_dica.Size = new System.Drawing.Size(91, 30);
            this.lb_dica.TabIndex = 10;
            this.lb_dica.Text = "*Para decimais\r\n  utilize vírgula.";
            // 
            // F_TempCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(218, 231);
            this.Controls.Add(this.lb_dica);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_tuto);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_fahrenheit);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.lb_kelvin);
            this.Controls.Add(this.lb_fahrenheit);
            this.Controls.Add(this.lb_celsius);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_TempCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperatura";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_celsius;
        private System.Windows.Forms.Label lb_fahrenheit;
        private System.Windows.Forms.Label lb_kelvin;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_fahrenheit;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lb_tuto;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lb_dica;
    }
}

