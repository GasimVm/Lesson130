using System;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {
             //test2

            #region t1

            Random task1 = new Random();
            int task1int = task1.Next(200);
            int countask1 = 0;
            for (int t1 = 0; t1 < task1int; t1++)
            {
                countask1 = countask1 + t1;

            }
            Console.WriteLine(task1int);
            Console.WriteLine(countask1);


            #endregion




            #region t2


            var task2 = 0;
            for (int t2 = 0; t2 < 21; t2++)
            {
                task2 = task2 + t2 * t2;
            }
            Console.WriteLine(task2);

            #endregion



            #region t3

            for (int t3 = 0; t3 < 101; t3++)
            {
                Console.WriteLine(t3);
            }
            #endregion



            #region t4 

            for (int t4 = 0; t4 < 101; t4++)
            {

                if (t4 % 3 == 0)
                {
                    Console.WriteLine(t4);
                }

            }



            #endregion


            #region t5

            for (int t5 = 0; t5 < 101; t5++)
            {

                if (t5 != 36 && t5 != 67)
                {
                    Console.WriteLine(t5);
                }
            }

            #endregion


            #region t6

            for (int t6 = 1; t6 < 101; t6++)
            {
                Console.WriteLine(t6);
                if (t6 % 17 == 0 && t6 < 18)
                {
                    Console.WriteLine("17e bolunen ilk eded tapildi");

                }
            }
            #endregion

            #region t7

            //serti basa dusmedim hec
            #endregion


            #region t8

            for (int t7 = 100; t7 > 0; t7--)
            {

                Console.WriteLine(t7);
            }

            #endregion

            #region t9

            var t91 = Convert.ToDouble(Console.ReadLine());
            var t92 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quvvet ustu");
            Console.WriteLine(Math.Pow(t91, t92));

            Console.WriteLine("Minimum");
            Console.WriteLine(Math.Min(t91, t92));

            Console.WriteLine("Maximum");
            Console.WriteLine(Math.Max(t91, t92));

            Console.WriteLine("modul");
            Console.WriteLine(Math.Abs(t91));

            Console.WriteLine("kokalti");
            Console.WriteLine(Math.Sqrt(t92));

            Console.WriteLine("yuvarlaglasdirma");
            Console.WriteLine(Math.Round(t91));
            //cevirmir bu ve asagidaki

            Console.WriteLine("asagi yuvarlaglasdirma");
            Console.WriteLine(Math.Floor(t92));

            #endregion

            #region t10

            string name = Console.ReadLine();
            string t10 = Console.ReadLine();

            if (name == null)
            {
                t10 = "test";
                Console.WriteLine(t10);
            }

            else
            {
                t10 = name;
                Console.WriteLine(t10);
            }

            #endregion



            #region t11

            var t11 = int.Parse(Console.ReadLine());

            switch (t11)
            {
                case 1:
                    Console.WriteLine(t11);

                    break;

                case 2:
                    Console.WriteLine(t11);

                    break;

                case 3:
                    Console.WriteLine(t11);

                    break;
                default:
                    Console.WriteLine("netice tapilmadi");
                    break;
            }


            #endregion




            #region t12

            var t121 = int.Parse(Console.ReadLine());
            var t122 = int.Parse(Console.ReadLine());
            var t123 = Console.ReadLine();

            switch (t123)
            {

                case "+":
                    Console.WriteLine(t121 + t122);
                    break;

                case "*":
                    Console.WriteLine(t121 * t122);
                    break;

                case "-":
                    Console.WriteLine(t121 - t122);
                    break;
                case "/":
                    Console.WriteLine(t121 / t122);
                    break;
                default:
                    Console.WriteLine(" ancag + * - / islede bilersiniz");
                    break;

            }

            #endregion



            #region t13

            double? t13 = Convert.ToDouble(Console.ReadLine());

            if (t13 == null)
            {
                Console.WriteLine("nulldur");
            }
            else
            {
                Console.WriteLine(t13);
            }
            #endregion

            #region t14

            for (int t14 = 10; t14 <= 300; t14 += 2)
            {
                Console.WriteLine(t14);
            }

            #endregion


            #region t15

            for (int t15 = 200; t15 >= 40; t15 -= 12)
            {
                Console.WriteLine(t15);
            }


            #endregion


            #region t16

            var t160 = Console.ReadLine();
            int t16 = 0;

            bool t161 = int.TryParse(t160, out t16);

            if (t161)
            {
                Console.WriteLine("siz eded daxil etdiniz");
            }
            else
            {
                Console.WriteLine("siz soz daxil etdiniz");
            }



            #endregion

        }


    }
}
