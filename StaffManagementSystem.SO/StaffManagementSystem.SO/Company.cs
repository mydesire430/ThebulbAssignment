using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementSystem.SO
{
    internal class Company
    {
        private List<Staff> staffs;
        private List<Admin> admins;
        private const double WorkHours = 8.0;
        private static readonly TimeSpan ExpectedArrivalTime = new TimeSpan(9, 0, 0); // 9:00 AM

        public Company()
        {
            staffs = new List<Staff>();
            admins = new List<Admin>();
        }

        // Login
        public bool Login(string identifier, string password)
        {
            var staff = staffs.FirstOrDefault(s => (s.Email == identifier || s.StaffName == identifier) && s.Password == password);
            if (staff != null)
            {
                staff.IsLoggedIn = true;
                return true;
            }
            return false;
        }

        // Logout
        public bool Logout(string identifier, string password)
        {
            var staff = staffs.FirstOrDefault(s => (s.Email == identifier || s.StaffName == identifier) && s.Password == password);
            if (staff != null && staff.IsLoggedIn)
            {
                staff.IsLoggedIn = false;
                return true;
            }
            return false;
        }

        // Track Late Arrivals
        public bool IsLateArrival(DateTime arrivalTime)
        {
            return arrivalTime.TimeOfDay > ExpectedArrivalTime;
        }

        // Clock In
        public DateTime ClockIn(string identifier, DateTime clockInTime)
        {
            var staff = staffs.FirstOrDefault(s => (s.Email == identifier || s.StaffName == identifier) && s.IsLoggedIn);
            if (staff != null && staff.IsActive)
            {
                staff.IsClockedIn = true;
                var expectedClockOutTime = clockInTime.AddHours(WorkHours);
                return expectedClockOutTime;
            }
            throw new InvalidOperationException("Staff must be logged in to clock in.");
        }

        // Clock Out
        public string ClockOut(string identifier, DateTime clockInTime, DateTime clockOutTime)
        {
            var staff = staffs.FirstOrDefault(s => (s.Email == identifier || s.StaffName == identifier) && s.IsLoggedIn);
            if (staff != null && staff.IsClockedIn)
            {
                staff.IsClockedIn = false;
                staff.IsLoggedIn = false;

                var actualWorkedHours = (clockOutTime - clockInTime).TotalHours;
                if (actualWorkedHours < WorkHours)
                {
                    return "You didn't work enough.";
                }
                return "You have done well.";
            }
            throw new InvalidOperationException("Staff must be clocked in to clock out.");
        }

        // View Work Hours
        public string ViewWorkHours(string identifier)
        {
            var staff = staffs.FirstOrDefault(s => (s.Email == identifier || s.StaffName == identifier));
            if (staff != null && staff.IsClockedIn)
            {
                return $"Expected work hours: {WorkHours}";
            }
            return "You are not clocked in.";
        }

        // Admin Functionalities
        // Toggle Active Status
        public void ToggleActiveStatus(string identifier, bool status)
        {
            var admin = admins.FirstOrDefault(a => a.Email == identifier || a.StaffName == identifier);
            if (admin != null && admin.IsLoggedIn)
            {
                var staff = staffs.FirstOrDefault(s => s.Email == identifier || s.StaffName == identifier);
                if (staff != null)
                {
                    staff.IsActive = status;
                }
            }
            else
            {
                throw new InvalidOperationException("Admin must be logged in to perform this action.");
            }
        }

        // Add Staff
        public void AddStaff(Staff newStaff)
        {
            var admin = admins.FirstOrDefault(a => a.Email == newStaff.Email || a.StaffName == newStaff.StaffName);
            if (admin != null && admin.IsLoggedIn)
            {
                staffs.Add(newStaff);
            }
            else
            {
                throw new InvalidOperationException("Admin must be logged in to perform this action.");
            }
        }

        // Remove Staff
        public void RemoveStaff(string identifier)
        {
            var admin = admins.FirstOrDefault(a => a.Email == identifier || a.StaffName == identifier);
            if (admin != null && admin.IsLoggedIn)
            {
                var staff = staffs.FirstOrDefault(s => s.Email == identifier || s.StaffName == identifier);
                if (staff != null)
                {
                    staffs.Remove(staff);
                }
            }
            else
            {
                throw new InvalidOperationException("Admin must be logged in to perform this action.");
            }
        }

        // View Staff Details
        public Staff ViewStaffDetails(string identifier)
        {
            var admin = admins.FirstOrDefault(a => a.Email == identifier || a.StaffName == identifier);
            if (admin != null && admin.IsLoggedIn)
            {
                return staffs.FirstOrDefault(s => s.Email == identifier || s.StaffName == identifier);
            }
            throw new InvalidOperationException("Admin must be logged in to perform this action.");
        }

        // View All Staff
        public List<Staff> ViewAllStaff(string identifier)
        {
            var admin = admins.FirstOrDefault(a => a.Email == identifier || a.StaffName == identifier);
            if (admin != null && admin.IsLoggedIn)
            {
                return staffs;
            }
            throw new InvalidOperationException("Admin must be logged in to perform this action.");
        }
    }
}

