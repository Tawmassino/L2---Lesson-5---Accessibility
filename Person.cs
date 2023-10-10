using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L2___Lesson_5___Accessibility
{
    public class Person
    {//properties
        protected string Name { get; set; } //pakeitem si private i protected, kad galetumem is vaiko pasiekti
        protected int Age { get; set; }
        //constructor

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //method
        protected string PrintInfo()//kadangi protected tai nebus matoma main'e
        {
            return $"Name is {Name} and age is {Age}"; // METODUOSE NAUDOSIME DAZNIAUSIAI NAUDOSIME PROPERTIES
                                                       // KINTAMUOSIUS NAUDOTUME TIK JEI REIKETU PAPILDOMU SPECIFINIU DUOMENU KURIE NERA APIBREZTI PROPERTIES
        }

        //protected string PrintInfo(string name, int age)//kadangi protected tai nebus matoma main'e
        //{
        //    return $"Name is {name} and age is {age}";
        //}

        public void PrintInfoUnlocked()
        {

            Console.WriteLine(PrintInfo());
        }

        //public string PrintInfoUnlocked(string name, int age)
        //{

        //    return $"Name is {name} and age is {age}";
        //}

        //end of method
    }
}
