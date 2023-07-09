using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOnWPF
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public bool IsActive { get; set; }

        public Account(string Name, string LastName, string Login, string Pass)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Login = Login;
            this.Pass = Pass;
            IsActive=true;
        }




    }
}
