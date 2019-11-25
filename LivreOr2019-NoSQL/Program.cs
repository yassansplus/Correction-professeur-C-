using System;

namespace LivreOr2019_NoSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            LivreOr livre = new LivreOr();


            while (true)
            {
                ClearConsole();
                foreach(var m in livre.Messages)
                {
                    Display(m);
                }

                var message = ReadMessage();
                livre.AddMessage(message);
            }

        }

        private static void ClearConsole()
        {
            Console.Clear();
        }

        private static Message ReadMessage()
        {
            Console.WriteLine(new String('-', 10));

            var color = Console.ForegroundColor;

            #region Lecture d'un nom depuis la console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> Nom? ");
            Console.ForegroundColor = color;
            var nom = Console.ReadLine();
            #endregion

            #region Description
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> Description? ");
            Console.ForegroundColor = color;
            var description = Console.ReadLine();
            #endregion

            return new Message(nom, description);
        }

        private static void Display(Message m)
        {
            Console.WriteLine($"* {m.Nom} | {m.Description}");

            //Console.WriteLine("* " + m.Nom + " | " + m.Description );
            //Console.WriteLine("* {0} | {1}", m.Nom, m.Description);
        }
    }
}
