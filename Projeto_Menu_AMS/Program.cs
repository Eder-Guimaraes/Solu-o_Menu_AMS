using System;
using System.Threading;

namespace Projeto_Menu_AMS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            string nome;
            Console.WriteLine("Boa Tarde!!");

            Console.Write("Qual é o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Seja bem-vindo(a) {nome} para nossa aula");
            Thread.Sleep(2000);

            do
            {
                Console.Clear();

                janela(0, 39, 2, 62, 'd');
                Console.SetCursorPosition(40, 1);
                //1 - Apresentar as opções

                Console.WriteLine("*** Menu Principal ***");

                janela(3, 29, 13, 70, 's');
                Console.SetCursorPosition(30, 4); Console.WriteLine("[1] Menu dos Vetores");
                Console.SetCursorPosition(30, 5); Console.WriteLine("[2] Tabuada");
                Console.SetCursorPosition(30, 6); Console.WriteLine("[3] Compara Números");
                Console.SetCursorPosition(30, 7); Console.WriteLine("[4] Equação do Segundo Grau");
                Console.SetCursorPosition(30, 8); Console.WriteLine("[5] Média");
                Console.SetCursorPosition(30, 9); Console.WriteLine("[6] Jogo Adivinha");
                Console.SetCursorPosition(30, 10); Console.WriteLine("[7] Encerrar");

                Console.SetCursorPosition(30, 11);
                for (int i = 0; i < 40; i++)
                {
                    Console.Write("=");
                }

                Console.SetCursorPosition(30, 12); Console.Write("Digite sua Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                janela(15, 29, 19, 70, 's');
                Console.SetCursorPosition(32, 17);
                //3 - Decidir o que

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Abrindo Menu dos Vetores...");
                        Thread.Sleep(1500);
                        Menu_Vetores();
                        break;

                    case 2:
                        Console.WriteLine("Abrindo Tabuada...");
                        Thread.Sleep(1500);
                        Tabuada();
                        break;

                    case 3:
                        Console.WriteLine("Abrindo Comparação de Numeros...");
                        Thread.Sleep(1500);
                        Compara_Numeros();
                        break;

                    case 4:
                        Console.WriteLine("Abrindo Bhaskara...");
                        Thread.Sleep(1500);
                        Bhaskara();
                        break;

                    case 5:
                        Console.WriteLine("Abrindo Media...");
                        Thread.Sleep(1500);
                        Media();
                        break;

                    case 6:
                        Console.WriteLine("Abrindo Jogo de Adivinhação...");
                        Thread.Sleep(1500);
                        Jogo_Adivinha();
                        break;

                    case 7:
                        Console.WriteLine("Até a próxima!");
                        Thread.Sleep(1500);
                        Console.SetCursorPosition(32, 19);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente!");
                        Thread.Sleep(1500);
                        Opcao_Invalida();
                        break;
                }

            } while (true);
        }

        static void Menu_Vetores()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < 80; i++)
            {
                Console.Write("=");
                Thread.Sleep(1);
            }
            Console.SetCursorPosition(30, 1);

            Console.WriteLine("*** Menu dos Vetores ***");
            Console.SetCursorPosition(0, 2);

            for (int i = 0; i < 80; i++)
            {
                Console.Write("=");
                Thread.Sleep(1);
            }

            Console.SetCursorPosition(30, 4); Console.WriteLine("[1] Sorteio de Nomes");
            Console.SetCursorPosition(30, 5); Console.WriteLine("[2] Sorteio de Duplas");
            Console.SetCursorPosition(30, 6); Console.WriteLine("[3] Valores por Extenso");
            Console.SetCursorPosition(30, 7); Console.WriteLine("[4] Voltar ao Principal");

            Console.WriteLine();

            //2 - Ler a escolha do usuario

            Console.SetCursorPosition(0, 9);
            Console.WriteLine(new string('=', 80));
            Console.SetCursorPosition(30, 10); Console.Write("Digite sua Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            //3 - Decidir o que

            switch (opcao)
            {
                case 1:
                    Menu_Vetores();
                    break;

                case 2:
                    Tabuada();
                    break;

                case 3:
                    Compara_Numeros();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Opcao_Invalida();
                    break;
            }
        }

        static void Tabuada()
        {
            do
            {
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("OPERAÇÃO TABUADA");
                Console.SetCursorPosition(0, 2);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }

                Console.SetCursorPosition(25, 3);
                Console.Write("Digite qual tabuada você quer: ");

                if (!double.TryParse(Console.ReadLine(), out double tab))
                {
                    Console.SetCursorPosition(25, 4);
                    Console.Write("Por favor, digite um número válido!");
                    Thread.Sleep(1500);
                    continue;
                }

                for (int i = 0; i <= 10; i++)
                {
                    Console.SetCursorPosition(35, 5 + i);
                    Console.WriteLine($"{tab} x {i} = {tab * i}");
                }

                Console.SetCursorPosition(20, 17);

            } while (Continuar());
        }

        static void Compara_Numeros()
        {
            do
            {
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("OPERAÇÃO COMPARA");
                Console.SetCursorPosition(0, 2);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }

                Console.SetCursorPosition(20, 3);
                double[] valores = new double[2];

                Console.Write("Digite dois valores separados por vírgula: ");

                string entrada = Console.ReadLine();

                string[] partes = entrada.Split(',');

                if (partes.Length != 2 ||
                    double.TryParse(partes[0].Trim(), out valores[0]) ||
                    double.TryParse(partes[1].Trim(), out valores[1])
                    )

                    valores[0] = double.Parse(partes[0].Trim());
                valores[1] = double.Parse(partes[1].Trim());

                double valor1 = valores[0];
                double valor2 = valores[1];


                if (valor1 > valor2)
                {
                    Console.WriteLine($"O {valor1} é maior do que {valor2}");
                }
                else if (valor1 < valor2)
                {
                    Console.WriteLine($"O {valor2} é maior do que {valor1}");
                }
                else
                {
                    Console.WriteLine($"O {valor1} é igual ao {valor2}");
                }

                Console.SetCursorPosition(20, 7);

            } while (Continuar());

        }

        static void Bhaskara()
        {
            do
            {
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("OPERAÇÃO DO SEGUNDO GRAU");
                Console.SetCursorPosition(0, 2);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }

                double[] valores = new double[3];

                Console.SetCursorPosition(5, 3);
                Console.Write("Digite, respectivamente, os valores de A, B e C separados por vírgula: ");


                Console.SetCursorPosition(5, 5);
                string entrada = Console.ReadLine();

                string[] partes = entrada.Split(',');

                if (partes.Length != 3 ||
                    !double.TryParse(partes[0].Trim(), out valores[0]) ||
                    !double.TryParse(partes[1].Trim(), out valores[1]) ||
                    !double.TryParse(partes[2].Trim(), out valores[2])
                    )
                {
                    Console.WriteLine("Valores inválidos!");
                    Thread.Sleep(2000);
                    continue;
                }

                double A = valores[0];
                double B = valores[1];
                double C = valores[2];

                if (A == 0)
                {
                    Console.WriteLine("O valor de A não pode ser zero!");
                    Thread.Sleep(2000);
                    continue;
                }

                Console.SetCursorPosition(5, 5);

                double delta = (Math.Pow(B, 2)) - (4 * A * C);

                Console.WriteLine($"Seu delta é igual a: {delta}");

                Console.SetCursorPosition(5, 7);
                if (delta < 0)
                {
                    Console.WriteLine("Não existem raízes reais se delta é menor do que 0");
                }

                else
                {
                    double raiz1 = (-B + Math.Sqrt(delta)) / (2 * A);
                    double raiz2 = (-B - Math.Sqrt(delta)) / (2 * A);

                    if (delta == 0)
                    {
                        Console.WriteLine($"Existe uma raiz: {raiz1:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"Existem duas raízes: {raiz1:F2} e {raiz2:F2}");
                    }
                }


            } while (Continuar());
        }

        static void Media()
        {
            do
            {
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("OPERAÇÃO DE MÉDIA");
                Console.SetCursorPosition(0, 2);
                for (int i = 0; i < 80; i++)
                {
                    Console.Write("=");
                    Thread.Sleep(1);
                }


            } while(Continuar());
        }

        static void Jogo_Adivinha()
        {

        }
        
        static void Opcao_Invalida()
        {
        }

        static void janela(int L1, int C1, int L2, int C2, char borda)
        {
            char cse, csd, cid, cie, lh, lv;

            if (borda == 's')
            {
                cse = '┌'; csd = '┐'; cid = '┘'; cie = '└';
                lh = '─'; lv = '│';
            }
            else if (borda == 'd')
            {
                cse = '╔'; csd = '╗'; cid = '╝'; cie = '╚';
                lh = '═'; lv = '║';
            }
            else
            {
                cse = '+'; csd = '+'; cid = '+'; cie = '+';
                lh = '-'; lv = '|';
            }

            //Desenhando a janela

            Console.SetCursorPosition(C1, L1);Console.Write(new string(lh, C2-C1));
            Console.SetCursorPosition(C1, L2); Console.Write(new string(lh, C2 - C1));

            for (int i = L1; i <= L2; i++) 
            {
                Console.SetCursorPosition(C1, i); Console.Write(lv);
                Console.SetCursorPosition(C2, i); Console.Write(lv);
            }

            Console.SetCursorPosition(C1, L1); Console.Write(cse);
            Console.SetCursorPosition(C2, L1); Console.Write(csd);
            Console.SetCursorPosition(C1, L2); Console.Write(cie);
            Console.SetCursorPosition(C2, L2); Console.Write(cid);
        }

        static bool Continuar()
        {
            Console.Write("Você deseja continuar nessa operação? (S/N): ");

            char user = char.ToLower(Console.ReadKey().KeyChar);

            if (user == 'n')
            {
                Console.Clear();
                Console.WriteLine("Voltando...");
                Thread.Sleep(2000);
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Voltando para operação...");
                Thread.Sleep(2000);
                return true;
            }
        }
    }
}