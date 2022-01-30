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
            int linha = dgFuncionarios.CurrentRow.Index;
            codAlterar = Convert.ToInt32(dgFuncionarios.Rows[linha].Cells["codFuncionario"].Value.ToString());
            txtAlteraCargo.Text = dgFuncionarios.Rows[linha].Cells["cargo"].Value.ToString();
            dtAlteraAdmissao = Convert.ToDateTime(dgFuncionarios.Rows[linha].Cells["dataAdmissao"].Value.ToString());
        }
    }
}
