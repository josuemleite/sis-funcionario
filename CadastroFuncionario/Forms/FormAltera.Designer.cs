namespace CadastroFuncionario.Forms
{
    partial class FormAltera
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
            this.btnAlteraFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgFuncionarios = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtAlteraRemuneracao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlteraCTPS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlteraNaturalidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlteraNacionalidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAlteraNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtAlteraAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlteraCargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlteraFuncionario
            // 
            this.btnAlteraFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAlteraFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlteraFuncionario.Location = new System.Drawing.Point(432, 12);
            this.btnAlteraFuncionario.Name = "btnAlteraFuncionario";
            this.btnAlteraFuncionario.Size = new System.Drawing.Size(119, 29);
            this.btnAlteraFuncionario.TabIndex = 1;
            this.btnAlteraFuncionario.Text = "ALTERAR";
            this.btnAlteraFuncionario.UseVisualStyleBackColor = true;
            this.btnAlteraFuncionario.Click += new System.EventHandler(this.btnAlteraFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Funcionário:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusca.Location = new System.Drawing.Point(118, 12);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(287, 29);
            this.txtBusca.TabIndex = 0;
            // 
            // dgFuncionarios
            // 
            this.dgFuncionarios.AllowUserToAddRows = false;
            this.dgFuncionarios.AllowUserToDeleteRows = false;
            this.dgFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarios.Location = new System.Drawing.Point(-4, 48);
            this.dgFuncionarios.Name = "dgFuncionarios";
            this.dgFuncionarios.ReadOnly = true;
            this.dgFuncionarios.RowTemplate.Height = 25;
            this.dgFuncionarios.Size = new System.Drawing.Size(579, 321);
            this.dgFuncionarios.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 425);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAlteraFuncionario);
            this.tabPage1.Controls.Add(this.dgFuncionarios);
            this.tabPage1.Controls.Add(this.txtBusca);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Funcionários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.txtAlteraRemuneracao);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtAlteraCTPS);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtAlteraNaturalidade);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtAlteraNacionalidade);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtAlteraNascimento);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtAlteraNome);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dtAlteraAdmissao);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtAlteraCargo);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Location = new System.Drawing.Point(211, 322);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(140, 35);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtAlteraRemuneracao
            // 
            this.txtAlteraRemuneracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraRemuneracao.Location = new System.Drawing.Point(151, 287);
            this.txtAlteraRemuneracao.Name = "txtAlteraRemuneracao";
            this.txtAlteraRemuneracao.Size = new System.Drawing.Size(120, 23);
            this.txtAlteraRemuneracao.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Remuneração: R$";
            // 
            // txtAlteraCTPS
            // 
            this.txtAlteraCTPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraCTPS.Location = new System.Drawing.Point(151, 250);
            this.txtAlteraCTPS.Name = "txtAlteraCTPS";
            this.txtAlteraCTPS.Size = new System.Drawing.Size(331, 23);
            this.txtAlteraCTPS.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Número da CTPS:";
            // 
            // txtAlteraNaturalidade
            // 
            this.txtAlteraNaturalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraNaturalidade.Location = new System.Drawing.Point(122, 210);
            this.txtAlteraNaturalidade.Name = "txtAlteraNaturalidade";
            this.txtAlteraNaturalidade.Size = new System.Drawing.Size(331, 23);
            this.txtAlteraNaturalidade.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Naturalidade:";
            // 
            // txtAlteraNacionalidade
            // 
            this.txtAlteraNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraNacionalidade.Location = new System.Drawing.Point(131, 173);
            this.txtAlteraNacionalidade.Name = "txtAlteraNacionalidade";
            this.txtAlteraNacionalidade.Size = new System.Drawing.Size(331, 23);
            this.txtAlteraNacionalidade.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nacionalidade:";
            // 
            // dtAlteraNascimento
            // 
            this.dtAlteraNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtAlteraNascimento.CustomFormat = "";
            this.dtAlteraNascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtAlteraNascimento.Location = new System.Drawing.Point(169, 133);
            this.dtAlteraNascimento.Name = "dtAlteraNascimento";
            this.dtAlteraNascimento.Size = new System.Drawing.Size(286, 25);
            this.dtAlteraNascimento.TabIndex = 3;
            this.dtAlteraNascimento.Value = new System.DateTime(2022, 1, 29, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Data de nascimento:";
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraNome.Location = new System.Drawing.Point(75, 95);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(420, 23);
            this.txtAlteraNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome:";
            // 
            // dtAlteraAdmissao
            // 
            this.dtAlteraAdmissao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtAlteraAdmissao.CustomFormat = "";
            this.dtAlteraAdmissao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtAlteraAdmissao.Location = new System.Drawing.Point(155, 51);
            this.dtAlteraAdmissao.Name = "dtAlteraAdmissao";
            this.dtAlteraAdmissao.Size = new System.Drawing.Size(286, 25);
            this.dtAlteraAdmissao.TabIndex = 1;
            this.dtAlteraAdmissao.Value = new System.DateTime(2022, 1, 29, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data de admissão:";
            // 
            // txtAlteraCargo
            // 
            this.txtAlteraCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraCargo.Location = new System.Drawing.Point(74, 13);
            this.txtAlteraCargo.Name = "txtAlteraCargo";
            this.txtAlteraCargo.Size = new System.Drawing.Size(331, 23);
            this.txtAlteraCargo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cargo:";
            // 
            // FormAltera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAltera";
            this.Text = "ALTERAR";
            this.Load += new System.EventHandler(this.FormAltera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAlteraFuncionario;
        private Label label1;
        private TextBox txtBusca;
        private DataGridView dgFuncionarios;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAlterar;
        private TextBox txtAlteraRemuneracao;
        private Label label8;
        private TextBox txtAlteraCTPS;
        private Label label7;
        private TextBox txtAlteraNaturalidade;
        private Label label6;
        private TextBox txtAlteraNacionalidade;
        private Label label5;
        private DateTimePicker dtAlteraNascimento;
        private Label label4;
        private TextBox txtAlteraNome;
        private Label label3;
        private DateTimePicker dtAlteraAdmissao;
        private Label label2;
        private TextBox txtAlteraCargo;
        private Label label9;
    }
}