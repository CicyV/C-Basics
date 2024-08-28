//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Hello World!");
//            Console.ReadLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            Console.WriteLine("I am Learning C#");
//            Console.WriteLine("It is awesome!");
//            

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            if (20 > 18)
//            {
//                Console.WriteLine("20 is greater than 18");
//                Console.ReadLine();
//            }
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int day = 4;
//            switch (day)
//            {
//                case 1:
//                    Console.WriteLine("Monday");
//                    break;
//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                case 4:
//                    Console.WriteLine("Thursday");
//                    break;
//                case 5:
//                    Console.WriteLine("Friday");
//                    break;
//                case 6:
//                    Console.WriteLine("Saturday");
//                    break;
//                case 7:
//                    Console.WriteLine("Sunday");
//                    break;


//            }
//            Console.ReadLine();
//        }
//    }
//}
//using System;

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 0;
//            do
//            {
//                Console.WriteLine(i);
//                i++;
//            }
//            while (i < 5);

//            Console.ReadLine();
//        }
//    }
//}

//using System;

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine(i);

//            }
//            Console.ReadLine();
//        }
//    }
//}
//using System;

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                if (i == 4)
//                {
//                    break;
//                }
//                Console.WriteLine(i);
//            }
//            Console.ReadLine();
//        }
//    }
//}


using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}