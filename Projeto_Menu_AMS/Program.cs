using System;
using System.Threading;

namespace Projeto_Menu_AMS
{
    internal class Program
    {
        // ============================================================
        // MÉTODO PRINCIPAL
        // ============================================================
        // É onde o programa começa a ser executado.
        // Aqui são definidas as cores iniciais, feita a apresentação
        // do usuário e exibido o Menu Principal.
        // ============================================================

        static void Main(string[] args)
        {
            // Define a cor de fundo do console
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            // Define a cor dos textos do console
            Console.ForegroundColor = ConsoleColor.White;

            // Limpa o console usando as cores definidas acima
            Console.Clear();


            // Variável que armazenará o nome do usuário
            string nome;

            // Primeira mensagem apresentada
            Console.WriteLine("Boa Tarde!!");

            // Solicita o nome do usuário
            Console.Write("Qual é o seu nome? ");

            // Lê o nome digitado
            nome = Console.ReadLine();

            // Pula uma linha
            Console.WriteLine();

            // Exibe uma mensagem personalizada usando o nome informado
            Console.WriteLine($"Seja bem-vindo(a) {nome} para nossa aula");

            // Exibe a quantidade de colunas disponíveis no console
            Console.WriteLine(Console.WindowWidth);

            // Aguarda 2 segundos antes de continuar
            Thread.Sleep(2000);


            // ========================================================
            // MENU PRINCIPAL
            // ========================================================
            // O do/while mantém o Menu Principal funcionando
            // continuamente.
            // ========================================================

            do
            {
                // Limpa a tela antes de redesenhar o menu
                Console.Clear();


                // ====================================================
                // TÍTULO DO MENU PRINCIPAL
                // ====================================================

                // Cria a janela do título
                // L1 = linha inicial
                // C1 = coluna inicial
                // L2 = linha final
                // C2 = coluna final
                // 'd' = borda dupla
                // false = sem sombra
                janela(0, 39, 2, 62, 'd', false);

                // Posiciona o cursor dentro da janela
                Console.SetCursorPosition(40, 1);

                // Exibe o título
                Console.WriteLine("*** Menu Principal ***");


                // ====================================================
                // JANELA DAS OPÇÕES
                // ====================================================

                janela(3, 29, 13, 70, 's', true);


                Console.SetCursorPosition(30, 4);
                Console.WriteLine("[1] Menu dos Vetores");

                Console.SetCursorPosition(30, 5);
                Console.WriteLine("[2] Tabuada");

                Console.SetCursorPosition(30, 6);
                Console.WriteLine("[3] Compara Números");

                Console.SetCursorPosition(30, 7);
                Console.WriteLine("[4] Equação do Segundo Grau");

                Console.SetCursorPosition(30, 8);
                Console.WriteLine("[5] Média");

                Console.SetCursorPosition(30, 9);
                Console.WriteLine("[6] Jogo Adivinha");

                Console.SetCursorPosition(30, 10);
                Console.WriteLine("[7] Encerrar");


                // ====================================================
                // LINHA DE SEPARAÇÃO
                // ====================================================

                Console.SetCursorPosition(30, 11);

                for (int i = 0; i < 40; i++)
                {
                    Console.Write("=");
                }

                Console.SetCursorPosition(30, 12);

                Console.Write("Digite sua Opção: ");

                int opcao = int.Parse(Console.ReadLine());


                // ====================================================
                // JANELA DE MENSAGEM
                // ====================================================

                janela(15, 29, 19, 70, 's', true);

                Console.SetCursorPosition(32, 17);


                // ====================================================
                // DECISÃO DA OPÇÃO
                // ====================================================

                switch (opcao)
                {
                    // ------------------------------------------------
                    // OPÇÃO 1 - MENU DOS VETORES
                    // ------------------------------------------------

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


                    // ------------------------------------------------
                    // OPÇÃO INVÁLIDA
                    // ------------------------------------------------

                    default:

                        Console.WriteLine("Opção inválida, tente novamente!");

                        Thread.Sleep(1500);

                        Opcao_Invalida();

                        break;
                }

            } while (true);
        }


        // ============================================================
        // MENU DOS VETORES
        // ============================================================

