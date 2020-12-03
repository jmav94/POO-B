using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryoyecto_Csharp_y_MySQL
{
    class User
    {
        public User()
        {

        }
        public User(string first_name, string last_name,string address)
        {
            this.id = 0;
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
        }
        public User(int id, string first_name, string last_name, string address)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string first_name;

        public string First_Name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        private string last_name;

        public string Last_Name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
