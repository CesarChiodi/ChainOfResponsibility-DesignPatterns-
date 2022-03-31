using System;
using System.Collections.Generic;

namespace ChainOfResponsibility_DesignPatterns_
{
    class Program
    {
        static void Main(string[] args)
        {
            // A outra parte do código do cliente constrói a CORRENTE real.

            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);  // "DEFININDO o sequenciamento"

            // O cliente deve ser capaz de enviar uma solicitação para qualquer HANDLER,
            // nao apenas o primeiro da cadeia.

            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Subchain: Dog\n");
            Client.ClientCode(dog);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
// https://refactoring.guru/pt-br/design-patterns/chain-of-responsibility
//Chain of Responsibility(CORRENTE DE RESPONSABILIDADES, "malha de comandos"): 
//Baseia em transformar certos comportamentos em objetos solitários chamados handlers(MANIPULADORES).
//Um handler pode decidir não passar o pedido adiante na corrente e efetivamente parar qualquer futuro processamento.