        static void Menu_Vetores()
        {
            do
            {
                Console.Clear();

                janela(0, 39, 2, 65, 'd', false);

                Console.SetCursorPosition(40, 1);

                Console.Write("*** Menu dos Vetores ***");


                // ====================================================
                // JANELA DAS OPÇÕES
                // ====================================================

                janela(3, 35, 12, 70, 's', true);


                Console.SetCursorPosition(36, 4);
                Console.WriteLine("[1] Sorteio de Nomes");

                Console.SetCursorPosition(36, 5);
                Console.WriteLine("[2] Sorteio de Duplas");

                Console.SetCursorPosition(36, 6);
                Console.WriteLine("[3] Valores por Extenso");

                Console.SetCursorPosition(36, 7);
                Console.WriteLine("[4] Voltar ao Principal");


                Console.SetCursorPosition(36, 9);
                Console.WriteLine(new string('=', 34));


                // ====================================================
                // LEITURA DA OPÇÃO
                // ====================================================

                Console.SetCursorPosition(36, 11);
                Console.Write("Digite sua Opção: ");

                int opcao = int.Parse(Console.ReadLine());


                // ====================================================
                // JANELA DE MENSAGEM
                // ====================================================

                janela(14, 35, 18, 70, 'd', true);

                Console.SetCursorPosition(36, 16);


                // ====================================================
                // DECISÃO
                // ====================================================

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


        // ============================================================
        // TABUADA
        // ============================================================

        static void Tabuada()
        {
            do
            {
                Console.Clear();

                janela(0, 39, 2, 65, 'd', false);

                Console.SetCursorPosition(44, 1);

                Console.WriteLine("OPERAÇÃO TABUADA");


                // ====================================================
                // JANELA PRINCIPAL
                // ====================================================

                janela(3, 22, 20, 80, 's', true);

                Console.SetCursorPosition(35, 4);

                Console.Write("Digite qual tabuada você quer: ");


                // ====================================================
                // LEITURA DA TABUADA
                // ====================================================

                // Tenta converter o valor digitado para double.
                // Se não conseguir, entra no if.
                if (!double.TryParse(Console.ReadLine(), out double tab))
                {
                    Console.SetCursorPosition(35, 6);

                    Console.Write("Por favor, digite um número válido!");

                    Thread.Sleep(1500);

                    // Volta para o início do do/while
                    continue;
                }


                // ====================================================
                // CÁLCULO E EXIBIÇÃO DA TABUADA
                // ====================================================

                for (int i = 0; i <= 10; i++)
                {
                    Console.SetCursorPosition(45, 6 + i);

                    Console.WriteLine($"{tab} x {i} = {tab * i}");

                    Console.WriteLine();
                }

                Console.SetCursorPosition(30, 19);

            } while (Continuar());
        }


        // ============================================================
        // COMPARAÇÃO DE NÚMEROS
        // ============================================================

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


                // ====================================================
                // VALIDAÇÃO
                // ====================================================

                // Verifica se:
                // 1 - Foram digitados exatamente dois valores
                // 2 - O primeiro pode ser convertido para double
                // 3 - O segundo pode ser convertido para double

                if (partes.Length != 2 ||
                    !double.TryParse(partes[0].Trim(), out valores[0]) ||
                    !double.TryParse(partes[1].Trim(), out valores[1]))
                {
                    janela(13, 30, 15, 72, 'd', false);

                    Console.SetCursorPosition(43, 14);

                    Console.Write("Entrada inválida!");

                    Console.SetCursorPosition(30, 19);

                    Thread.Sleep(2000);

                    continue;
                }


                double valor1 = valores[0];
                double valor2 = valores[1];


                janela(13, 30, 15, 72, 'd', false);

                Console.SetCursorPosition(40, 14);


                // ====================================================
                // COMPARAÇÃO
                // ====================================================

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


                Console.SetCursorPosition(30, 19);


            } while (Continuar());
        }


        // ============================================================
        // BHASKARA
        // ============================================================

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

