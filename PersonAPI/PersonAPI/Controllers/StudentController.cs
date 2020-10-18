using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonAPI.Data;
using PersonAPI.Model;
using PersonAPI.Service;

namespace PersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private StudentService studentSurvice;

        public StudentController(StudentContext context)
        {
            studentSurvice = new StudentService(context);
        }

        //Get api/student
        [HttpGet]
        public ActionResult<Student> Get()
        {
            var list = studentSurvice.GetStudentList();
            return Ok(list);
        }

        //// POST api/student
        [HttpPost]
        public ActionResult Post([FromBody] Student model)
        {
            try
            {
                var massege = studentSurvice.SaveStudent(model);
                return Ok(massege);
            }
            catch (Exception ex)
            {
                return BadRequest($"Student Save Unsuccesssss!!! Error this warning {ex.Message} ");
            }
        }
    }
}