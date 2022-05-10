using System;

using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConstructors();
            Console.WriteLine();
            TestGetters();
            Console.WriteLine();
            TestSetters();
        }

        static void TestConstructors()
        {
            Professor defaultProf = new Professor();
            Professor meProf = new Professor("L00659829", "Castigliano", "Jake", "Physics");
            Console.WriteLine("default professor: " + defaultProf);
            Console.WriteLine("custom professor: " + meProf);
        }

        static void TestGetters()
        {
            Professor getTest = new Professor("L00000001", "Lasname", "Firsname", "Zoology");
            Console.WriteLine("Getter test: LNumber: " + getTest.LNumber + " | Last Name: " + getTest.NameLast + " | First Name: " + getTest.NameFirst + " | Department: " + getTest.Department + "|");
        }

        static void TestSetters()
        {
            Professor setTest = new Professor("", "", "", "");
            Console.WriteLine("setter test");
            setTest.LNumber = "L00AhhAhh";
            //trying to figure out why its throwing, length is fine, all requirements satisfied(?)
            //Console.WriteLine(setTest.LNumber.Length);
            setTest.NameLast = "Chim";
            setTest.NameFirst = "Panzee";
            setTest.Department = "Monkey Business";
            Console.WriteLine(setTest);
        }


    }
}
