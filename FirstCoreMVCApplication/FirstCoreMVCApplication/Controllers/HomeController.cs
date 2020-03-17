using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _repository = null;

        public HomeController(IStudentRepository repository)
        {
            repository = _repository;
        }

        public JsonResult GetStudentDetails(int Id)
        {
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);
        }

        public JsonResult GetAllStudentDetails()
        {
            TestStudentRepository repository = new TestStudentRepository();
            List<Student> student = repository.GetAllStudentDetails();
            return Json(student);
        }
    }
}