using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementSystem.SO
{
    internal class Admin
    {
        public int AdminNumber { get; set; }

        public Admin(string staffName, string email, string password, DateTime hireDate, int staffNumber, int adminNumber)
            : base(staffName, email, password, hireDate, staffNumber)
        {
            AdminNumber = adminNumber;
        }
    }
}

