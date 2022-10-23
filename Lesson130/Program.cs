using System;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1

            //İstifadəçidən number formatlı dəyər daxil edilməsi istənilsin.
            //Daxil edilmiş dəyər qədər 0 - la 200 arasında ədəd generasiya olunsun
            //və bu ədədlərin cəmi ekrana yazdırılsın.

            //Console.WriteLine("Reqem formatli deyer daxil edin : ");
            //int dovrlerinSayi = int.Parse(Console.ReadLine());

            //Random rand = new Random();
            //int randNum = 0;
            //int cemi = 0;
            //for (int i = 1; i <= dovrlerinSayi; i++)
            //{
            //    randNum = rand.Next(200);
            //    Console.WriteLine($"{i}-ci eded : {randNum}");
            //    cemi += randNum;
            //}
            //Console.WriteLine("Ededlerin cemi : " + cemi);

            #endregion
            #region Task 2
            //1-dən 20-ə kimi  ədədlərin kvadları cəmi ekrana yazdırılsın.

            //double cem = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine($"{i}-ci eded {i}, kvadrati : {Math.Pow(i, 2)}");
            //    cem += Math.Pow(i, 2);
            //}
            //Console.WriteLine($"Cemi : {cem}");

            #endregion
            #region Task 3

            //Istifadəçidən number dəyər daxil edilməsi istənilsin.
            //Daha sonra element sayı daxil edilmiş number olan int
            //tipli array yaradılsın və istifadəçidən arrayin elementlərini
            //daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini
            //daxil etdikdən sonra arrayin max elementi ekrana yazdırılsın.

            //Console.WriteLine("Reqem tipli deyer daxil edin : ");
            //int deyer = int.Parse(Console.ReadLine());

            //int[] array = new int[deyer];
            //for (int i = 0; i < deyer; i++)
            //{
            //    Console.WriteLine($"Arrayin {i}-ci indexdeki elementini daxil edin");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int max = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //}
            //Console.WriteLine("Maksimum element : {0}", max); //Hazir metod : array.Max

            #endregion
            #region Task 4
            //10 elementli array yaradılsın və element dəyərləri arrayi
            //yaradarkən verilsin. Daha sonra arrayin minimum elementi ekrana yazdırılsın.

            //int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //int min = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}
            //Console.WriteLine("Minimum element : {0}", min);

            #endregion
            #region Task 5
            //Istifadəçidən number dəyər daxil edilməsi istənilsin.
            //Daha sonra element sayı daxil edilmiş number olan int
            //tipli array yaradılsın və istifadəçidən arrayin elementlərini
            //daxil etməsi tələb olunsun. İstifadəçi arrayin bütün
            //elementlərini daxil etdikdən sonra arrayin tək elementləri ekrana yazdırılsın.

            //Console.WriteLine("Reqem daxil edin : ");
            //int reqem = int.Parse(Console.ReadLine());

            //int[] array = new int[reqem];

            //for (int i = 0; i < reqem; i++)
            //{
            //    Console.WriteLine("Arrayin elementini daxil edin : ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (var item in array)
            //{
            //    if (item % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 6
            //Istifadəçidən number dəyər daxil edilməsi istənilsin.
            //Daha sonra element sayı daxil edilmiş number olan int
            //tipli array yaradılsın və istifadəçidən arrayin elementlərini
            //daxil etməsi tələb olunsun. İstifadəçi arrayin bütün elementlərini
            //daxil etdikdən sonra hər bir elementin dəyəri 2misli ilə əvəz edilərək ekrana yazdırılsın.

            //Console.WriteLine("Reqem daxil edin : ");
            //int reqem = int.Parse(Console.ReadLine());

            //int[] array = new int[reqem];

            //for (int i = 0; i < reqem; i++)
            //{
            //    Console.WriteLine("Arrayin elementini daxil edin : ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item*2);
            //}

            #endregion
            #region Task 7
            //Foreach istifadə edərək string arrayi ekrana yazdırılsın.

            //string[] array = new string[2] {"Nurlan","Khankishiyev"};
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 8
            //6 elementli integer arrayi yaradılsın və istifadəçidən
            //onun dəyərlərinin daxil edilməsi tələb edilsin. Daha sonra
            //yaranmış arrayi artan sıra ilə düzüb ekrana yazın. (Array.Sort ilə yox, alqoritmi yazın).

            //int[] array = new int[6];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Arrayin {i}-ci indexindeki elementini daxil edin : ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //int temp = 0;
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Artan sira ...");
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 9
            //Try catch üçün nümunə yazın.

            //try
            //{
            //    int a = 0;
            //    int b = 51;
            //    int c = b / a;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion
            #region Task 10
            // Istifadəçidən number tipli dəyər alınsın.
            // Daha sonra uzunluğu həmən dəyər olan string array qurulsun
            // və array-in elementlərini daxil etməsi istifadəçidən tələb edilsin.
            // Array-in bütün elementləri daxil edildikdən sonra, array-in elementlərini ekrana yazdırın.

            //Console.WriteLine("Reqem daxil edin : ");
            //int reqem = int.Parse(Console.ReadLine());

            //string[] array = new string[reqem];

            //for (int i = 0; i < reqem; i++)
            //{
            //    Console.WriteLine($"{i}-ci elementi daxil edin :");
            //    array[i] = Console.ReadLine();
            //}
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 11
            // String dəyər təyin edin və daxilində 1-dən 10-a kimi
            //ədədlər aralarında boşluq işarəsi olmaqla yazılsın.
            //(“1 2 3 …”) Daha sonra hər bir ədədi ekrana yazdırın.
            //(yeni sətirdən, yəni Сonsole.WriteLine ilə)

            //string a = "1 2 3 4 5 6 7 8 9 10";
            //char[] b = a.ToCharArray();
            //foreach (var item in b)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 12
            // String dəyər təyin edin və dövr operatoru istifadə edərək
            //hər bir elementini ekrana yazdırın. Elementlər arasında vergül işarəsi istifadə edilsin.

            //string name = "Nurlan";
            //char[] divideName = name.ToCharArray();
            //foreach (var item in divideName)
            //{
            //    Console.Write(item + ",");
            //}

            #endregion
            #region Task 13
            // string-i foreach ilə ekrana yazdırın.

            //string name = "Nurlan";
            //char[] divideName = name.ToCharArray();
            //foreach (var item in divideName)
            //{
            //    Console.Write(item);
            //}

            #endregion

        }
    }
}
