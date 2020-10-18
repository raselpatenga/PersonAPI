using PersonAPI.Data;
using PersonAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonAPI.Service
{
    public class StudentService
    {
        private StudentContext _context;
        public StudentService(StudentContext context)
        {
            _context = context;
        }
        public List<Student> GetStudentList()
        {
            try
            {
                var list = _context.tblStudents.ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string SaveStudent(Student model)
        {
            try
            {
                _context.tblStudents.Add(model);
                _context.SaveChanges();
                var result = "Save Successfully";
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
