using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityNew.Models;

namespace UniversityNew.Services
{
    public class StudentService
    {
        private static List<Student> _students = new List<Student>();
        public void Add(Student student)
        {
            _students.Add(student);
        }

        public Student Get(Guid id)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                    return _students[i];
            }
            return default(Student);
        }

        public List<Student> GetAllByTeacher(Guid id)
        {
            List<Student> stList = new List<Student>();
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._teacher._id == id)
                {
                    stList.Add(_students[i]);
                }
            }
            return stList;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public void Remove(Student student)
        {
            _students.Remove(student);
        }

        public void Update(Student student)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == student._id)
                {
                    _students[i] = student;
                }
            }
        }
    }
}
