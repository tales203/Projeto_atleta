namespace ProjetoAtleta
{
    partial class Form1
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
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(146, 287);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(116, 43);
            this.btn_enviar.TabIndex = 25;
            this.btn_enviar.Text = "Enviar Dados";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imc.Location = new System.Drawing.Point(109, 234);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(54, 25);
            this.lbl_imc.TabIndex = 24;
            this.lbl_imc.Text = "0.00";
            this.lbl_imc.Click += new System.EventHandler(this.lbl_imc_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.Location = new System.Drawing.Point(86, 214);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(105, 20);
            this.lbl_text.TabIndex = 23;
            this.lbl_text.Text = "IMC é igual a:";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(15, 287);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(108, 43);
            this.btn_calc.TabIndex = 22;
            this.btn_calc.Text = "Calcular IMC";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click_1);
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(12, 69);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_altura.TabIndex = 21;
            this.lbl_altura.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 20;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(9, 122);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 19;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(6, 175);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(34, 13);
            this.lbl_idade.TabIndex = 18;
            this.lbl_idade.Text = "Idade";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(9, 16);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 17;
            this.lbl_nome.Text = "Nome";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(12, 191);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(250, 20);
            this.txtIdade.TabIndex = 16;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(12, 138);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(250, 20);
            this.txtPeso.TabIndex = 15;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(12, 85);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(250, 20);
            this.txtAltura.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
            this.txtNome.TabIndex = 13;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 354);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtNome;
    }
}

