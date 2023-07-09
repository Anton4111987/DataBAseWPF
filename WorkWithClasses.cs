using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOnWPF
{
    public class IWorkWithClasses
    {
        public IWorkWithClasses() { }

    }

    public class WorkWithAccount:IWorkWithClasses
    {
        public List<Account>? Accounts;
        public string? Login;
        public string? Pass;
        public Account? Account;
        public WorkWithAccount(List<Account> accounts, string Login)
        {
            Accounts = accounts;
           
                this.Accounts = accounts;
                this.Login = Login;
           
        }
        public WorkWithAccount(List<Account> accounts, string Login, string Password)
        {
            this.Accounts = accounts;
            this.Login = Login;
            this.Pass= Password;
        }

        public Account? SearchUser() 
        {
            
           
                foreach (Account a in Accounts)
                {
                    if (a.Login == Login)
                       Account = a;
                    //result = true;
                }

            return Account;

        }

        public Account? SignIn() // проверка логина и пароля для входа
        {          
           
                foreach (Account a in Accounts)
                {
                    if (a.Login == Login && a.Pass == Pass)
                        Account=a;
                }

            return Account ;

        }



    }





}

