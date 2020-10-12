using System;
using CalculatorLibrary;

namespace ConsoleCalculator
{
    public class Program
    {

        private static bool firstCharIsNegativeForFirstNumber;
        private static bool firstCharIsNegativeForSecondNumber;

        public static void Main()
        {
            // Calculator

            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ CALCULATOR ++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.WriteLine("\t% - Modulo");
            // We repeat operations until the users enters other that Y or y
            bool repeat;
            // We create an object from the Class Calculator
            // before entering inside the loop
            Calculator calculator = new Calculator();
            do
            {
                String firstNumberString;

                bool isNumber;
                // We loop until the user enters a valid number
                // The user is allowed to enter "." for example 34.54
                // If the user enters for example 34.54. it is not 
                // a valid double number, it will be rejected
                do
                {
                    isNumber = true;
                    Console.WriteLine("Enter the First Number: ");
                    firstNumberString = Console.ReadLine();
                    firstNumberString = firstNumberString.Trim();
                    if (firstNumberString.Substring(0, 1) == "-")
                    {
                        firstCharIsNegativeForFirstNumber = true;
                    }
                    else
                    {
                        firstCharIsNegativeForFirstNumber = false;
                    }
                    isNumber = checkValidityOfNumber(firstNumberString, isNumber, firstCharIsNegativeForFirstNumber);
                } while (isNumber == false);

                String operation = "";
                // We loop until the user enters a valid operator
                // Anything except "+" or "-" or "*" or "/" or "%" is not accepted
                do
                {
                    Console.WriteLine("Enter A Valid Operator: ");
                    operation = Console.ReadLine();
                } while (operation != "+" && operation != "-" && operation != "*" &&
                         operation != "/" && operation != "%");

                String secondNumberString;

                // We check the number validity of the second entered number
                do
                {
                    isNumber = true;
                    Console.WriteLine("Enter The Second Number: ");
                    secondNumberString = Console.ReadLine();
                    secondNumberString = secondNumberString.Trim();
                    if (secondNumberString.Substring(0, 1) == "-")
                    {
                        firstCharIsNegativeForSecondNumber = true;
                    }
                    else
                    {
                        firstCharIsNegativeForSecondNumber = false;
                    }

                    isNumber = checkValidityOfNumber(secondNumberString, isNumber, firstCharIsNegativeForSecondNumber);
                } while (isNumber == false);

                // firstNumberString and secondNumberString are converted to double to
                // make operations
                double firstNumberDouble = Double.Parse(firstNumberString);
                double secondNumberDouble = Double.Parse(secondNumberString);
                //if (firstCharIsNegativeForFirstNumber)
                //{
                //    firstNumberDouble = -firstNumberDouble;
                //}
                //if (firstCharIsNegativeForSecondNumber)
                //{
                //    secondNumberDouble = -secondNumberDouble;
                //}

                double result;
                String resultDivision;
                result = calculator.DoOperation(firstNumberDouble, secondNumberDouble, operation);
                resultDivision = calculator.getMessageDivideByZero();
                if (!resultDivision.Trim().Equals(""))
                {
                    Console.WriteLine(resultDivision);
                }
                else
                {
                    Console.WriteLine("Result: ");
                    Console.WriteLine(result);

                }
                String anotherOp;
                Console.WriteLine("Another Operation?: Y Or y for Yes or enter to quit: ");
                anotherOp = Console.ReadLine();
                if (anotherOp == "Y" || anotherOp == "y")
                {
                    repeat = true;
                }
                else
                {
                    calculator.Finish();
                    repeat = false;
                }

            } while (repeat == true);

            static bool checkValidityOfNumber(String strNumber, bool isNumber, bool firstCharIsNegative)
            {
                if (firstCharIsNegative)
                {
                    strNumber = strNumber.Substring(1);
                }
                if (strNumber.Trim().Equals(""))
                {
                    isNumber = false;
                }
                else if(strNumber.Substring(0, 1) == "-")
                {

                }
                else
                {
                    int nbrOfDots = 0;
                    foreach (char c in strNumber)
                    {
                        if (!char.IsDigit(c))
                        {
                            if (c == '.')
                            {
                                nbrOfDots++;
                                if (nbrOfDots > 1)
                                // Only one "." is accepted
                                {
                                    isNumber = false;
                                    continue;
                                }
                            }
                            else
                            {
                                isNumber = false;
                                continue;
                            }
                        }
                    }

                }
                return isNumber;
            }
        }
    }

}