using System;

namespace ConditionalDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please enter what your grade as a decimal is (ex. 64).");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if (grade < 60)
                {
                    Console.WriteLine("You have an F in the class. Please reach out for help!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 60 && grade <=61)
                {
                    Console.WriteLine("You have a D- in the class. Please reach out for help!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("You have a D in the class. Please reach out for help!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("You have a D+ in the class. Please reach out for help!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("You have a C- in the class. You passed the course, but barely!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("You have a C in the class. You passed the course!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("You have a C+ in the class. You passed the course, and you were so close to a B!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("You got a B- in the class. That's pretty good!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("You got a B in the class. Good job!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("You got a B+ in the class. Great work!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 90 && grade <= 91)
                {
                    Console.WriteLine("You got an A- in the class. Congrats!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("Congrats! You got an A in the class. Great work!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                else if (grade >= 98 && grade <= 100)
                {
                    Console.WriteLine("Awesome! You got an A+ in the class! Great work");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }   
            }//end of try

            catch
            {
                Console.WriteLine("Error! Please enter a value from 0-100. IF you have above a 100, enter 100.");
                Console.WriteLine("Please press any button to exit and try again.");
                Console.ReadKey(true);
            }//end of catch
        }
    }
}
