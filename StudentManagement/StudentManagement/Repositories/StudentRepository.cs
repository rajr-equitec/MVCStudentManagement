using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;
using Dapper;
using StudentManagement.Models;

namespace StudentManagement.Repositories
{
    public class StudentRepository
    {
        private readonly string _connectionstring = ConfigurationManager.ConnectionStrings["Student"].ConnectionString;

        public StudentRepository(string connectionString)
        {
            _connectionstring = connectionString;

        }

        public StudentRepository()
        {

        }

        public IEnumerable<Students> GetAll()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                var employees = connection.Query<Students>("select t.id,t.Name,t.Rollno,d.deptname,t.DOB,t.gender,t.Address,t.phone from temstude t join department d on t.depid=d.depid ORDER BY Rollno ASC;").ToList();
                return employees;
            }
        }



        public void insertData(Students sm)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                string sql = "insert into  temstude(Name, Rollno, depid, DOB, Gender, Address, phone) values(@Name ,@Rollno,@depid , @DOB,@Gender , @Address,@phone);";
                connection.Execute(sql, sm); 
            }
        }


        public IEnumerable<Students> GetPast()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                var employees = connection.Query<Students>("select b.id,b.Name,b.Rollno,d.deptname,b.DOB,b.gender,b.Address,b.phone from bac b join department d on b.depid=d.depid ORDER BY Rollno ASC;").ToList();
                return employees;
            }
        }




        public bool Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {

                string selectQuery = "SELECT * FROM temstude WHERE Id = @Id";
                var stud = connection.QueryFirstOrDefault<Students>(selectQuery, new { Id = id });


                if (stud != null)
                {
                    string insertQuery = "insert into bac(Name, Rollno, depid, DOB, Gender, Address, phone) values(@Name ,@Rollno,@depid , @DOB,@Gender , @Address,@phone);";
                    var insertResult = connection.Execute(insertQuery, new
                    {
                        stud.Name,
                        stud.Rollno,
                        stud.depid,
                        stud.DOB,
                        stud.Gender,
                        stud.Address,
                        stud.phone,

                    });


                    if (insertResult > 0)
                    {
                        string deleteQuery = "DELETE FROM temstude WHERE Id = @Id";
                        var result = connection.Execute(deleteQuery, new { Id = id });
                        return result > 0;
                    }
                }


                return false;
            }
        }






        public bool RESTORE(int id)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {

                string selectQuery = "SELECT * FROM bac WHERE Id = @Id";
                var stud = connection.QueryFirstOrDefault<Students>(selectQuery, new { Id = id });


                if (stud != null)
                {
                    string insertQuery = "insert into temstude(Name, Rollno, depid, DOB, Gender, Address, phone) values(@Name ,@Rollno,@depid , @DOB,@Gender , @Address,@phone);";
                    var insertResult = connection.Execute(insertQuery, new
                    {
                        stud.Name,
                        stud.Rollno,
                        stud.depid,
                        stud.DOB,
                        stud.Gender,
                        stud.Address,
                        stud.phone,

                    });


                    if (insertResult > 0)
                    {
                        string deleteQuery = "DELETE FROM bac WHERE Id = @Id";
                        var result = connection.Execute(deleteQuery, new { Id = id });
                        return result > 0;
                    }
                }


                return false;
            }
        }





        public Students GetByID(int id)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                string query = "select b.id,b.Name,b.Rollno,d.deptname,b.DOB,b.gender,b.Address,b.phone from bac b join department d on b.depid=d.depid WHERE id = @id";
                var stud = connection.QueryFirstOrDefault<Students>(query, new { id });
                return stud;
            }
        }

        
 public void OLDDETAILS(int id)
        {
            using (var connnection = new SqlConnection(_connectionstring))
            {
                string query = "select b.id,b.Name,b.Rollno,d.deptname,b.DOB,b.gender,b.Address,b.phone from bac b join department d on b.depid=d.depid WHERE id = @id";
                var stud = connnection.QuerySingleOrDefault<Students>(query);
            }
        }


        public Students GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                string query = "select t.id,t.Name,t.Rollno,d.deptname,t.DOB,t.gender,t.Address,t.phone from temstude t join department d on t.depid=d.depid WHERE id = @id";
                var stud = connection.QueryFirstOrDefault<Students>(query, new { id });
                return stud;
            }
        }

        public void Details(int id)
        {
            using (var connnection = new SqlConnection(_connectionstring))
            {
                string query = "select t.id,t.Name,t.Rollno,d.deptname,t.DOB,t.gender,t.Address,t.phone from temstude t join department d on t.depid=d.depid where id = id";
                var stud = connnection.QuerySingleOrDefault<Students>(query);
            }
        }

        public void Add(Students student)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                string query = "insert into temstude(Name, Rollno, depid, DOB, Gender, Address, phone) values(@Name ,@Rollno,@depid , @DOB,@Gender , @Address,@phone);";
                connection.Execute(query, student);

            }
        }

        public void Save(Students student)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {

                string query = "UPDATE temstude SET Name = @Name, Rollno = @Rollno,  DOB = @DOB, Gender = @Gender, Address = @Address, phone = @phone WHERE Id = @id";
                connection.Execute(query, new { Name = student.Name, Rollno = student.Rollno, DOB = student.DOB, Gender = student.Gender, Address = student.Address, phone = student.phone , id = student.Id });
            }
        }

        public void Rollcheck(Students students)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                String query = "select Rollno from temstude";
                var stud = connection.QuerySingleOrDefault<Students>(query);
            }
        }
    }
}