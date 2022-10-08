using System;
using System.Runtime.CompilerServices;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {
            //test1
            //test2
            #region
            //1
            /*  Console.WriteLine("eded daxil et ");
              int num = Convert.ToInt32(Console.ReadLine());

              Random rand = new Random();
              int num2 = rand.Next(200);
              Console.WriteLine(num2+num); */
            #endregion

            #region
            //2
            /* 
             int result = 0;

             for(int i = 1; i < 21; i++)
             {

                 result += i * i;


             }
               Console.WriteLine(result);  
            */

            #endregion

            #region
            //3
            /*
            for(int i = 0; i <101 ; i++)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region
            //4
            /*
            for(int i = 0; i <=100; i+=3)
            {
                
                Console.WriteLine(i);

            }
            */
            #endregion

            #region
            //5
            /*
            for (int i = 0; i <= 100; i++) 
                if (i != 36 && i != 67) Console.WriteLine(i);
            */
            #endregion

            #region
            //6
            /*
            for (int i = 0; i <= 100; i++)
                if (i == 17)
                {
                    Console.WriteLine("17 e bolunen ilk eded tapildi");
                    break;
                }
            */
            #endregion

            #region
            //7
            /*
            string str = "salam";
            for (int i=0; i<=100; i++)
            {
                Console.WriteLine(str + i);
            }
            */
            #endregion

            #region 
            //8
            /*
            for (int i = 100; i >=0; i--)
            {
                Console.WriteLine(i);

            }
            */
            #endregion

            #region
            //9
            /*
            Console.WriteLine(Math.Cbrt(27));
            Console.WriteLine(Math.Clamp(10,6,9));
            Console.WriteLine(Math.BigMul(9,4));
            Console.WriteLine(Math.CopySign(8,6));
            Console.WriteLine(Math.MaxMagnitude(6,5));
            */
            #endregion

            #region
            //10
            /*
            string str = null;
            var str1 = str ?? "test";
            Console.WriteLine(str1);
            */
            #endregion

            #region
            //11
            /*
            int number = Convert.ToInt32(Console.ReadLine());
            if (number==1)
            {
                Console.WriteLine("bir") ;
            }
            else if (number == 2)
            {
                Console.WriteLine("iki");
            }
            else if (number==3)
            {
                Console.WriteLine("uc");
            }
            else
            {
                Console.WriteLine("tapilmadi");
            }
            */
            #endregion

            #region
            //12
            /*
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("bir");
                    break;
                case 2:
                    Console.WriteLine("iki");
                    break;
                case 3:
                    Console.WriteLine("uc");
                    break;
                default:
                    Console.WriteLine("tapilmadi");
                    break ;
            }
            */
            #endregion

            #region 
            //13
            /*
           double? dbl = null;
           string tdbl = Convert.ToString(dbl);
           string result = tdbl ?? "nulldur";
           Console.WriteLine(result);
            */
            #endregion

            #region
            //14
            /*
            for (int i = 10; i <=300 ; i+=2)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region
            //15
            /*
            for (int i =200; i >=40 ; i-=12)
            {
                Console.WriteLine(i);   
            }
            */
            #endregion

            #region
            //16
            /*
            string str = Console.ReadLine();
            int a;
            var check= int.TryParse(str, out a);
            if (check == true)
            {
                Console.WriteLine("siz eded daxil etdiniz ");
            }
            else
            {
                Console.WriteLine("siz metn daxil etdiniz");
            }
            */
            #endregion



            Console.WriteLine("test"); 



            Console.ReadLine();
        }

    }
}
