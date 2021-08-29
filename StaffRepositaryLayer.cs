using Staff_Details.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Staff_Details.RepositaryLayer
{
    public class StaffRepositaryLayer
    {
       public List<StaffDetails> GetStaffDetails()
        {
            List<StaffDetails> staffDetails = new List<StaffDetails>();
            StaffDetails staffobject = new StaffDetails();
               staffobject = new StaffDetails();
                staffobject.FirstName = "Anu";
                staffobject.LastName = "Sha";
                staffobject.Dob = "01-07-1998";
                staffobject.Email = "Anu@gmail.com";
                staffobject.Phoneno = "9388732312";
                staffobject.Likedin = "JobAlerts";
                staffobject.Designation = "Developer";
                staffobject.Department = "CSE";
                staffobject.Dateofjoining = "1-8-2020";
                staffobject.Isactive = 1;
                staffobject.Language = "Angular";
                staffDetails.Add(staffobject);
            return staffDetails;
        }
    }
}