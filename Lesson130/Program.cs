using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace ht_for_l5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region task1

            // String equals-a aid nümunə yazın.

            //var t1 = Console.ReadLine().ToLower();
            //var t01 = Console.ReadLine().ToLower();
            //bool t02 = t1.Equals(t01);
            //Console.WriteLine(t02); 


            #endregion


            #region task2

            // String metodlarına aid nümunələr yazın.

            //var t2 = Console.ReadLine().Trim().ToLower().Substring(0, 2).IndexOf('a');
            //Console.WriteLine(t2);

            #endregion

            #region task3
            // Datatime-i müxtəlif formatlı stringlər şəklində ekrana yazdırın. (longDateString, longTimeString, shortDateString, shortTimeString, dd/MMM/yyyy hh:mm)

            //DateTime dt3 = DateTime.Now;
            //// var dtt3 = dt3.ToLongDateString; //  Error CS8773  Feature 'inferred delegate type' is not available in C# 9.0. Please use language version 10.0 or greater.	
            //var dttt3 = dt3.ToLongTimeString();
            //var dtttt3=dt3.ToString("dd MMM yyyy hh:mm");
            //Console.WriteLine(dt3);
            //Console.WriteLine(dttt3);
            //Console.WriteLine(dtttt3);


            #endregion

            #region task4
            //  İf, else if və else üçün nümunələr yazın.

            //var t4 = int.Parse(Console.ReadLine());
            //if (t4>0)
            //{
            //    Console.WriteLine("musbet eded");
            //}
            //else if (t4 < 0)
            //{
            //    Console.WriteLine("menfi eded");
            //}

            //else
            //{
            //    Console.WriteLine("0");
            //}

            #endregion


            #region task5


            // Switch operatoru üçün nümunə yazın.

            //var t5 = int.Parse(Console.ReadLine());

            //switch (t5)
            //{
            //    case 0:
            //        Console.WriteLine("1ci duz cavab");
            //        break;


            //    case 1:
            //        Console.WriteLine("2-ci dyz cavab");
            //        break;

            //    default:
            //        Console.WriteLine("sehv cavab");
            //        break ;
            //}

            #endregion


            #region task6

            //Break və continue üçün nümunə yazın. 
            //var t6 = int.Parse(Console.ReadLine());
            //for (int i = 1; i < t6; i++)
            //{

            //    if (i % 10 != 0)
            //    {
            //        Console.WriteLine($"Yuvarlag olmayan eded: {i}");
            //        continue;
            //    }

            //    else if (i % 50 == 0)
            //    {
            //        Console.WriteLine($"50e bolunen ilk eded: {i}");
            //        break;
            //    }

            //}


            #endregion


            #region task7


            ////For üçün nümunə yazın. 
            //for(int i = 0; i < 100; i+=3)
            //    Console.WriteLine(i);

            #endregion


            #region task8

            //While üçün nümunə yazın
            //int a;
            //var t8 = int.Parse(Console.ReadLine());
            //while (t8 > 0)
            //{
            //    a= t8 % 10;
            //    Console.WriteLine(a);
            //    t8 = t8 / 10;
            //}

            #endregion

            #region task9

            //var t10=int.Parse(Console.ReadLine());
            // do
            // {
            //     t10--;
            //     Console.WriteLine(t10);
            // }
            // while (t10 > 10);




            #endregion


            #region task10-11
            //Converting və parsing üçün nümunə yazın.
            // Tryparse üçün nümunə yazın.
            //var a =Console.ReadLine();
            //var a1 = Convert.ToInt32(a);
            //var a2 = int.Parse(a);
            //var a3 = int.TryParse(a, out a1);
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a3);



            #endregion

            #region task12

            // İstifadəçidən alınmış string dəyəri tərsinə yazdırın.

            #endregion

            #region task13
            //var s = 0;
            //var t13 =int.Parse(Console.ReadLine());
            //var tyedek = t13;
            //int t013;

            //while (t13 > 0)
            //{
            //    t013 = t13 % 10;
            //    s = s * 10 + t013;
            //    t13 = t13 / 10;
            //}

            //if (tyedek == s)
            //{
            //    Console.WriteLine("polindrom");
            //}
            //else
            //{
            //    Console.WriteLine("not polindrom");
            //}




            #endregion

            #region task14
            //Istidadəçidən int dəyər daxil etməsi istənilsin. Daxil edilmiş ədədin sadə və ya mürəkkəb olduğunu tapın.
            //var a = int.Parse(Console.ReadLine());
            //for (int i = 2; i < a; i++)
            //{

            //    if (a % i == 0)
            //    {
            //        Console.WriteLine("murekkeb eded");
            //        break;
            //    }
            //    else if (i == a-1)
            //    {
            //        Console.WriteLine("sade eded");
            //    }

            //}




            #endregion


            #region task15

            // Istidadəçidən int dəyər daxil etməsi istənilsin. Daxil edilmiş ədədin bölənlərini ekrana yazdırın.
            //var a= int.Parse(Console.ReadLine());

            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion


            #region task 16
            //10 iterasiyalı dövr daxilində istifadəçidən number daxil etməsini istəyin. İterasiyanın sonunda daxil edilmiş ən böyük ədəd ekrana yazdırılsın.
            //var a = int.Parse(Console.ReadLine());

            //for (int i = 0; i < a; i+=10)
            //{
            //    if (i + 10 >= a)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region task1
            //Random r = new Random();
            //int m = r.Next(100);
            //Console.WriteLine(m);

            //var a = int.Parse(Console.ReadLine());

            //for (int i = 1; i < a; i++)
            //{

            //    Random random = new Random();
            //    int rdn = random.Next(100);
            //    Console.WriteLine(rdn);
            //    if (m > rdn)
            //    {
            //        m = rdn;

            //    }


            //}
            //Console.WriteLine($"en kicik random eded {m}");

            #endregion

            #region task2

            //Random r = new Random();
            //int m = r.Next(100);
            //Console.WriteLine(m);

            //var a = int.Parse(Console.ReadLine());

            //for (int i = 1; i < a; i++)
            //{

            //    Random random = new Random();
            //    int rdn = random.Next(100);
            //    Console.WriteLine(rdn);
            //    if (m < rdn)
            //    {
            //        m = rdn;

            //    }


            //}
            //Console.WriteLine($"en boyuk random eded {m}");

            #endregion

            #region task3
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin. Daha sonra həmən sayda random ədəd generasiya edilsin və ədədlərin 2 mislinin cəmini hesablayın.
            //int s = 0;
            //var a=int.Parse(Console.ReadLine());

            //for(int i=0; i<a; i++)
            //{
            //    Random r = new Random();
            //    int r1 = r.Next(100);
            //    Console.WriteLine(r1);
            //    s = s + r1;
            //}
            //Console.WriteLine(2*s);

            #endregion

            #region task4

            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin. Daha sonra həmən sayda 0-100 arası random ədəd generasiya edilsin və ədədlər içərisində 3-ə və 5-ə bölünənlərin hasilini tapın.

            //int s = 1;
            //var a=int.Parse(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Random r = new Random();
            //    int r1 =r.Next(100);
            //    Console.WriteLine(r1);
            //    if (r1 % 15 == 0)
            //    {
            //        s = s * r1;
            //    }
            //} Console.WriteLine(s);
            #endregion

            #region task5

            // İstifadəçidən string dəyər daxil edilməsi tələb edilsin. Bu proses istifadəçi polindrom ədəd daxil edənə kimi davam etsin.
            int s = 0;
            var a = int.Parse(Console.ReadLine());
            var b = a;
            while (a > 0)
            {
                s = s * 10 + a % 10;
                a = a / 10;

            }





            #endregion



            #region task6

            // 0 - dan 100 - ə kimi ədədlərin ekrana yazdırın. İlk 22 - ə bölünən ədədlər ekrana yazdırılmasın. Bunu continue ilə həll edin.
            //for(int i = 0; i < 100; i++)
            //{
            //    if(i%22!=0)
            //        Console.WriteLine(i);
            //    continue;
            //}
            #endregion

            #region task7
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin. Daha sonra istifadəçidən həmən sayda string daxil etməsi istənilsin və sonda stringlərin uzunluqları cəmini ekrana yazdırın.
            //var a = int.Parse(Console.ReadLine());
            //var s = 0;
            //for (int i=0; i<a; i++) 
            //{
            //    var b =Console.ReadLine();
            //    s = s + b.Length;
            //}
            //Console.WriteLine(s);

            #endregion

            #region task8
            //String format və interpolationa aid nümunələr yazın.




            #endregion

            #region task9

            // İstifadəçinin daxil etdiyi dəyərin int olub-olmadığını yoxlayın.
            //var a =Console.ReadLine();
            //int b ;
            //var str = int.TryParse(a, out b);
            //Console.WriteLine(str);

            #endregion


            #region task10

            // İstifadəçidən alınmış inputu int-ə çevirin və ekrana yazdırın. Növbəti sətirlərdə isə proqramda xəta olub-olmamasından asılı olmayaraq ekrana “Hello world” yazdırılsın.
            //var a = Console.ReadLine();
            //int b;
            //var str = int.TryParse(a, out b);
            //if (str)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("stringi cevirmek mumkun deil");
            //}
            //Console.WriteLine("Hello World");


            #endregion


            #region task11

            //var a = int.Parse(Console.ReadLine());
            //var b = int.Parse(Console.ReadLine());

            //try
            //{
            //   a = a / b;
            //    Console.WriteLine(a);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("xeta bas verdi");
            //}
            //finally
            //{
            //    Console.WriteLine("kodun sonu");   
            //}

            #endregion


            #region task17

            //İstifadəçidən ədəd daxil etməsini tələb edin və daha sonra ədədin rəqəmlərini ayrı-ayrılıqda ekrana yazdırın. (məsələn: 45232 -> 4 5 2 3 2)

            //var a = int.Parse(Console.ReadLine());

            //int b;

            //while (a>0)
            //{
            //    b = a % 10;
            //    Console.WriteLine(b);

            //    a = a / 10;

            //}



            #endregion
        }
    }
}

