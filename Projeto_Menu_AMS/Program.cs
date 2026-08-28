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

                // Cria a janela que contém as opções do menu
                // 's' = borda simples
                // true = com sombra
                janela(3, 29, 13, 70, 's', true);


                // Exibe a opção 1
                Console.SetCursorPosition(30, 4);
                Console.WriteLine("[1] Menu dos Vetores");

                // Exibe a opção 2
                Console.SetCursorPosition(30, 5);
                Console.WriteLine("[2] Tabuada");

                // Exibe a opção 3
                Console.SetCursorPosition(30, 6);
                Console.WriteLine("[3] Compara Números");

                // Exibe a opção 4
                Console.SetCursorPosition(30, 7);
                Console.WriteLine("[4] Equação do Segundo Grau");

                // Exibe a opção 5
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("[5] Média");

                // Exibe a opção 6
                Console.SetCursorPosition(30, 9);
                Console.WriteLine("[6] Jogo Adivinha");

                // Exibe a opção 7
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("[7] Encerrar");


                // ====================================================
                // LINHA DE SEPARAÇÃO
                // ====================================================

                // Posiciona o cursor
                Console.SetCursorPosition(30, 11);

                // Cria uma linha formada por 40 caracteres '='
                for (int i = 0; i < 40; i++)
                {
                    Console.Write("=");
                }


                // ====================================================
                // LEITURA DA OPÇÃO
                // ====================================================

                // Posiciona o cursor para solicitar a opção
                Console.SetCursorPosition(30, 12);

                // Solicita a opção escolhida
                Console.Write("Digite sua Opção: ");

                // Lê a opção e converte para inteiro
                int opcao = int.Parse(Console.ReadLine());


                // ====================================================
                // JANELA DE MENSAGEM
                // ====================================================

                // Cria uma janela onde será mostrada a mensagem
                // correspondente à opção escolhida.
                janela(15, 29, 19, 70, 's', true);

                // Posiciona o cursor dentro da janela
                Console.SetCursorPosition(32, 17);


                // ====================================================
                // DECISÃO DA OPÇÃO
                // ====================================================

                // O switch verifica qual opção o usuário escolheu.
                switch (opcao)
                {
                    // ------------------------------------------------
                    // OPÇÃO 1 - MENU DOS VETORES
                    // ------------------------------------------------

                    case 1:

                        // Mensagem antes de abrir o menu
                        Console.WriteLine("Abrindo Menu dos Vetores...");

                        // Aguarda 1,5 segundos
                        Thread.Sleep(1500);

                        // Chama o método do Menu dos Vetores
                        Menu_Vetores();

                        break;


                    // ------------------------------------------------
                    // OPÇÃO 2 - TABUADA
                    // ------------------------------------------------

                    case 2:

                        Console.WriteLine("Abrindo Tabuada...");

                        Thread.Sleep(1500);

                        // Chama o método da Tabuada
                        Tabuada();

                        break;


                    // ------------------------------------------------
                    // OPÇÃO 3 - COMPARAÇÃO DE NÚMEROS
                    // ------------------------------------------------

                    case 3:

                        Console.WriteLine("Abrindo Comparação de Numeros...");

                        Thread.Sleep(1500);

                        // Chama o método de comparação
                        Compara_Numeros();

                        break;


                    // ------------------------------------------------
                    // OPÇÃO 4 - BHASKARA
                    // ------------------------------------------------

                    case 4:

                        Console.WriteLine("Abrindo Bhaskara...");

                        Thread.Sleep(1500);

                        // Chama o método de Bhaskara
                        Bhaskara();

                        break;


                    // ------------------------------------------------
                    // OPÇÃO 5 - MÉDIA
                    // ------------------------------------------------

                    case 5:

                        Console.WriteLine("Abrindo Media...");

                        Thread.Sleep(1500);

                        // Chama o método da média
                        Media();

                        break;


                    // ------------------------------------------------
                    // OPÇÃO 6 - JOGO DE ADIVINHAÇÃO
                    // ------------------------------------------------

                    case 6:

                        Console.WriteLine("Abrindo Jogo de Adivinhação...");

                        Thread.Sleep(1500);

                        // Chama o método do jogo
                        Jogo_Adivinha();

                        break;


                    // ------------------------------------------------
                    // OPÇÃO 7 - ENCERRAR
                    // ------------------------------------------------

                    case 7:

                        Console.WriteLine("Até a próxima!");

                        Thread.Sleep(1500);

                        // Posiciona o cursor
                        Console.SetCursorPosition(32, 19);

                        // Encerra completamente o programa
                        Environment.Exit(0);

                        break;


                    // ------------------------------------------------
                    // OPÇÃO INVÁLIDA
                    // ------------------------------------------------

                    default:

                        Console.WriteLine("Opção inválida, tente novamente!");

                        Thread.Sleep(1500);

                        // Chama o método de opção inválida
                        Opcao_Invalida();

                        break;
                }

                // O Menu Principal continua sendo executado
                // enquanto a condição for verdadeira.
            } while (true);
        }


        // ============================================================
        // MENU DOS VETORES
        // ============================================================

        static void Menu_Vetores()
        {
            // Mantém o menu funcionando continuamente
            do
            {
                // Limpa a tela
                Console.Clear();


                // ====================================================
                // TÍTULO
                // ====================================================

                // Cria a janela do título
                janela(0, 39, 2, 65, 'd', false);

                // Posiciona o cursor dentro da janela
                Console.SetCursorPosition(40, 1);

                // Exibe o título
                Console.Write("*** Menu dos Vetores ***");


                // ====================================================
                // JANELA DAS OPÇÕES
                // ====================================================

                // Cria a janela que contém as opções
                janela(3, 35, 12, 70, 's', true);


                // Opção 1
                Console.SetCursorPosition(36, 4);
                Console.WriteLine("[1] Sorteio de Nomes");

                // Opção 2
                Console.SetCursorPosition(36, 5);
                Console.WriteLine("[2] Sorteio de Duplas");

                // Opção 3
                Console.SetCursorPosition(36, 6);
                Console.WriteLine("[3] Valores por Extenso");

                // Opção 4
                Console.SetCursorPosition(36, 7);
                Console.WriteLine("[4] Voltar ao Principal");


                // Linha de separação
                Console.SetCursorPosition(36, 9);
                Console.WriteLine(new string('=', 34));


                // ====================================================
                // LEITURA DA OPÇÃO
                // ====================================================

                Console.SetCursorPosition(36, 11);
                Console.Write("Digite sua Opção: ");

                // Lê a opção escolhida
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
                    // Opção 1
                    case 1:

                        Console.Write("Abrindo Sorteio de Nomes");

                        Thread.Sleep(1500);

                        // Chama o método correspondente
                        Sorteio_Nomes();

                        break;


                    // Opção 2
                    case 2:

                        Console.Write("Abrindo Sorteio de Duplas");

                        Thread.Sleep(1500);

                        // Chama o método correspondente
                        Sorteio_Duplas();

                        break;


                    // Opção 3
                    case 3:

                        Console.Write("Abrindo Valores por Extenso");

                        Thread.Sleep(1500);

                        // Chama o método correspondente
                        Valores_Extenso();

                        break;


                    // Opção 4
                    case 4:

                        Console.Write("Abrindo Menu Principal");

                        Thread.Sleep(1500);

                        // return encerra o método Menu_Vetores
                        // e retorna para quem chamou esse método.
                        return;


                    // Qualquer outro valor
                    default:

                        // Chama o método de opção inválida
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
            // Mantém a operação sendo repetida enquanto Continuar()
            // retornar true.
            do
            {
                Console.Clear();


                // ====================================================
                // TÍTULO
                // ====================================================

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

                // Percorre os valores de 0 até 10
                for (int i = 0; i <= 10; i++)
                {
                    // Define a posição de cada operação
                    Console.SetCursorPosition(45, 6 + i);

                    // Mostra a operação
                    Console.WriteLine($"{tab} x {i} = {tab * i}");

                    // Pula uma linha
                    Console.WriteLine();
                }


                // Posiciona o cursor antes de perguntar se deseja
                // continuar.
                Console.SetCursorPosition(30, 19);


                // Pergunta ao usuário se deseja continuar.
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


                janela(0, 39, 2, 65, 'd', false);

                Console.SetCursorPosition(44, 1);

                Console.WriteLine("OPERAÇÃO BHASKARA");


                double[] valores = new double[3];


                Console.SetCursorPosition(5, 3);

                Console.Write("Digite, respectivamente, os valores de A, B e C separados por espaço: ");

                Console.SetCursorPosition(5, 5);

                string entrada = Console.ReadLine();

                string[] partes = entrada.Split(' ');

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

                // Em uma equação do segundo grau, A não pode ser zero.
                if (A == 0)
                {
                    Console.WriteLine("O valor de A não pode ser zero!");

                    Thread.Sleep(2000);

                    continue;
                }


                Console.SetCursorPosition(5, 5);


                // ====================================================
                // CÁLCULO DO DELTA
                // ====================================================

                // Fórmula:
                // Δ = B² - 4AC
                double delta = (Math.Pow(B, 2)) - (4 * A * C);


                // Exibe o delta
                Console.WriteLine($"Seu delta é igual a: {delta}");


                // ====================================================
                // VERIFICAÇÃO DO DELTA
                // ====================================================

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

        static void Jogo_Adivinha()
        {
            do
            {
                janela(0, 39, 2, 65, 'd', false);

                Console.SetCursorPosition(44, 1);

                Console.WriteLine("OPERAÇÃO ADIVINHA");


                // Pergunta se deseja continuar.
            } while (Continuar());
        }

        static void Opcao_Invalida()
        {
            // Método reservado para tratar uma opção inválida.
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
            Console.Clear();

            // Exibe o título
            Console.WriteLine("Sorteio de Nomes");

            // Implementação do sorteio de nomes
        }


        // ============================================================
        // SORTEIO DE DUPLAS
        // ============================================================

        static void Sorteio_Duplas()
        {
            Console.Clear();

            // Exibe o título
            Console.WriteLine("Sorteio de Duplas");

            // Implementação do sorteio de duplas
        }


        // ============================================================
        // VALORES POR EXTENSO
        // ============================================================

        static void Valores_Extenso()
        {
            Console.Clear();

            // Exibe o título
            Console.WriteLine("Valores por Extenso");

            // Implementação dos valores por extenso
        }
    }
}
