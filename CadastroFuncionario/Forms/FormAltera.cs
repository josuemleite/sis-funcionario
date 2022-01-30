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
    public partial class FormAltera : Form
    {
        int codAlterar;

        public FormAltera()
        {
            InitializeComponent();
            tabPage2.Parent = null;
        }

        private void FormAltera_Load(object sender, EventArgs e)
        {
            LoadTheme();
            listaDgFuncionarios();
        }

        void listaDgFuncionarios()
        {
            ConectaBanco con = new ConectaBanco();
            dgFuncionarios.DataSource = con.listaFuncionarios();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.tabControl1.SelectedTab.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgFuncionarios.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("nome like '%{0}%'", txtBusca.Text);
        }

        private void btnAlteraFuncionario_Click(object sender, EventArgs e)
        {
            tabPage2.Parent = tabControl1;

            tabControl1.SelectedTab = tabPage2;

            this.LoadTheme();

            int linha = dgFuncionarios.CurrentRow.Index;

            codAlterar = Convert.ToInt32(dgFuncionarios.Rows[linha].Cells["codFuncionario"].Value.ToString());
            txtAlteraCargo.Text = dgFuncionarios.Rows[linha].Cells["cargo"].Value.ToString();
            dtAlteraAdmissao.Value = Convert.ToDateTime(dgFuncionarios.Rows[linha].Cells["dataAdmissao"].Value.ToString());
            txtAlteraNome.Text = dgFuncionarios.Rows[linha].Cells["nome"].Value.ToString();
            dtAlteraNascimento.Value = Convert.ToDateTime(dgFuncionarios.Rows[linha].Cells["dataNascimento"].Value.ToString());
            txtAlteraNacionalidade.Text = dgFuncionarios.Rows[linha].Cells["nacionalidade"].Value.ToString();
            txtAlteraNaturalidade.Text = dgFuncionarios.Rows[linha].Cells["naturalidade"].Value.ToString();
            txtAlteraCTPS.Text = dgFuncionarios.Rows[linha].Cells["numCTPS"].Value.ToString();
            txtAlteraRemuneracao.Text = dgFuncionarios.Rows[linha].Cells["remuneracao"].Value.ToString();

            //tabControl1.SelectedIndex = 1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.Cargo = txtAlteraCargo.Text;
            f.DataAdmissao = Convert.ToDateTime(dtAlteraAdmissao.Text);
            f.Nome = txtAlteraNome.Text;
            f.DataNascimento = Convert.ToDateTime(dtAlteraNascimento.Text);
            f.Nacionalidade = txtAlteraNacionalidade.Text;
            f.Naturalidade = txtAlteraNaturalidade.Text;
            f.NumCTPS = txtAlteraCTPS.Text;
            f.Remuneracao = Convert.ToDecimal(txtAlteraRemuneracao.Text);
            ConectaBanco con = new ConectaBanco();
            bool r = con.alteraFuncionario(f, codAlterar);
            if (r == true)
            {
                MessageBox.Show("Dados alterados com sucesso!");
                listaDgFuncionarios();
                tabPage2.Parent = tabControl1;
                tabPage2.Parent = null;
                tabControl1.SelectedTab = tabPage1;
            }
            else
                MessageBox.Show(con.mensagem);
        }
    }
}
