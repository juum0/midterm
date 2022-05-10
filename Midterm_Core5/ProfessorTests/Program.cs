using System;

using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConstructors();
        }

        static void TestConstructors()
        {
            Professor defaultProf = new Professor();
            Professor meProf = new Professor("L00659829", "Jake", "Castigliano", "Physics");
            Console.WriteLine("default professor: " + defaultProf);
            Console.WriteLine("custome professor: " + meProf);
        }
    }
}
