using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Netflix";
        job1._jobTitle = "Head developer";
        job1._startYear = 2023;
        job1._endYear = 2026;

        Console.WriteLine(job1._company);
        Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job1._startYear);
        Console.WriteLine(job1._endYear);
    }
}