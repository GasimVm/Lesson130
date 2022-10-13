using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //1.İstifadəçidən number formatlı dəyər daxil edilməsi istənilsin.
            //Daxil edilmiş dəyər qədər 0 - la 200 arasında ədəd generasiya olunsun və bu ədədlərin cəmi ekrana yazdırılsın.
            /*  Console.WriteLine("loop daxil edin");
              int loop = Convert.ToInt32(Console.ReadLine());
              int result=0;
              for (int i = 1; i <= loop; i++)
              {
                  Random rdm = new Random();
                  int number = rdm.Next(0,200);
                  Console.WriteLine(number);
                  result += number;
              }
              Console.WriteLine($"ededler cemi - {result}"); */
            #endregion

            #region
            //2.1-dən 20-ə kimi  ədədlərin kvadları cəmi ekrana yazdırılsın.
            /*  int result = 0;
              for (int i = 1; i <=20; i++)
              {
                  result = result + (i*i);
              }
              Console.WriteLine(result); */
            #endregion

            #region
            //3.Istifadəçidən number dəyər daxil edilməsi istənilsin. Daha sonra element sayı daxil edilmiş number olan int tipli array yaradılsın və istifadəçidən arrayin elementlərini daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini daxil etdikdən sonra arrayin max elementi ekrana yazdırılsın.
            /*
            int range = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[range];
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine("elementleri daxil edin :");
                int arrElement= Convert.ToInt32(Console.ReadLine());
                array[i] = arrElement;
            }
            //Console.WriteLine(array.Max()); ve ya 
            int j = 0;
            for (int i = 0; i <array.Length ; i++)
            {
                if (array[j]>= array[i])
                {
                    continue;
                }
                else
                {
                    j= i;
                }
            }
            Console.WriteLine(array[j]); */
            #endregion

            #region
            //4.10 elementli array yaradılsın və element dəyərləri arrayi yaradarkən verilsin. Daha sonra arrayin minimum elementi ekrana yazdırılsın.
            /*
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(array.Min()); */
            #endregion

            #region
            //5.Istifadəçidən number dəyər daxil edilməsi istənilsin. Daha sonra element sayı daxil edilmiş number olan int tipli array yaradılsın və istifadəçidən arrayin elementlərini daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini daxil etdikdən sonra arrayin tək elementləri ekrana yazdırılsın.
            /*
            int range = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[range];
            for (int i = 0; i < range; i++)
            {
                int element= Convert.ToInt32(Console.ReadLine());
                array[i] = element;
            }
            /* foreach (int single in array)
             {
                 if(single%2==0)
                     continue;
                 else 
                     Console.WriteLine(single+"\n");
             } */
            //veya
            /*
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    continue;
                else
                    Console.WriteLine(array[i] + "\n");
            } */
            #endregion

            #region
            //6.Istifadəçidən number dəyər daxil edilməsi istənilsin. Daha sonra element sayı daxil edilmiş number olan int tipli array yaradılsın və istifadəçidən arrayin elementlərini daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini daxil etdikdən sonra hər bir elementin dəyəri 2misli ilə əvəz edilərək ekrana yazdırılsın.
            /*
            int range = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[range];
            for (int i = 0; i < range; i++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                array[i] = element;
            }
            for (int i = 0; i < range; i++)
            {
                array[i] *=2;
            }
            foreach (int dbl in array)
            {
                Console.WriteLine(dbl);
            } */
            #endregion

            #region 
            //8.6 elementli integer arrayi yaradılsın və istifadəçidən onun dəyərlərinin daxil edilməsi tələb edilsin. Daha sonra yaranmış arrayi artan sıra ilə düzüb ekrana yazın. (Array.Sort ilə yox, alqoritmi yazın).
            //????????????????????????????????????????/
            #endregion

            #region 
            //10.Istifadəçidən number tipli dəyər alınsın. Daha sonra uzunluğu həmən dəyər olan string array qurulsun və array-in elementlərini daxil etməsi istifadəçidən tələb edilsin. Array-in bütün elementləri daxil edildikdən sonra, array-in elementlərini ekrana yazdırın.
            /*
            int range = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[range];
            for (int i = 0; i < range; i++)
            {
                string element = Console.ReadLine();
                array[i] = element;
            }
            foreach (string el in array)
            {
                Console.WriteLine(el + ",");
            } */
            #endregion

            #region
            //11.string dəyər təyin edin və daxilində 1-dən 10-a kimi ədədlər aralarında boşluq işarəsi olmaqla yazılsın. (“1 2 3 …”) Daha sonra hər bir ədədi ekrana yazdırın. (yeni sətirdən, yəni Сonsole.WriteLine ilə)
            //serti basa dusmedim
            #endregion

            #region
            //12.string dəyər təyin edin və dövr operatoru istifadə edərək hər bir elementini ekrana yazdırın. Elementlər arasında vergül işarəsi istifadə edilsin.
            /*
            string txt = Console.ReadLine();
            for (int i = 0; i < txt.Length; i++)
            {
                char element;
                element = txt[i];
                Console.WriteLine(element + ",");
            } */
            #endregion
        }

    }
}