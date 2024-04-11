using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonCafe
{
    public class Staff
    {
        public int id {  get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public string login {  get; set; }
        public string password { get; set; }

        public Staff(int id, string firstname, string surname, string role, string status, string login, string password)
        {
            this.id = id;
            this.firstname = firstname;
            this.surname = surname;
            this.role = role;
            this.status = status;
            this.login = login;
            this.password = password;
        }

        public Staff(string firstname, string surname, string role, string status, string login, string password)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.role = role;
            this.status = status;
            this.login = login;
            this.password = password;
        }
    }
}
