using System;

namespace taprisig
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region t1

            var task1 = Console.ReadLine();
            Console.WriteLine(task1.TrimStart());

            #endregion


            #region t2

            var task2 = Console.ReadLine().ToLower();

            if (task2.Contains('e') && task2.Contains('q'))
            {
                Console.WriteLine("cannot enter e or q symbol");
            }

            else
            {
                Console.WriteLine(task2);
            }

            #endregion


            #region t3

            var task3 = Console.ReadLine();
            task3 = task3.Replace(" ", "").ToUpper();
            Console.WriteLine(task3);

            #endregion

            #region t4

            var task4 = Console.ReadLine();

            if (task4.Length >= 7)
            {
                Console.WriteLine(task4.Substring(2, 5));
            }

            else
            {
                Console.WriteLine("can not execute operation");
            }

            #endregion


            #region t5

            var task5 = Console.ReadLine();

            if (task5 == null || task5 == " ")
            {
                Console.WriteLine("value can not be empty or whitespace");
            }


            #endregion


            #region t6

            const string task6 = "salam";
            Console.WriteLine(task6);

            #endregion

            #region t7

            Random t7 = new Random();
            int task7 = t7.Next(100);

            Console.WriteLine(task7);
            #endregion


            #region t8

            Random t8 = new Random();
            var task8 = t8.Next(10, 2333);

            Console.WriteLine(task8);
            #endregion

            #region t9

            Guid t9 = Guid.NewGuid();

            Console.WriteLine(t9);
            #endregion


            #region t10

            var t10 = int.Parse(Console.ReadLine());

            if (t10 > 10)
            {
                Console.WriteLine("10dan boyuk");

            }
            else if (t10 < 10)
            {
                Console.Write("10dan kicik");
            }

            else
            {
                Console.WriteLine("10a beraber");
            }

            #endregion


            #region t11

            var t11 = Console.ReadLine();

            if (t11.Length > 6)
            {
                Console.WriteLine("6dan boyuk");
            }
            else if (t11.Length < 6)
            {
                Console.WriteLine("6dan kicik");
            }

            else
            {
                Console.WriteLine("6a beraber");
            }

            #endregion

            #region t12

            var t12 = int.Parse(Console.ReadLine());

            if (t12 == 6 || t12 == 7)
            {
                Console.WriteLine("duzgun cavab");
            }
            else
            {
                Console.WriteLine("yanlis cavab");
            }

            #endregion


            #region t13

            var t13 = int.Parse(Console.ReadLine());

            if (t13 > 20)
            {
                Console.WriteLine("netice tapilmadi");
            }

            else if (t13 >= 10)
            {
                Console.WriteLine("10-20 araligi");
            }

            else if (t13 >= 1)
            {
                Console.WriteLine("1-10araligi");
            }
            else
            {
                Console.WriteLine("netice tapilmadi");
            }

            #endregion



            #region t14

            var t14 = int.Parse(Console.ReadLine());

            if (t14 % 2 == 0)
            {
                Console.WriteLine("cut eded");
            }

            else
            {
                Console.WriteLine("tek eded");
            }

            #endregion


            #region t15

            Random t15 = new Random();
            int task15 = t15.Next(100);

            if (task15 > 50)
            {
                Console.WriteLine(task15);
            }
            else
            {
                Console.WriteLine("50den kicik eded");
            }

            #endregion


            #region t16

            var t16 = int.Parse(Console.ReadLine());

            var tc = t16 % 2 == 0 ? "cut eded" : "tek eded";

            Console.WriteLine(tc);
            #endregion



            #region t17 

            var t17 = Console.ReadLine();
            var t171 = t17.Substring(1);
            var t172 = t17.Substring(0, 1);

            if (t171.Contains('t') && t172.Contains('t'))
            {
                Console.WriteLine("birden cox t var");
            }
            else if (t171.Contains('t') || t172.Contains('t'))
            {
                Console.WriteLine("bir eded t var");
            }
            else
            {
                Console.WriteLine("t herfi yoxdur");
            }
            #endregion



            #region t17 st2

            var t170 = Console.ReadLine();

            if (t170.LastIndexOf('t') == t170.IndexOf('t'))
            {
                Console.WriteLine("tek t herfi var");
            }
            else
            {
                Console.WriteLine("Birden cox t var");
            }

            #endregion
        }
    }
}
