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
            var num = Convert.ToDecimal(textBox6.Text);
            textBox6.Text = num.ToString("N2");
        }
    }
}
