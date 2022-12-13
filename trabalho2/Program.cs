using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinhaTabelaHash t = new MinhaTabelaHash(8);
            t.InserirNovaPessoa(new Pessoa { Nome = "Zeferino", Idade = 20, Num_cidadao = 345564 });

            //Console.WriteLine(t);
            //foreach (var item in MinhaTabelaHash.Gettabela())
            //{
            //    Console.WriteLine(item);

            //}

            Console.WriteLine(t.Procurar("Zeferino"));
            




        }
    }
}
