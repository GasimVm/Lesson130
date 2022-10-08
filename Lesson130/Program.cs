using System;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /* “02.03.2021 tarixində hava soyuq idi” cümləsində 02.03.2021
               tarixini string format və interpolation istifadə edərək(ayrı ayrılıqda) 
               console - a yazdırın.Tarix cari tarix olsun(DateTime istifadə edin).
            */
            //DateTime date = DateTime.Now;
            //Console.WriteLine($"{date.ToShortDateString()} tarixinde hava soyuq idi");

            #endregion
            #region Task 2
            //string tipindən name adlı variable yaradın və string format
            //istifadə edərək ekrana “My name is x” yazdırın.X yerinə name
            //variablesinin dəyəri olsun.

            //string name = "Nurlan";
            //Console.WriteLine($"My name is {name}");

            #endregion
            #region Task 3
            //string tipindən olan variablenin dəyərinin uzunluğunu ekrana yazdırın.

            //string a = "Azerbaycan Dovlet Iqtisad Universiteti";
            //Console.WriteLine(a.Length);

            #endregion
            #region Task 4
            //DateTime ilə cari tarix götürülsün və format edilərək
            //“dd / MM / yyyy hh: mm” formatına salınsın.

            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm"));

            #endregion
            #region Task 5
            // String tipindən olan dəyərin başlıqdan və sondan, sondan və başlıqdan olan boşluqlarını silin.

            //string a = "     Nurlan     ";
            //a = a.Trim();
            //Console.WriteLine(a);

            #endregion
            #region Task 6
            //String tipindən olan dəyərdə a hərflərini b hərfi ilə əvəz edin.

            //string text = "aaa3aaa3aaa";
            //text = text.Replace('a', 'b');
            //Console.WriteLine(text);

            #endregion
            #region Task 7
            //Parse metodunu 3 fərqli data type üçün yazın.

            //string a = "46";
            //int b = int.Parse(a);

            //string a1 = "456";
            //short b1 = short.Parse(a1);

            //string a2 = "4568.56";
            //double b2 = double.Parse(a2);

            //Console.WriteLine($"{b}, {b1}, {b2}");

            #endregion
            #region Task 8
            //String contains üçün nümunə yazın.

            //string name = "Khankishiyev Nurlan";
            //bool result = name.Contains('z');
            //Console.WriteLine(result);

            #endregion
            #region Task 9
            //String ends and starts with üçün nümunə yazın.

            //string a = "Nurlan";
            //bool b = a.EndsWith('n');
            //bool c = a.StartsWith('A');
            //Console.WriteLine($"{b}, {c}");

            #endregion
            #region Task 10
            // Stringin bütün hərflərini əvvəlcə böyük, daha sonra kiçik hərflərə dəyişin.

            //string name = "Nurlan Khankishiyev";
            //string name1 = name.ToUpper();
            //string name2 = name.ToLower();

            //Console.WriteLine($"{name1}, {name2}");

            #endregion
            #region Task 11
            //String daxilində ilk və son a hərfinin indexini ekrana yazdırın.

            //string name = "0aaaaaaaaaa";
            //Console.WriteLine(name.IndexOf("a"));
            //Console.WriteLine(name.LastIndexOf("a"));

            #endregion
            #region Task 12
            // String dəyərin 5-ci indexinə test sözü yazdırın.

            //string text = "0123456789";
            ////text = text.Remove(5,1);
            //text = text.Insert(5, "test");
            //Console.WriteLine(text);

            #endregion
            #region Task 13
            //String 3-cü indexdən 5-ci indexə qədər olan hissəsini kəsin.

            //string text = "0123456789";
            //text = text.Substring(3, 3);
            //Console.WriteLine(text);

            #endregion
            #region Task 14
            //String dəyərin 3-cü simvoldan sona qədər, daha sonra isə əldə
            //edilmiş dəyərdən 2-ci simvoldan 4 simvol sonraya qədər kəsin
            //və nəticəni ekrana yazdırın.

            //string text = "0123456789";
            //text = text.Substring(3);
            //text = text.Substring(2, 4);

            //Console.WriteLine(text);

            #endregion
            #region Task 15
            //Datetime-in metodlarına aid nümunələr yazın.

            //string a = DateTime.Now.ToString("MM/dd/yyyy");
            //string b = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            //string c = DateTime.Now.ToString("MM/dd/yyyy H:mm");
            //string d = DateTime.Now.ToString("yyyy MMMM");
            //string e = DateTime.Now.ToString("H:mm");
            //string f = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);

            #endregion
            #region Task 16
            //Verilmiş stringə əsasən datetime yaradın və üzərinə
            //3 ay, 2 gün, 4 saat, 2 dəqiqə və 34 saniyə gəlin.

            //DateTime time = new DateTime(2022, 1, 1, 0, 0, 0);
            //time = time.AddMonths(3);
            //time = time.AddDays(2);
            //time = time.AddHours(4);
            //time = time.AddMinutes(2);
            //time = time.AddSeconds(34);

            //Console.WriteLine(time);

            #endregion
            #region Task 17
            // Həftənin gününü ekrana yazdırın.

            //string dayOfWeek = DateTime.Now.ToString("dddd");
            //Console.WriteLine(dayOfWeek);

            #endregion
            #region Task 18
            //Int tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.

            //int a;
            //a = 89;
            //Console.WriteLine(a);

            #endregion
            #region Task 19
            //Bool tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.

            //bool a;
            //a = true;
            //Console.WriteLine(a);

            #endregion
            #region Task 20
            //String tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.

            //string a;
            //a = "Nurlan";
            //Console.WriteLine(a);

            #endregion
            #region Task 21
            //Char tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.

            //char a;
            //a = 'a';
            //Console.WriteLine(a);

            #endregion
            #region Task 22
            //Cari tarixi ekrana yazdırın.

            //string now = DateTime.Now.ToString();
            //Console.WriteLine(now);

            #endregion
            #region Task 23
            //Double, float və decimal tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.

            //double a = 5.8966;
            //float b = 7.48f;
            //decimal c = 45.789m;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            #endregion
            #region Task 24
            //Cari tarixin ilini ekrana yazdırın.

            //string now = DateTime.Now.ToString("yyyy");
            //Console.WriteLine(now);

            #endregion
            #region Task 25
            //Int tipindən 2 variable təyin edin və dəyər assign edin.
            //Daha sonra ekrana həmin ədədlərin hasilini yazdırın.

            //int a = 8;
            //int b = 7;
            //Console.WriteLine(a*b);

            #endregion
            #region Task 26
            //Int tipindən 2 variable təyin edin və dəyər assign edin.
            //Daha sonra ekrana birinci ədədin ikinci ədədə bölünməsindən alınan qalığı yazdırın.
            //int a = 10;
            //int b = 7;
            //Console.WriteLine(a%b);

            #endregion
            #region Task 27
            //Istifadeciye sual verinki nece yasin var.Ekrana onun yasi
            //ile oz yasiniz arasinda ferqi yazdirin.

            //Console.WriteLine("How old are you ?");
            //uint userAge = uint.Parse(Console.ReadLine());
            //uint myAge = 21;
            //Console.WriteLine("Aramizda " + (userAge - myAge) + " yash ferq var.");

            #endregion
            #region Task 28
            //Istifadecinin adini,soyadini,nomresini,yasini ayri-ayri sorucun ve birlerdirib ekrana yazdirin


            //Console.WriteLine("What is your name ?");
            //string name = Console.ReadLine();

            //Console.WriteLine("What is your surname ?");
            //string surname = Console.ReadLine();

            //Console.WriteLine("Please enter your phone number : ");
            //string number = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine(
            //    $"Username : {name} {surname}\n" +
            //    $"Age : {age}\n" +
            //    $"Phone number : {number}"
            //    );

            #endregion

        }


    }
}
