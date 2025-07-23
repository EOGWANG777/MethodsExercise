using System.Globalization;
using System.Security.Cryptography;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          Madlib();
            //Madlib2();//
        }
        
        public static void Madlib()
        {
            Console.WriteLine(Multiply(x1: 10, x2: 20));
           // int multiplication = Multiply(x1: 10, x2: 20);//
            //Console.WriteLine(multiplication);//
            
            //Console.WriteLine(subtract(x:79, y:32));//
            int subtraction = (subtract(x: 79, y: 32));
            Console.WriteLine(subtraction);
            
            //Console.WriteLine(add(A:12, B:88));//
            int addition = (add(A: 12, B: 88));
            Console.WriteLine(addition);
            
            //Console.WriteLine(divide(x2:20, y2:80));//
            int division = (divide(x2: 20, y2: 80));
            Console.WriteLine(division);
            
            // Console.WriteLine(sum(8, 8, 8, 3));//
            int addednumbers = sum(8,8,8,3);
            Console.WriteLine(addednumbers);
        
            
            Console.WriteLine("What is your favorite sport?");
            string favoriteSport = Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! which are your favorite flowers?");
            string favFlowers = Console.ReadLine();
            Console.WriteLine("What is your zodiac sign?");
            string zodiacSign = Console.ReadLine();

            Console.WriteLine($"$Hello there! my name is {name} and I really enjoy going for walks, reading books and shopping. At the store like to buy a bouquet of {favFlowers} to enjoy.Currently, the sport I play most is {favoriteSport}. I was born in February, so I am an {zodiacSign} air sign.");
        }
        
        //Exercise two//
        public static int Multiply(int x1, int x2)

        {
            return x1 * x2;
        }

        public static int subtract(int x, int y)
        {
            return x - y;
        }

        public static int add(int A, int B)
        {
            return A + B;
        }

        public static int divide(int x2, int y2)

        {
            return x2 / y2;
        }

        public static int sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;//
                sum += number;
            }

            return sum;
        }

        

     public static   void Madlib2()
     {
            Console.WriteLine("What is your favorite sport?");
            string favoriteSport = Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! which are your favorite flowers?");
            string favFlowers = Console.ReadLine();
            Console.WriteLine("What is your zodiac sign?");
            string zodiacSign = Console.ReadLine();

            Console.WriteLine($"$Hello there! my name is {name} and I really enjoy going for walks, reading books of many genres, and shopping. At the store like to buy a bouquet of {favFlowers} to enjoy.Currently, the sport I play most is {favoriteSport}. I was born in February, so I am an {zodiacSign} air sign.");
     }
     



    }
    
    
}


