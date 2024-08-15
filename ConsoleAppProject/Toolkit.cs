using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toolkit
{
    public static class Message
    {
        public static void Send(string[] messages, bool clearOut)
        {
            foreach (string message in messages)
            {
                if (clearOut) Console.Clear();

                Console.Beep(250, 400);
                Console.WriteLine();

                for (int i = 0; i < message.Length; i++)
                {
                    Console.Write(message[i]);

                    // if (!String.Equals(message[i], " "))
                    System.Threading.Thread.Sleep(100);
                }

                Console.WriteLine();
            }
            Console.Beep(100, 1000);
        }
    }

    public static class User
    {
        public static void Wait()
        {
            Console.WriteLine();
            Console.WriteLine(" [ Нажмите на любую клавишу для продолжения ... ]");

            Console.ReadKey();
            Console.Beep(200, 300);
        }

        public static string Input()
        {
            Console.WriteLine();
            Console.WriteLine(" [ Введите ответ ... ]");

            string text = Console.ReadLine();

            Console.Beep(500, 500);
            return text;

        }

        public static void Menu()
        {
            Console.Title = "Меню";
            Console.Clear();
            Console.WriteLine(" ==================================");
            Console.WriteLine();
            Console.WriteLine($" Добро пожаловать в меню");
            Console.WriteLine();
            Console.WriteLine($" Отсюда вы можете отправиться куда угодно при помощи команд");
            Console.WriteLine($" Введите /help для полного списка команд");
        }
    }

    public static class Server
    {
        public static void Loading(int repet, bool allGood)
        {
            int repetSecond = 1000;

            repetLoad();

            if (allGood)
            {
                goodEnd();
            }
            else
            {
                badEnd();
            }

            void repetLoad()
            {
                string loadPoints = "";

                for (int i = 0; i < repet; i++)
                {
                    System.Threading.Thread.Sleep(repetSecond);

                    Console.Beep(300, repetSecond); // 300

                    Console.Clear();

                    string point = ".";

                    if (loadPoints.Length == 3)
                    {
                        loadPoints = ".";
                    }
                    else
                    {
                        loadPoints += point;
                    }

                    Console.WriteLine($"[ Загрузка {loadPoints} ]");
                }

                Console.Clear();
            }

            void goodEnd()
            {
                Console.Clear();

                int freque = 300;

                for (int i = 0; i < repet; i++)
                {
                    Console.Beep(freque += 50, 300);
                    Console.WriteLine($"[ Отлично ]");
                }

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine($"[ Загрузка -- завершена ]");

                Console.Beep(100, 1000);

            }

            void badEnd()
            {
                Console.Clear();

                int freque = 50;

                for (int i = 0; i < repet; i++)
                {
                    Console.Beep(freque, 300);
                    Console.WriteLine($"[ Плохо ]");
                }

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine($"[ Загрузка -- прервана ]");

                Console.Beep(100, 1000);

            }
        }

        public static void BaseLoading()
        {
            int repet = 3;
            int repetSecond = 1000;

            string loadPoints = "";

            for (int i = 0; i < repet; i++)
            {
                System.Threading.Thread.Sleep(repetSecond);

                Console.Beep(300, repetSecond); // 300

                Console.Clear();

                string point = ".";

                if (loadPoints.Length == 3)
                {
                    loadPoints = ".";
                }
                else
                {
                    loadPoints += point;
                }

                Console.WriteLine($"[ Загрузка {loadPoints} ]");
            }

            Console.Clear();

            Console.WriteLine($"[ Загрузка -- завершена ]");

            Console.Beep(100, 1000);
        }

        public static void Command(string command)
        {

        }
    }
}