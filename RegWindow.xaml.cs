using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBaseOnWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowReg.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public List<Account>? Accounts { get; set; }
        public Account? Account { get; set;}
        //public ApplicationContext db;
        /*public RegWindow()
        {
            InitializeComponent();

            textBox_Login.Focus();
            textBox_Password.IsEnabled = false;
            textBox_RepeatPassword.IsEnabled = false;
            textBox_Name.IsEnabled = false;
            textBox_LastName.IsEnabled = false;
            btnReg.IsEnabled = false;

        }*/
        public RegWindow(List<Account> accounts)
        {
            InitializeComponent();
            this.Accounts = accounts;
            textBox_Login.Focus();
            textBox_Password.IsEnabled = false;
            textBox_RepeatPassword.IsEnabled = false;
            textBox_Name.IsEnabled = false;
            textBox_LastName.IsEnabled = false;
            btnReg.IsEnabled = false;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* var options = ApplicationContext.GetDbContextOptions();
            db = new ApplicationContext(options);*/
            if (textBox_Login.Text == "")
                MessageBox.Show("Пустое поле логин", "Ошибка");
            if (textBox_Password.Text == "")
                MessageBox.Show("Пароль не может быть пустым", "Ошибка");
            if (textBox_Name.Text == "")
                MessageBox.Show("Не заполнено поле Имя", "Ошибка");
            if (textBox_LastName.Text == "")
                MessageBox.Show("Не заполнено поле Фамилия", "Ошибка");
            if (textBox_Password.Text != textBox_RepeatPassword.Text)
                MessageBox.Show("Пароли не совпадают", "Ошибка");

            string Login = textBox_Login.Text;
            string Password = textBox_Password.Text;
            // string RepeatPassword=textBox_RepeatPassword.Text;
            string Name = textBox_Name.Text;
            string LastName = textBox_LastName.Text;
            Account = new Account(Name, LastName, Login, Password);
           
            Close();
        }

        private void textBox_Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_Login.Text.Length > 3)
                textBox_Password.IsEnabled = true;

        }
        private void textBox_Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            WorkWithAccount wwa = new WorkWithAccount(Accounts, textBox_Login.Text);
            if (wwa.SearchUser() != null)
            {
                MessageBox.Show("Этот логин уже занят, пожалуйста, введите другой", "Ошибка");
                textBox_Login.Text = "";
                textBox_Login.Focus();
            }
            else if (textBox_Password.Text.Length > 3)
                textBox_RepeatPassword.IsEnabled = true;

        }
        private void textBox_RepeatPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_Password.Text.Length < 4)
            {
                MessageBox.Show("Пароль должен содержать не менее 4 символов", "Ошибка");
                textBox_Password.Focus();
            }

            else if (textBox_Password.Text == textBox_RepeatPassword.Text)
                textBox_Name.IsEnabled = true;

        }

        private void textBox_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (textBox_Name.Text.Length > 1)
                textBox_LastName.IsEnabled = true;
        }

        private void textBox_LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_LastName.Text.Length > 1)
                btnReg.IsEnabled = true;
        }


    }
}

