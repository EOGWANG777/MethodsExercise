using System.Globalization;
using System.Security.Cryptography;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          //  Madlib();//
            Madlib2();
        }
        
        public static void Madlib()
        {
           // Console.WriteLine("What is your favorite sport?");//
            string favoriteSport = Console.ReadLine();
           // Console.WriteLine("What is your name?");//
            string name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}! which are your favorite flowers?");//
            string favFlowers = Console.ReadLine();
           // Console.WriteLine("What is your zodiac sign?");//
            string zodiacSign = Console.ReadLine();

            //Console.WriteLine($"$Hello there! my name is {name} and I really enjoy going for walks, reading books and shopping. At the store like to buy a bouquet of {favFlowers} to enjoy.Currently, the sport I play most is {favoriteSport}. I was born in February, so I am an {zodiacSign} air sign.");//
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

            Console.WriteLine($"$Hello there! my name is {name} and I really enjoy going for walks, reading books and shopping. At the store like to buy a bouquet of {favFlowers} to enjoy.Currently, the sport I play most is {favoriteSport}. I was born in February, so I am an {zodiacSign} air sign.");
     }

    }
    
    
}


