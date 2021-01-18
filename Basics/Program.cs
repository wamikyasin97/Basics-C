using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output on different line
            Console.WriteLine("Hello World!");

            //Output on same line
            Console.Write("Hello World ");
            Console.Write("On same line. ");

            //Output variables
            string name = "Wamik Yasin";
            int age = 23;
            Console.WriteLine($"\n{name} is {age} years old.");

            //Type Casting Methods
            int myInt = 10;
            double myDouble = 5.8;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));    
            Console.WriteLine(Convert.ToInt32(myDouble));  
            Console.WriteLine(Convert.ToString(myBool));

            //User input and display
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine($"Entered username is: {username}");

            //User input Typecasting
            Console.WriteLine("\nPlease enter your age");
            double user_age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your entered age is: {user_age}");

            //String Methods
            string firstName = "Wamik ";
            string lastName = "Yasin";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine($"First Name is: {firstName} with {firstName.Length} characters");
            Console.WriteLine($"Last Name is: {lastName} with {lastName.Length} characters");
            int index = fullName.IndexOf("Y");
            Console.WriteLine(fullName.Substring(index));

            //Ternary Operator
            int time = 20;
            string res = time < 22 ? "Good number" : "Bad number";
            Console.WriteLine(res);

            //Case Switch
            int day = 4;
            switch(day)
            {
                case 1:
                    Console.WriteLine("It is Weekday");
                    break;
                case 2:
                    Console.WriteLine("It is Weekend");
                    break;
                default:
                    Console.WriteLine("Have Happy whatever");
                    break;
            }

            //While loop
            int i = 0;
            Console.WriteLine("While loop in working");
            while(i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //for loop
            Console.WriteLine("for loop in working");
            for(int a=0; a<5; a++)
            {
                Console.WriteLine(a);
            }

            //for each loop and arrays
            string[] cars = { "BMW", "Mercedes", "Honda", "Toyota" };
            foreach(string c in cars)
            {
                Console.WriteLine(c);
            }

        }
    }
}
