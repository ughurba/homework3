using System;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Ay(month) adı daxil edilir.
            //Çıxışa hansı fəsil olduğunu yazdırsın.
            //(if,else muxtelif yollar ile yaza bilersiz)


            //                                     Switch varianti 


         /*  Console.WriteLine("Xaiw edirik awaqidaki aylardan birini yazin ve onun hansi fesil olduqunu oyrenin");
             Console.WriteLine();
             Console.WriteLine("Yanvar , Fevral , Mart , Aprel , May , Iyun , Iyul , Avgust , Sentyabr , Oktyabr , Noyabr , Dekabr");
             string month = Console.ReadLine();

             switch (month)
             {
                 case "Dekabr":
                 case "Yanvar":
                 case "Fevral":
                    Console.WriteLine();
                     Console.WriteLine($"{month} Qiw feslidir");
                     break;
                 case "Mart":
                 case "Aprel":
                 case "May":
                    Console.WriteLine();
                    Console.WriteLine($"{month} Yaz feslidir");
                     break;
                 case "Iyun":
                 case "Iyul":
                 case "Avgust":
                    Console.WriteLine();
                    Console.WriteLine($"{month} Yay feslidir");
                     break;
                 case "Sentyabr":
                 case "Oktyabr":
                 case "Noyabr":
                    Console.WriteLine();
                    Console.WriteLine($"{month} Payiz feslidir");
                     break;
                     default:
                     Console.WriteLine("bele bir ay movcud deyil");
                     break;

             }*/


            //                     if else varianti 

            Console.WriteLine("Xaiw edirik awaqidaki aylardan birini yazin ve onun hansi fesil olduqunu oyrenin");
            Console.WriteLine();
            Console.WriteLine("Yanvar , Fevral , Mart , Aprel , May , Iyun , Iyul , Avgust , Sentyabr , Oktyabr , Noyabr , Dekabr");
            string month = Console.ReadLine();
            if (month == "Yanvar" || month == "Fevral" || month == "Dekabr")
            {
                Console.WriteLine();
                Console.WriteLine($"{month} Qiw feslidir");

            }else if  (month == "Mart" || month == "Aprel" || month == "May"){
                Console.WriteLine();
                Console.WriteLine($"{month} Yaz feslidir");

            }else if (month == "Iyun" || month == "Iyul" || month == "Avgust")
            {
                Console.WriteLine();
                Console.WriteLine($"{month} Yay feslidir");

            }else if (month == "Sentyabr" || month == "Oktyabr" || month == "Noyabr")
            {
                Console.WriteLine();
                Console.WriteLine($"{month} Payiz feslidir");

            }else
            {
                Console.WriteLine("bele bir ay movcud deyil!");
            }



            



        }
    }
}
