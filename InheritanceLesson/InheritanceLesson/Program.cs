using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student
            //{
            //    FullName = "Bekas Sekas",
            //    Age = 20,
            //    Gender = 1,
            //    MarkAverage = 2.3,
            //    GroupName = "SDP-181/1"
            //};
            Person person = new Student("Bekmyrza Uzumaki", "SDP-11");
            Person mentor = new Mentor("Bekmyrzakikus Hatake");

            Console.WriteLine(person);
            Console.ReadLine();

            ((Student)person).MarkAverage = 4.6; //задание значение не смотря на то что
            (person as Student).MarkAverage = 4.6;


            Person[] people = new Person[]
            {
                person, mentor
            };

            foreach(var man in people)
            {
                if(man is Student)
                {
                    Console.WriteLine((man as Student).MarkAverage);
                    man.DoStaff("какое то дело студента");
                }
                else if (man is Mentor)
                {
                    Console.WriteLine((man as Mentor).SubjectsName);
                    man.DoStaff("какое то дело препода");
                }
            }


        }
    }
}
