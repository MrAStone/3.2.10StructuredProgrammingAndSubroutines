using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._10StructuredProgrammingAndSubroutines
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = intFunctionReturner(); //function call and store return value in variable a
            int b = addTwoNumbers(3, 4); // function call with paramters 3 and 4 and stores return value in b
            b = addTwoNumbers(a, b); // function call with parameters being two variables and stores return value in b
            b = addTwoNumbers(a, 231); // function call with one parameter being a variable and the other a value, store return value in b
            Console.WriteLine(getResponseFromUser()); //output return value of function call



            int num = 0; 
            while (!validInput(num, 1, 10)) // loops while return value is false from valid input
            {
                Console.Write("Enter a number between 1 and 10: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"You entered {num}");

            thisIsAProcedure();// don't need to assign or output as procedure doesn't return a value
            procedureWithParameters("first parameter", "another one");
            string s, t;
            s = "Something";
            t = "thingy";
            procedureWithParameters(s, t); // using variables as parameters
            procedureUsingLocalVariables(10, 1, "Some text");

        }
        // Functions need a data type
        // static keyword is used to 
        static int intFunctionReturner()
        {
            return 10; // returns the value 10
        }
        static int addTwoNumbers(int a, int b) // function with two parameters
        {
            return a + b; // adds the parameters a and b and returns the value
        }
        static string getResponseFromUser() // asks for input and returns the value
        {
            Console.Write("Enter something for this function to return: ");
            string response; // local variable - destroyed when function ends
            response = Console.ReadLine();
            return response;
        }

        static bool validInput(int input, int lower, int upper) // checks an input is between two numbers and returns true/false
        {
            if (input >= lower && input <= upper)
            {
                return true; //once a value is returned, function ends
            }
            return false; //will only happen if true has not already been returned
        }

        // in C# a subroutine is defined by declaring the data type as void
        static void thisIsAProcedure()
        {
            Console.WriteLine("I don't return anything!");
            Console.WriteLine("I just do what I need to!");
        }
        static void procedureWithParameters(string first, string second)
        {
            Console.WriteLine($"The values passed into this procedure are {first} and {second}");
        }
        static void procedureUsingLocalVariables(int a,int b, string s)
        {
            int result = 0; // local variable
            for (int i  = 0; i < a; i++)
            {
                result += b;
            }
            Console.WriteLine($"{s} is a passed in parameter and {result} is local");
            Console.WriteLine($"Once this procedure finishes, {result} no longer exists in the program");
            Console.WriteLine("This makes my program more efficient as it only uses memory when needed");
            Console.WriteLine("If i used global variables, they would allways exist in memory when the program runs");
        }
    }

}
