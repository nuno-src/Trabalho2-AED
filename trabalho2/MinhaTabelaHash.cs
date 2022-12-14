using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2
{
    internal class MinhaTabelaHash
    {
        static public Pessoa[,] tab;
        const int tam = 8;

        public MinhaTabelaHash() : this(8) { }
        public MinhaTabelaHash(int tam)
        {
            tab = new Pessoa[tam,3];
            //this.tam = tam;
        }

        static public Array Gettabela()
        {
            return tab;
        }


        public void InserirNovaPessoa(Pessoa p)
        {
            int cama = 0;
            
            int i = calc_index(p);
            Console.WriteLine("Index:" + i);
            while (true)
            {
                if (cama <= 2)
                {
                    if (tab[i, cama] == null)
                    {
                        tab[i, cama] = p;
                        Console.WriteLine("Index:" + i);
                        Console.WriteLine("Cama:" + cama);
                        break;
                        
                        
                    }
                    if (tab[7, 2] != null)
                    {
                        i = 0;
                        cama = 0;

                    }
                    else
                    {
                        cama++;
                    }
                }
                else { 
                    i++;
                    cama = 0;
                }
            }
            Console.WriteLine("\nRecluso registado com sucesso!");


        }

        public Pessoa Procurar(string nome)
        {
            Console.WriteLine(nome.GetHashCode());
            //Console.WriteLine("tab index 2:" + tab[2]);
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
