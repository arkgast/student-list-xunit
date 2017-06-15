using System;
using System.Linq;

namespace StudentList.Services
{
    public class StudentManager
    {
        private const char StudentEntryDelimiter = ',';
        private StudentStorage _storage;
        private Random _rand;
        private string _studentList;
        public StudentManager(StudentStorage storage)
        {
            _storage = storage;
            _rand = new Random();
            _studentList = _storage.LoadStudentList();
        }

        public string[] Students
        {
            get
            {
                return _studentList.Split(StudentEntryDelimiter);
            }
        }

        public string PickRandomStudent()
        {
            var students = _studentList.Split(StudentEntryDelimiter);
            var randomIndex = _rand.Next(0,students.Length);
            return students[randomIndex];
        }

        public void AddStudent(string newStudent)
        {
            _studentList += "," + newStudent;
            _storage.UpdateStudentList(_studentList);
        }

        public bool StudentExists(string student)
        {
            var students = _studentList.Split(StudentEntryDelimiter);

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
