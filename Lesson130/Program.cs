using System;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            // Istifadəçidən   array   daxil edilməsi tələb edilsin.
            // Daha sonra array  elementlərinə random olaraq yalnız
            // tək ədədlər verilsin. Proqramın sonunda yaranmış
            // massivin elementlərini   ekrana yazdırın.

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

            //int[] array = new int[5] {78,105,56,23,45};
            ////Console.WriteLine(array.Min());  //hazir metod
            ////int min = 0;
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
            #region Task 3 ???
            // Istifadəçidən number dəyər daxil edilməsi istənilsin və
            // element sayı daxil edilmiş integer olan array yaradılsın.
            // Daha sonra həmən elementin minimum və maximum
            // elementlərinin hasili ekrana yazdırılsın.

            //Console.WriteLine("Number deyer daxil edin : ");
            //int[] array = new int[int.Parse(Console.ReadLine())];
            //Console.WriteLine(array.Max()*array.Min());

            #endregion
            #region Task 4
            //10 elementdən ibarət massiv yaradılsın və elementləri set edilsin.
            //Daha sonra həmən massivi azalan sırada ekrana yazdırın.

            //int[] array = new int[10];
            //array[0] = 18;
            //array[1] = 7;
            //array[2] = 35;
            //array[3] = 14;
            //array[4] = 25;
            //array[5] = 62;
            //array[6] = 27;
            //array[7] = 87;
            //array[8] = 59;
            //array[9] = 11;
            //Array.Sort(array);
            //Array.Reverse(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Task 5
            // Array təyin edin və elementlərinə dəyər verin.
            // Daha sonra arrayin 1-ci və sonuncu elementlərinin hasilini ekrana yazdırın.

            //int[] array = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(array[1] * array[array.Length - 1]);

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

            //Random random = new Random();
            //int cutElementCem = 0;
            //int cutElementSay = 0;
            //int[] array= new int[5];
            //array[0] = random.Next(100);
            //array[1] = random.Next(100);
            //array[2] = random.Next(100);
            //array[3] = random.Next(100);
            //array[4] = random.Next(100);

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0)
            //    {
            //        cutElementCem += array[i];
            //        cutElementSay++;
            //    }
            //}
            //try
            //{
            //    Console.WriteLine(cutElementCem / cutElementSay);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Random generatoru butun reqemleri tek verdi.. Yeniden cehd edin.");
            //}

            #endregion
            #region Task 8
            //Math funksiyalarına aid nümunələr yazın.

            //Console.WriteLine(Math.Truncate(6.95));
            //Console.WriteLine(Math.Clamp(1, 5, 15));
            //Console.WriteLine(Math.Abs(-6));
            //Console.WriteLine(Math.BitDecrement(55));
            //Console.WriteLine(Math.Cbrt(27));
            //Console.WriteLine(Math.CopySign(4.5, -5));
            //Console.WriteLine(Math.Pow(2, 5));
            //Console.WriteLine(Math.Round(5.5));

            #endregion
            #region task 9
            //String metodlarına aid nümunələr yazın.

            //string a = " Nurlan";
            //a = a.Replace('n', 'a').ToUpper();
            //Console.WriteLine(a.Min());
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
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"{array.Max()} * {array.Min()} = {array.Max() * array.Min()}");

            #endregion
            #region Task 11
            //  arrayin  elementlərinin ədədi ortasını tapın.

            //int[] array = { 40, 10, 29, 21 };
            //int b = (int)array.Average();
            //Console.WriteLine(b);

            #endregion
            #region Task 12
            //5(45623) reqemli eded verilib,ededin tek reqemlerin cemini ve hasilini tapin


            ////// Hell yolu 1 //////

            //int cem = 0;
            //int hasil = 1;
            //int[] array = new int[5] {4, 5, 6, 2, 3 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 1)
            //    {
            //        cem += array[i];
            //        hasil *= array[i];
            //    }
            //}
            //Console.WriteLine($"Cemi : {cem} , Hasili : {hasil}");


            ////// Hell yolu 2 //////

            //int eded = 45623, qaliq = 0, cem = 0, hasil = 1;
            //while (eded>0)
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
            //int[] arr = new int[7] { 5, 9, 0, 45,6,78,7 } max min elementlerin cemini tapin.

            //int[] arr = new int[7] { 5, 9, 0, 45, 6, 78, 7 };
            //Console.WriteLine(arr.Max() + arr.Min());

            #endregion
            #region Task 14
            //int[] arr = new int[7] { 5, 9, 0, 45,6,78,7 } artan sira ile siralayin.

            //int[] arr = new int[7] { 5, 9, 0, 45, 6, 78, 7 };
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
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
            //        reqem = (int)Math.CopySign(reqem,-1); // dovru dayandirmaq uchun
            //    }
            //    reqem /= 10;
            //}
            //Console.WriteLine(three == 3 ? "3 var" : "3 yoxdur");

            #endregion

        }

    }
}
