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
            // String equals-a aid nümunə yazın.
            /*  string str1 = Console.ReadLine();   
              string str2 = Console.ReadLine();
              bool check = str1.Equals(str2);
              Console.WriteLine(check); */
            #endregion

            #region
            //String metodlarına aid nümunələr yazın.
            /*
            string test = Console.ReadLine();
            Console.WriteLine(test.ToLower());
            Console.WriteLine(test.Contains('a'));
            Console.WriteLine(test.Substring(5));
            */
            #endregion

            #region
            //İf, else if və else üçün nümunələr yazın.
            /*
            Console.WriteLine("movcud emelyatlar: 1-topla,2-cix,3-vur,4-bol");
            string cmm = Console.ReadLine();
            int command;
            bool result = int.TryParse(cmm, out command);
            if (result)
            {
                if (command==1)
                {
                    Console.WriteLine("ededleri daxil edin:");
                    int x1= Convert.ToInt32(Console.ReadLine());
                    int x2= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"emelyatin neticesi ={x1+x2}");
                }
                else if (command==2)
                {
                    Console.WriteLine("ededleri daxil edin:");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    int x2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"emelyatin neticesi ={x1 - x2}");
                }
                else if (command == 3)
                {
                    Console.WriteLine("ededleri daxil edin:");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    int x2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"emelyatin neticesi ={x1 * x2}");
                }
                else if (command == 4)
                {
                    Console.WriteLine("ededleri daxil edin:");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    int x2 = Convert.ToInt32(Console.ReadLine());
                     if (x2!=0)
                    {
                        Console.WriteLine($"emelyatin neticesi ={x1 / x2}");
                    }
                     else
                    {
                        Console.WriteLine("ugursuz emelyat");
                    }  
                }
            }
            else
            {
                Console.WriteLine("emelyati duzgun secin!!!");
            }
            */
            #endregion

            #region 
            //Switch operatoru üçün nümunə yazın.
            /*
            char cmm = Convert.ToChar(Console.ReadLine());
            switch (cmm)
            {
                case '1':
                    Console.WriteLine("hava soyuqdu 1");
                    break;
                case '2':
                    Console.WriteLine("hava istidi 2");
                    break;
                default:
                    Console.WriteLine("hec biri");
                    break;
            }
           */
            #endregion

            #region
            //Break və continue üçün nümunə yazın.
            /*
            for (int i = 1; i<= 100; i++)
            {
                if (i==45)
                {
                   continue;
                }
                Console.WriteLine(i);
            }
            */
            #endregion

            #region
            //While üçün nümunə yazın.
            /*
            int cmm = Convert.ToInt32(Console.ReadLine());
            while (cmm > 0 && cmm<11)
            {
                Console.WriteLine($"commandin indiki qiymeti-{cmm}");
                cmm++;
            }
            */
            #endregion

            #region
            //Do while üçün nümunə yazın.
            /*??????????????????????????????????????????????????
            int rqm = 0;
            do
            {
                rqm++;
            }
            while (rqm > 0);
            Console.WriteLine(rqm);
            */
            #endregion

            #region
            //Converting və parsing üçün nümunə yazın.
            /*
            int x1 = Convert.ToInt32(Console.ReadLine());
            string str = "200";
            int strcheck= int.Parse(str);
            Console.WriteLine(strcheck);
            */
            #endregion

            #region 
            //İstifadəçidən alınmış string dəyəri tərsinə yazdırın.
            //???????????????????????????????????????????????????????
            /*
            string test = "teymur";
            string reverse=null;
            for (int i = test.Length-1; i >=0; i--)
            {
                reverse = reverse + test[i];
            }
            Console.WriteLine(reverse);
            */
            #endregion

            #region
            //İstifadəçinin daxil etdiyi dəyərin polindrom olub-olmadığını bildirən proqram yazın.
            /*
            string input = Console.ReadLine();
            string check = null;
            for (int i = input.Length-1; i >=0; i--)
            {
                check = check + input[i];
            }
            if (check == input)
            {
                Console.WriteLine($"daxil etdiyiniz soz polindromdur:input={input},check={check}");
            }
            else
            {
                Console.WriteLine($"soz polindrom deyil:input={input},check={check}");    
            }
            */
            #endregion

            #region
            //Istidadəçidən int dəyər daxil etməsi istənilsin. Daxil edilmiş ədədin sadə və ya mürəkkəb olduğunu tapın.
            /*
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("bu eded murekkebdir");
            }
            else if (number==1)
            {
                Console.WriteLine("1 daxil etdiniz");
            }
            else
            {
                Console.WriteLine("sade eded daxil etdiniz");
            }
            */
            #endregion

            #region
            //Istidadəçidən int dəyər daxil etməsi istənilsin. Daxil edilmiş ədədin bölənlərini ekrana yazdırın.
            /*
           int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number%i==0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            #endregion

            #region
            //10 iterasiyalı dövr daxilində istifadəçidən number daxil etməsini istəyin. İterasiyanın sonunda daxil edilmiş ən böyük ədəd ekrana yazdırılsın.
            /*
            int[] array = new int[10];
            int j=0;
            for (int i = 0; i < array.Length; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                array[i] = input;
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[j] >= array[i])
                {
                    continue;
                }
                else if (array[j] < array[i])
                {
                    j=i;
                } 
            }
            int result = array[j];
            Console.WriteLine(result);
            */
            #endregion

            #region
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin. Daha sonra həmən sayda random ədəd generasiya edilsin və ədədlər içərisindən minimumunu ekrana yazdırın.
            /*
            int loop = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[loop];
            int j=0;
            for (int i = 0; i < loop; i++)
            {
               Random rand = new Random();
               int number = rand.Next(1,loop);
               Console.WriteLine(number);
               array[i] = number;
            }
            for (int i = 1; i < loop; i++)
            {
                if (array[j] <= array[i] )
                {
                    continue;
                }
                else if (array[j] > array[i])
                {
                    j = i;
                }
            }
            int result=array[j];
            Console.WriteLine("bize lazim olan netice"+result);
            */
            #endregion

            #region
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin. Daha sonra həmən sayda random ədəd generasiya edilsin və ədədlərin 2 mislinin cəmini hesablayın.
            /*
            Console.WriteLine("dovr sayini daxil edin:");
            int loop = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < loop; i++)
            {
                Random rdm = new Random();
                int number = rdm.Next(1,10);
                Console.WriteLine(number);
                result= result + number*2;
            }
            Console.WriteLine($"ededlerin 2 mislinin ceminin nticesi:{result}");
            */
            #endregion

            #region
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin. Daha sonra həmən sayda 0-100 arası random ədəd generasiya edilsin və ədədlər içərisində 3-ə və 5-ə bölünənlərin hasilini tapın.
            /*
            Console.WriteLine("loop daxil edin: ");
            int loop = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < loop; i++)
            {
                Random rdm=new Random();
                int number = rdm.Next(1, 100);
                Console.WriteLine(number);
                if (number%15==0)
                {
                    result=result*number;
                }
            }
            Console.WriteLine($"bize lazim olan netice:{result}");
            */
            #endregion

            #region
            //İstifadəçidən string dəyər daxil edilməsi tələb edilsin. Bu proses istifadəçi polindrom ədəd daxil edənə kimi davam etsin.
            /* ???????????????????????????????????????????????????????????????????????????????
            string check = null;
            string str;
            try
            {
                do
                {
                    Console.WriteLine("string deyer daxil edin :");
                    str = Console.ReadLine();
                    for (int i = str.Length; i >= 0; i--)
                    {
                        check = check + str[i];
                    }
                }
                while (check != str);
            }
            catch (Exception ex)
            {
                Console.WriteLine("polindrom");
            }
            */
            #endregion

            #region
            //0-dan 100-ə kimi ədədlərin ekrana yazdırın. İlk 22-ə bölünən ədədlər ekrana yazdırılmasın. Bunu continue ilə həll edin.
            /*
            for (int i = 0; i <=100; i++)
            {
                if (i%22==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            */
            #endregion

            #region
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin. Daha sonra istifadəçidən həmən sayda string daxil etməsi istənilsin və sonda stringlərin uzunluqları cəmini ekrana yazdırın.
            /*
            Console.WriteLine("loop sayi daxil edin:");
            int loop = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("string deyer daxil edin:");
                string str= Console.ReadLine();
                result= result + str.Length;
            }
            Console.WriteLine($"bize lazim olan netice:{result}");
            */
            #endregion

            #region
            //İstifadəçinin daxil etdiyi dəyərin int olub-olmadığını yoxlayın.
            /*
            Console.WriteLine("her hansi bir input daxil edin:");
            string str= Console.ReadLine();
            int number;
            bool check=int.TryParse(str, out number);
            if (check)
            {
                Console.WriteLine($"siz integer deyer daxil etduiniz:{number}");
            }
            else
            {
                Console.WriteLine($"siz string deyer daxil etiniz:{str}");
            }
            */
            #endregion

            #region
            //İstifadəçidən alınmış inputu int-ə çevirin və ekrana yazdırın. Növbəti sətirlərdə isə proqramda xəta olub-olmamasından asılı olmayaraq ekrana “Hello world” yazdırılsın. 
            /*
            string str = Console.ReadLine();
            int number;
            bool check =int.TryParse(str, out number);
            try
            {
                if (check)
                {
                    Console.WriteLine($"siz integer deyer daxil etduiniz:{number}");
                }
                else
                {
                    Console.WriteLine($"siz string deyer daxil etiniz:{str}");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("Hello World");
            }
            */
            #endregion

            #region
            //İstifadəçidən ədəd daxil etməsini tələb edin və daha sonra ədədin rəqəmlərini ayrı-ayrılıqda ekrana yazdırın. (məsələn: 45232 -> 4 5 2 3 2)
            /*
            int number = Convert.ToInt32(Console.ReadLine());
            string str= Convert.ToString(number);
            string result = null;
            for (int i = str.Length; i >=0; i--)
            {
                result = result + str[i];  //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'- bele error aliram 
            }
            Console.WriteLine($"bize lazim olan netice: \n {result}");
            */
            #endregion
            Console.ReadLine(); 
        }

    }
}