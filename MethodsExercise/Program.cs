using System.Globalization;
using System.Security.Cryptography;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Madlib();
          
          int Multiplication = Multiply(x1: 10, x2: 20);
          //Console.WriteLine(multiplication);//
          Console.WriteLine(Multiplication);
            
          int Subtraction = (Subtract(x: 79, y: 32));
          // Console.WriteLine(subtraction);//
          Console.WriteLine(Subtraction);
            
          int Addition = (Add(A: 12, B: 88));
          //Console.WriteLine(addition);//
          Console.WriteLine(Addition);
            
          int Division = (Divide(x2: 20, y2: 80));
          // Console.WriteLine(division);//
          Console.WriteLine(Division);
            
          int AddedNumbers = Sum(8,8,8,3);
          //Console.WriteLine(addedNumbers);//
          Console.WriteLine(AddedNumbers);
        }
        
        public static void Madlib()
        {
            
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


        public static int Multiply(int x1, int x2) 
        
        {
            
            return x1 * x2;
        }

        public static int Subtract(int x, int y)
        
        {
            
            return x - y;
        }

        public static int Add(int A, int B)
        
        {
            
            return A + B;
        }

        public static int Divide(int x2, int y2)

        {
            
            return x2 / y2;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                
                //sum = sum + number;//
                sum += number;
            }

            return sum;
        }

        

    }
    
    
}


