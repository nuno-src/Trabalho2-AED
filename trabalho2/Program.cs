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

            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "345564", Nome = "Zeferino", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1970"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2050") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "13455656744", Nome = "Saraiva", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2080") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "76893456755642", Nome = "Albano", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2050") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "2368934556677742", Nome = "joao", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1950"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1950"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2050") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "76893455642", Nome = "rui", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2060") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "563893455647682", Nome = "quim", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2050") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "689344555642", Nome = "Mariano", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/2000"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2050") });
            t.InserirNovaPessoa(new Pessoa { Num_cidadao = "7689344657555642", Nome = "ronaldo", Genero = "Masculino", Datanasc = DateTime.Parse("03/07/1970"), Contacto = 123456789, Dataentrada = DateTime.Parse("14/09/1980"), Diasacumprir = 23000, Motivosaida = "", Datasaida = DateTime.Parse("23/03/2050") });


            int op = 9;
            while (op != 0)
            {
                Console.WriteLine("\n-------------------MENU-----------------");
                Console.WriteLine(" 1) - Remover recluso");
                Console.WriteLine(" 2) - Adicionar recluso");
                Console.WriteLine(" 3) - Alteração da pena de um recluso");
                Console.WriteLine(" 4) - Procura de de cela de um recluso");
                Console.WriteLine(" 5) - Mapa da prisao numa determinada data");
                Console.WriteLine(" 6) - Ver Info completa de todos os reclusos");
                Console.WriteLine(" 7) - Ver histórico de ex reclusos");
                Console.WriteLine(" 8) - Ver lotação atual da prisão");
                Console.WriteLine(" 0) - Sair");
                Console.WriteLine("------------------------------------------");


                Console.Write("Escolha uma opção:");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1: Remover_recluso(); break;
                    case 2: Adicionar_recluso(); break;
                    case 3: Alteracao_pena(); break;
                    case 4: Procurar_recluso(); break;
                    case 5: mapa_data(); break;
                    case 6: lista_reclusos(); break;
                    case 7: lista_ex_reclusos(); break;
                    case 8: ver_lotacao(); break;
                    case 0: Environment.Exit(0); break;
                    



                    default:
                        Console.WriteLine("OPÇÃO ERRADA");
                        break;


                }

            }



        }

        static void Adicionar_recluso()
        {
            

            Console.Write("Insira o numero de cidadao:");
            string num_cid = Console.ReadLine();

            Console.Write("Insira o Nome:");
            string nome = Console.ReadLine();

           
            string genero = "";
            int count = 0;

           

            do
            {
                Console.Write("Insira o Genero: 1) Masculino / 2) Feminino: ");
                int opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {

                    genero = "Masculino";
                    count++;
                }
                else if (opc == 2)
                {
                    genero = "Feminino";
                    count++;

                }
                else
                {
                    Console.WriteLine("Opção errada");
                }


            } while (count == 0);


            Console.Write("Insira a Data de nascimento:");
            string datanasc = Console.ReadLine();

            Console.Write("Insira o contacto:");
            int contacto = int.Parse(Console.ReadLine());

            Console.Write("Insira a Data de entrada na prisao:");
            string dataentrada = Console.ReadLine();


            Console.Write("Insira o numero de dias de pena a cumprir:");
            int diasacumprir = int.Parse(Console.ReadLine());

            Console.Write("Insira o motivo de saida:");
            string motivosaida = Console.ReadLine();

            Console.Write("Insira a Data de saida da prisao:");
            string datasaida = Console.ReadLine();


            t.InserirNovaPessoa(new Pessoa { Num_cidadao = num_cid, Nome = nome, Genero = genero, Datanasc = DateTime.Parse(datanasc), Contacto = contacto, Dataentrada = DateTime.Parse(dataentrada), Diasacumprir = diasacumprir, Motivosaida = motivosaida, Datasaida = DateTime.Parse(datasaida) });


            

        }


        static void Procurar_recluso()
        {
            Console.Write("Insira o numero de cidadao:");
            string num_cid = Console.ReadLine();


            
            t.Procurar(num_cid);

        }


        static void Remover_recluso()
        {
            Console.Write("Insira o numero de cidadao do recluso:");
            string num_cid = Console.ReadLine();

            
            

            DateTime now = DateTime.Now;

            string motivosaida = "";
            int count = 0;



            do
            {
                Console.Write("Insira o Motivo de saida: 1) Obito / 2) Conclusão de pena: ");
                int opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {

                    motivosaida = "Obito";
                    count++;
                }
                else if (opc == 2)
                {
                    motivosaida = "Pena concluida";
                    count++;

                }
                else
                {
                    Console.WriteLine("Opção errada");
                }


            } while (count == 0);

            t.Remover(num_cid, motivosaida, now);

        }

        static void Alteracao_pena()
        {
            Console.Write("Insira o numero de cidadao do recluso:");
            string num_cid = Console.ReadLine();

            Console.Write("Insira o numero de dias de pena a cumprir:");
            int ndiasacumprir = int.Parse(Console.ReadLine());

            t.alteracao_pena(num_cid, ndiasacumprir);


        }


        static void mapa_data()
        {

            Console.Write("Insira um mes:");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Insira um ano:");
            int ano = int.Parse(Console.ReadLine());


            Console.WriteLine($"Os seguintes reclusos acama a pena em {mes}/{ano}:");
            t.mapa_sp_data(mes, ano);




        }





        static void lista_reclusos()
        {
            Console.WriteLine("Reclusos: \n");
            t.lista_completa_rec();

        }

        static void lista_ex_reclusos()
        {
            Console.WriteLine("Antigos reclusos: \n");
            t.lista_completa_exrec();

        }

        static void ver_lotacao()
        {

            Console.WriteLine(t);
        
        }
    }
}
