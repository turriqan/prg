using System;

namespace exodus
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            Waitkey();
        }

        private static void Init()
        {
            LogContext("program start", ELevel.Informative);
        }
        private static void LogContext(string value, ELevel eLevel)
        {
            ConsoleColor color = Console.ForegroundColor;
            switch (eLevel)
            {
                case ELevel.Informative:
                    {
                        color = ConsoleColor.Green;
                        break;
                    }
                case ELevel.Warning:
                    {
                        color = ConsoleColor.Yellow;
                        break;
                    }
                case ELevel.Error:
                    {
                        color = ConsoleColor.Red;
                        break;
                    }
                default:
                    {
                        color = ConsoleColor.Gray;
                        break;
                    }
            }
            Console.ForegroundColor = color;
            Console.WriteLine(String.Format("exodus: {0}", value));
        }


        private static void Waitkey()
        {
            Console.ReadKey();
        }
        private enum ELevel
        {
            Normal,
            Informative,
            Warning,
            Error
        }
    }
}