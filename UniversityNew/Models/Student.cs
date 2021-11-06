using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityNew.Models
{
    public class Student
    {
        public Guid _id;
        public string _name;
        public int _age;
        public Teacher _teacher;

        public Student()
        {
            _id = new Guid();
        }

        public Student(string name, int age)
        {
            _id = new Guid();
            _name = name;
            _age = age;
        }
    }
}
