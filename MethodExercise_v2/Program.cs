using System;

namespace MethodExercise_v2
{
    internal class Program
    {
        public static void SillyStory()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"One day {name} went on a walk down the street. They were busy listening to their favorite band {band} when they happened upon a {color} {animal}.");
        }
        public static void Add()
        {
            int sum = 0;
            Console.WriteLine($"Please enter how many numbers you wish to add:");
            int howManyNumbers = int.Parse(Console.ReadLine());
            int[] list = new int[howManyNumbers];
            for(int i=0;  i<list.Length; i++)
            {
                Console.WriteLine($"Please enter your {i + 1} number: ");
                list[i] = int.Parse(Console.ReadLine());  
                sum = sum + list[i];
            }
            Console.WriteLine($"Your answer is {sum}.");
        }
        //public static int Add(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        public static void Subtract()
        {
            int sub = 0;
            Console.WriteLine($"Please enter how many numbers you wish to subtract:");
            int howManyNumbers = int.Parse(Console.ReadLine());
            int[] list = new int[howManyNumbers];
            int ii = 0;
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"Please enter your {i + 1} number: ");
                list[i] = int.Parse(Console.ReadLine());
                    if(ii==0)
                    {
                        sub = list[0];
                        ii = 1;
                    }
                    else
                    {
                        sub = sub - list[i];
                    }
            }
            Console.WriteLine($"Your answer is {sub}.");
        }
        //public static int Subtract(int num1, int num2)
        //{
        //    return num1 - num2;
        //}
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Would you like to make a silly story or play a number game? Press '1' for story and '2' for numbers: ");
            int gameChoice = int.Parse(Console.ReadLine());

            if (gameChoice == 1)
                {
                Console.WriteLine($"Today we will make a silly story, please answer the following questions to do so:");
                SillyStory();
                }
            if (gameChoice == 2)
                {
                Console.WriteLine($"Today we will play with numbers.");

                Console.WriteLine($"Would you like to add, subtract, multiply, divide, or modulus today? Please enter the name as listed in this text previously.");
                string answerNumbersText = Console.ReadLine();

                if (answerNumbersText == "add")
                {
                    Add();
                    //int add = Add(2,3);
                    //Console.WriteLine($"The answer is: {add}");
                }
                if (answerNumbersText == "subtract")
                {
                    Subtract();
                    // int subtract = Subtract(2,3);
                    // Console.WriteLine($"The answer is: {subtract}");
                }
                if (answerNumbersText == "multiply")
                {
                    Console.WriteLine($"We will now multiply, please input your first number:");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Now please input your second number:");
                    int secondNumber = int.Parse(Console.ReadLine());
                    int multiply = Multiply(firstNumber, secondNumber);
                    Console.WriteLine($"The answer is: {multiply}");
                    //int multiply = Multiply(2,3);
                    //Console.WriteLine($"The answer is: {multiply}");
                }
                if (answerNumbersText == "divide")
                {
                    Console.WriteLine($"WARNING: Will only display as an integer, so result will be round down to the nearest integer:");
                    //int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"We will now divide, please input your first number:");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Now please input your second number:");
                    int secondNumber = int.Parse(Console.ReadLine());
                    int divide = Divide(firstNumber, secondNumber);
                    Console.WriteLine($"The answer is: {divide}");
                    //int divide = Divide(2,3);
                    //Console.WriteLine($"The answer is: {divide}");
                }
                if (answerNumbersText == "modulus")
                {
                    Console.WriteLine($"We will now check the modulus, please input your first number:");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Now please input your second number:");
                    int secondNumber = int.Parse(Console.ReadLine());
                    int modulus = Modulus(firstNumber, secondNumber);
                    Console.WriteLine($"The answer is: {modulus}");
                    //int modulus = Modulus(2,3);
                    //Console.WriteLine($"The answer is: {modulus}");
                }

            }

        }
    }
}
