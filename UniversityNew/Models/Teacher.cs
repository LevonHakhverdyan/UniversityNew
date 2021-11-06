using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityNew.Models
{
    public class Teacher
    {
        public Guid _id;
        public string _name;
        public int _age;
        public List<Student> _students;

        public Teacher()
        {
            _id = new Guid();
        }

        public Teacher(string name, int age)
        {
            _id = new Guid();
            _name = name;
            _age = age;
            _students = new List<Student>();
        }
    }
}
