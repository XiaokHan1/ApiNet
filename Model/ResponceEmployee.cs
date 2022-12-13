using ChatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatAPI.Model
{
    public partial class ResponceEmployee
    {
        public ResponceEmployee(Employee employee)
        {
            id = employee.Id;
            FullName = employee.FullName;
            username = employee.username;
            password = employee.password;
        }

        public int id { get; set; }
        public string FullName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}