using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool loop = true;
            int choice;
            
            

            while (loop)
            {
                
                
                Console.WriteLine("Welcome to Calculator Program, Please select an operation from the menu:\n" +
                "1.Addition Operation (+).\n" +
                "2.Subtraction Operation(-).\n" +
                "3.Multiplication Operation(*).\n" +
                "4.Division Operation(/).\n" +
                "5.Square Root Operation (√)\n" +
                "6.Power ^2 Operation (^2).\n" +
                "7.Exit.");


                //choice = Convert.ToInt32(Console.ReadLine());
                //Get an Exeption error when user press enter without selecting any number.
                    
                int.TryParse(Console.ReadLine(),out choice); // This more useful.
                    
                    


                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Plus();
                        break;
                    case 2:
                        Console.Clear();
                        Sub();
                        break;
                    case 3:
                        Console.Clear();
                        Multi();
                        break;
                    case 4:
                        Console.Clear();
                        Div();
                        break;
                    case 5:
                        Console.Clear();
                        Squrt();
                        break;
                    case 6:
                        Console.Clear();
                        Pow2();
                        break;
                    case 7:
                        Console.WriteLine("Thank you Program has been shutting down!");
                        loop = false;
                        break;
                        

                    default:
                            
                        Console.WriteLine("Invalid Choice, please try again");
                        break;


                }
                Console.ReadKey();
                Console.Clear();

           

            }


            
        }

        
       static void Plus()
        {
            try
            {
                Console.WriteLine("Addition Operation (+)");
                Console.WriteLine("Enter Numbers Separated with (+) Operator: ");

                List<double> numlistinput = new List<double>();
                List<double> numlist = new List<double>();

                numlistinput = Console.ReadLine().Split('+').Select(double.Parse).ToList();


                double result = numlistinput.Sum(z => Convert.ToDouble(z));
                Console.WriteLine("The result for (Addition) is: {0} .", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter valid format numbers !");
            }
            
            

        }


        static void Sub()
        {
            try
            {
                Console.WriteLine("Subtraction Operation (-)");
                Console.WriteLine("Enter Numbers separated with (-) operator : ");
                string numinput = Console.ReadLine();
                string[] numbers = numinput.Split(',');
                DataTable sub = new DataTable();
                var values = numbers.Select(x => sub.Compute(x, null));
                string result = String.Join(", ", values);
                Console.WriteLine("The result for (Subtraction) is: {0} .", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter valid format numbers and must be separated by (-)!");
            }
           

        }


        static void Multi()
        {
            try
            {
                Console.WriteLine("Multiplication Operation (X)");
                Console.WriteLine("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = num1 * num2;
                Console.WriteLine("The result for (Multiplication) is: {0} .", result);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
           
        }


        static void Div()
        {
            try
            {
                Console.WriteLine("Division Operation (/)");
                Console.WriteLine("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = num1 / num2;
                Console.WriteLine("The result for (Division) is: {0} .", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

        }


        static void Squrt()
        {
            try
            {
                Console.WriteLine("Square Root Operation (√)");
                Console.WriteLine("Enter a number to get a Square Root: ");
                double num = Convert.ToDouble(Console.ReadLine());
                double squrt = Math.Sqrt(num);
                Console.WriteLine("The result for (Squre Root) is: {0} .", squrt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }


        static void Pow2()
        {
            try
            {
                Console.WriteLine("Power ^2 Operation (^2)");
                Console.WriteLine("Enter a number to get ^2 for it: ");
                double num = Convert.ToDouble(Console.ReadLine());
                double pow = Math.Pow(num, 2);
                Console.WriteLine("The result for (Power ^2)  is: {0} .", pow);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }



    }
}
