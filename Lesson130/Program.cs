using System;
using System.Text;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {

            // impilicit
            //int i = 5;
            //double dv = i;

            //// expilicit
            //double dbl = 45.8;
            //int num =(int) dbl;

            //// unboxing
            //object obj = "56";
            //int number =(int) obj;
            //// boxing
            //double dbl2 = 45.7;
            //object obj2 = dbl2;

            // Random random = new Random();
            // int ramEded = random.Next(25,50);
            //// Console.WriteLine(ramEded);

            // Guid guid = Guid.NewGuid();
            // Console.WriteLine(guid);
            //int x = 3;
            //int y = 35;
            //string str = null;
            // ternary operator
            //  var rgrfr = y > x ? "" : "";
            // var  Enboyuk = x > y ? 25.6 : 456.8;

            //null coalescing
            //   var str2 = str ?? "Null-dir";
            // Console.WriteLine(Enboyuk);

            //if ( y>x  )
            //{
            //    Console.WriteLine("Ela");
            //}
            //int number = 16;
            #region switch goto
            //switch (number)
            //{
            //    case 5:
            //        Console.WriteLine("case 5");
            //        break;
            //    case 6:
            //        Console.WriteLine("case 6");
            //        break;
            //    case 7:
            //        Console.WriteLine("case  7");
            //        goto case 5;
            //    default:
            //        Console.WriteLine("uygun olmuyan hall");
            //        break;
            //}

            #endregion

            //switch (1)
            //{
            //    case int x when x > 445:
            //        Console.WriteLine("case x>15");
            //        break;
            //    case int x when x+5 <14:
            //        Console.WriteLine("case x<4");
            //        break;
            //    default:
            //        Console.WriteLine("uygun olmuyan hall");
            //        break;
            //}

            //while (number>25)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //int result = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%33==0)
            //    {
            //        result++;
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("say"+result);

            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number > 12);
            //int b = 5;
            //b = 15;
            //string name = "Nurlan";
            //name += " Xankisiyev";
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Teymur");
            //stringBuilder.Append(" Memmed");
            //Console.WriteLine(stringBuilder.ToString());
            //    for (int i = 1; i < 100; i++)
            //    {
            //        if (i%17==0)
            //        {
            //            Console.WriteLine("ilk 17-e bolunewn"+i);
            //            break;
            //        }
            //        Console.WriteLine(i);
            //    }

            //string str = Console.ReadLine();
            //if (str==null || str==" ")
            //{
            //    Console.WriteLine("is null or whitespace");
            //}

            //Console.WriteLine(str??"is null");

            //if (String.IsNullOrWhiteSpace(str))
            //{
            //    Console.WriteLine("is null or whitespace");
            //}
            //int number = Int32.Parse(Console.ReadLine());
            //int sum = 0;
            //int r = 0;
            //Random random = new Random();
            //for (int i = 0; i < number; i++)
            //{
            //    r = random.Next(200);
            //    Console.WriteLine(r);
            //    sum = sum + r;
            //}
            //Console.WriteLine("yekun netice: "+sum);

            //double? dbl = null;
            //var test = dbl.ToString() ?? "nulldur";
            //Console.WriteLine(test);

            //string str = "salam";
            //string strOld = str;
            //for (int i = 0; i < 1000; i++)
            //{
            //    str += $"iteration number {i} ";
            //}
            // Console.WriteLine(num );
            //int[] array  = { 56,6,78,98,2};
            //string[] arrayStr  = { "salam","netersen","ne "};
            //string str = "Salam";
            //var strNew = str.Split(" ");
            //var strChar = str.ToCharArray();
            //foreach (var item in strChar)
            //{
            //    Console.WriteLine(item);
            //}
            //bool check = true;
            //while (check)
            //{
            //    if( )
            //    {
            //        check = false;
            //    }
            //}
            int eded = Convert.ToInt32(Console.ReadLine());
            
            Random random = new Random();
            int min = random.Next();//56
            for (int i = 0; i < eded-1; i++)
            {
                int newNum = random.Next();//45 /6767
                if (newNum<min)
                {
                    min = newNum;
                }
            }
            Console.WriteLine(min);
        }

        static int  DoOperation(int op, int a, int b)
        {
            switch (op)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                default: return 0;
            }
        }
 

    }
}
