using System;
using System.Linq;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            // Istifadəçidən array daxil edilməsi tələb edilsin.
            // Daha sonra array elementlərinə random olaraq yalnız
            // tək ədədlər verilsin. Proqramın sonunda yaranmış
            // massivin elementlərini  ekrana yazdırın.

            //Console.WriteLine("Arrayin uzunlugunu daxil edin : ");
            //int[] array = new int[int.Parse(Console.ReadLine())];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int a = random.Next(200);
            //    if (a % 2 == 1)
            //    {
            //        array[i] = a;
            //    }
            //    else
            //        array[i] = a + 1;
            //}
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 2
            // Array təyin edin, elementlərini əlavə edin və minimum elementini ekrana yazdırın.

            //int[] array = new int[5] { 78, 105, 56, 23, 45 };
            //////Console.WriteLine(array.Min());  //hazir metod
            //int min = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}
            //Console.WriteLine($"En kicik eded : {min}");

            #endregion
            #region Task 3
            // Istifadəçidən number dəyər daxil edilməsi istənilsin və
            // element sayı daxil edilmiş integer olan array yaradılsın.
            // Daha sonra həmən elementin minimum və maximum
            // elementlərinin hasili ekrana yazdırılsın.

            //Console.WriteLine("Arrayin uzunlugunu daxil edin : ");
            //int[] array = new int[int.Parse(Console.ReadLine())];

            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(100);
            //    Console.WriteLine($"{i}ci eded : {array[i]}");
            //}
            //int min = array[0];
            //int max = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    else if(min > array[i])
            //        min = array[i];
            //}
            //Console.WriteLine($"Minimum ve maksimumun hasili : {min * max}");

            //////Console.WriteLine(array.Max() * array.Min()); //// Hazir metod

            #endregion
            #region Task 4
            //10 elementdən ibarət massiv yaradılsın və elementləri set edilsin.
            //Daha sonra həmən massivi azalan sırada ekrana yazdırın.

            //int[] array = new int[10];
            //Random random = new Random();
            //int temp = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(200);
            //}
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] < array[j])
            //        {
            //            temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //// hazir metod ////
            //////Array.Sort(array);
            //////Array.Reverse(array);


            #endregion
            #region Task 5
            // Array təyin edin və elementlərinə dəyər verin.
            // Daha sonra arrayin 1-ci və sonuncu elementlərinin hasilini ekrana yazdırın.

            //int[] array = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(array[0] * array[array.Length - 1]);

            #endregion
            #region Task 6
            //String dəyər təyin edin. Daha sonra 5 iterasiyalı dövr qurun və
            //hər iterasiyada istifadəçidən dəyər daxil etməsini tələb edin.
            //İstifadəçinin daxil etdiyi hər dəyəri string-ə əlavə edin
            //(arxasında boşluq işarəsi qoymaqla). İstifadəçi 5 dəyərin 5ni
            //də daxil etdikdən sonra string split funksiyasında istifadə edərək
            //əldə edilmiş string dəyərindən string arrayi yaradın ekrana ekrana yazdırın.

            //string deyer = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("String deyer daxil edin : ");
            //    deyer += " " + Console.ReadLine();
            //}
            //string[] array = deyer.Split();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region task 7
            //array təyin edilsin və elementləri 0-100 arası random ədədlər olsun.
            //Daha sonra arrayın cüt elementlərinin ədədi ortasını tapın.

            //try
            //{
            //    Random random = new Random();
            //    int cutElementCem = 0;
            //    int cutElementSay = 0;
            //    int[] array = new int[6];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        array[i] = random.Next(100);
            //        Console.WriteLine($"Arrayin {i}-ci elementi : " + array[i]);
            //    }
            //    Console.WriteLine("Cüt elementler :");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % 2 == 0)
            //        {
            //            cutElementCem += array[i];
            //            cutElementSay++;
            //            Console.WriteLine(array[i]);
            //        }
            //    }
            //    Console.WriteLine("Ededi orta : " + cutElementCem / cutElementSay);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Random generatoru butun reqemleri tek verdi.. Yeniden cehd edin.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion
            #region Task 8
            //Math funksiyalarına aid nümunələr yazın.

            //Console.WriteLine(Math.Truncate(6.95)); // kesr hisseni atib verir
            //Console.WriteLine(Math.Clamp(10, 5, 15)); // birinci verilen eded araliqdadisa
            // ededi yox eger deyilse,
            // serhedlerden hansina yaxindisa onu verir.
            //Console.WriteLine(Math.Abs(-6)); // modul
            //Console.WriteLine(Math.BitDecrement(55)); // axirin .999999999999 edir
            //Console.WriteLine(Math.Cbrt(27)); // 3cu dereceden kok alir
            //Console.WriteLine(Math.CopySign(4.5, -5)); // ikincinin isharesin birinciye verir
            //Console.WriteLine(Math.Pow(2, 5)); // 2 ustu 5
            //Console.WriteLine(Math.Round(5.5)); // yuvarlaqlasdirma riyazdaki kimi

            #endregion
            #region task 9
            //String metodlarına aid nümunələr yazın.

            //string a = " nurlan ";
            //Console.WriteLine(a.Length);
            //a = a.Replace('n', 'a').ToUpper();
            //Console.WriteLine(a);
            //Console.WriteLine(a.Max());
            //a = a.Substring(1, 3);
            //Console.WriteLine(a);
            //a.ToCharArray();
            //foreach (var item in a)
            //    Console.WriteLine(item);
            //a.TrimStart();
            //Console.WriteLine(a);

            #endregion
            #region task 10
            // arrayin max və min elementlərinin hasilini tapın.

            //int[] array = { 4, 8, 95, 5, 9, 65, 94, 4, 5 };
            //int min = array[0], max = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //        max = array[i];
            //    else if (array[i] < min)
            //        min = array[i];
            //}
            //Console.WriteLine($"Maksimum element : {max}, Minimum element : {min}" + "\n" +
            //    $"{max} * {min} = {max * min}");

            #endregion
            #region Task 11
            //  arrayin  elementlərinin ədədi ortasını tapın.

            //int[] array = { 40, 10, 29, 21 };
            //int cem = 0;
            //Console.WriteLine("Arrayin elementleri :");
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    cem += array[i];
            //}
            //Console.WriteLine($"Ededi orta : {cem} / {array.Length} = {cem/array.Length}");

            //////int b = (int)array.Average(); // hazir metod

            #endregion
            #region Task 12
            //5(45623) reqemli eded verilib,ededin tek reqemlerin cemini ve hasilini tapin

            //int eded = 45623, qaliq = 0, cem = 0, hasil = 1;
            //while (eded > 0)
            //{
            //    qaliq = eded % 10;
            //    if (qaliq % 2 == 1)
            //    {
            //        cem += qaliq;
            //        hasil *= qaliq;
            //    }
            //    eded = eded / 10;
            //}
            //Console.WriteLine($"Cemi : {cem}, Hasili : {hasil}");

            #endregion
            #region Task 13
            //int[] array = new int[7] { 5, 9, 0, 45,6,78,7 } max min elementlerin cemini tapin.

            //int[] array = new int[7] { 5, 9, 0, 45, 6, 78, 7 };
            //int min = array[0], max = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    else if (min > array[i])
            //        min = array[i];
            //}
            //Console.WriteLine($"Maksimum : {max}, Minimum : {min}" + "\n"
            //    + $"Cemi : {max + min}");

            #endregion
            #region Task 14
            //int[] array = new int[7] { 5, 9, 0, 45,6,78,7 } artan sira ile siralayin.

            //int[] array = new int[7] { 5, 9, 0, 45, 6, 78, 7 };
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
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 15
            //Dördrəqəmli tam ədəd verilmişdir. Ədədin bütün rəqəmlərinin fərqli olub olmadığını müəyyənləşdirin.

            //Console.WriteLine("4 Reqemli eded daxil edin :");
            //int eded = int.Parse(Console.ReadLine());
            //int qaliq = 0;
            //int[] array = new int[4];
            //int test = 0;
            //qaliq = eded % 10;
            //array[0] = qaliq;
            //eded = eded / 10;
            //for (int i = 1; i < 4; i++)
            //{
            //    qaliq = eded % 10;
            //    array[i] = qaliq;
            //    if (array[i] == array[i - 1])
            //    {
            //        test++;
            //    }
            //    eded = eded / 10;
            //}
            //if (array[0] == array[1] && array[1] != array[2] && array[2] == array[3])
            //{
            //    Console.WriteLine("1ci ile 2ci , 3cu ile 4cu reqem eynidi");
            //}
            //else if (array[0] != array[1] && array[1] == array[2] && array[2] != array[3])
            //    Console.WriteLine("1ci ile 4cu , 2ci ile 3cu reqem eynidi");
            //else
            //Console.WriteLine(test == 0 ? "Butun reqemler ferqlidi" : test + 1 == 4 ? "Butun reqemleri eynidi" :
            //    $"Eyni reqemlerin sayi :{test + 1}");

            #endregion
            #region Task 16
            //Dördrəqəmli tam ədəd verilmişdir. Rəqəmdə 3 rəqəminin olub olmadığını müəyyənləşdirin.

            //Console.WriteLine("4 Reqemli eded daxil edin : ");
            //int reqem = int.Parse(Console.ReadLine());
            //int qaliq = 0, three = 0;
            //while (reqem > 0)
            //{
            //    qaliq = reqem % 10;
            //    if (qaliq == 3)
            //    {
            //        three += qaliq;
            //        break;
            //        ////reqem = (int)Math.CopySign(reqem, -1); // dovru dayandirmaq uchun
            //    }
            //    reqem /= 10;
            //}
            //Console.WriteLine(three == 3 ? "3 var" : "3 yoxdur");

            #endregion

        }

    }
}
