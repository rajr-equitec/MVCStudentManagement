using StudentManagement.Models;
using StudentManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Web.Configuration;
using StudentManagement.Controllers;



namespace StudentManagement.Controllers
{

    public class StudentController : Controller
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();
 

        
        public StudentController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
         
        }

        public StudentController() { }

        public ActionResult Index(int page = 1)
        {
            int pageSize = 5;
            var stu = _studentRepository.GetAll();
            var students = stu.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalCount = stu.Count();
            int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            return View(students);
        }

        public ActionResult Old(int page = 1)
        {
            int pageSize = 5;
            var allStudents = _studentRepository.GetPast();
            var students = allStudents.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalCount = allStudents.Count();
            int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            return View(students);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
  
            var deleted = _studentRepository.Delete(id);
            TempData["Success"] = "Deleted successfully.";
            if (!deleted)
            {
                ViewData["Error"] = "Error.";
                return HttpNotFound();
            }
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult RESTORE(int id)
        {
            var deleted = _studentRepository.RESTORE(id);
            TempData["Success"] = "Restore Successfully.";
            if (!deleted)
            {
                ViewData["Error"] = "Error.";
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult OLDDETAILS(int id)
        {
            var stud = _studentRepository.GetByID(id);
            return View(stud);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var stud = _studentRepository.GetById(id);
            return View(stud);
        }
       

      
        public ActionResult Create( )
        {

            try
            {
                string con = ConfigurationManager.ConnectionStrings["Student"].ConnectionString;
                using (var connection = new SqlConnection(con))
                {
                    string sql = "select * from department";
                    var ex = connection.Query<Students>(sql);
                    ViewBag.dept = ex;
                }

                TempData["Success"] = "successfully.";
                return View();
            }
            catch (Exception ex)
            {
                TempData["Error"] = "error: " + ex.Message;
                return View();
            }
        }



        [HttpPost]
        public ActionResult Create(Students sm)
        {

            try
            {
                _studentRepository.insertData(sm);
                
                TempData["Success"] = "successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "error: " + ex.Message;
                return View(sm);
            }
        }

       [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Students student)
        {
           _studentRepository.Save(student);
             return RedirectToAction("Index");
  
        } 
        [HttpGet]
        public ActionResult Edit(int id)
        {
          
            var stu = _studentRepository.GetById(id);
            if (stu == null)
            {
                return HttpNotFound();
            }

            return View(stu);
        }

     

    }
}
