using System;

class Program
{
    static void Main(string[] args)
    {
        char opcaoMenu;

        do
        {
            // Menu de opções
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Verificar se um número pertence à sequência de Fibonacci");
            Console.WriteLine("2 - Contar ocorrências da letra 'a' em uma string");
            Console.WriteLine("S - Sair");
            Console.Write("Opção: ");
            opcaoMenu = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Para quebra de linha após a escolha

            switch (opcaoMenu)
            {
                case '1':
                    VerificarFibonacci(); // Chama o programa de Fibonacci
                    break;
                case '2':
                    ContarLetraA(); // Chama o programa de contagem de 'a'
                    break;
                case 'S':
                case 's':
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcaoMenu != 'S' && opcaoMenu != 's'); // Repete o menu enquanto o usuário não quiser sair
    }

    // Método para verificar Fibonacci
    static void VerificarFibonacci()
    {
        char opcaoContinuar;

        do
        {
            int numero;

            // Tenta obter um número do usuário
            while (true)
            {
                Console.Write("Informe um número para verificar se ele pertence à sequência de Fibonacci: ");
                string entrada = Console.ReadLine();

                // Tenta converter a entrada em um número inteiro
                if (int.TryParse(entrada, out numero))
                {
                    break; // Sai do loop se a conversão for bem-sucedida
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Por favor, insira um número válido.");
                }
            }

            // Variáveis iniciais da sequência de Fibonacci
            int a = 0;
            int b = 1;

            // Verifica se o número é 0 ou 1, pois fazem parte da sequência
            if (numero == 0 || numero == 1)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                // Gera a sequência de Fibonacci e verifica se o número pertence
                while (b < numero)
                {
                    int temp = b;
                    b = a + b;
                    a = temp;
                }

                // Exibe o resultado
                if (b == numero)
                {
                    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
                }
            }

            // Pergunta ao usuário se deseja continuar verificando Fibonacci
            Console.WriteLine("\nDeseja verificar outro número na sequência de Fibonacci? Pressione 'S' para sair, ou qualquer outra tecla para continuar.");
            opcaoContinuar = Console.ReadKey().KeyChar;

            Console.WriteLine(); // Para quebra de linha após a tecla pressionada

        } while (opcaoContinuar != 'S' && opcaoContinuar != 's'); // Continua enquanto a tecla pressionada não for 'S' ou 's'
    }

    // Método para contar a letra 'a' em uma string
    static void ContarLetraA()
    {
        char opcaoContinuar;

        do
        {
            // Entrada da string
            Console.Write("Informe uma string: ");
            string input = Console.ReadLine();

            // Variáveis para contar a ocorrência de 'a' e 'A'
            int contador = 0;

            // Percorrer a string e contar as ocorrências de 'a' ou 'A'
            foreach (char c in input)
            {
                if (c == 'a' || c == 'A' || c == 'á' || c == 'Á' || c == 'à' || c == 'À' || c == 'ã' || c == 'Ã' || c == 'â' || c == 'Â')
                {
                    contador++;
                }
            }

            // Exibir o resultado
            if (contador > 0)
            {
                Console.WriteLine($"A letra 'a' (maiúscula, minúscula ou com acentos) ocorre {contador} vezes na string.");
            }
            else
            {
                Console.WriteLine("A letra 'a' não foi encontrada na string.");
            }

            // Pergunta ao usuário se deseja continuar verificando strings
            Console.WriteLine("\nDeseja verificar outra string? Pressione 'S' para sair, ou qualquer outra tecla para continuar.");
            opcaoContinuar = Console.ReadKey().KeyChar;

            Console.WriteLine(); // Para quebra de linha após a tecla pressionada

        } while (opcaoContinuar != 'S' && opcaoContinuar != 's'); // Continua enquanto a tecla pressionada não for 'S' ou 's'
    }
}
