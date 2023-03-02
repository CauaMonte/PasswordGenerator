namespace GeradorSenhas
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
            this.tittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGerar = new System.Windows.Forms.Button();
            this.boxQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSave = new System.Windows.Forms.TextBox();
            this.btCopiar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCopiarTudo = new System.Windows.Forms.Button();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.cbNum = new System.Windows.Forms.CheckBox();
            this.cbEspec = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(85, 9);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(236, 29);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Gerador de senhas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de caracteres: ";
            // 
            // btGerar
            // 
            this.btGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerar.Location = new System.Drawing.Point(297, 63);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(83, 30);
            this.btGerar.TabIndex = 2;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // boxQtd
            // 
            this.boxQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxQtd.Location = new System.Drawing.Point(219, 65);
            this.boxQtd.Name = "boxQtd";
            this.boxQtd.Size = new System.Drawing.Size(69, 26);
            this.boxQtd.TabIndex = 3;
            this.boxQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxQtd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha : ";
            // 
            // textSenha
            // 
            this.textSenha.AutoSize = true;
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(80, 140);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(0, 20);
            this.textSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salvos =>";
            // 
            // textSave
            // 
            this.textSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSave.Location = new System.Drawing.Point(101, 225);
            this.textSave.Multiline = true;
            this.textSave.Name = "textSave";
            this.textSave.ReadOnly = true;
            this.textSave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSave.Size = new System.Drawing.Size(279, 148);
            this.textSave.TabIndex = 7;
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(130, 179);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(83, 30);
            this.btCopiar.TabIndex = 8;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(263, 179);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 30);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(12, 256);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(83, 30);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCopiarTudo
            // 
            this.btCopiarTudo.Location = new System.Drawing.Point(12, 301);
            this.btCopiarTudo.Name = "btCopiarTudo";
            this.btCopiarTudo.Size = new System.Drawing.Size(83, 30);
            this.btCopiarTudo.TabIndex = 11;
            this.btCopiarTudo.Text = "Copiar Tudo";
            this.btCopiarTudo.UseVisualStyleBackColor = true;
            this.btCopiarTudo.Click += new System.EventHandler(this.btCopiarTudo_Click);
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.Location = new System.Drawing.Point(12, 108);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(95, 17);
            this.cbUpper.TabIndex = 14;
            this.cbUpper.Text = "Maiusculas (A)";
            this.cbUpper.UseVisualStyleBackColor = true;
            this.cbUpper.CheckStateChanged += new System.EventHandler(this.cbUpper_CheckStateChanged);
            // 
            // cbLower
            // 
            this.cbLower.AutoSize = true;
            this.cbLower.Location = new System.Drawing.Point(113, 108);
            this.cbLower.Name = "cbLower";
            this.cbLower.Size = new System.Drawing.Size(94, 17);
            this.cbLower.TabIndex = 15;
            this.cbLower.Text = "Minusculas (a)";
            this.cbLower.UseVisualStyleBackColor = true;
            this.cbLower.CheckStateChanged += new System.EventHandler(this.cbLower_CheckStateChanged);
            // 
            // cbNum
            // 
            this.cbNum.AutoSize = true;
            this.cbNum.Location = new System.Drawing.Point(213, 108);
            this.cbNum.Name = "cbNum";
            this.cbNum.Size = new System.Drawing.Size(83, 17);
            this.cbNum.TabIndex = 16;
            this.cbNum.Text = "Números (1)";
            this.cbNum.UseVisualStyleBackColor = true;
            this.cbNum.CheckStateChanged += new System.EventHandler(this.cbNum_CheckStateChanged);
            // 
            // cbEspec
            // 
            this.cbEspec.AutoSize = true;
            this.cbEspec.Location = new System.Drawing.Point(297, 108);
            this.cbEspec.Name = "cbEspec";
            this.cbEspec.Size = new System.Drawing.Size(91, 17);
            this.cbEspec.TabIndex = 17;
            this.cbEspec.Text = "Especiais (@)";
            this.cbEspec.UseVisualStyleBackColor = true;
            this.cbEspec.CheckStateChanged += new System.EventHandler(this.cbEspec_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "By Cauã Monte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEspec);
            this.Controls.Add(this.cbNum);
            this.Controls.Add(this.cbLower);
            this.Controls.Add(this.cbUpper);
            this.Controls.Add(this.btCopiarTudo);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.textSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxQtd);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.TextBox boxQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSave;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCopiarTudo;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbNum;
        private System.Windows.Forms.CheckBox cbEspec;
        private System.Windows.Forms.Label label4;
    }
}

