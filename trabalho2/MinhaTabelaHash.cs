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

        //Lista de atuais reclusos, usada apenas para confirmação de dados inseridos pelo utilizador e na opção 6
        private List<Pessoa> lista_reclusos = new List<Pessoa>();

        //Lista de ex reclusos
        private List<Pessoa> lista_exreclusos = new List<Pessoa>();

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
        //static public List<Pessoa> Getlista()
        //{
        //    return lista_reclusos;
        //}


        public void InserirNovaPessoa(Pessoa p)
        {
            lista_reclusos.Add(p);

            int t = 0;

            int cama = 0;
            int volta = 0;
            
            int i = calc_index(p);
            //Console.WriteLine("Index:" + i);


            while (t == 0)
            {
                if (cama <= 2)
                {
                    if (tab[i, cama] == null)
                    {
                        tab[i, cama] = p;
                        //Console.WriteLine("Index:" + i);
                        //Console.WriteLine("Cama:" + cama);
                        t = 1;
                        break;
                        
                        
                    }
                    if (i == 7 && cama == 2 && tab[7, 2] != null)
                    {
                        i = 0;
                        cama = 0;
                        volta++;
                    }
                    if (volta == 2)
                    {
                        // acontece se todas as celas estivrem cheias(o recluso mais antigo é tranferido)

                        

                        Pessoa rec_mais_antigo = o_mais_antigo(p);

                        int index_do_rec_mais_antigo = calc_index(rec_mais_antigo);

                        for (int z = 0; z < 3; z++)
                        {
                            if (tab[index_do_rec_mais_antigo, z] != null && tab[index_do_rec_mais_antigo, z].Num_cidadao == rec_mais_antigo.Num_cidadao)
                            {
                                tab[index_do_rec_mais_antigo, z].Motivosaida = "Tranferencia";
                                lista_exreclusos.Add(tab[index_do_rec_mais_antigo, z]);
                                tab[index_do_rec_mais_antigo, z] = p;
                            }

                        }

                        Console.WriteLine($"O recluso com o numero de cidadao {rec_mais_antigo.Num_cidadao} será transferido e o recluso com o numero de cidadao {p.Num_cidadao} ocupará o seu lugar");
                        t = 1;
                    }
                    else
                    {
                        cama++;
                    }
                }
                else
                { 
                    i++;
                    cama = 0;
                }
            }
            Console.WriteLine("\nRecluso registado com sucesso!");


        }

        public void Procurar(string nc)
        {
            
            int temp_index = calc_index(nc);
            //Console.WriteLine(temp_index);
            int k = 0;

            foreach (Pessoa p in lista_reclusos)
            {
                if (p.Num_cidadao == nc)
                {
                    while ( k == 0)
                    {

                        for (int z = 0; z < 3; z++)
                        {

                            if (tab[temp_index, z] != null && tab[temp_index, z].Num_cidadao == nc)
                            {

                                Console.WriteLine($"O recluso com o numero de cidadao {nc} encontra-se na cela: {temp_index} na cama: {z}");
                                //return procurado;
                                k++;
                                //break;
                            }
                            else
                            {
                                temp_index++;
                            }
                        }
                    }


                    break;
                }
                else
                {
                    Console.WriteLine("O numero de cidadao introduzido não corresponde a nenhum recluso.");
                    break;
                }
            }
            
        }

        public void Remover(string nc, string mts, DateTime now)
        {

            int temp_index = calc_index(nc);
            int k = 0;

            foreach (Pessoa p in lista_reclusos)
            {
                if (p.Num_cidadao == nc)
                {
                    while (k == 0)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            if (tab[temp_index, z] != null && tab[temp_index, z].Num_cidadao == nc)
                            {
                                tab[temp_index, z].Motivosaida = mts;
                                tab[temp_index, z].Datasaida = now;
                                lista_reclusos.Remove(tab[temp_index, z]);
                                lista_exreclusos.Add(tab[temp_index, z]);
                                tab[temp_index, z] = null;

                                Console.WriteLine($"O recluso com o numero de cidadao {nc} foi removido.");
                                //return procurado;
                                k++;
                                //break;
                                if (z == 0 && tab[temp_index, 1] != null && tab[temp_index, 2] != null)
                                {
                                    tab[temp_index, 0] = tab[temp_index, 1];
                                    tab[temp_index, 1] = tab[temp_index, 2];
                                    tab[temp_index, 2] = null;
                                }
                                else if (z == 0 && tab[temp_index, 1] != null)
                                {
                                    tab[temp_index, 0] = tab[temp_index, 1];
                                    tab[temp_index, 1] = tab[temp_index, 2];
                                    tab[temp_index, 2] = null;
                                }
                                

                            }
                            else
                            {
                                temp_index++;
                            }

                        }
                    }

                    break;

                }
                //else
                //{
                //    Console.WriteLine("O numero de cidadao introduzido não corresponde a nenhum recluso");
                    
                //}
            }
            




            //foreach (string num_cid in lista_reclusos)
            //{
            //    if (num_cid == p.Num_cidadao)
            //    {

            //    }

            //}
        }


        public void alteracao_pena(string nc, int np)
        {

            int k = 0;

            int temp_index = calc_index(nc);

            foreach (Pessoa p in lista_reclusos)
            {
                if (p.Num_cidadao == nc)
                {
                    p.Diasacumprir = np;
                    while (k == 0)
                    {

                        for (int z = 0; z < 3; z++)
                        {
                            if (tab[temp_index, z] != null && tab[temp_index, z].Num_cidadao == nc)
                            {

                                tab[temp_index, z].Diasacumprir = np;

                                Console.WriteLine($"O recluso com o numero de cidadao {nc} teve a sua pena alterada para {np} dias");
                                //return procurado;
                                k++;
                                //break;
                            }
                            else
                            {
                                temp_index++;
                            }
                        }
                    }

                    break;
                }
                //else
                //{
                //    Console.WriteLine("O numero de cidadao introduzido não corresponde a nenhum recluso");
                    
                //}
            }

        }



        public void lista_completa_rec()
        {

            foreach (Pessoa p in lista_reclusos)
            {
                
                Console.WriteLine(p.ToString());
            }

        }

        public void lista_completa_exrec()
        {

            foreach (Pessoa p in lista_exreclusos)
            {

                Console.WriteLine(p.ToString());
            }

        }

        // ver lotação da prisao num data especifica
        public void mapa_sp_data(int mes, int ano)
        {

            

            for (int i = 0; i < tam; i++)
            {
                //Console.WriteLine("--------------------------");
                //Console.WriteLine("Cela: " + i);
                //Console.WriteLine(" ");
                //Console.WriteLine("Camas:");



                for (int s = 0; s < 3; s++)
                {
                    if (tab[i, s] != null && tab[i,s].Datasaida.Month == mes && tab[i, s].Datasaida.Year == ano)
                    {
                        Console.WriteLine("Cela: " + i);
                        Console.WriteLine(string.Format("[{0}] -> {1} ", s,
                        tab[i, s] != null ? tab[i, s].Nome : "V A Z I O"));
                    }

                }
            }


            Console.WriteLine("--------------------------");
            

        }






        public int calc_index(string s)
        {
            int soma = 0;
            foreach (char ch in s)
                soma += Convert.ToInt32(ch);
            return soma % tam;

        }


        public int calc_index(Pessoa p)
        {
            return (p.GetHashCode() % tam);
            
        }

        // função para descobrir o mrecluso mais antigo
        public Pessoa o_mais_antigo(Pessoa p)
        {
            Pessoa mais_antigo = lista_reclusos[0] as Pessoa;
            //DateTime temp;
            //DateTime now = DateTime.Now;
            foreach (Pessoa x in lista_reclusos)
            {
                //DateTime calc = now - x.Dataentrada;
                if (x.Dataentrada < mais_antigo.Dataentrada)
                {
                    mais_antigo = x;
                }
            
            }

            return mais_antigo;
        }


        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Cela: " + i);
                Console.WriteLine(" ");
                Console.WriteLine("Camas:");



                for (int s = 0; s < 3; s++)
                {
                    
                    Console.WriteLine(string.Format("[{0}] -> {1} ", s,
                    tab[i,s] != null ? tab[i,s].Nome : "V A Z I O"));

                }
            }


            Console.WriteLine("--------------------------");
            return res.ToString();
        }






    }
}
