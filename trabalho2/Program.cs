using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2
{
    internal class Program
    {
        static MinhaTabelaHash t = new MinhaTabelaHash(8);
        static void Main(string[] args)
        {
            //MinhaTabelaHash t = new MinhaTabelaHash(8);
            //t.InserirNovaPessoa(new Pessoa { Num_cidadao = 345564, Nome = "Zeferino", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida= "pena cumprida", Datasaida = DateTime.Parse("23/03/2050") });

            //Console.WriteLine(t);
            //foreach (var item in MinhaTabelaHash.Gettabela())
            //{
            //    Console.WriteLine(item);

            //}

            //Console.WriteLine(t.Procurar("Zeferino"));

            int op = 9;
            while (op != 0)
            {
                Console.WriteLine("\n-------------------MENU-----------------");
                Console.WriteLine(" 1) - Adicionar recluso");
                Console.WriteLine(" 2) - Procurar recluso");
                Console.WriteLine(" 3) - Remover recluso");
                Console.WriteLine(" 4) - Ver lotação da prisão");


                Console.WriteLine(" 0) - Sair");
                Console.WriteLine("------------------------------------------");


                Console.Write("Escolha uma opção:");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1: Adicionar_recluso(); break;
                    case 0: Environment.Exit(0); break;
                    case 4: ver_lotacao(); break;



                    default:
                        Console.WriteLine("OPÇÃO ERRADA");
                        break;


                }

            }



        }

        static void Adicionar_recluso()
        {

            //Console.Write("Insira o numero de cidadao:");
            //string num_cid = Console.ReadLine();

            //Console.Write("Insira o Nome:");
            //string nome = Console.ReadLine();

            //Console.Write("Insira o Genero:");
            //string genero = Console.ReadLine();

            //Console.Write("Insira a Data de nascimento:");
            //string datanasc = Console.ReadLine();

            //Console.Write("Insira o contacto:");
            //int contacto = int.Parse(Console.ReadLine());

            //Console.Write("Insira a Data de entrada na prisao:");
            //string dataentrada = Console.ReadLine();


            //Console.Write("Insira o numero de dias de pena a cumprir:");
            //int diasacumprir = int.Parse(Console.ReadLine());

            //Console.Write("Insira o motivo de saida:");
            //string motivosaida = Console.ReadLine();

            //Console.Write("Insira a Data de saida da prisao:");
            //string datasaida = Console.ReadLine();


            //t.InserirNovaPessoa(new Pessoa { Num_cidadao = num_cid, Nome = nome, Genero = genero, Datanasc = DateTime.Parse(datanasc), Contacto = contacto, Dataentrada = DateTime.Parse(dataentrada), Diasacumprir = diasacumprir, Motivosaida = motivosaida, Datasaida = DateTime.Parse(datasaida) });

            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "345564", Nome = "Zeferino", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "pena cumprida", Datasaida = DateTime.Parse("23/03/2050") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "3455656744", Nome = "Zeferino", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "pena cumprida", Datasaida = DateTime.Parse("23/03/2050") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "76893455642", Nome = "Zeferino", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "pena cumprida", Datasaida = DateTime.Parse("23/03/2050") });


            Console.WriteLine("\nRecluso registado com sucesso!");

        }

        static void ver_lotacao()
        {

            Console.WriteLine(t);
        
        }
    }
}
