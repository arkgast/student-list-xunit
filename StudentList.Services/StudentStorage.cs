using System;

namespace StudentList.Services
{
    public class StudentStorage
    {
        /// <summary>
        /// Replaces the contents of the student storage with the given string of content.
        /// The method will also update the timestamp in the student storage.
        /// </summary>
        /// <param name="content">The new content for the student storage </param> 
        public virtual void UpdateStudentList(string content)
        {
            throw new NotImplementedException("Tests needed!");
        }

        /// <summary>
        /// Reads student data from student storage.
        /// </summary>
        /// <returns>A string of student names.</returns>
        public virtual string LoadStudentList()
        {
            throw new NotImplementedException("Tests needed");
        }
    }
}
