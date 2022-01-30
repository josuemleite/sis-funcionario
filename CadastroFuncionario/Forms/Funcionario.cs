using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario.Forms
{
    internal class Funcionario
    {
        string cargo;
        DateTime dataAdmissao = new DateTime();
        string nome;
        DateTime dataNascimento = new DateTime();
        string nacionalidade;
        string naturalidade;
        string numCTPS;
        decimal remuneracao;

        public string Cargo { get => cargo; set => cargo = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public string Naturalidade { get => naturalidade; set => naturalidade = value; }
        public string NumCTPS { get => numCTPS; set => numCTPS = value; }
        public decimal Remuneracao { get => remuneracao; set => remuneracao = value; }
    }
}
