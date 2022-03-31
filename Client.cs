using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_DesignPatterns_
{
    class Client 
    {
        // O código do cliente geralmente é adequado para trabalhar com um único Handler.
        // Na maioria dos casos, nem sequer está ciente de que o HANDLER faz parte de uma cadeia.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "MeatBall" })
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
