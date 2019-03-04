using System;

namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // create a method named GradeTestScores that takes a int array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a string of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".

            int[] testScores = new int[] { 40, 92, 87, 77, 95, 95 };

            Console.WriteLine(GradeTestScores(testScores));
            Console.ReadLine();

        }

        public static string GradeTestScores(int[] testScores)
        {
            int total = 0;
            int average = 0;
            

            foreach (int score in testScores)
            { 
                if (score < 50)
                {
                    return "Fail";
                }

                total += score;
                average = total / testScores.Length;

            }

            if (average >= 70)
            {
                return "Pass";
            }
            else 
            {
                return "Fail";
            }
        }
    }
}
