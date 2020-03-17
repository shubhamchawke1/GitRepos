using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCApplication.Models
{
    public class TestStudentRepository : IStudentRepository
    {
        private List<Student> _studentsList;

        public TestStudentRepository()
        {
            _studentsList = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
               new Student() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };
        }

        public List<Student> GetAllStudentDetails()
        {

            return this._studentsList;
        }

        public Student GetStudentById(int StudentId)
        {
            return this._studentsList.FirstOrDefault(e => e.StudentId == StudentId);
        }
    }
}
