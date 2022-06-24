using System;
using System.Collections.Generic;

namespace Append
{
    public static class Logger
    {
        private static Dictionary<Varbosity, ConsoleColor> _colors = new Dictionary<Varbosity, ConsoleColor>
                                                                                                            {
                                                                                                                {Varbosity.High, ConsoleColor.Red},
                                                                                                                {Varbosity.Med, ConsoleColor.Yellow},
                                                                                                                {Varbosity.Low, ConsoleColor.Blue},
                                                                                                            };
    
        public static void Log(string _message, Varbosity _varb)
        {
            ConsoleColor _cColor = Console.ForegroundColor;
            Console.ForegroundColor = _colors[_varb];
            Console.WriteLine(_message);
            Console.ForegroundColor = _cColor;
        }
        public static void Log(List<string> _messages, Varbosity _varb)
        {
            ConsoleColor _cColor = Console.ForegroundColor;
            Console.ForegroundColor = _colors[_varb];
            
            for (int i = 0; i < _messages.Count; i++)
            {
                Console.WriteLine(_messages[i]);
                Console.WriteLine(Environment.NewLine);
            }

            Console.ForegroundColor = _cColor;
        }
    }
}


