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
    public partial class FormBusca : Form
    {
        public FormBusca()
        {
            InitializeComponent();
        }

        private void FormBusca_Load(object sender, EventArgs e)
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
            //dgFuncionarios.BackgroundColor = ThemeColor.PrimaryColor;
            //dgFuncionarios.RowsDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            //label14.ForeColor = ThemeColor.SecondaryColor;
            //label15.ForeColor = ThemeColor.PrimaryColor;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgFuncionarios.DataSource as DataTable).DefaultView.RowFilter = 
                String.Format("nome like '%{0}%'", txtBusca.Text);
        }

        private void btnRemoveFuncionario_Click(object sender, EventArgs e)
        {
            int linha = dgFuncionarios.CurrentRow.Index;
            int cod = Convert.ToInt32(dgFuncionarios.Rows[linha].Cells["codFuncionario"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?", "Remove Funcionário", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaFuncionario(cod);
                if (retorno == true)
                {
                    MessageBox.Show("Funcionário excluído com sucesso!");
                    listaDgFuncionarios();
                }
                else
                    MessageBox.Show(con.mensagem);
            }
            else
                MessageBox.Show("Exclusão cancelada!");
        }
    }
}
