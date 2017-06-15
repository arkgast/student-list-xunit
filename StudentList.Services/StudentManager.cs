using System;
using System.Linq;

namespace StudentList.Services
{
    public class StudentManager
    {
        private StudentStorage _storage;
        private Random _rand;
        public StudentManager(StudentStorage storage)
        {
            _storage = storage;
            _rand = new Random();
        }

        public string[] GetAllStudents()
        {
            var studentList =  _storage.LoadStudentList();
            return studentList.Split(',');
        }

        public int CountStudents()
        {
           var studentList = _storage.LoadStudentList();
           return studentList.Split(',').Length;
        }

        public string PickRandomStudent()
        {
            var studentList = _storage.LoadStudentList();
            var students = studentList.Split(',');
            var randomIndex = _rand.Next(0,students.Length);
            return students[randomIndex];
        }

        public void AddStudent(string newStudent)
        {
            var studentList = _storage.LoadStudentList();
            _storage.UpdateStudentList(studentList + "," + newStudent);
        }

        public bool StudentExists(string student)
        {
            var studentList = _storage.LoadStudentList();
            var students = studentList.Split(',');

            // Using the 'Any'  LINQ method to return whether or not 
            // any item  matches the given predicate.
            if (students.Any(s => s.Trim() == student))
            {
                return true;
            }

            return false;
        }

    }
}
