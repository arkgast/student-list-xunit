using System;


namespace StudentList.Services
{
    public class StudentManager
    {
        private StudentStorage _storage;
        public StudentManager(StudentStorage storage)
        {
            _storage = storage;
        }

        public string[] GetAllStudents()
        {
            var studentList = _storage.LoadStudentList();
            return studentList.Split(',');
        }
    }
}
