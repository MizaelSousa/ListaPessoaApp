using System;
namespace ListaPessoaApp.Model
{
    public class Pessoa
    {
        public string nome { set; get; }
        public string sobrenome { set; get; }
        public string dtCadastro { set; get; }

        public string nomeCompleto
        {
            get { return nome + " " + sobrenome; }
        }

        public Pessoa()
        {
        }
    }
}
