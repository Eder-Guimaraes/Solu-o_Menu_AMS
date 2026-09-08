using System;
using System.Collections.Generic;
using System.Threading;

namespace Projeto_Menu_AMS
{
    internal class Program
    {
        static readonly Dictionary<char, string[]> Fonte = new Dictionary<char, string[]>()
        {
            ['M'] = new[] { "█   █", "██ ██", "█ █ █", "█   █", "█   █" },
            ['E'] = new[] { "█████", "█    ", "████ ", "█    ", "█████" },
            ['N'] = new[] { "█   █", "██  █", "█ █ █", "█  ██", "█   █" },
            ['U'] = new[] { "█   █", "█   █", "█   █", "█   █", " ███ " },
            ['V'] = new[] { "█   █", "█   █", "█   █", " █ █ ", "  █  " },
            ['T'] = new[] { "█████", "  █  ", "  █  ", "  █  ", "  █  " },
            ['O'] = new[] { " ███ ", "█   █", "█   █", "█   █", " ███ " },
            ['R'] = new[] { "████ ", "█   █", "████ ", "█  █ ", "█   █" },
            ['S'] = new[] { " ████", "█    ", " ███ ", "    █", "████ " },
        };

        static void EscreverBanner(string texto, int linha, int coluna)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(coluna, linha + i);

