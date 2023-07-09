using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
       
        public List <Account>? Accounts {  get; set; }
        public Account? Account { get; set; }
        public ApplicationContext? db;
        public MainWindow()
        {
            InitializeComponent();
            textBoxLogin.Focus();
            textBoxPass.Text = "Введите пароль";
            /* WindowDB dB = new WindowDB();
             dB.Show();*/
           
        }

        private void Click_btnAuth(object sender, RoutedEventArgs e)
        {
            var options = ApplicationContext.GetDbContextOptions();
            db = new ApplicationContext(options);
            Accounts = db.Accounts.ToList();

            /* WindowDB dB = new WindowDB();
             dB.Show();*/
            if (textBoxLogin.Text == "" || textBoxLogin.Text == "введите логин")
                {
                    MessageBox.Show("логин не введен!", "ошибка");
                    textBoxLogin.Focus();
                }
                else
                {
                    string login = textBoxLogin.Text;
                    string pass = textBoxPass.Text;
                    try
                    {
                    
                    WorkWithAccount wwa=new WorkWithAccount(Accounts,login, pass);
                        if (wwa.SearchUser()!=null)
                        {
                            if(wwa.SignIn()!=null)
                            {
                            Account = wwa.SignIn();
                            MessageBox.Show($"вы успешно авторизовались под пользователем {login} ", "вход");
                            WindowDB windowDB = new WindowDB(Account);
                            windowDB.ShowDialog();
                             Close();
                            }
                            else
                            MessageBox.Show($"Введен неверный пароль ", "ошибка");

                        }
                        else
                         {
                            MessageBox.Show($"Данный пользователь отсутствует в БД", "Логин не найден" );
                            textBoxLogin.Focus();
                            textBoxLogin.Text = "";
                       
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"проблема авторизации" + ex);

                    }
                    
                }
           
        }

        private void Click_btnClear(object sender, RoutedEventArgs e)
        {
           
            if (textBoxLogin.Text == "" && textBoxPass.Text == "")
            MessageBox.Show($"Куда ты жмешь-то, итак поля пустые!", "Окошко");
            textBoxLogin.Text = "";
            textBoxPass.Text = "";  
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            var options = ApplicationContext.GetDbContextOptions();
            db = new ApplicationContext(options);
            Accounts = db.Accounts.ToList();

            RegWindow regWindow = new RegWindow(Accounts);
            regWindow.ShowDialog();
            Account = regWindow.Account;           
            if (Account!=null)
            {
                db.Accounts.AddRange(Account);
                db.SaveChanges();
                MessageBox.Show($"Вы успешно зарегистрировали логин {Account.Login}", "Регистрация");
            }
           
        }

        private void textBoxLogin_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxLogin.Text == "Введите логин")
                textBoxLogin.Text = "";
            if (textBoxPass.Text == "")
                textBoxPass.Text = "Введите пароль";
        }

        private void textBoxPass_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            if (textBoxPass.Text == "" || textBoxPass.Text == "Введите пароль")
                textBoxPass.Text = "";
            if (textBoxLogin.Text == "")
                textBoxLogin.Text = "Введите логин";
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e) // при перемещении кнопкой таб с логина на пароль надпись введите пароль стирается
        {
            if (textBoxPass.Text == "" || textBoxPass.Text == "Введите пароль")
                textBoxPass.Text = "";
            if (textBoxLogin.Text == "")
                textBoxLogin.Text = "Введите логин";
        }
    }














}
