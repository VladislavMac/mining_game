using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolkit;

namespace Store
{
    public class Product
    {
        public int Id;
        public string Title;
        public decimal Price;
        public decimal Income;

        public Product(int id, string title, decimal price, decimal income)
        {
            Id = id;
            Title = title;
            Price = price;
            Income = income;
        }
    }

    public static class Shop
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(1, "Майнинговая ферма", 50, 0.000000165343m),
        };

        public static void Want(decimal userCash, Dictionary<Product, int> userCart)
        {
            start();
            void start()
            {
                Console.Title = "Магsазин 'FarmStore'";
                Console.Clear();
                Console.WriteLine(" ==================================");
                Console.WriteLine();
                Console.WriteLine($" Добро пожаловать в 'FarmStore' ");
                Console.WriteLine();
                Console.WriteLine($" Вот список нашей продукции по актуальным ценам: ");

                foreach (Product product in Products)
                {
                    Console.WriteLine($"\t{product.Id}. {product.Title} - ${product.Price}, доход - {product.Income} YTC ");
                }

                Console.WriteLine();
                Console.WriteLine(" ==================================");
                Console.WriteLine();

                Console.WriteLine($" Для выхода введите /exit");
                Console.WriteLine($" Введите номер желаемой продукции:");

                trySetCart();
            }

            void trySetCart()
            {
                string input = User.Input();

                if (int.TryParse(input, out int result))
                {
                    foreach (Product product in Products)
                    {
                        if (result == product.Id)
                        {
                            Console.WriteLine($" Введите количество желаемой продукции:");
                            input = User.Input();

                            if (int.TryParse(input, out int many))
                            {
                                if (many * product.Price <= userCash && many > 0)
                                {
                                    if(userCart.ContainsKey(product))
                                    {
                                        userCart[product] = userCart[product] + many;
                                    }
                                    else
                                    {
                                        userCart.Add(product, many);
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine(" ==================================");
                                    Console.WriteLine();
                                    Console.WriteLine($" В вашу корзину добавлено:");
                                    Console.WriteLine();
                                    Console.WriteLine($"\tПродукт - {product.Title}");
                                    Console.WriteLine($"\tКоличество - {many} ");
                                    Console.WriteLine();
                                    Console.WriteLine(" ==================================");

                                    Console.WriteLine($" Для выхода введите: /exit");
                                    Console.WriteLine($" Для оформления покупки введите: /shop_buy");

                                    // !!!!!!!!!!!!!!!!!!!!!! ТУТ ДОЛЖЕН БЫТЬ МЕТОД РОБОТЫ ИГРОКА С КОММАНДНОЙ СТРОКОЙ!!! !!!!!!!!!!!!!!!!!!!!!!!
                                }
                                else if (many <= 0)
                                {
                                    Console.WriteLine($" [ Совсем дурак? ]");
                                    User.Wait();

                                    start();
                                }
                                else
                                {
                                    Console.WriteLine($" [ Недостаточно $ на балансе - попробуйте ещё раз ]");
                                    User.Wait();

                                    start();
                                }
                            }
                            else if (input == "/exit")
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine($" [ Некорректное значение - попробуйте ещё раз ]");
                                User.Wait();

                                start();
                            }

                            Console.WriteLine(result);
                        }
                        else if (input == "/exit")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"[ Номер продукта не найден - попробуйте ещё раз ]");
                            User.Wait();

                            start();
                        }
                    }
                }
                else if (input == "/exit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine($"[ Неизвестная команда - попробуйте ещё раз ]");
                    User.Wait();

                    start();
                }
            }
        }

        public static void Buy(decimal cash)
        {

        }

        public static void Check()
        {

        }
    }

}