using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

using Toolkit;
using Mining;
using Store;

namespace ConsoleAppProject
{
    class Program
    {
        public static decimal UserCash = 150;
        public static decimal UserMineCash = 0;
        public static int UserFarms = 0;
        public static Dictionary<int, string> Сart = new Dictionary<int, string>()
        {
            [0] = "Ферма",
        };

        static void Main()
        {
            string[] messages = {
                "Приложение успешно запущено...",
                "Вас приветствует умный помошник по уровлению",
                "Для продолжения войдите в аккаунт"
            };

            Shop.Want(UserCash);
        }
    }
}

namespace Mining    
{
    public static class Statistics
    {
        public static void Money(decimal income, decimal cash)
        {
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine();
            Console.WriteLine($"У вас: {income} YTC и ${cash}");
            Console.WriteLine();
            Console.WriteLine("====================");
        }
    }

    public static class Mine
    {
        public static void Start(ref decimal cash, int farms)
        {
            if (farms <= 0)
            {
                BedEnd("отсутствуют майнинговые установки");
            }
            else
            {
                GoodEnd();
            }

            void BedEnd(string reason)
            {
                Console.WriteLine();
                Console.WriteLine("==================================");
                Console.WriteLine();
                Console.WriteLine($"[ Майнинговая ферма - не запущена ]");
                Console.WriteLine($"[ Причина - {reason} ]");
                Console.WriteLine();
                Console.WriteLine("==================================");
            }

            void GoodEnd()
            {
                Console.WriteLine();
                Console.WriteLine("==================================");
                Console.WriteLine();
                Console.WriteLine($"[ Майнинговая ферма - запущенна ]");
                Console.WriteLine();
                Console.WriteLine("==================================");
            }
        }
    }
}


