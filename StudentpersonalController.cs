using skillicergproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace skillicergproject.Controllers
{
    public class StudentpersonalController : ApiController
    {
 

        [HttpGet]
        [Route("api/GetPersonaldetails1")]

        public List<personaldetails> GetPersonaldetails1()

        {
            personaldetails personaldata = new personaldetails();
            List<personaldetails> pd = new List<personaldetails>();
            personaldetails s1 = new personaldetails();
            SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
            con.Open();
            string query = "select * from Personaldetails1 ";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dr = cm.ExecuteReader();


            while (dr.Read())
            {
                s1 = new personaldetails();
                s1.Firstname = dr["Firstname"].ToString();
                s1.lastname = dr["lastname"].ToString();
                s1.fathername = dr["fathername"].ToString();
                s1.mothername = dr["mothername"].ToString();
                s1.age = Convert.ToInt32(dr["age"]);
                s1.dob = dr["dob"].ToString();
                s1.gender = dr["gender"].ToString();
                s1.caste = dr["caste"].ToString();
               /// s1.phono = Convert.ToInt32(dr["phono"]);
                s1.email = dr["email"].ToString();

                pd.Add(s1);
            }
            con.Close();



            return pd;

        }


            //GET: api/Studentpersonal
            public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Studentpersonal/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Studentpersonal

        [HttpPost]
        [Route("api/Personaldetails1/insert")]

        public string Getinsert(personaldetails obj)

        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.;database=master,integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("insert into Personaldetails1 values('" + obj.Firstname + "','" + obj.lastname + "'," +
                    "'" + obj.fathername + "','" + obj.mothername + "'," + obj.age + ",'" + obj.dob + "','" + obj.gender + "','" + obj.caste + "','" + obj.email + "');", con);
                SqlDataReader dr = cm.ExecuteReader();


            }
            catch (Exception ex)
            {

            }
            return "inserted data successfully";


        }


     /*   [HttpPost]
        [Route("api/Personaldetails1/insert")]

        public personaldetails InsertPersonaldetails1([FromBody] personaldetails pd)
        {
            personaldetails s1 = new personaldetails();
            SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
            try
            {
                con.Open();
                string query = "insert into personaldetails Values" +
                   "(" + pd.Firstname + "," + pd.lastname + "," + pd.fathername + "," + pd.mothername + " , " +
                   "" + pd.age + "," + pd.dob + " " + pd.gender + "," + pd.caste + "," + pd.email + " )";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {

            }

            return pd; 
        }*/


        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Studentpersonal/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Studentpersonal/5
        public void Delete(int id)
        {
        }
    }
}
