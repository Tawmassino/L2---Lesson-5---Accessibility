﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L2___Lesson_5___Accessibility
{
    public class Teacher : Person
    {
        private string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {  // cia konstruktoriuje nusirodome paveldimume IR pasakome NAUJUS DALYKUS

            Subject = subject;
        }

        public string GetSubject()
        {
            return Subject;
        }


    }
}
