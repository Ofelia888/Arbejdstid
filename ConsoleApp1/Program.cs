using System.ComponentModel.Design;

namespace Arbejdstid
{
    class Methods
    {
        public string input1;
        public string input2;
        public TimeOnly checkIn;
        public TimeOnly checkOut;

        public TimeOnly Program1()
        {
            Console.WriteLine("\nTryk '1' for at tjekke ind");
            input1 = Console.ReadLine();
            checkIn = TimeOnly.FromDateTime(DateTime.Now);
            if (input1 == "1")
                Console.WriteLine("\nTjekket ind kl. " + checkIn + "\nAfventer tjek-ud...");
            else
            {
                Console.WriteLine("\nForkert input");
                Program1();
            }
            return checkIn;
        }

        public TimeOnly Program2()
        {
            Console.WriteLine("\nTryk '2' for at tjekke ud");
            input2 = Console.ReadLine();
            checkOut = TimeOnly.FromDateTime(DateTime.Now);
            if (input2 == "2")
            {
                Console.WriteLine("\nTjekket ud kl. " + checkOut);
            }
            else
            {
                Console.WriteLine("\nForkert input");
                Program2();
            }
            return checkOut;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            methods.Program1();
            methods.Program2();

            TimeOnly workHrs = TimeOnly.FromTimeSpan(methods.checkOut - methods.checkIn);
            Console.WriteLine("\nArbejdstid for dagen: " + workHrs);
        }
    }
}