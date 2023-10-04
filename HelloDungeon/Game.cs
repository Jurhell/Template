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
        Mayro Mayo;

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

        public string GetInput(string prompt, string choice1, string choice2)
        {
            string input = "";

            while (input != "1" && input != "2")
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1. " + choice1);
                Console.WriteLine("2. " + choice2);

                input = Console.ReadLine();

                if (input == "1")
                {
                    input = "1";
                }
                else if (input == "2")
                {
                    input = "2";
                }
                else
                {
                    Console.WriteLine("That is not a choice.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }

            return input;
        }

        public void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public int Pab(int a, int b)
        {
            if (a < b)
            {
                return a;
            }

            return b;
        }

        int[] blank = new int[] { 1, 2, 3, 4, 5, 6};

        public void ReverseArray(int[] array)
        {
            int sum = 0;

            for (int i = array.Length - 1; i >= array[0] - 1; i--)
            {
                Console.WriteLine(array[i]);
            }
            
        }

        public void ArraySum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
        }

        public void Start()
        {
            Mayo = new Mayro("Mayonnaise", "Is mayonnaise an instrument?", 10000, true, 50);
        }

        public void Update()
        {

        }

        public void Run()
        {
            ReverseArray(blank);

            return;

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
        }
    }
}
