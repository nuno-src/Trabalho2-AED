using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2
{
    // class para o recluso
    internal class Pessoa
    {
        
        private string nome;
        private int idade;
        private int numcidadao;

        //public Pessoa(string nNome, int Nidade, int Nnumcidadao)
        //{
        //    nome = nNome;
        //    idade= Nidade;
        //    numcidadao = Nnumcidadao;
        //}

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Num_cidadao { get => numcidadao; set => numcidadao = value; }

        
        public override int GetHashCode()
        {
            int soma = 0;
            foreach (char ch in Nome)
                soma += Convert.ToInt32(ch);
            return soma;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Nome, Idade, Num_cidadao);
        }
    }
}
