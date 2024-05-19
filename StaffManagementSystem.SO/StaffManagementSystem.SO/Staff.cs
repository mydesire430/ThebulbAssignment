using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementSystem.SO
{
    public class Staff
    {
        public string StaffName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime HireDate { get; set; }
        public int StaffNumber { get; set; }
        public bool IsClockedIn { get; set; }
        public bool IsActive { get; set; }
        public bool IsLoggedIn { get; set; }
        public Staff(string staffName, string email, string password, DateTime hireDate, int staffNumber)
        {
            StaffName = staffName;
            Email = email;
            Password = password;
            HireDate = hireDate;
            StaffNumber = staffNumber;
            IsClockedIn = false;
            IsActive = true;
            IsLoggedIn = false;
        }
        protected void ValidateInput(object input, Type expectedType)
        {
            if (input.GetType() != expectedType)
            {
                throw new ArgumentException($"Invalid input type. Expected {expectedType}.");
            }
        }

    }
}