using System;

namespace Aula3107_Console{

    class Program {
        public static int id { get; set; }
        static void Main(string[] args) {
            Console.WriteLine("Digite um número: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: " + id);
            Console.ReadKey();
        }
    }
}
