using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace ht_for_l6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region task1 
            //İstifadəçidən number formatlı dəyər daxil edilməsi istənilsin.
            // Daxil edilmiş dəyər qədər 0 - la 200 arasında ədəd generasiya olunsun və bu ədədlərin cəmi ekrana yazdırılsın.

            //var a= int.Parse(Console.ReadLine());
            //var s = 0;

            //for(int i = 0; i < a; i++)
            //{
            //    Random random = new Random();
            //    int rdn = random.Next(200);
            //    s = s + rdn;


            //}

            //Console.WriteLine(s);

            #endregion


            #region task2

            // 1-dən 20-ə kimi  ədədlərin kvadları cəmi ekrana yazdırılsın.
            //var s = 0; 

            //for(int i = 0; i < 20; i++)
            //{
            //    s = s + i*i;
            //}

            //Console.WriteLine(s);
            #endregion


            #region task3
            // Istifadəçidən number dəyər daxil edilməsi istənilsin. Daha sonra element sayı daxil edilmiş number olan int tipli array yaradılsın və istifadəçidən arrayin elementlərini daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini daxil etdikdən sonra arrayin max elementi ekrana yazdırılsın.


            //var a = int.Parse(Console.ReadLine());
            // int[] b = new int[a];

            // for(int i = 0; i < a; i++)
            // {
            //     b[i] = int.Parse(Console.ReadLine());
            // }

            // Console.WriteLine(b.Max());
            #endregion


            #region task4

            // 10 elementli array yaradılsın və element dəyərləri arrayi yaradarkən verilsin. Daha sonra arrayin minimum elementi ekrana yazdırılsın.

            //int [] b  =  { 0, 1, 2, 3, 4, 5, 6, 7, 8 , 9 };

            //Console.WriteLine(b.Min());

            #endregion

            #region task5
            // Istifadəçidən number dəyər daxil edilməsi istənilsin. Daha sonra element sayı daxil edilmiş number olan int tipli array yaradılsın və istifadəçidən arrayin elementlərini daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini daxil etdikdən sonra arrayin tək elementləri ekrana yazdırılsın.

            //var a =int.Parse(Console.ReadLine());
            //int[] b = new int[a];

            //for(int i = 0; i < a; i++)
            //{
            //    b[i] = int.Parse(Console.ReadLine());
            //}

            //foreach(var item in b)
            //{
            //    if(item%2==1)
            //        Console.WriteLine(item);
            //}
            #endregion


            #region task 6

            // Istifadəçidən number dəyər daxil edilməsi istənilsin. Daha sonra element sayı daxil edilmiş number olan int tipli array yaradılsın və istifadəçidən arrayin elementlərini daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini daxil etdikdən sonra hər bir elementin dəyəri 2misli ilə əvəz edilərək ekrana yazdırılsın.
            //var a = int.Parse(Console.ReadLine());
            //int[] b = new int[a];
            //var c = 0;
            //for (int i = 0; i < a; i++)
            //{
            //    b[i] = int.Parse(Console.ReadLine());
            //}

            //for(int i = 0; i < b.Length; i++)
            //{
            //    c=b[i];
            //    Console.WriteLine(c*2);
            //}


            #endregion



            #region task7


            //var a = int.Parse(Console.ReadLine());
            //string[] b =new string[a];

            //for(int i = 0; i < b.Length; i++)
            //{
            //    b[i] = Console.ReadLine();  
            //}

            //foreach(var item in b)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task8

            //6 elementli integer arrayi yaradılsın və istifadəçidən onun dəyərlərinin daxil edilməsi tələb edilsin. Daha sonra yaranmış arrayi artan sıra ilə düzüb ekrana yazın. (Array.Sort ilə yox, alqoritmi yazın).


            //int[] a = new int[6];
            //var t = 0;
            //for(var i = 0; i<6; i++)
            //{
            //    a[i]= int.Parse(Console.ReadLine());

            //}

            //for(var i = 0; i<6; i++)
            //{
            //for(var j = i+1; j<6; j++)
            //    {
            //        if (a[i] > a[j])
            //        {
            //            t=a[i];
            //            a[i]=a[j];
            //            a[j]=t;
            //        }
            //    }
            //}


            //for(var i = 0; i<6; i++)
            //{
            //    Console.WriteLine(a[i] + " ");
            //}


            #endregion

            #region task9

            //int a= int.Parse(Console.ReadLine());
            //int[] b = new int[a];
            //for (int i = 0; i < a; i++)
            //{
            //    b[i] = int.Parse(Console.ReadLine());
            //}

            //try
            //{    var c=int.Parse(Console.ReadLine());
            //    Console.WriteLine(b[c]);
            //}

            //catch(Exception e)
            //    {
            //    Console.WriteLine("Xeta bas verdi");
            //}



            #endregion


            #region task10
            //Istifadəçidən number tipli dəyər alınsın. Daha sonra uzunluğu həmən dəyər olan string array qurulsun və array-in elementlərini daxil etməsi istifadəçidən tələb edilsin. Array-in bütün elementləri daxil edildikdən sonra, array-in elementlərini ekrana yazdırın.


            //var a = int.Parse(Console.ReadLine());
            //int[] b = new int[a];

            //for(int i = 0; i < a; i++)
            //{
            //    b[i] = int.Parse(Console.ReadLine());   
            //}

            //foreach(var item in b) 
            //    Console.WriteLine(item);


            #endregion


            #region task11
            //string[] a = { "1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10" };
            //var b = Convert.ToString(a);
            //Console.WriteLine(b);
            //foreach(var item in a)
            //{
            //    Console.WriteLine(item);
            //}


            // bir lineda print etmey olmr 


            #endregion


            #region task12
            //var a = int.Parse(Console.ReadLine());
            //string[] b = new string[a];

            //for(int i = 0; i < a; i++)
            //{
            //    b[i] = Console.ReadLine();  
            //}

            //foreach(var item in b)
            //{
            //    Console.WriteLine(item + ",");
            //}

            // eyni problem


            #endregion



            #region task13

            //var a = int.Parse(Console.ReadLine());
            //string[] b = new string[a];

            //for (int i = 0; i < a; i++)
            //{
            //    b[i] = Console.ReadLine();
            //}

            //foreach(var item in b)
            //    Console.WriteLine(item);

            #endregion

        }

    }
}
