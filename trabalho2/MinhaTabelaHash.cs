using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2
{
    internal class MinhaTabelaHash
    {
        static public Pessoa[] tab;
        const int tam = 8;

        public MinhaTabelaHash() : this(8) { }
        public MinhaTabelaHash(int tam)
        {
            tab = new Pessoa[tam];
            //this.tam = tam;
        }

        static public Array Gettabela()
        {
            return tab;
        }


        public int InserirNovaPessoa(Pessoa p)
        {
            int indice = 0;
            // p.Nome
            int i = calc_index(p);
            Console.WriteLine("Index:" + i);
            tab[i] = p;
            return 0;
        }

        public Pessoa Procurar(string nome)
        {
            Console.WriteLine(nome.GetHashCode());
            Console.WriteLine("tab index 2:" + tab[2]);
            return null;
        }

        public void Remover(string nome)
        {

        }

        public int calc_index(Pessoa p)
        {
            return (p.GetHashCode() % tam);
            
        }











    }
}
