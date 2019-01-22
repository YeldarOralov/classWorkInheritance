using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public class Mentor: Person
    {
        public string[] SubjectsName { get; set; }
        public Mentor(string fullName) : base(fullName)
        {               
        }

        public override void DoStaff(string staffName)
        {
            // Переопределяем 
        }

        public override void SayAllInfo()
        {
            //реализовать
        }
    }
}
