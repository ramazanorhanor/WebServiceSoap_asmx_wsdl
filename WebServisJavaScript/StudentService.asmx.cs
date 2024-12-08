using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
namespace WebServisJavaScript
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService] //1
    public class StudentService : System.Web.Services.WebService
    {
        [WebMethod]
        public Student GetStudentById(int Id)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con=new SqlConnection(cs))
            {
                //public SqlCommand(string cmdText, SqlConnection connection);
                SqlCommand cmd = new SqlCommand("upGetStudentById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("id",Id);
                cmd.Parameters.Add(parameter);
                Student student = new Student();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Name = reader["Name"].ToString();
                    student.Gender = reader["Gender"].ToString();
                    student.TotalMarks = Convert.ToInt32(reader["TotalMarks"]);
                }
                return student;
            }
            
        }
    }
}
/*
  create procedure upGetStudentById
  @id int
  as
  begin
  Select Id,[Name],[Gender],[TotalMarks] from tblStudents where Id=@id
  end

 */