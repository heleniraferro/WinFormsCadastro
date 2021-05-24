
namespace WinFormsTela
{
    partial class frmCadastroPessoas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cbbxProfissao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstwPessoas = new System.Windows.Forms.ListView();
            this.ColNome = new System.Windows.Forms.ColumnHeader();
            this.ColIdade = new System.Windows.Forms.ColumnHeader();
            this.ColTelefone = new System.Windows.Forms.ColumnHeader();
            this.ColEmail = new System.Windows.Forms.ColumnHeader();
            this.ColProfissao = new System.Windows.Forms.ColumnHeader();
            this.ColFormacao = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(315, 34);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(334, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(334, 35);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(188, 34);
            this.txtIdade.TabIndex = 3;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress);
            // 
            // cbbxProfissao
            // 
            this.cbbxProfissao.FormattingEnabled = true;
            this.cbbxProfissao.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "ADVOGADO ",
            "AGENCIADOR DE PROPAGANDA",
            "AGENTE ADMINISTRATIVO",
            "AGENTE DE SERVICOS FUNERARIOS E EMBALSAMADOR ",
            "AGENTE DE VIAGEM E GUIA DE TURISMO",
            "AGRONOMO",
            "ANALISTA DE SISTEMAS",
            "BANCARIO E ECONOMIARIO",
            "BIBLIOTECARIO, ARQUIVISTA, MUSEOLOGO E ARQUEOLOGO ",
            "BIOLOGO E BIOMEDICO",
            "BOLSISTA, ESTAGIARIO E ASSEMELHADOS ",
            "BOMBEIRO E INSTALADOR DE GAS, AGUA, ESGOTO E ASSEMELHADOS ",
            "CONTADOR",
            "COREOGRAFO",
            "DECORADOR",
            "DIRETOR DE EMPRESAS",
            "ENGENHEIRO",
            "MODELO DE MODAS"});
            this.cbbxProfissao.Location = new System.Drawing.Point(207, 99);
            this.cbbxProfissao.Name = "cbbxProfissao";
            this.cbbxProfissao.Size = new System.Drawing.Size(260, 36);
            this.cbbxProfissao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(207, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Profissão:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionar.Location = new System.Drawing.Point(620, 141);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 43);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(528, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(528, 35);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(188, 34);
            this.txtTelefone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 34);
            this.txtEmail.TabIndex = 11;
            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(477, 101);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(239, 34);
            this.txtFormacao.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(481, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Formação:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(518, 141);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 43);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemover.Location = new System.Drawing.Point(416, 141);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(96, 43);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome:";
            // 
            // lstwPessoas
            // 
            this.lstwPessoas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNome,
            this.ColIdade,
            this.ColTelefone,
            this.ColEmail,
            this.ColProfissao,
            this.ColFormacao});
            this.lstwPessoas.FullRowSelect = true;
            this.lstwPessoas.HideSelection = false;
            this.lstwPessoas.Location = new System.Drawing.Point(17, 190);
            this.lstwPessoas.MultiSelect = false;
            this.lstwPessoas.Name = "lstwPessoas";
            this.lstwPessoas.Size = new System.Drawing.Size(710, 188);
            this.lstwPessoas.TabIndex = 18;
            this.lstwPessoas.UseCompatibleStateImageBehavior = false;
            this.lstwPessoas.View = System.Windows.Forms.View.Details;
            this.lstwPessoas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstwPessoas_ItemSelectionChanged);
            // 
            // ColNome
            // 
            this.ColNome.Name = "ColNome";
            this.ColNome.Text = "Nome";
            this.ColNome.Width = 150;
            // 
            // ColIdade
            // 
            this.ColIdade.Name = "ColIdade";
            this.ColIdade.Text = "Idade";
            // 
            // ColTelefone
            // 
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.Text = "Telefone";
            this.ColTelefone.Width = 100;
            // 
            // ColEmail
            // 
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Text = "E-mail";
            this.ColEmail.Width = 150;
            // 
            // ColProfissao
            // 
            this.ColProfissao.Name = "ColProfissao";
            this.ColProfissao.Text = "Profissão";
            this.ColProfissao.Width = 150;
            // 
            // ColFormacao
            // 
            this.ColFormacao.Name = "ColFormacao";
            this.ColFormacao.Text = "Formação";
            this.ColFormacao.Width = 150;
            // 
            // frmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 816);
            this.Controls.Add(this.lstwPessoas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtFormacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbxProfissao);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmCadastroPessoas";
            this.Text = "Tela Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cbbxProfissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader ColNome;
        private System.Windows.Forms.ColumnHeader ColIdade;
        private System.Windows.Forms.ColumnHeader ColTelefone;
        private System.Windows.Forms.ColumnHeader ColEmail;
        private System.Windows.Forms.ColumnHeader ColProfissao;
        private System.Windows.Forms.ColumnHeader ColFormacao;
        internal System.Windows.Forms.ListView lstwPessoas;
    }
}

