using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}

// {
//     List<string> numbersInput = new List<string>();

//     Console.WriteLine("Enter an integer or 0 to quit. ");
//     string input = Console.ReadLine();
//     numbersInput.Add(input);

//     while (input != "")
//     {
//         Console.WriteLine("Enter another integer or 0 to quit. ");
//         input = Console.ReadLine();
//     }

//     if (input == "")
//     {
//         Console.WriteLine("The number you have entered is: " + " " + input);
//         numbersInput.Add(input);

//         foreach (string value in numbersInput)
//         {
//             Console.WriteLine("The number that was added to the list is :" + "" + value);
//         }
//         Console.ReadLine();
//     }


// List<string> words = new List<string>();

// words.Add("phone");
// words.Add("keyboard");
// words.Add("mouse");
// {
//     Console.WriteLine(words.Count);
// }

// foreach (String word in words)
// {
//     Console.WriteLine(word);
// }

// for (int i = 0; i < words.Count; i++)
// {
//     Console.WriteLine(words[i]);
// }