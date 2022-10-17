using System;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tasks

            #region Tasks Part 1

            #region Task 1
            //String equals-a aid nümunə yazın.

            //string a = "Nurlan";
            //Console.WriteLine(a.Equals("Nurlan"));

            #endregion
            #region Task 2
            //String metodlarına aid nümunələr yazın.

            //string a = "NURLAN";
            //Console.WriteLine(a.Replace('N','1'));
            //Console.WriteLine(a.ToLower());
            //Console.WriteLine(a.Length);
            //Console.WriteLine(a.FirstOrDefault());
            //Console.WriteLine(a.Any());
            //Console.WriteLine(a.Contains("A"));

            #endregion
            #region Task 3
            //Datatime-i müxtəlif formatlı stringlər şəklində ekrana yazdırın.
            //(longDateString, longTimeString, shortDateString, shortTimeString, dd/MMM/yyyy hh:mm)

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToLongDateString());
            //Console.WriteLine(dateTime.ToLongTimeString());
            //Console.WriteLine(dateTime.ToShortDateString());
            //Console.WriteLine(dateTime.ToShortTimeString());
            //Console.WriteLine(dateTime.ToString("dd/MMM/yyyy hh:mm"));

            #endregion
            #region Task 4
            //İf, else if və else üçün nümunələr yazın.

            //Console.WriteLine("Reqem daxil edin : ");
            //int reqem = int.Parse(Console.ReadLine());

            //if (reqem == 0)
            //{
            //    Console.WriteLine("Bu reqem 0'dir");
            //}
            //else if (reqem > 0 && reqem < 5)
            //{
            //    Console.WriteLine("Bu reqem 0-5 arasindadi");
            //}
            //else if (reqem > 5 && reqem < 10)
            //{
            //    Console.WriteLine("Reqem 5-10 arasindadir");
            //}
            //else if (reqem > 10 && reqem < 15)
            //{
            //    Console.WriteLine("Reqem 10-15 arasindadir");
            //}
            //else
            //    Console.WriteLine("Hechbiri uygun gelmedi");

            #endregion
            #region Task 5
            //Switch operatoru üçün nümunə yazın.

            //Console.WriteLine("reqem daxil edin : ");
            //int reqem = int.Parse(Console.ReadLine());

            //string message = reqem switch
            //{
            //    0 when reqem == 0 => $"Bu reqem : {reqem}",
            //    1 when 3 == 3 => $"Bu reqem : {reqem}",
            //    var x when x == 2 && x % 2 == 0 => $"Bu reqem : {reqem}",
            //    var x when x == 3 => $"Bu reqem : {reqem}",
            //    4 when 5 == 5 => $"Bu reqem : {reqem}",
            //    5 => $"Bu reqem : {reqem}",
            //    _ => "Hechbiri uygun gelmedi"
            //};
            //Console.WriteLine(message);

            #endregion
            #region Task 6 
            //Break və continue üçün nümunə yazın.

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i % 23 == 0)
            //    {
            //        Console.WriteLine($"Ilk 23'e bolunen eded tapildi : {i}");
            //        break;
            //    }
            //}

            //int cutEded = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cutEded++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Cut ededlerin sayi : {cutEded}");

            #endregion
            #region Task 7 
            //For üçün nümunə yazın.

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Task 8 
            //While üçün nümunə yazın.

            //int reqem = 0;
            //while (reqem <= 50)
            //{
            //    Console.WriteLine(reqem);
            //    reqem++;
            //}

            #endregion
            #region Task 9 
            //Do while üçün nümunə yazın.

            //string name = "";
            //do
            //{
            //    name += "Nurlan";
            //    Console.WriteLine(name);
            //} while (name != "Nurlan");

            #endregion
            #region Task 10 
            //Converting və parsing üçün nümunə yazın.

            //int a = 15;
            //string b = "84518";
            //char c = '5'; 
            //double d = 99;

            //Console.WriteLine(a.ToString());
            //Console.WriteLine(int.Parse(b));
            //Console.WriteLine(c.ToString());
            //Console.WriteLine(Convert.ToInt32(d));

            #endregion
            #region Task 11 
            //Tryparse üçün nümunə yazın.

            //Console.WriteLine("Deyer daxil edin : ");
            //string a = Console.ReadLine();
            //int result;
            //bool parseSuccessful;

            //if (parseSuccessful = int.TryParse(a, out result))
            //{
            //    Console.WriteLine("Siz reqem daxil etmisiz");
            //}
            //else
            //    Console.WriteLine("Siz metn daxil etmisiz");

            #endregion
            #region Task 12
            //İstifadəçidən alınmış string dəyəri tərsinə yazdırın.

            //Console.WriteLine("Deyer daxil edin : ");
            //string deyer = Console.ReadLine();
            //string tersDeyer = "";

            //for (int i = deyer.Length - 1; i >= 0; i--)
            //{
            //    tersDeyer += deyer.Substring(i, 1);
            //}
            //Console.WriteLine(tersDeyer);

            ////or //ikinci yol

            ////for (int i = deyer.Length - 1; i >= 0; i--)
            ////{
            ////    tersDeyer += tersDeyer + deyer[i];
            ////}

            #endregion
            #region Task 13
            //İstifadəçinin daxil etdiyi dəyərin polindrom olub-olmadığını bildirən proqram yazın.

            //Console.WriteLine("Int deyer daxil edin : ");
            //int deyer = int.Parse(Console.ReadLine());
            //int rezervDeyer = deyer;
            //int tersDeyer = 0;
            //int qaliq;

            //while (deyer > 0)
            //{
            //    qaliq = deyer % 10; // axrinci reqemi goturduk
            //    deyer = deyer/ 10; // axrincini goturduk deye uje bir mertebe atiriq
            //    tersDeyer = tersDeyer * 10 + qaliq; // tersDeyer default 0-di , 10-a vurub usdune
            //                                        // qaliq(axrinci) reqemi geldik. Verdiyimiz
            //                                        // deyerin axrinci deyeri uje oldu birinci deyerimiz
            //}
            //Console.WriteLine(tersDeyer == rezervDeyer ? "Polindromdur" : "Polindrom deyil");

            #endregion
            #region Task 14
            //Istidadəçidən int dəyər daxil etməsi istənilsin.
            //Daxil edilmiş ədədin sadə və ya mürəkkəb olduğunu tapın.

            //Console.WriteLine("Reqem daxil edin : ");
            //int reqem = int.Parse(Console.ReadLine());
            ////reqem = (int)Math.Sqrt(reqem); // Verilen boyuk ededden kok alir,kompu guce salmir
            //                                 //Bunu yazanda ama 25 kokde 5 chixir,
            //                                 //murekkebe sade qaytarir(mentiqi error)
            //int qaliq0 = 0;
            //for (int i = 1; i <= reqem; i++)
            //{
            //    if (reqem % i == 0)
            //    {
            //        qaliq0++;
            //    }
            //}
            //Console.WriteLine(qaliq0 > 2 ? "Murekkebdir.." : "Sadedir..");

            #endregion
            #region Task 15 
            //Istidadəçidən int dəyər daxil etməsi istənilsin.
            //Daxil edilmiş ədədin bölənlərini ekrana yazdırın.

            //Console.WriteLine("Reqem daxil edin");
            //int reqem = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= reqem; i++)
            //{
            //    if (reqem % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region Task 16 
            //10 iterasiyalı dövr daxilində istifadəçidən number daxil etməsini istəyin.
            //İterasiyanın sonunda daxil edilmiş ən böyük ədəd ekrana yazdırılsın.

            //int reqem = 0;
            //int enBoyuk = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i}-ci Reqem daxil edin : ");
            //    reqem = int.Parse(Console.ReadLine());

            //    if (reqem > enBoyuk)
            //    {
            //        enBoyuk = reqem;
            //    }
            //}
            //Console.WriteLine($"En boyuk eded : {enBoyuk} ");

            #endregion

            #endregion
            #region Tasks Part 2

            #region Task 1 
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin.
            //Daha sonra həmən sayda random ədəd generasiya edilsin və
            //ədədlər içərisindən minimumunu ekrana yazdırın.

            //Console.WriteLine("Dovrlerin sayini daxil edin : ");
            //int dovrlerinSayi = int.Parse(Console.ReadLine());

            //Random rand = new();
            //int randNum = rand.Next(200);
            //int min = randNum;
            //Console.WriteLine("1-ci eded : " + randNum);

            //for (int i = 2; i <= dovrlerinSayi; i++)
            //{
            //    randNum = rand.Next(200);
            //    Console.WriteLine($"{i}-ci eded : {randNum}");
            //    if (randNum < min)
            //        min = randNum;
            //}
            //Console.WriteLine("En kicik eded : " + min);

            #endregion
            #region Task 2 
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin.
            //Daha sonra həmən sayda random ədəd generasiya edilsin və
            //ədədlər içərisindən maximumunu ekrana yazdırın.


            //Console.WriteLine("Dovrlerin sayini daxil edin : ");
            //int dovrlerinSayi = int.Parse(Console.ReadLine());

            //Random rand = new();
            //int randNum = rand.Next(100);
            //int max = randNum;
            //Console.WriteLine("1-ci eded : " + randNum);

            //for (int i = 2; i <= dovrlerinSayi; i++)
            //{
            //    randNum = rand.Next(100);
            //    Console.WriteLine($"{i}-ci eded : {randNum}");
            //    if (randNum > max)
            //        max = randNum;
            //}
            //Console.WriteLine("En kicik eded : " + max);

            #endregion
            #region Task 3 
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin.
            //Daha sonra həmən sayda random ədəd generasiya edilsin və
            //ədədlərin 2 mislinin cəmini hesablayın.

            ////Console.WriteLine("Dovrlerin sayini daxil edin : ");
            ////int dovrlerinSayi = int.Parse(Console.ReadLine());

            ////Random rand = new();
            ////int randNum = rand.Next(100);
            ////Console.WriteLine("1-ci eded : " + randNum + $" 2misli : {randNum * 2} ");
            ////int cemi = randNum * 2;
            ////for (int i = 2; i <= dovrlerinSayi; i++)
            ////{
            ////    randNum = rand.Next(100);
            ////    Console.WriteLine($"{i}-ci eded : {randNum} 2misli : {randNum * 2}");
            ////    cemi += randNum * 2;
            ////}
            ////Console.WriteLine("Ededlerin cemi : " + cemi);

            #endregion
            #region Task 4 
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin.
            //Daha sonra həmən sayda 0-100 arası random ədəd generasiya
            //edilsin və ədədlər içərisində 3-ə və 5-ə bölünənlərin hasilini tapın.

            //Console.WriteLine("Dovrlerin sayini daxil edin : ");
            //int dovrlerinSayi = int.Parse(Console.ReadLine());

            //Random rand = new();
            //int randNum = rand.Next(100);
            //int hasil = 1;
            //if (randNum % 3 == 0 || randNum % 5 == 0)
            //{
            //    Console.WriteLine($"1-ci eded : {randNum} (3-e ve ya 5-e bolunur.. )");
            //}
            //else
            //    Console.WriteLine("1-ci eded : " + randNum);

            //if (randNum % 3 == 0 || randNum % 5 == 0)
            //{
            //    hasil *= randNum;
            //}
            //for (int i = 2; i <= dovrlerinSayi; i++)
            //{
            //    randNum = rand.Next(100);
            //    if (randNum % 3 == 0 || randNum % 5 == 0)
            //    {
            //        Console.WriteLine($"{i}-ci eded : {randNum} (3-e ve ya 5-e bolunur.. )");
            //        hasil *= randNum;
            //    }
            //    else
            //        Console.WriteLine($"{i}-ci eded : {randNum}");
            //}
            //if (hasil > 1)
            //{
            //    Console.WriteLine("Ededlerin hasili : " + hasil);
            //}
            //else
            //    Console.WriteLine("Burda 3-e ve ya 5-e bolunen eded yoxdur");


            #endregion
            #region Task 5 
            //İstifadəçidən string dəyər daxil edilməsi tələb edilsin.
            //Bu proses istifadəçi polindrom ədəd daxil edənə kimi davam etsin.

            //bool achar = true;
            //while (achar)
            //{
            //    Console.WriteLine("Int deyer daxil edin : ");
            //    int deyer = int.Parse(Console.ReadLine());
            //    int rezervDeyer = deyer;
            //    int tersDeyer = 0;
            //    int qaliq;

            //    while (deyer > 0)
            //    {
            //        qaliq = deyer % 10; // axrinci reqemi goturduk
            //        deyer = deyer / 10; // axrincini goturduk deye uje bir mertebe atiriq
            //        tersDeyer = tersDeyer * 10 + qaliq; // tersDeyer default 0-di , 10-a vurub usdune
            //                                            // qaliq(axrinci) reqemi geldik. Verdiyimiz
            //                                            // deyerin axrinci deyeri uje oldu birinci deyerimiz
            //    }
            //    if (tersDeyer == rezervDeyer)
            //        achar = false;
            //    Console.WriteLine(tersDeyer == rezervDeyer ? "Polindromdur" : "Polindrom deyil");
            //}

            #endregion
            #region Task 6
            //0-dan 100-ə kimi ədədlərin ekrana yazdırın.
            //İlk 22-ə bölünən ədədlər ekrana yazdırılmasın. Bunu continue ilə həll edin.

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 22 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Task 7
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin.
            //Daha sonra istifadəçidən həmən sayda string daxil etməsi
            //istənilsin və sonda stringlərin uzunluqları cəmini ekrana yazdırın.

            //Console.WriteLine("Dovrlerin sayini daxil edin : ");
            //int dovrSayi = int.Parse(Console.ReadLine());
            //int uzunCemi = 0;
            //for (int i = 0; i < dovrSayi; i++)
            //{
            //    Console.WriteLine("String(Metn) deyer daxil edin : ");
            //    String metn = Console.ReadLine();
            //    uzunCemi += metn.Length;
            //}
            //Console.WriteLine("Stringlerin uzunluqlari cemi {0}",uzunCemi);

            #endregion
            #region Task 8
            //Istidadəçidən iterasiya(dövr) sayı daxil etməsi istənilsin.
            //Daha sonra istifadəçidən həmən sayda string daxil etməsi
            //istənilsin və sonda stringlərin uzunluqları cəmini ekrana yazdırın.

            //Console.WriteLine("Dovrlerin sayini daxil edin : ");
            //int dovrSayi = int.Parse(Console.ReadLine());
            //int uzunCemi = 0;
            //for (int i = 0; i < dovrSayi; i++)
            //{
            //    Console.WriteLine("String(Metn) deyer daxil edin : ");
            //    String metn = Console.ReadLine();
            //    uzunCemi += metn.Length;
            //}
            //Console.WriteLine("Stringlerin uzunluqlari cemi {0}",uzunCemi);

            #endregion
            #region Task 9 
            //String format və interpolationa aid nümunələr yazın.

            //int num = 100;
            //int num1 = 200;
            //int num2 = 300;
            //string numStr = String.Format("Number {0} + {1} + {2}",num,num1,num2);

            //Console.WriteLine(numStr); // String format
            //Console.WriteLine($"Birinci eded {num} , Ikinci {num1} , Uchuncu {num2}"); //interpolation

            #endregion
            #region Task 10 
            //Datetime metodlarına aid nümunələr yazın.

            //string a = DateTime.Now.ToString("MM/dd/yyyy");
            //string b = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            //string c = DateTime.Now.ToString("MM/dd/yyyy H:mm");
            //string d = DateTime.Now.ToString("yyyy MMMM");

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            #endregion
            #region Task 11 
            //İstifadəçinin daxil etdiyi dəyərin int olub-olmadığını yoxlayın.

            //Console.WriteLine("Deyer daxil edin : ");
            //string a = Console.ReadLine();
            //int inta;
            //bool tryparse = int.TryParse(a, out inta);
            //if (tryparse == true)
            //{
            //    Console.WriteLine("Siz eded daxil etmisiz");
            //}
            //else
            //    Console.WriteLine("Siz metn daxil etmisiz ");

            #endregion
            #region Task 12 
            //İstifadəçidən alınmış inputu int-ə çevirin və ekrana yazdırın.
            //Növbəti sətirlərdə isə proqramda xəta olub-olmamasından asılı
            //olmayaraq ekrana “Hello world” yazdırılsın.

            //Console.WriteLine("Input daxil edin");
            //string input = Console.ReadLine(); 
            //try
            //{
            //    int cevirme = int.Parse(input);
            //}
            //catch (Exception)
            //{
            //}
            //finally
            //{
            //    Console.WriteLine("Hello World");
            //}

            #endregion
            #region Task 13 
            //Try catch finally və exceptionlara aid nümunələr yazın.

            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int c = a / b;

            //    //int.Parse("dwsd");

            //    //string str = "99999999999999999999999999999999";
            //    //int.Parse(str);

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Message : " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Message : " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Namelum xeta bash verdi");
            //}
            //finally
            //{
            //    Console.WriteLine("Bura Finallly-dir");
            //}



            #endregion
            #region Task 14 
            //Switch üçün nümunələr yazın.

            //int number = int.Parse(Console.ReadLine());
            //string message = number switch
            //{
            //    1 => "Bu reqem 1-dir",
            //    5 => "Bu reqem 5-dir",
            //    3 => "Bu reqem 3-dur",
            //    7 => "Bu reqem 7-dir",
            //    10 => "Bu reqem 10-dur",
            //    _ => "Uygun reqem tapilmadi.."

            //};
            //Console.WriteLine(message);
            #endregion
            #region Task 15 Oxu
            //Tiplərin memory sizə və rangelərini oxuyun.

            // Oxudum

            #endregion
            #region Task 16 Oxu
            //Garbage collector, value və referens type-lar haqqında oxuyun.

            // Oxudum
            #endregion
            #region Task 17 
            //İstifadəçidən ədəd daxil etməsini tələb edin və daha sonra ədədin
            //rəqəmlərini ayrı-ayrılıqda ekrana yazdırın. (məsələn: 45232 -> 4 5 2 3 2)

            //Console.WriteLine("Eded daxil edin : ");
            //string eded = Console.ReadLine();
            //string arali = "";
            //for (int i = 0; i < eded.Length; i++)
            //{
            //    arali += " " + eded.Substring(i, 1);
            //}
            //Console.WriteLine(arali);

            #endregion

            #endregion

            #endregion


        }


    }
}
