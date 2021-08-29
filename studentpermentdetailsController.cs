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
    public class studentpermentdetailsController : ApiController
    {
        // GET: api/studentpermentdetails


        [HttpGet]
        [Route("api/Getpermentaddress")]

        public List<perment>Getpermentaddress()

        {


            perment personaldata = new perment();
            List<perment> pe = new List<perment>();
            perment e1 = new perment();
            SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
            con.Open();
            string query = "select * from Tempararyaddress1 ";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dr = cm.ExecuteReader();


            while (dr.Read())
            {
                e1 = new perment();
                e1.HNo = Convert.ToInt32(dr["HNo"]);
                e1.street = dr["street"].ToString();
                //e1.city = dr["city"]?.ToString();
                e1.state = dr["state"].ToString();
                e1.country = dr["country"].ToString();
                


                pe.Add(e1);
            }
            con.Close();



            return pe;

        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/studentpermentdetails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/studentpermentdetails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/studentpermentdetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/studentpermentdetails/5
        public void Delete(int id)
        {
        }
    }
}
