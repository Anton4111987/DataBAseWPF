/*using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBaseOnWPF
{
    public class DB    
    {
        string connectionString = ConfigurationManager.ConnectionStrings["LocalDbConnection"].ConnectionString;
        SqlConnection sqlConnection = null;
        SqlDataReader result = null;
        DataTable table = null;
        SqlDataAdapter adapter = null;
        Account Account = null;
        public SqlConnection OpenDbConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            return sqlConnection;

        }

        public void CloseDbConnection(SqlConnection connection)
        {
            connection?.Close();

        }
        public bool SearchUser(string Login) // проверка логина, есть ли вообще такой
        {
            string cmdStr = $"select * from Users where login=@l";
            OpenDbConnection();
            table = new DataTable();
            adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(cmdStr, sqlConnection);
            cmd.Parameters.AddWithValue("@l", Login);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0) // проверка на наличие пользователя
            {
                CloseDbConnection(sqlConnection);
                return true;
            }
            else
            {
                CloseDbConnection(sqlConnection);
                //MessageBox.Show($"Пользователя с логином {Login} не существует в базе", "Ошибка");
                return false;
            }

        }

        public bool InToDataBase(string Login, string Password) // метод проверки логина и пароля
        {
            string cmdStr = $"select * from Users where login=@l and pass=@p";
            OpenDbConnection();
            table = new DataTable();
            adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(cmdStr, sqlConnection);
            cmd.Parameters.AddWithValue("@l", Login);
            cmd.Parameters.AddWithValue("@p", Password);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                CloseDbConnection(sqlConnection);
                return true;
            }
            else
            {
                CloseDbConnection(sqlConnection);
                MessageBox.Show($"Введен неверный пароль", "Ошибка");
                return false;
            }

        }
        public void InsertRow(Account account)
        {
            SqlConnection connection = null;
            // SqlDataReader result = null;
            try
            {
                connection = OpenDbConnection();
                string cmdString = $"insert into users(Name, LastName, Login, Pass) values (@p1, @p2,@p3,@p4)";
                SqlCommand cmd = new SqlCommand(cmdString, connection);

                cmd.Parameters.AddWithValue("@p1", SqlDbType.NVarChar).Value = account.Name;
                cmd.Parameters.AddWithValue("@p2", SqlDbType.NVarChar).Value = account.LastName;
                cmd.Parameters.AddWithValue("@p3", SqlDbType.NVarChar).Value = account.Login;
                cmd.Parameters.AddWithValue("@p4", SqlDbType.NVarChar).Value = account.Pass;


                int result = cmd.ExecuteNonQuery();
                MessageBox.Show($"Пользователь {account.Login} успешно добавлен в базу", "Добавление");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла проблема добавления пользователя" + ex.Message);

            }
            finally
            {
                CloseDbConnection(connection);
            }





        }
    }
*/