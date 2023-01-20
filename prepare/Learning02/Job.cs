using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job(string aCompany, string aJobTitle, int aStartYear)
    {
        _company = aCompany;
        _jobTitle = aJobTitle;
        _startYear = aStartYear;
    }

    public void Display()
    {
        Console.WriteLine($"{_company} {_jobTitle} {_startYear}-{_endYear}");
    }

}