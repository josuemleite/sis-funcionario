namespace CadastroFuncionario.Forms
{
    partial class FormBusca
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
            this.dgFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFuncionarios
            // 
            this.dgFuncionarios.AllowUserToAddRows = false;
            this.dgFuncionarios.AllowUserToDeleteRows = false;
            this.dgFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarios.Location = new System.Drawing.Point(0, 48);
            this.dgFuncionarios.Name = "dgFuncionarios";
            this.dgFuncionarios.ReadOnly = true;
            this.dgFuncionarios.RowTemplate.Height = 25;
            this.dgFuncionarios.Size = new System.Drawing.Size(580, 349);
            this.dgFuncionarios.TabIndex = 0;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusca.Location = new System.Drawing.Point(114, 12);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(287, 29);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionário:";
            // 
            // btnRemoveFuncionario
            // 
            this.btnRemoveFuncionario.FlatAppearance.BorderSize = 0;
            this.btnRemoveFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFuncionario.Location = new System.Drawing.Point(428, 12);
            this.btnRemoveFuncionario.Name = "btnRemoveFuncionario";
            this.btnRemoveFuncionario.Size = new System.Drawing.Size(119, 29);
            this.btnRemoveFuncionario.TabIndex = 16;
            this.btnRemoveFuncionario.Text = "REMOVER";
            this.btnRemoveFuncionario.UseVisualStyleBackColor = true;
            this.btnRemoveFuncionario.Click += new System.EventHandler(this.btnRemoveFuncionario_Click);
            // 
            // FormBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgFuncionarios);
            this.Name = "FormBusca";
            this.Text = "BUSCAR";
            this.Load += new System.EventHandler(this.FormBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgFuncionarios;
        private TextBox txtBusca;
        private Label label1;
        private Button btnRemoveFuncionario;
    }
}