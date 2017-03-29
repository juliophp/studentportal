using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal
{
    class Teacher
    {
        public string first_name;
        public string last_name;
        public string username;
        public string password;
        public string department;
        public string phone;
        public string office_no;


        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Office_no
        {
            get { return office_no; }
            set { office_no = value; }
        }
    }
}
