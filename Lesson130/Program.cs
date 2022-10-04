using System;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {

                //Console.WriteLine("1-ci reqemi daxil edin");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("2-ci reqemi daxil edin");
                //int b = Convert.ToInt32(Console.ReadLine());
                //   Console.WriteLine("    eded:"+ Math.Round(5.2)+"  T " + Math.Floor(5.7) );
                string str = Console.ReadLine();
                var firstIndex = str.ToLower().IndexOf('m');
                var lastIndex = str.ToLower().LastIndexOf('m');
                if (firstIndex==lastIndex)
                {
                    Console.WriteLine("1 dene t herfi var ");
                }
                else
                {
                    Console.WriteLine("1-den cox t herfi var");
                }
                //for (int i = 0;  i<5 ; i++)
                //{
                //    char a = Convert.ToChar(Console.ReadLine());
                //    double result = 0;  
                //    switch (a)
                //    {
                //        case '+':
                //            Console.WriteLine("Bu  ++++dir");
                //            int b = 5;
                //            int c = 3;
                //            result = Math.Pow(b, c);
                //            Console.WriteLine(result);
                //            break;
                //        case '-':
                //            Console.WriteLine("Bu -------dir");
                //            break;
                //        case '*':
                //            Console.WriteLine("Bu *****dir");
                //            break;
                //        case '/':
                //            Console.WriteLine("Bu //////dir");
                //            break;
                //        default:
                //            Console.WriteLine("uygun olmuyan hall");
                //            break;
                //    }
                //}

               
                //Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine("error bas verdi");
                 
            }
             


            
             

            
        }

       
    }
}
