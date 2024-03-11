Console.WriteLine("-------------------");
Console.WriteLine("Calculator Program");
Console.WriteLine("-------------------");

double num1;
double num2;
double result;
string answer;

do
{
    Console.Write("Enter number 1 :");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2 :");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an option");
    Console.WriteLine("\t + : Add");
    Console.WriteLine("\t - : Minus");
    Console.WriteLine("\t * : Multiply");
    Console.WriteLine("\t / : Divide");
    Console.Write("Enter an option :");
    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result is : {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result is : {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result is : {num1} x {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result is : {num1} / {num2} = " + result);
            break;
    }
    Console.WriteLine("Do you want to continuse? (Y/N)");
    answer = Console.ReadLine();
    answer = answer.ToUpper();
} 
    while (answer != "N");
Console.WriteLine("Thank you");

Console.ReadKey();