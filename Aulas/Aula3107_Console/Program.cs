using System;

namespace Aula3107_Console{

    class Program {
        public static int num1 { get; set; }
        public static int num2 { get; set; }
        static void Main(string[] args) {
            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            int opcao = 0;
            while (opcao != 5) {

                Console.WriteLine("Digite 1 para soma.\nDigite 2 para subtração.\nDigite 3 para multiplicação.\n" +
                "Digite 4 para divisão.\nDigite 5 para sair.");

                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1) {
                    Console.WriteLine("A soma é: " + (num1 + num2));
                } else if (opcao == 2) {
                    Console.WriteLine("A subtração é: " + (num1 - num2));
                } else if (opcao == 3) {
                    Console.WriteLine("A multiplicação é: " + (num1 * num2));
                } else if (opcao == 4) {
                    Console.WriteLine("A divisão é: " + (num1 / num2));
                } else if (opcao == 5) {
                    break;
                } else {
                    Console.WriteLine("Opção inválida");
                }
            }
        }

    }
}
