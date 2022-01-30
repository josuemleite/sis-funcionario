using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario.Forms
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.SecondaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                    e.Handled = true;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            var num = Convert.ToDecimal(txtRemuneracao.Text);
            txtRemuneracao.Text = num.ToString("N2");
        }

        void limpaCampos()
        {
            txtCargo.Clear();
            dtAdmissao.Value = DateTime.Now;
            txtNome.Clear();
            dtNascimento.Value = DateTime.Now;
            txtNacionalidade.Clear();
            txtNaturalidade.Clear();
            txtCTPS.Clear();
            txtRemuneracao.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.Cargo = txtCargo.Text;
            f.DataAdmissao = Convert.ToDateTime(dtAdmissao.Text);
            f.Nome = txtNome.Text;
            f.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
            f.Nacionalidade = txtNacionalidade.Text;
            f.Naturalidade = txtNaturalidade.Text;
            f.NumCTPS = txtCTPS.Text;
            f.Remuneracao = Convert.ToDecimal(txtRemuneracao.Text);
            ConectaBanco con = new ConectaBanco();
            bool r = con.insereFuncionario(f);
            if (r == true)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
                limpaCampos();
                txtCargo.Focus();
            }
            else
                MessageBox.Show(con.mensagem);
        }
    }
}
