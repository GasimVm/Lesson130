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
            //1.Istifadəçidən   array   daxil edilməsi tələb edilsin. Daha sonra array  elementlərinə random olaraq yalnız tək ədədlər verilsin. Proqramın sonunda yaranmış  massivin elementlərini   ekrana yazdırın.
            /*
            int range = Convert.ToInt32(Console.ReadLine());
            int[] array =new int[range];
            int index = 0;
            while (index < range)
            {
                Random rand = new Random();
                int element = rand.Next(1,100);
                if (!(element%2==0))
                {
                    array[index] = element;
                    index++;
                }
            }
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            #region
            //2. array təyin edin, elementlərini əlavə edin və minimum elementini ekrana yazdırın.
            /*
            int[] array = new int[5] { 92, 73, 98, 221, 111 };
            int min= 0;
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[min])
                {
                    min = i;
                }
            } 
            Console.WriteLine(array[min]);  */
            #endregion

            #region
            //3.Istifadəçidən number dəyər daxil edilməsi istənilsin və elemet sayı daxil edilmiş integer olan array yaradılsın. Daha sonra həmən elementin minimum və maximum elementlərinin hasili ekrana yazdırılsın.
            /*
            int range = Convert.ToInt32(Console.ReadLine());
            int[] array= new int[range];
            Random rdm = new Random();
            for (int i = 0; i < range; i++)
            {
                int element = rdm.Next(1,100);
                Console.WriteLine(element);
                array[i] = element;
            }
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[max])
                {
                    max = i;
                }
            } 
            int min=0;
            for (int i = 1; i < array.Length; i++) 
            {
                if (array[i] <= array[min])
                {
                    min=i;
                }
            }
            Console.WriteLine($"bize lazim olan cavab:min={array[min]},max={array[max]},hasil={array[min] * array[max]}");
            */
            #endregion

            #region
            //4.10 elementdən ibarət massiv yaradılsın və elementləri set edilsin. Daha sonra həmən massivi azalan sırada ekrana yazdırın.
            
            int[] array = new int[10] { 12, 23, 45, 89, 90, 123, 67, 78, 234, 567 };

            #endregion

            #region
            //5.Array təyin edin və elementlərinə dəyər verin. Daha sonra arrayin 1-ci və sonuncu elementlərinin hasilini ekrana yazdırın.
            /*
            int[] array= new int[5] {122,34,25,56,234};
            int a= array[0];
            int b = array[array.Length-1];
            Console.WriteLine($"birinci element={a},sonuncu={b},hasil={a*b}"); */
            #endregion

            #region
            //6.String dəyər təyin edin. Daha sonra 5 iterasiyalı dövr qurun və hər iterasiyada istifadəçidən dəyər daxil etməsini tələb edin. İstifadəçinin daxil etdiyi hər dəyəri string-ə əlavə edin(arxasında boşluq işarəsi qoymaqla). İstifadəçi 5 dəyərin 5ni də daxil etdikdən sonra string split funksiyasında istifadə edərək əldə edilmiş string dəyərindən string arrayi yaradın ekrana ekrana yazdırın.
            /*
            string text = null;
            for (int i = 0; i < 5; i++)
            {
                string element=Console.ReadLine();
                text= text + element + " ";
            }
            //splitin nece islediyini basa dusmedim */
            #endregion

            #region
            //7.array təyin edilsin və elementləri 0-100 arası random ədədlər olsun. Daha sonra arrayın cüt elementlərinin ədədi ortasını tapın.
            /*
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int element = rand.Next(0,100);
                Console.WriteLine(element);
                array[i] = element;
            }
            int plural = 0;
            int mid = 0;
            foreach (int element in array)
            {
                if (element%2==0)
                {
                    plural=plural + element;
                    mid++;
                }
            }
            Console.WriteLine($"bize lazim olan={plural/mid}"); */
            #endregion

            #region
            //8.Math funksiyalarına aid nümunələr yazın.
            /*
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(d)); */
            #endregion

            #region
            //10.Arrayin max və min elementlərinin hasilini tapın.
            /*
            int[] array = new int[10] {1296,34,295,67,9000,89,234,124,678,2345};
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[max])
                {
                    max = i;
                }
            }
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[min])
                {
                    min = i;
                }
            }
            Console.WriteLine($"max element={array[max]},min element={array[min]},hasil={array[max] * array[min]}");
            */
            #endregion

            #region
            //11.arrayin  elementlərinin ədədi ortasını tapın.
            /*
            int[] array = new int[10] {123,456,34,89,9087,2345,78,12,1267,2345};
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            int result = sum / array.Length;
            Console.WriteLine(result); */
            #endregion

            #region
            //12.5(45623) reqemli eded verilib,ededin tek reqemlerin cemini ve hasilini tap	out.
            /*
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number.ToString().Length];
            int rezerv = number;
            int changenumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                changenumber = number % 10;
                number = number / 10;
                array[array.Length-1-i] = changenumber;
            }
            int resultsum = 0;
            int result2 = 1;
            foreach (int element in array)
            {
                if (!(element%2==0))
                {
                    resultsum += element;
                    result2 *= element;
                }
            }
            Console.WriteLine($"cem={resultsum},hasil={result2}");
            */
            #endregion

            #region
            //13.int[] arr = new int[7] { 5, 9, 0, 45,6,78,7 } max min elementlerin cemini tapin.
            /*
            int[] arr = new int[7] { 5, 9, 2000, 45, 6, 78, 7 };
            Console.WriteLine(arr.Max() + arr.Min()); */
            #endregion

            #region
            //14.int[] arr = new int[7] { 5, 9, 0, 45,6,78,7 } artan sira ile siralayin.

            #endregion

            #region
            //15.Dördrəqəmli tam ədəd verilmişdir. Ədədin bütün rəqəmlərinin fərqli olub olmadığını müəyyənləşdirin.
            /*
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number.ToString().Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[array.Length - 1 - i] = number % 10;
                number /= 10;
            }
            bool check = true;
            bool tap = false;
            int favoriteIndex = 0;
            while (check)
            {
                for (int i = favoriteIndex+1; i < array.Length; i++)
                {
                    if(array[favoriteIndex] != array[i] && i==array.Length-1)
                    {
                        favoriteIndex++;
                    }
                    else if (array[favoriteIndex] == array[i])
                    {
                        check = false;
                        tap = true;
                        break;
                    }
                }
                if (favoriteIndex==array.Length-1)
                {
                    check = false;
                    break;
                }
            }
            if (tap)
            {
                Console.WriteLine("tapildi");
            }
            else
            {
                Console.WriteLine("tapmadim");
            } */
            #endregion

         






        }


    }
}