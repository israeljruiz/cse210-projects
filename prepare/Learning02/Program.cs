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

        job1.Display();

        Job job2 = new Job();
        job2._company = "Alphabet";
        job2._jobTitle = "Security specialist";
        job2._startYear = 2026;
        job2._endYear = 2030;

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Israel Ruiz";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}