                Console.SetCursorPosition(24, 20);

            } while (Continuar());
        }


        // ============================================================
        // MÉDIA
        // ============================================================

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


                // ====================================================
                // CÁLCULO DA MÉDIA
                // ====================================================

                double media = (valores[0] + valores[1]) / 2;


                Console.SetCursorPosition(30, 8);

                Console.Write($"A média entre os dois valores é {media:F2}");


                Console.SetCursorPosition(30, 12);
            } while (Continuar());
        }


        // ============================================================
        // JOGO DE ADIVINHAÇÃO
        // ============================================================

        // ============================================================
        // JOGO DE ADIVINHAÇÃO
        // ============================================================

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

                Console.SetCursorPosition(25, 19);

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


        // ============================================================
        // MÉTODO JANELA
        // ============================================================
        //
        // Responsável por desenhar as janelas utilizadas no programa.
        //
        // L1 = linha inicial
        // C1 = coluna inicial
        // L2 = linha final
        // C2 = coluna final
        // borda = tipo de borda
        // sombra = define se haverá sombra
        //
        // ============================================================

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


            // ========================================================
            // DESENHANDO A SOMBRA
            // ========================================================

            // Verifica se a janela deve possuir sombra
            if (sombra)
            {
                // Define a cor da sombra como preta
                Console.ForegroundColor = ConsoleColor.Black;


                // ----------------------------------------------------
                // SOMBRA LATERAL
                // ----------------------------------------------------

                // Percorre as linhas da janela
                // deslocando a sombra uma posição para a direita
                // e uma posição para baixo.
                for (int i = L1 + 1; i <= L2 + 1; i++)
                {
                    // Posiciona o cursor na coluna seguinte à janela
                    Console.SetCursorPosition(C2 + 1, i);

                    // Desenha um caractere da sombra
                    Console.Write("▓");
                }


                // ----------------------------------------------------
                // SOMBRA INFERIOR
                // ----------------------------------------------------

                // Posiciona o cursor uma linha abaixo
                // e uma coluna depois do início da janela.
                Console.SetCursorPosition(C1 + 1, L2 + 1);

                // Cria vários caracteres "▓" para formar a sombra
                // na parte inferior da janela.
                Console.Write(new string('▓', C2 - C1));


                // Volta a cor do texto para branco
                Console.ForegroundColor = ConsoleColor.White;
            }


            // ========================================================
            // DESENHANDO A JANELA
            // ========================================================

            // Desenha a linha superior
            Console.SetCursorPosition(C1, L1);

            Console.Write(new string(lh, C2 - C1));


            // Desenha a linha inferior
            Console.SetCursorPosition(C1, L2);

            Console.Write(new string(lh, C2 - C1));


            // ========================================================
            // DESENHANDO AS LATERAIS
            // ========================================================

            // Percorre todas as linhas da janela
            for (int i = L1; i <= L2; i++)
            {
                // Desenha a lateral esquerda
                Console.SetCursorPosition(C1, i);

                Console.Write(lv);


                // Desenha a lateral direita
                Console.SetCursorPosition(C2, i);

                Console.Write(lv);
            }


            // ========================================================
            // DESENHANDO OS CANTOS
            // ========================================================

            // Canto superior esquerdo
            Console.SetCursorPosition(C1, L1);
            Console.Write(cse);


            // Canto superior direito
            Console.SetCursorPosition(C2, L1);
            Console.Write(csd);


            // Canto inferior esquerdo
            Console.SetCursorPosition(C1, L2);
            Console.Write(cie);


            // Canto inferior direito
            Console.SetCursorPosition(C2, L2);
            Console.Write(cid);
        }


        // ============================================================
        // PERGUNTA SE O USUÁRIO DESEJA CONTINUAR
        // ============================================================

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

        // ============================================================
        // SORTEIO DE NOMES
        // ============================================================

        static void Sorteio_Nomes()
        {
            do
            {
                Console.Clear();

                janela(0, 35, 2, 70, 'd', false);

                Console.SetCursorPosition(43, 1);
                Console.Write("SORTEIO DE NOMES");

                janela(3, 20, 22, 85, 's', true);

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

                Console.SetCursorPosition(30, 21);

            } while (Continuar());
        }

        // ============================================================
        // SORTEIO DE DUPLAS
        // ============================================================

        static void Sorteio_Duplas()
        {
            do
            {
                Console.Clear();

                janela(0, 35, 2, 70, 'd', false);

                Console.SetCursorPosition(42, 1);
                Console.Write("SORTEIO DE DUPLAS");

                janela(3, 20, 24, 90, 's', true);

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

                // Embaralhamento (Fisher-Yates)

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

                janela(3, 20, 22, 90, 's', true);

                int linha = 5;

                for (int i = 0; i < quantidade; i += 2)
                {
                    Console.SetCursorPosition(25, linha);
                    Console.Write($"Dupla {(i / 2) + 1}: {alunos[i]}  e  {alunos[i + 1]}");

                    linha++;
                }

                Console.SetCursorPosition(25, 20);

            } while (Continuar());
        }


        // ============================================================
        // VALORES POR EXTENSO
        // ============================================================

        static void Valores_Extenso()
        {
            do
            {
                Console.Clear();

                janela(0, 35, 2, 72, 'd', false);

                Console.SetCursorPosition(42, 1);
                Console.Write("VALORES POR EXTENSO");

                janela(3, 15, 20, 95, 's', true);

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

                // Verifica se foi digitado um número
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.SetCursorPosition(20, 7);
                    Console.Write("Digite um número válido!");

                    Thread.Sleep(2000);
                    continue;
                }

                // Verifica se está na faixa permitida
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

                Console.SetCursorPosition(20, 18);

            } while (Continuar());
        }
    }
}