                foreach (char letra in texto)
                {
                    if (letra == ' ')
                    {
                        Console.Write("   ");
                    }
                    else if (Fonte.ContainsKey(letra))
                    {
                        Console.Write(Fonte[letra][i] + " ");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string nome;

            Console.WriteLine("Boa Tarde!!");
            Console.Write("Qual é o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Seja bem-vindo(a) {nome} para nossa aula");
            Console.WriteLine(Console.WindowWidth);

            Thread.Sleep(2000);

            do
            {
                Console.Clear();

                janela(0, 35, 6, 66, 'd', true);
                EscreverBanner("MENU", 1, 40);

                janela(9, 29, 19, 70, 's', true);

                Console.SetCursorPosition(30, 10);
                Console.WriteLine("[1] Menu dos Vetores");

                Console.SetCursorPosition(30, 11);
                Console.WriteLine("[2] Tabuada");

                Console.SetCursorPosition(30, 12);
                Console.WriteLine("[3] Compara Números");

                Console.SetCursorPosition(30, 13);
                Console.WriteLine("[4] Equação do Segundo Grau");

                Console.SetCursorPosition(30, 14);
                Console.WriteLine("[5] Média");

                Console.SetCursorPosition(30, 15);
                Console.WriteLine("[6] Jogo Adivinha");

                Console.SetCursorPosition(30, 16);
                Console.WriteLine("[7] Encerrar");

                Console.SetCursorPosition(30, 17);
                Console.Write(new string('=', 40));

                Console.SetCursorPosition(30, 18);
                Console.Write("Digite sua Opção: ");

                int opcao = int.Parse(Console.ReadLine());

                janela(22, 29, 26, 70, 's', true);
                Console.SetCursorPosition(32, 24);

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
            do
            {
                Console.Clear();

                janela(0, 20, 6, 97, 'd', true);
                EscreverBanner("MENU VETORES", 1, 25);

                janela(10, 35, 19, 70, 's', true);

                Console.SetCursorPosition(36, 11);
                Console.WriteLine("[1] Sorteio de Nomes");

                Console.SetCursorPosition(36, 12);
                Console.WriteLine("[2] Sorteio de Duplas");

                Console.SetCursorPosition(36, 13);
                Console.WriteLine("[3] Valores por Extenso");

                Console.SetCursorPosition(36, 14);
                Console.WriteLine("[4] Voltar ao Principal");

                Console.SetCursorPosition(36, 16);
                Console.WriteLine(new string('=', 34));

                Console.SetCursorPosition(36, 18);
                Console.Write("Digite sua Opção: ");

                int opcao = int.Parse(Console.ReadLine());

                janela(21, 35, 25, 70, 'd', true);
                Console.SetCursorPosition(36, 23);

                switch (opcao)
                {
                    case 1:
                        Console.Write("Abrindo Sorteio de Nomes");
                        Thread.Sleep(1500);
                        Sorteio_Nomes();
                        break;

                    case 2:
                        Console.Write("Abrindo Sorteio de Duplas");
                        Thread.Sleep(1500);
                        Sorteio_Duplas();
                        break;

                    case 3:
                        Console.Write("Abrindo Valores por Extenso");
                        Thread.Sleep(1500);
                        Valores_Extenso();
                        break;

                    case 4:
                        Console.Write("Abrindo Menu Principal");
                        Thread.Sleep(1500);
                        return;

                    default:
                        Opcao_Invalida();
                        break;
                }

            } while (true);
        }

        static void Tabuada()
        {
            do
            {
                Console.Clear();

                janela(0, 39, 2, 65, 'd', false);
                Console.SetCursorPosition(44, 1);
                Console.WriteLine("OPERAÇÃO TABUADA");

                janela(3, 22, 20, 80, 's', true);

                Console.SetCursorPosition(35, 4);
                Console.Write("Digite qual tabuada você quer: ");

                if (!double.TryParse(Console.ReadLine(), out double tab))
                {
                    Console.SetCursorPosition(35, 6);
                    Console.Write("Por favor, digite um número válido!");
                    Thread.Sleep(1500);
                    continue;
                }

                for (int i = 0; i <= 10; i++)
                {
                    Console.SetCursorPosition(45, 6 + i);
                    Console.WriteLine($"{tab} x {i} = {tab * i}");
                    Console.WriteLine();
                }

            } while (Continuar());
        }

        static void Compara_Numeros()
        {
            do
            {
                Console.Clear();

                janela(0, 39, 2, 65, 'd', false);
                Console.SetCursorPosition(44, 1);
                Console.WriteLine("OPERAÇÃO COMPARA");

                janela(4, 22, 20, 80, 's', true);

                double[] valores = new double[2];

                Console.SetCursorPosition(28, 6);
                Console.Write("Digite dois valores separados por espaço: ");

                janela(8, 45, 10, 55, 'd', false);
                Console.SetCursorPosition(47, 9);

                string entrada = Console.ReadLine();
                string[] partes = entrada.Split(' ');

                if (partes.Length != 2 ||
                    !double.TryParse(partes[0].Trim(), out valores[0]) ||
                    !double.TryParse(partes[1].Trim(), out valores[1]))
                {
                    janela(13, 30, 15, 72, 'd', false);
                    Console.SetCursorPosition(43, 14);
                    Console.Write("Entrada inválida!");
                    Thread.Sleep(2000);
                    continue;
                }

                double valor1 = valores[0];
                double valor2 = valores[1];

                janela(13, 30, 15, 72, 'd', false);
                Console.SetCursorPosition(40, 14);

                if (valor1 == valor2)
                {
                    Console.Write($"O {valor1} é igual ao {valor2}");
                }
                else
                {
                    double maior = valor1 > valor2 ? valor1 : valor2;
                    double menor = valor1 < valor2 ? valor1 : valor2;

                    Console.Write($"O {maior} é maior do que {menor}");
                }

            } while (Continuar());
        }

        static void Bhaskara()
        {
            do
            {
                Console.Clear();

                janela(0, 38, 2, 66, 'd', false);
                Console.SetCursorPosition(44, 1);
                Console.Write("OPERAÇÃO BHASKARA");

                janela(3, 15, 12, 95, 's', true);

                Console.SetCursorPosition(18, 5);
                Console.Write("Digite os valores de A, B e C separados por espaço:");

                Console.SetCursorPosition(18, 7);

                double[] valores = new double[3];
                string entrada = Console.ReadLine();
                string[] partes = entrada.Split(' ');

                if (partes.Length != 3 ||
                    !double.TryParse(partes[0], out valores[0]) ||
                    !double.TryParse(partes[1], out valores[1]) ||
                    !double.TryParse(partes[2], out valores[2]))
                {
                    janela(14, 25, 18, 85, 'd', false);
                    Console.SetCursorPosition(35, 16);
                    Console.Write("Digite exatamente três números válidos.");
                    Thread.Sleep(2000);
                    continue;
                }

                double A = valores[0];
                double B = valores[1];
                double C = valores[2];

                if (A == 0)
                {
                    janela(14, 25, 18, 85, 'd', false);
                    Console.SetCursorPosition(33, 16);
                    Console.Write("O coeficiente A deve ser diferente de zero.");
                    Thread.Sleep(2000);
                    continue;
                }

                double delta = Math.Pow(B, 2) - (4 * A * C);

                janela(14, 20, 21, 90, 'd', false);
                Console.SetCursorPosition(24, 15);
                Console.Write($"Delta = {delta:F2}");

                if (delta < 0)
                {
                    Console.SetCursorPosition(24, 17);
                    Console.Write("A equação não possui raízes reais.");
                }
                else if (delta == 0)
                {
                    double raiz = (-B) / (2 * A);
                    Console.SetCursorPosition(24, 17);
                    Console.Write($"Raiz única = {raiz:F2}");
                }
                else
                {
                    double raiz1 = (-B + Math.Sqrt(delta)) / (2 * A);
                    double raiz2 = (-B - Math.Sqrt(delta)) / (2 * A);

                    Console.SetCursorPosition(24, 17);
                    Console.Write($"Raiz 1 = {raiz1:F2}");

                    Console.SetCursorPosition(24, 18);
                    Console.Write($"Raiz 2 = {raiz2:F2}");
                }

            } while (Continuar());
        }

        static void Media()
        {
            do
            {
                double[] valores = new double[2];

                Console.Clear();

                janela(0, 39, 2, 65, 'd', false);
                Console.SetCursorPosition(46, 1);
                Console.WriteLine("OPERAÇÃO MÉDIA");

                janela(3, 29, 13, 75, 's', true);

                Console.SetCursorPosition(30, 4);
                Console.WriteLine("Digite dois valores separados por vírgula");

                Console.SetCursorPosition(48, 6);
                string entrada = Console.ReadLine();
                string[] partes = entrada.Split(',');

                if (partes.Length != 2 ||
                    !double.TryParse(partes[0].Trim(), out valores[0]) ||
                    !double.TryParse(partes[1].Trim(), out valores[1]))
                {
                    Console.WriteLine("Valores inválidos!");
                    Thread.Sleep(2000);
                    continue;
                }

                double media = (valores[0] + valores[1]) / 2;

                Console.SetCursorPosition(30, 8);
                Console.Write($"A média entre os dois valores é {media:F2}");

            } while (Continuar());
        }

        static void Jogo_Adivinha()
        {
            do
            {
                Console.Clear();

                janela(0, 36, 2, 68, 'd', false);
                Console.SetCursorPosition(42, 1);
                Console.Write("JOGO DE ADIVINHAÇÃO");

                janela(3, 20, 20, 90, 's', true);

                Random sorteio = new Random();
                int numero = sorteio.Next(1, 101);
                int tentativa = 0;
                int chute = 0;

                Console.SetCursorPosition(24, 5);
                Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

                while (chute != numero)
                {
                    tentativa++;

                    Console.SetCursorPosition(24, 7);
                    Console.Write(new string(' ', 45));

                    Console.SetCursorPosition(24, 7);
                    Console.Write($"Tentativa {tentativa}: ");

                    if (!int.TryParse(Console.ReadLine(), out chute))
                    {
                        Console.SetCursorPosition(24, 9);
                        Console.Write(new string(' ', 50));
                        Console.SetCursorPosition(24, 9);
                        Console.Write("Digite um número válido!");
                        continue;
                    }

                    if (chute < 1 || chute > 100)
                    {
                        Console.SetCursorPosition(24, 9);
                        Console.Write(new string(' ', 50));
                        Console.SetCursorPosition(24, 9);
                        Console.Write("Digite um número entre 1 e 100.");
                        continue;
                    }

                    if (chute < numero)
                    {
                        Console.SetCursorPosition(24, 9);
                        Console.Write(new string(' ', 50));
                        Console.SetCursorPosition(24, 9);
                        Console.Write("O número secreto é MAIOR.");
                    }
                    else if (chute > numero)
                    {
                        Console.SetCursorPosition(24, 9);
                        Console.Write(new string(' ', 50));
                        Console.SetCursorPosition(24, 9);
                        Console.Write("O número secreto é MENOR.");
                    }
                }

                janela(12, 25, 17, 85, 'd', false);

                Console.SetCursorPosition(30, 14);
                Console.Write($"Parabéns! Você acertou o número {numero}.");

                Console.SetCursorPosition(30, 15);
                Console.Write($"Quantidade de tentativas: {tentativa}");

            } while (Continuar());
        }

        static void Opcao_Invalida()
        {
            Console.Clear();

            janela(6, 28, 12, 72, 'd', true);

            Console.SetCursorPosition(36, 8);
            Console.Write("Opção inválida!");

            Console.SetCursorPosition(31, 10);
            Console.Write("Pressione qualquer tecla para voltar...");

            Console.ReadKey();
        }

        static void janela(int L1, int C1, int L2, int C2, char borda, bool sombra)
        {
            char cse, csd, cid, cie, lh, lv;

            if (borda == 's')
            {
                cse = '┌';
                csd = '┐';
                cid = '┘';
                cie = '└';
                lh = '─';
                lv = '│';
            }
            else if (borda == 'd')
            {
                cse = '╔';
                csd = '╗';
                cid = '╝';
                cie = '╚';
                lh = '═';
                lv = '║';
            }
            else
            {
                cse = '+';
                csd = '+';
                cid = '+';
                cie = '+';
                lh = '-';
                lv = '|';
            }

            if (sombra)
            {
                Console.ForegroundColor = ConsoleColor.Black;

                for (int i = L1 + 1; i <= L2 + 1; i++)
                {
                    Console.SetCursorPosition(C2 + 1, i);
                    Console.Write("▓");
                }

                Console.SetCursorPosition(C1 + 1, L2 + 1);
                Console.Write(new string('▓', C2 - C1));

                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.SetCursorPosition(C1, L1);
            Console.Write(new string(lh, C2 - C1));

            Console.SetCursorPosition(C1, L2);
            Console.Write(new string(lh, C2 - C1));

            for (int i = L1; i <= L2; i++)
            {
                Console.SetCursorPosition(C1, i);
                Console.Write(lv);

                Console.SetCursorPosition(C2, i);
                Console.Write(lv);
            }

            Console.SetCursorPosition(C1, L1);
            Console.Write(cse);

            Console.SetCursorPosition(C2, L1);
            Console.Write(csd);

            Console.SetCursorPosition(C1, L2);
            Console.Write(cie);

            Console.SetCursorPosition(C2, L2);
            Console.Write(cid);

            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool Continuar()
        {
            int l1 = 21, c1 = 25, l2 = 26, c2 = 75;

            janela(l1, c1, l2, c2, 'd', true);

            Console.SetCursorPosition(c1 + 3, l1 + 1);
            Console.Write("[1] Continuar nesta operação");

            Console.SetCursorPosition(c1 + 3, l1 + 2);
            Console.Write("[2] Voltar ao Menu Anterior");

            Console.SetCursorPosition(c1 + 3, l1 + 4);
            Console.Write("Escolha uma opção: ");

            int escolha;

            while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha != 1 && escolha != 2))
            {
                Console.SetCursorPosition(c1 + 3, l1 + 4);
                Console.Write(new string(' ', c2 - c1 - 4));

                Console.SetCursorPosition(c1 + 3, l1 + 4);
                Console.Write("Opção inválida. Escolha 1 ou 2: ");
            }

            Console.Clear();

            if (escolha == 2)
            {
                Console.WriteLine("Voltando...");
                Thread.Sleep(1200);
                return false;
            }

            Console.WriteLine("Voltando para operação...");
            Thread.Sleep(1200);
            return true;
        }

        static void Sorteio_Nomes()
        {
            do
            {
                Console.Clear();

                janela(0, 35, 2, 70, 'd', false);
                Console.SetCursorPosition(43, 1);
                Console.Write("SORTEIO DE NOMES");

                janela(3, 20, 19, 85, 's', true);

                Console.SetCursorPosition(24, 5);
                Console.Write("Quantos nomes deseja cadastrar (2 a 10): ");

                int quantidade;

                if (!int.TryParse(Console.ReadLine(), out quantidade))
                {
                    Console.SetCursorPosition(24, 7);
                    Console.Write("Valor inválido!");
                    Thread.Sleep(2000);
                    continue;
                }

                if (quantidade < 2 || quantidade > 10)
                {
                    Console.SetCursorPosition(24, 7);
                    Console.Write("Informe um número entre 2 e 10.");
                    Thread.Sleep(2000);
                    continue;
                }

                string[] nomes = new string[quantidade];

                for (int i = 0; i < quantidade; i++)
                {
                    Console.SetCursorPosition(24, 7 + i);
                    Console.Write($"Nome {i + 1}: ");
                    nomes[i] = Console.ReadLine();
                }

                Random sorteio = new Random();
                int escolhido = sorteio.Next(0, quantidade);

                janela(15, 30, 19, 75, 'd', false);
                Console.SetCursorPosition(34, 17);
                Console.Write($"Nome sorteado: {nomes[escolhido]}");

            } while (Continuar());
        }

        static void Sorteio_Duplas()
        {
            do
            {
                Console.Clear();

                janela(0, 35, 2, 70, 'd', false);
                Console.SetCursorPosition(42, 1);
                Console.Write("SORTEIO DE DUPLAS");

                janela(3, 20, 19, 90, 's', true);

                Console.SetCursorPosition(24, 5);
                Console.Write("Quantidade de alunos (par e entre 2 e 20): ");

                int quantidade;

                if (!int.TryParse(Console.ReadLine(), out quantidade))
                {
                    Console.SetCursorPosition(24, 7);
                    Console.Write("Valor inválido!");
                    Thread.Sleep(2000);
                    continue;
                }

                if (quantidade < 2 || quantidade > 20 || quantidade % 2 != 0)
                {
                    Console.SetCursorPosition(24, 7);
                    Console.Write("A quantidade deve ser PAR e entre 2 e 20.");
                    Thread.Sleep(2000);
                    continue;
                }

                string[] alunos = new string[quantidade];

                for (int i = 0; i < quantidade; i++)
                {
                    Console.SetCursorPosition(24, 7 + i);
                    Console.Write($"Aluno {i + 1}: ");
                    alunos[i] = Console.ReadLine();
                }

                Random random = new Random();

                for (int i = quantidade - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);

                    string aux = alunos[i];
                    alunos[i] = alunos[j];
                    alunos[j] = aux;
                }

                Console.Clear();

                janela(0, 35, 2, 70, 'd', false);
                Console.SetCursorPosition(42, 1);
                Console.Write("DUPLAS SORTEADAS");

                janela(3, 20, 19, 90, 's', true);

                int linha = 5;

                for (int i = 0; i < quantidade; i += 2)
                {
                    Console.SetCursorPosition(25, linha);
                    Console.Write($"Dupla {(i / 2) + 1}: {alunos[i]}  e  {alunos[i + 1]}");
                    linha++;
                }

            } while (Continuar());
        }

        static void Valores_Extenso()
        {
            do
            {
                Console.Clear();

                janela(0, 35, 2, 72, 'd', false);
                Console.SetCursorPosition(42, 1);
                Console.Write("VALORES POR EXTENSO");

                janela(3, 15, 19, 95, 's', true);

                string[] unidades =
                {
                    "", "Um", "Dois", "Três", "Quatro",
                    "Cinco", "Seis", "Sete", "Oito", "Nove"
                };

                string[] especiais =
                {
                    "Dez", "Onze", "Doze", "Treze", "Quatorze",
                    "Quinze", "Dezesseis", "Dezessete",
                    "Dezoito", "Dezenove"
                };

                string[] dezenas =
                {
                    "", "", "Vinte", "Trinta", "Quarenta",
                    "Cinquenta", "Sessenta", "Setenta",
                    "Oitenta", "Noventa"
                };

                string[] centenas =
                {
                    "", "Cento", "Duzentos", "Trezentos",
                    "Quatrocentos", "Quinhentos",
                    "Seiscentos", "Setecentos",
                    "Oitocentos", "Novecentos"
                };

                Console.SetCursorPosition(20, 5);
                Console.Write("Digite um número entre 0 e 1000: ");

                int numero;

                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.SetCursorPosition(20, 7);
                    Console.Write("Digite um número válido!");
                    Thread.Sleep(2000);
                    continue;
                }

                if (numero < 0 || numero > 1000)
                {
                    Console.SetCursorPosition(20, 7);
                    Console.Write("O número deve estar entre 0 e 1000.");
                    Thread.Sleep(2000);
                    continue;
                }

                string extenso = "";

                if (numero == 0)
                {
                    extenso = "Zero";
                }
                else if (numero == 1000)
                {
                    extenso = "Mil";
                }
                else if (numero == 100)
                {
                    extenso = "Cem";
                }
                else
                {
                    int c = numero / 100;
                    int resto = numero % 100;

                    if (c > 0)
                    {
                        extenso += centenas[c];

                        if (resto > 0)
                            extenso += " e ";
                    }

                    if (resto >= 10 && resto <= 19)
                    {
                        extenso += especiais[resto - 10];
                    }
                    else
                    {
                        int d = resto / 10;
                        int u = resto % 10;

                        if (d > 1)
                        {
                            extenso += dezenas[d];

                            if (u > 0)
                                extenso += " e ";
                        }

                        if (u > 0)
                        {
                            extenso += unidades[u];
                        }
                    }
                }

                janela(12, 20, 16, 90, 'd', false);
                Console.SetCursorPosition(24, 14);
                Console.Write($"Número por extenso: {extenso}");

            } while (Continuar());
        }
    }
}