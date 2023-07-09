using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для WindowDB.xaml
    /// </summary>
    public partial class WindowDB : Window
    {
        public ApplicationContext? db=null;
        public List<Account>? Accounts=null;
        public List<VegetableAndFruit>? VegetableAndFruits = null;
        public VegetableAndFruit? VegetableAndFruit = null;
        public Account? Account = null;

        public WindowDB(Account account)
        {
            Account = account;
            InitializeComponent();
            ConnectDbAndAhow();
            Accounts = db.Accounts.ToList();
            dataGridDb.ItemsSource = db.VegetableAndFruits.ToList();
            labelLogin.Content = $"Вы авторизовались под логином: {Account.Login}";
            Closing += (_, e) =>
            {
                var result = MessageBox.Show("Вы точно хотите выйти", "Закрытие", MessageBoxButton.YesNo);
                if (result != MessageBoxResult.Yes)
                {
                    e.Cancel=true;
                }
            };
        }
        private ApplicationContext ConnectDbAndAhow()
        {
            var options = ApplicationContext.GetDbContextOptions();
            db = new ApplicationContext(options);
            return db;
        }

        private void btnDelete_Click(object sender, object e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить строку?",
               "Удаление строки", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var CurrentRow = dataGridDb.SelectedItem;
                
                db.VegetableAndFruits.Remove((VegetableAndFruit)CurrentRow);
                
                db.SaveChanges();
                MessageBox.Show("Строка успешно удалена");

            }

            dataGridDb.ItemsSource = db.VegetableAndFruits.ToList();



        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }

        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите сохранить изменненую таблицу?",
               "Сохранение таблицы", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                db.SaveChanges();

                MessageBox.Show("Таблица успешно изменена");

            }



        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {           
            // ConnectDbAndAhow();           
            db.VegetableAndFruits.Add(new VegetableAndFruit("", "", "", 0));
            db.SaveChanges();
            dataGridDb.ItemsSource = db.VegetableAndFruits.ToList();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {            
           
            ConnectDbAndAhow();
            dataGridDb.ItemsSource = db.VegetableAndFruits.ToList();
        }
    }
}
