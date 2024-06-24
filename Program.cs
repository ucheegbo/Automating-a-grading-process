/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sonya", "Uchenna", "Israel", "Kaina", "Philip", "Michael", "Quinn", "Olive" };

int[] sonyaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] uchennaScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] israelScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] kainaScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] philipScores = new int[] { 92, 98, 86, 81, 94, 98 };
int[] michaelScores = new int[] { 91, 93, 97, 85, 97, 96 };
int[] quinnScores = new int[] { 98, 85, 97, 78, 86, 86, 97 };
int[] oliveScores = new int[] { 100, 95, 89, 78, 96, 99, 88 };


int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sonya")
        studentScores = sonyaScores;

    else if (currentStudent == "Uchenna")
    {
        studentScores = uchennaScores;
    }

    else if (currentStudent == "Israel")
    {
        studentScores = israelScores;
    }

    else if (currentStudent == "Philip")
    {
        studentScores = philipScores;
    }

    else if (currentStudent == "Quinn")
    {
        studentScores = quinnScores;
    }

    else if (currentStudent == "Michael")
    {
        studentScores = michaelScores;
    }

    else if (currentStudent == "Olive")
    {
        studentScores = oliveScores;
    }

    else if (currentStudent == "Kaina")
    {
        studentScores = kainaScores;
    }

    else 
    {
        continue;
    }                    



    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int addExamScores = 0;
    int addExtraCreditExamScores = 0;

    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditPoints = 0;

    /* 
    the inner foreach loop adds assignment scores and
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            addExamScores += score;
        }

        else
        {
            gradedExtraCreditAssignments += 1;
            addExtraCreditExamScores += score;
        }
    }

    currentStudentExamScore = (decimal)(addExamScores) / examAssignments;
    currentStudentExtraCreditPoints = (decimal)(addExtraCreditExamScores) / gradedExtraCreditAssignments;

    currentStudentGrade = (decimal)((decimal) addExamScores + ((decimal)addExtraCreditExamScores / 10)) / examAssignments;

    if (currentStudentGrade >= 97) 
    {
        currentStudentLetterGrade = "A+";
    }

    else if (currentStudentGrade >= 93)
    {
        currentStudentLetterGrade = "A";
    }

    else if (currentStudentGrade >= 90)
    {
        currentStudentLetterGrade = "A-";
    }

    else if (currentStudentGrade >= 87)
    {
        currentStudentLetterGrade = "B+";
    }

    else if (currentStudentGrade >= 83)
    {
        currentStudentLetterGrade = "B";
    }

    else if (currentStudentGrade >= 80)
    {
        currentStudentLetterGrade = "B-";
    }

    else if (currentStudentGrade >= 77)
    {
        currentStudentLetterGrade = "C+";
    }

    else if (currentStudentGrade >= 73)
    {
        currentStudentLetterGrade = "C";
    }

    else if (currentStudentGrade >= 70)
    {
        currentStudentLetterGrade = "C-";
    }

    else if (currentStudentGrade >= 67)
    {
        currentStudentLetterGrade = "D+";
    }

    else if (currentStudentGrade >= 63)
    {
        currentStudentLetterGrade = "D";
    }

    else if (currentStudentGrade >= 60)
    {
        currentStudentLetterGrade = "D-";
    }

    else if (currentStudentGrade >= 55) 
    {
        currentStudentLetterGrade = "E+";
    }

    else if (currentStudentGrade >= 50) 
    {
        currentStudentLetterGrade = "E";
    }

    else if (currentStudentGrade >= 45) 
    {
        currentStudentLetterGrade = "E-";
    }

    else
        currentStudentLetterGrade = "F";

    
    
    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditPoints} ({((decimal)addExtraCreditExamScores / 10) / examAssignments} pts.)");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
