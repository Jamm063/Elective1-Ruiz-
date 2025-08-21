using System;

class Exercises
{
    static void Main()
    {
        // P1 - Even or Odd
        Console.Write("Input a whole number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"Result:The number {num} is Even.");
        }
        else
        {
            Console.WriteLine($"Result:The number {num} is Odd.");
        }

        // P2 - Positive or Negative
        if (num > 0)
        {
            Console.WriteLine($"The number {num} is Positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine($"The number {num} is Negative.");
        }
        else
        {
            Console.WriteLine("The number is Zero.");
        }

        // P3 - Age & Income Category
        Console.Write("Enter your age in years: ");
        int ageInput = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the income per month: ");
        double monthlysalary = Convert.ToDouble(Console.ReadLine());

        if (ageInput >= 25 && ageInput <= 35 && monthlysalary > 50000)
        {
            Console.WriteLine("Classification: You're Young Professional");
        }
        else if (ageInput >= 36 && ageInput <= 55 && monthlysalary > 70000)
        {
            Console.WriteLine("Classification: You're Mid-aged Professional");
        }
        else if (ageInput >= 56 && ageInput <= 100 && monthlysalary < 30000)
        {
            Console.WriteLine("Classification: You're Senior Citizen");
        }
        else
        {
            Console.WriteLine("Classification: Others");
        }

        // P4 - Pass or Fail
        Console.Write("Enter your test score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score < 50)
        {
            Console.WriteLine("Student Result:You Failed the exam");
        }
        else if (score >= 50 && score <= 100)
        {
            Console.WriteLine("Student Result:You Passed the exam");
        }
        else
        {
            Console.WriteLine("Invalid score. Please enter between 0 and 100.");
        }

        // P5 - Circle Operations
        Console.Write("Enter circle radius: ");
        double rad = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nMenu:");
        Console.WriteLine("A - Area");
        Console.WriteLine("P - Perimeter");
        Console.WriteLine("E - Exit the Program");

        Console.Write("Your option: ");
        char pick = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (pick)
        {
            case 'A':
                Console.WriteLine($"Circle Area = {Math.PI * rad * rad}");
                break;

            case 'P':
                Console.WriteLine($"Circle Perimeter = {2 * Math.PI * rad}");
                break;

            case 'E':
                Console.WriteLine("Program terminated.");
                break;

            default:
                Console.WriteLine("Invalid option chosen!");
                break;
        }
    }
}

