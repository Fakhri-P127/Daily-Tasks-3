using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] studentScores = { 60, 65, 50, 25, 90, 100, 100, 30, 0, 45, 80}; //studentScores uda ref ile cagiriram bunda
            
            SumofScores(ref studentScores);            
        }
        public static int SumofScores( ref int[] studentScores)
        {            
            int numofStudents=studentScores.Length;             
            int sum = 0;
            
            for (int i = 0; i < studentScores.Length; i++)
            {
                sum += studentScores[i];
            }            
            Console.WriteLine("Telebelerin ballari cemi: " + sum);
            AvgScore(ref numofStudents, ref sum);
            return sum;                       
        }
        public static int AvgScore(ref int numofStudents, ref int sum )
        {
            int avgOfClass = sum / numofStudents ;
            Console.WriteLine("Sinifin ortalama bali: "+ avgOfClass);
            return avgOfClass;
        }
    }
}
