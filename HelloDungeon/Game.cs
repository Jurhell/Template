using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        private bool _weapon = false;
        private string _crazy = "Crazy? I was crazy once. \nThey locked me in a room. \nA rubber room filled with rats. \nRats make me crazy.\n";
        private string _input = "";
        private bool _correctChoice = false;

        public void Crazy()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i != 15)
                {
                    Console.WriteLine(_crazy);
                }
            }
        }

        public int Pab(int a, int b)
        {
            int result;

            if (a < b)
            {
                result = a;
            }
            else 
            {
                result = b;
            }

            return result;
        }

        public void Update()
        {

        }

        public void Run()
        {
            Console.WriteLine(Pab(3, 5));

            while (!_correctChoice)
            {
                Console.WriteLine("Choose yo class brah.");
                Console.WriteLine("1. No class");
                Console.WriteLine("2. Knight");
                Console.WriteLine("3. Fish smoothie");
                Console.WriteLine("4. Bottle eater");
                Console.WriteLine("5. Tree hugger");
                Console.WriteLine("6. Back flipper");
                Console.WriteLine("7. GioGio");
                Console.WriteLine("8. One Piece Is Real");
                Console.WriteLine("9. All of the above");

                _input = Console.ReadLine();

                if (_input == "7")
                {
                    Console.WriteLine("\nCorrect!");
                    _correctChoice = true;
                }
                else
                {
                    Console.WriteLine("\nNope! Try again dummy!\n");
                }

            }

            Crazy();

            return;

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\n");

            for (i = 0; i <= 10; i+=2 )
            {
                Console.WriteLine(i);
            }
        }
    }
}
