using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_5___Accessibility
{
    public class Student : Person
    {
        private string StudentID { get; set; }


        public Student(string name, int age, string studentID) : base(name, age) // cia konstruktoriuje nusirodome paveldimume IR pasakome NAUJUS DALYKUS
        {
            StudentID = studentID;
        }

        public string GetStudentId()
        {
            return StudentID;
        }

    }
}
