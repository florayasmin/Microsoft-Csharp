using System;

class Program
{
    static void Main()
    {
        string studentName = "Yasmin";
        string course1Name = "English 182";
        string course2Name = "Algebra 208";
        string course3Name = "Physics 101";
        string course4Name = "Computer Science 123";
        string course5Name = "Psychology 210";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHours = 0;
        totalCreditHours += course1Credit;
        totalCreditHours += course2Credit;
        totalCreditHours += course3Credit;
        totalCreditHours += course4Credit;
        totalCreditHours += course5Credit;

        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

        int leadingDigit = (int) gradePointAverage;
        int firstDigit = (int) (gradePointAverage * 10) % 10;
        int secondDigit = (int) (gradePointAverage * 100 ) % 10;

        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine("Course\t\t\tGrade\tCredits");

        Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
        Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
        Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
        Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
        Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}");

        Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
    }
}
