using System;
using Xunit;
using Moq;
using StudentList.Services;


namespace StudentList.Tests
{
    public class StudentManager_Should
    {
        Mock<StudentStorage> mockStorage;

        public StudentManager_Should()
        {
            mockStorage = new Mock<StudentStorage>();
            mockStorage.Setup(sm => sm.LoadStudentList())
                        .Returns("student1,student2,student3");
        }

        [Fact]
        public void ReturnListOfStudents()
        {
           // Arrange
           var sut = new StudentManager(mockStorage.Object);

            // Act
            var actual = sut.GetAllStudents();

            // Assert
            Assert.IsType(typeof(string[]), actual);
            Assert.True(actual.Length == 3);
            Assert.Contains("student2",actual);
        }

        [Fact]
        public void ReturnCorrectStudentCount()
        {
            // Arrange
           var sut = new StudentManager(mockStorage.Object);

            // Act
            var actual = sut.CountStudents();

            // Assert 
            Assert.Equal(actual, 3);

        }
    }
}
