using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int percentage = int.Parse(gradePercentage);
        string grade = " ";
        if (percentage >= 90)
            grade = "A";
        else if (percentage >= 80)
            grade = "B";
        else if (percentage >= 70)
            grade = "C";
        else if (percentage >= 60)
            grade = "D";
        else
            grade = "F";
        if (percentage % 10 >= 7 && (grade != "A" && grade !="F"))
            grade = grade + "+";
        else if(percentage % 10 <= 3 && grade != "F")
            grade = grade + "-";
         
            Console.WriteLine($"Your grade is {grade} ");
        if (percentage <=69)
            Console.WriteLine("Do not quit keep trying!");
        else
            Console.WriteLine("Congratulations you have passed the class!");

        
    }
}