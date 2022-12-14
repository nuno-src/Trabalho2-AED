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
        private string numcidadao;
        private string nome;
        private string genero;
        private DateTime datanasc;
        private int contacto;
        private DateTime dataentrada;
        private int diasacumprir;
        private string motivosaida;
        private DateTime datasaida;

        //public Pessoa(string nNome, int Nidade, int Nnumcidadao)
        //{
        //    nome = nNome;
        //    idade= Nidade;
        //    numcidadao = Nnumcidadao;
        //}

        public string Num_cidadao { get => numcidadao; set => numcidadao = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Datanasc { get => datanasc; set => datanasc = value; }
        public int Contacto { get => contacto; set => contacto = value; }
        public DateTime Dataentrada { get => dataentrada; set => dataentrada = value; }
        public int Diasacumprir { get => diasacumprir; set => diasacumprir = value; }
        public string Motivosaida { get => motivosaida; set => motivosaida = value; }
        public DateTime Datasaida { get => datasaida; set => datasaida = value; }




        public override int GetHashCode()
        {
            int soma = 0;
            foreach (char ch in Num_cidadao)
                soma += Convert.ToInt32(ch);
            return soma;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", Num_cidadao, Nome, Genero, Datanasc, Contacto, Dataentrada, Diasacumprir, Motivosaida, Datasaida);
        }
    }
}
