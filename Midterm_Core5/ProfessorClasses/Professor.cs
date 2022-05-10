using System;

namespace ProfessorClasses
{
    public class Professor
    {
        private string lNum;
        private string lName;
        private string fName;
        private string dPartment;

        public Professor()
        {
            LNumber = "Ldefault0";
            NameLast = "DefaultLast";
            NameFirst = "Defaultfirst";
            Department = "Default";
        }

        public Professor(string lNum, string lastName, string firstName, string profDepartment)
        {
            LNumber = lNum;
            NameLast = lastName;
            NameFirst = firstName;
            Department = profDepartment;
        }

        public override string ToString()
        {
            return String.Format("L-Number: {0}, Last Name: {1}, First Name: {2}, Department: {3}", lNum, lName, fName, dPartment);
        }

        public string LNumber
        {
            get
            {
                return lNum;
            }

            set
            {
                if (value.StartsWith("L") && (value.Length == 9))
                {
                    lNum = value;
                }
                else
                    throw new ArgumentException("Value must start with L and have a character length of 9");
            }
        }

        public string NameLast
        {
            get
            {
                return lName;
            }

            set
            {
                {
                    lName = value;
                }
            }
        }

        public string NameFirst
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        public string Department
        {
            get
            {
                return dPartment;
            }

            set
            {
                {
                    lNum = value;
                }
            }
        }





    }
}
