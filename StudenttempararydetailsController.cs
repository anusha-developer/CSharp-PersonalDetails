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
    public class StudenttempararydetailsController : ApiController
    {
        // GET: api/Studenttempararydetails

        [HttpGet]
        [Route("api/GetTempararyaddress1")]

        public List<Temparary> GetTempararyaddress1()

        {


            Temparary personaldata = new Temparary();
            List<Temparary> td = new List<Temparary>();
            Temparary t1 = new Temparary();
            SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
            con.Open();
            string query = "select * from Tempararyaddress1 ";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dr = cm.ExecuteReader();


            while (dr.Read())
            {
                t1 = new Temparary();
                t1.Hno = Convert.ToInt32(dr["Hno"]);
                t1.street = dr["street"].ToString();
                t1.village = dr["village"].ToString();
                t1.mandal = dr["mandal"].ToString();
                t1.dist = dr["dist"].ToString();
                t1.pincode = Convert.ToInt32(dr["pincode"]);
                t1.country = dr["country"].ToString();
                t1.state = dr["state"].ToString();
                
               

                td.Add(t1);
            }
            con.Close();



            return td;

        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Studenttempararydetails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Studenttempararydetails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Studenttempararydetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Studenttempararydetails/5
        public void Delete(int id)
        {
        }
    }
}
