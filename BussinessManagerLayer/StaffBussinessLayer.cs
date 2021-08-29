using Staff_Details.Models;
using Staff_Details.RepositaryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Staff_Details.BussinessManagerLayer
{
    public class StaffBussinessLayer
    {
        public  List<StaffDetails> GetStaffDetails()
        {
            StaffRepositaryLayer staffRepositaryLayer = new StaffRepositaryLayer();
            return staffRepositaryLayer.GetStaffDetails();
        }
    }
}