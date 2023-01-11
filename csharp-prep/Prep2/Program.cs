using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your grade calculator.");
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);


        if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is 'A'. You have passed the course.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your letter grade is 'B'. You have passed the course.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your letter grade is 'C'. You have passed the course.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your letter grade is 'D'. You did not pass but we believe in you.");
        }
        else
        {
            Console.WriteLine("Your letter grade is 'F'. You did not pass but we believe in you.");
        }
    }
}

// git remote -v git status - git add . - git status - git commit -m "Here it is!" - git push :q!