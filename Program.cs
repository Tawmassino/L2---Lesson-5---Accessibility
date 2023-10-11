namespace L2___Lesson_5___Accessibility
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Task1


            Person persona = new Person("Žmogėdra", 42);
            persona.PrintInfoUnlocked();

            Console.WriteLine("----------------------------");

            Student studentas = new Student("Mokslincius", 22, "12345_ID");
            studentas.PrintInfoUnlocked();
            Console.WriteLine($"ID: {studentas.GetStudentId()}");

            Console.WriteLine("----------------------------");

            Teacher mokytojas = new Teacher("Ziniuonis", 70, "Runos");
            mokytojas.PrintInfoUnlocked();
            Console.WriteLine($"Subject is {mokytojas.GetSubject()}");
            #endregion


            //protected - tevu nurodyme kas yra, tas nesikeciai - bus private
            //salyga 
            //error
            //update

        }
    }
}