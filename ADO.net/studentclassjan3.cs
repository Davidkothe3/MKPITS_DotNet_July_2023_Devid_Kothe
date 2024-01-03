using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace form_3jan24
{
    internal class studentclass
    {
        string strcon = "server=.\\sqlexpress; integrated security=true;database=student_info_3jan";

        public string InsertStudent(int rno, string names, string gender, string hobby, string city, string dob)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "insert into student values(@rno,@names,@gender,@hobby,@city,@dob)";
                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    command.Parameters.AddWithValue("@names", names);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.ExecuteNonQuery();
                    con.Close();

                    return "RECORD SAVED SUCCESSFULLY";
                }

            }

        }

        public string Upadatestudent(int rno, string names, string gender, string hobby, string city, string dob)
        {


            using(SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "update student set names=@names,gender=@gender,hobby=@hobby,city=@city,dob=@dob where rno=@rno";

                using (SqlCommand command=new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@rno" , rno);
                    command.Parameters.AddWithValue("@names" , names);
                    command.Parameters.AddWithValue("@gender" , gender);
                    command.Parameters.AddWithValue("@hobby" , hobby);
                    command.Parameters.AddWithValue("@city" , city);
                    command.Parameters.AddWithValue("@dob" , dob);
                    command.ExecuteNonQuery();

                    con.Close();

                    return "record update successfully";

                }

            }
        }

       public string deletestudent(int rno,string names)
        {
            using (SqlConnection con=new SqlConnection())
            {
                con.Open();
                string str = "delete from student where rno=@rno or name=@name";
                using (SqlCommand command = new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    command.Parameters.AddWithValue("@names", names);

                    command.ExecuteNonQuery ();
                    con.Close();

                    return "record deleted successfully";
                }

                    
            }
        }

    }
}
