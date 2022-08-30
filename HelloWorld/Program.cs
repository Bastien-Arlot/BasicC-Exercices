
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.exercice4();
            
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
    }
}