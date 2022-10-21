//using System;
//using System.Linq;

//namespace ht_for_l7
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {




//            #region t1
//            //Istifadəçidən   array   daxil edilməsi tələb edilsin. Daha sonra array  elementlərinə random olaraq yalnız tək ədədlər verilsin. Proqramın sonunda yaranmış  massivin elementlərini   ekrana yazdırın.

//            //int[] a = new int[5];
//            //var c = 0;

//            //while (c < a.Length)
//            //{
//            //    Random r = new Random();
//            //    int rdn = r.Next(100);
//            //    if (rdn % 2 == 1)
//            //    {
//            //        a[c] = rdn;
//            //        c++;
//            //    }
//            //}
//            //foreach (int item in a)
//            //{
//            //    Console.WriteLine(item);
//            //}



//            // ancag 1 tek ededi butun elementlere beraber edir

//            #endregion

//            #region  t2

//            //array təyin edin, elementlərini əlavə edin və minimum elementini ekrana yazdırın.
//            //int[] a = new int[5] {0, 2,3, 4, 5 };

//            //Console.WriteLine(a.Min());


//            #endregion

//            #region t3

//            //Istifadəçidən number dəyər daxil edilməsi istənilsin və elemet sayı daxil edilmiş integer olan array yaradılsın. Daha sonra həmən elementin minimum və maximum elementlərinin hasili ekrana yazdırılsın.

//            // var say = int.Parse(Console.ReadLine());
//            // int[] a = new int[say];

//            // for(int i = 0; i < a.Length; i++)
//            // {
//            //     a[i] = int.Parse(Console.ReadLine());
//            // }

//            //Console.WriteLine("En boyuk eded: " + a.Max());
//            // Console.WriteLine("En kicik eded: " + a.Min());
//            #endregion

//            #region t4

//            //10 elementdən ibarət massiv yaradılsın və elementləri set edilsin. Daha sonra həmən massivi azalan sırada ekrana yazdırın.

//            //  int[] a = new int[10];

//            //  for (int i = 0; i < a.Length; i++)
//            //  {
//            //      a[i] = int.Parse(Console.ReadLine());
//            //  }
//            //Array.Sort(a);
//            //  Array.Reverse(a);
//            //  foreach(int item in a)
//            //  {
//            //      Console.WriteLine(item);
//            //  }

//            #endregion

//            #region t5

//            //  Array təyin edin və elementlərinə dəyər verin.Daha sonra arrayin 1 - ci və sonuncu elementlərinin hasilini ekrana yazdırı

//            //var say = int.Parse(Console.ReadLine());
//            //int[] a = new int[say];

//            //for (int i = 0; i < a.Length; i++)
//            //{
//            //    a[i] = int.Parse(Console.ReadLine());
//            //}
//            //Console.WriteLine(a[0] * a[say-1]);

//            #endregion

//            #region t6

//            // tring dəyər təyin edin. Daha sonra 5 iterasiyalı dövr qurun və hər iterasiyada istifadəçidən dəyər daxil etməsini tələb edin. İstifadəçinin daxil etdiyi hər dəyəri string-ə əlavə edin(arxasında boşluq işarəsi qoymaqla). İstifadəçi 5 dəyərin 5ni də daxil etdikdən sonra string split funksiyasında istifadə edərək əldə edilmiş string dəyərindən string arrayi yaradın ekrana ekrana yazdırın.
//            //string str = "";
//            //for(int i = 0; i < 5; i++)
//            //{
//            //    var a =Console.ReadLine();  
//            //    str=str+a+" ";
//            //}

//            //string[] str2 = str.Split(" ");
//            //foreach(string item in str2)
//            //{
//            //    Console.WriteLine(item);    
//            //}

//            #endregion

//            #region t7
//            // array təyin edilsin və elementləri 0-100 arası random ədədlər olsun. Daha sonra arrayın cüt elementlərinin ədədi ortasını tapın.
//            //int[] a = new int[5];
//            //var c = 0;
//            //var s=0;

//            //for(int i = 0; i < a.Length; i++)
//            //{
//            //    Random r = new Random();
//            //    int rdn=r.Next(100);
//            //    a[i] = rdn;
//            //}

//            //for(int i = 0; i < a.Length; i++)
//            //{
//            //    if(a[i] % 2 == 0)
//            //    {
//            //        c++;
//            //        s=s+a[i];
//            //    }
//            //}
//            //foreach(int item in a)
//            //{
//            //    Console.WriteLine(item);
//            //}


//            //Console.WriteLine("ededi orta : " + s/c);

//            #endregion

//            #region t8
//            //  Math funksiyalarına aid nümunələr yazın. 

//            //var t91 = Convert.ToDouble(Console.ReadLine());
//            //var t92 = Convert.ToDouble(Console.ReadLine());

//            //Console.WriteLine("power");
//            //Console.WriteLine(Math.Pow(t91, t92));

//            //Console.WriteLine("Minimum");
//            //Console.WriteLine(Math.Min(t91, t92));

//            //Console.WriteLine("Maximum");
//            //Console.WriteLine(Math.Max(t91, t92));

//            //Console.WriteLine("modeules");
//            //Console.WriteLine(Math.Abs(t91));

//            //Console.WriteLine("root");
//            //Console.WriteLine(Math.Sqrt(t92));




//            #endregion

//            #region t11

//            //task 10 task3 eynidir

//            // arrayin  elementlərinin ədədi ortasını tapın.
//            //var s = 0;
//            //var say = int.Parse(Console.ReadLine());
//            //int[] a = new int[say];

//            //for (int i = 0; i < a.Length; i++)
//            //{
//            //    a[i] = int.Parse(Console.ReadLine());

//            //    s=s+a[i];
//            //}
//            //Console.WriteLine("ededi orta: " + s/say);

//            #endregion

//            #region t12
//            //var n = int.Parse(Console.ReadLine());
//            //var s = 0;
//            //var h = 1;
//            //while (n > 0)
//            //{
//            //    if (n % 10 % 2 == 1)
//            //    {
//            //        s = s + n % 10;
//            //        h = h * (n % 10);
//            //    }
//            //    n = n / 10;
//            //}
//            //Console.WriteLine($"tek reqemlerin cemi: {s}\n tek ededlerin hasili: {h} ");

//            #endregion

//            #region t13
//            //int[] arr = new int[7] { 5, 9, 0, 45,6,78,7 } max min elementlerin cemini tapin.

//            //int[] arr = new int[7] { 5, 9, 0, 45, 6, 78, 7 };
//            //Console.WriteLine(arr.Max()+arr.Min());


//            #endregion

//            #region t14
//            // int[] arr = new int[7] { 5, 9, 0, 45,6,78,7 } artan sira ile siralayin.


//            //int[] arr = new int[7] { 5, 9, 0, 45, 6, 78, 7 };
//            //Array.Sort(arr);

//            //foreach(int item in arr)
//            //{
//            //    Console.WriteLine(item);    
//            //}



//            #endregion

//            #region t15

//            // Dördrəqəmli tam ədəd verilmişdir. Ədədin bütün rəqəmlərinin fərqli olub olmadığını müəyyənləşdirin.

//            //var n = int.Parse(Console.ReadLine());
//            //var a = n / 1000;
//            //var b = n / 100 % 10;
//            //var c = n % 100 / 10;
//            //var d = n % 10;

//            //if(a == b || a==c || a==d || b==c || b==d || c == d)
//            //{
//            //    Console.WriteLine("eyni eded var");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("butun ededler ferglidir");
//            //}




//            #endregion

//            #region
//            // Dördrəqəmli tam ədəd verilmişdir. Rəqəmdə 3 rəqəminin olub olmadığını müəyyənləşdirin.


//            //var n= int.Parse(Console.ReadLine());
//            //var h = 0;
//            //while (n > 0)
//            //{
//            //    if (n % 10 == 3)
//            //    {
//            //        Console.Write("3 regemi ededin icinde var");
//            //        h = 1;
//            //        break;
//            //    }
//            //    n=n/ 10;
//            //}

//            //if (h ==0)
//            //{
//            //    Console.Write("bu ededin icinde 3 regemi yoxdur");
//            //}

//            #endregion
//        }
//    }
//}
