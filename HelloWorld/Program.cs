
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.exercice7();
            
        }
        public void exercice1()
        {
            int counter = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        public void exercice2()
        {

            Console.WriteLine("Press a number or ok to exit");
            var input = Console.ReadLine();

            while (input != "ok")
            {
                Console.WriteLine("Press a number or ok to exit");
                input = Console.ReadLine();
            }
        }
        public void exercice3()
        {

            Console.WriteLine("");
        }

        public void exercice4()
        {
            int sum = 0;
            for (var i = 0; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    sum++;
                }
            }
            Console.Write("There are {0} numbers divisible by 3 between 1 and 100", sum);
        }

        public void exercice5()
        {
          
            var sum = 0;
            while(true)
            {
                string exitInput = "ok";
                Console.Write("Enter a number or ok to exit: ");
                var input = Console.ReadLine();


                if (input.ToLower() == exitInput)
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of your selected numbers is {0}", sum);
        }

        public void exercice6()
        {
            Console.WriteLine("Enter a number and i'll compute its factorial");
            var number = Convert.ToInt32(Console.ReadLine());
            var result = 1;

            for(var i = 1; i <= number; i++)
            {
                result *= i;
                Console.WriteLine(result);
            }
            Console.WriteLine("{0}! = {1}", number, result);
        }

        public void exercice7()
        {
            var secretNumber = new Random().Next(1, 10);
            var count = 0;
            Console.WriteLine("Try to find our secret number betweem 1 and 10, you have 4 tries");
            while (count < 4)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if(input == secretNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
               count++;
            }
            Console.WriteLine("you lost the secret number was {0}", secretNumber);  
        }

    }
}