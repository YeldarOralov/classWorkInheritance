using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public sealed class Student: Person // sealed - запечатывает класс не позволяя от него наследоваться
    {
        public double MarkAverage { get; set; }
        public string GroupName { get; set; }

        public Student(string fullName, string groupName):base(fullName)
        {
            GroupName = groupName;            
        }

        public new void DoStaff(string staffName)
        {
            //мы явно точно создаем свою реализацию метода
        }

        public override void SayAllInfo()
        {
            //реализовать
        }

        public override string ToString() 
        {
            return $"{FullName}, {GroupName}";
        }
    }
}
