using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume myResume = new Resume();
        myResume._name="Jose R. Meza";

         job1._jobTitle = "Software Engineer";
         job1._company = "Microsoft";
         job1._endYear = 2020;
         job1._startYear = 2018;

         job2._jobTitle = "Manager";
         job2._company = "Apple";
         job2._endYear = 2022;
         job2._startYear = 2020;

         myResume._jobs.Add(job1);
         myResume._jobs.Add(job2);

         myResume.Display();

    }
}