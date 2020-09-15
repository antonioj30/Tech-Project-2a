using System;
using System.Linq.Expressions;

namespace Tech_Project_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer value between 1 and 25 to execute an iterative statement: ");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if((value_of_input > 1) &&(value_of_input <= 25))
                {
                    Console.WriteLine("Executing a Do While Loop!");
                    Console.WriteLine("The While Loop will iterate" + value_of_input.ToString()+"times.");
                    //Here is the Do While Loop
                    do
                    {
                        Console.WriteLine("The value of the iterative varible is: " + value_of_input.ToString());
                        value_of_input--;
                    } while (value_of_input > 0);
                    Console.WriteLine("Press any ket to exit the program...");
                    Console.ReadKey(true);
                }
                // If the user does not enter a value bettween 1 and 25, dispaly message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again...");
                    Console.WriteLine("Press any ket to exit the program and try gain...");
                    Console.ReadKey(true);
                }
            }//End of try
            catch
            {
                Console.WriteLine("Please enter an interger value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }// End of catch
        }//End of Main
    }//End of class
}//End of namspace
