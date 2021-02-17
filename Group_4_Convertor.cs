using System;
using System.Collections.Generic;

namespace Group_4_Convertor
{
    class Group_4_Convertor
    {
        static void Main(string[] args)
        {
            //Main Menu of the app:
            //Two Numbers for calculation purposes:
            double number1 = 0;
            double number2 = 0;

            //User's choice will be stored here:
            int option = 0;

            //User's choice to either continue using the app to exit it
            String choice = "";

            //For storing MR
            LinkedList<int> listMR = new LinkedList<int>();


            //Options to users to select from
            String[] optionArray = {"Addition","Substraction","Division","Multiplication","Modulus","Factorial","Absolute","Power",
        "Exponential","1/x","Log","Ln","Square Root","Memory Add", "Memory Clear", "Memory Recall","Exit"};

            do
            {
                //Greeting the user and asking his/her choice of number for calcualation purposes
                Console.WriteLine("Welcome To C# Console Calculator");
                Console.WriteLine("Please Enter Your First Number:");
                //Reading first Number

                number1 = Convert.ToDouble(Console.ReadLine());

                //ASking for user's desired operation:
                Console.WriteLine("Please choose any of the following operation to continue:");


                for (int i = 0; i < optionArray.Length; i++)
                {
                    Console.WriteLine("Press " + add(i, 1) + " For " + optionArray[i]);
                }

                //Reading the choice of user
                option = Convert.ToInt32(Console.ReadLine());


                //Applying conditions according to user's input
                switch (option)
                {
                    case 1:

                        Console.WriteLine("Please enter second number to perform addition:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The Addition of " + number1 + " and " + number2 + " is" + ":" + add(number1, number2));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Please enter second number to perform Substraction:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The Substraction of " + number1 + " and " + number2 + " is" + ":" + substraction(number1, number2));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Please enter second number to perform Division:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The Division of " + number1 + " and " + number2 + " is" + ":" + division(number1, number2));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Please enter second number to perform Multiplication:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The Multiplication of " + number1 + " and " + number2 + " is" + ":" + multiplication(number1, number2));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Please enter second number to perform Modulus:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The Modulus of " + number1 + " and " + number2 + " is" + ":" + modulus(number1, number2));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 6:
                        Console.WriteLine("The factorial of " + number1 + " is" + ":" + factorial(Convert.ToInt32(number1)));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("The Absolute of " + number1 + " is" + ":" + absolute(Convert.ToInt32(number1)));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 8:
                        Console.WriteLine("The Power of " + number1 + " is" + ":" + power(Convert.ToInt32(number1)));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 9:
                        Console.WriteLine("The Exponential of " + number1 + " is" + ":" + expoValue(number1));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 10:
                        Console.WriteLine("The 1/x of " + number1 + " is" + ":" + (oneByX(Convert.ToInt32(number1))));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 11:
                        Console.WriteLine("The Log of " + number1 + " is" + ":" + logValue(number1));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 12:
                        Console.WriteLine("The Ln of " + number1 + " is" + ":" + LN(number1));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 13:
                        Console.WriteLine("The Square Root of " + number1 + " is" + ":" + sqrt(number1));
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 14:
                        listMR.AddFirst(Convert.ToInt32(number1));
                        Console.WriteLine("The number has been added to memory");
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 15:
                        listMR.Clear();
                        Console.WriteLine("The Memory Has Been Cleared!");
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 16:
                        int listNumbers = 0;
                        foreach (int number in listMR)
                        {
                            listNumbers += number;
                            Console.WriteLine(Convert.ToDouble(number));
                        }
                        Console.WriteLine("The Number in the Memory is: " + listNumbers);
                        Console.WriteLine("Do you want to perform any other operation?");
                        choice = Console.ReadLine();
                        break;

                    case 17:
                        String exitCommand = "";
                        Console.WriteLine("Do you really want to quit y or n");
                        exitCommand = Console.ReadLine();
                        if (exitCommand == "y")
                        {
                            Environment.Exit(0);
                        }
                        if (exitCommand == "n")
                        {
                            Console.WriteLine("Do you want to perform any other operation?");
                            choice = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Please check command!");
                            choice = Console.ReadLine();
                        }

                        break;
                }
            } while (choice == "y");

        }

        /*This method will return the addition of two numbers*/
        static double add(double num1, double num2)
        {
            double addition = num1 + num2;
            return addition;
        }

        /*This method will return the substraction of two numbers*/
        static double substraction(double num1, double num2)
        {
            double substraction = num1 - num2;
            return substraction;
        }

        /*This method will return the division of two numbers*/
        static double division(double num1, double num2)
        {
            double divison = num1 / num2;
            return divison;
        }

        /*This method will return the multiplication of two numbers*/
        static double multiplication(double num1, double num2)
        {
            double multiplication = num1 * num2;
            return multiplication;
        }

        /*This method will return the modulus of two numbers*/
        static double modulus(double num1, double num2)
        {
            double modulus = num1 % num2;
            return modulus;
        }

        /*This method will return the factorial of a number*/
        static int factorial(int num1)
        {
            int i;
            int factorial = 1;
            for (i = 1; i <= num1; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        /*This method will return the power of a number*/
        static int power(int num1)
        {
            int power = num1 * num1;
            return power;
        }
        /*This method will return the absolute of a number*/
        static int absolute(int num1)
        {
            int absolute = 0;
            if (num1 < 0)
            {
                absolute = num1 * (-1);
            }
            else
            {
                return num1;
            }
            return absolute;
        }
        /*This method will return the exponetial value of a number*/
        static double expoValue(double num1)
        {
            double expoValue = Math.Exp(num1);
            return expoValue;
        }

        /*This method will return the LN value of a number*/
        static double LN(double num1)
        {
            double LN = Math.Log(num1);
            return LN;
        }

        /*This method will return the log value of a number*/
        static double logValue(double num1)
        {
            double logValue = Math.Log10(num1);
            return logValue;
        }
        /*This method will return the sqrt value of a number*/
        static double sqrt(double num1)
        {
            double sqrt = Math.Sqrt(num1);
            return sqrt;
        }

        /*This method will return the 1/x value of a number*/
        static int oneByX(int num1)
        {
            if (num1 <= 0)
            {
                return 0;
            }
            int oneByX = 1 / num1;
            return oneByX;
        }
    }
}
