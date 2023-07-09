using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DataBaseOnWPF
{
    
    public class ExecutQueryWithADONET
    {
        string Command;
        public List<VegetableAndFruit>? vegetableAndFruitList;
        public DataTable? dataTable;
        SqlConnection? sqlConnection;
        SqlDataReader queryResult;
        public ExecutQueryWithADONET(string command)
        {
            Command = command;
            OpenDbConnection();

            




        }
        private SqlConnection OpenDbConnection()
        {
            string connectionstring = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vegetables and fruits;Integrated Security=SSPI;";// ConfigurationManager.ConnectionStrings["LocalDbConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            
            return sqlConnection;

        }
        public void ExecuteQuery()
        {
            vegetableAndFruitList = new List<VegetableAndFruit>();
            // Выполнение запроса с помещением результата в объект DataTable
            //dataTable  // объект DataTable, который привяжется в DataGridView
            
            // блок обработчика
            try
            {
                // 1. создать и открыть соединение к БД
                SqlConnection connection = OpenDbConnection();
                // 2. Сформировать и выполнить запрос
                SqlCommand cmd = new SqlCommand(Command, connection);
                queryResult = cmd.ExecuteReader();
                // 3. Переместить результат запрос в объект DataTable
                // 3.1) Создать DataTable
                dataTable = new DataTable();
                // 3.2) Добавить в него столбцы
                do
                {
                    for (int i = 0; i < queryResult.FieldCount; i++)
                    {
                        dataTable.Columns.Add(queryResult.GetName(i));
                       
                    }
                    // 3.3) Добавить строки
                    while (queryResult.Read())
                    {
                        DataRow row = dataTable.NewRow();   // создать строку dataTable
                        for (int i = 0; i < queryResult.FieldCount; i++)
                        {
                            row[i] = queryResult[i];
                        }
                        dataTable.Rows.Add(row);
                    }
                    // 4. помещение dataTable в качестве источника данных для DataGridView

                   //dataTable;

                } while (queryResult.NextResult());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something wrong: {ex.Message}", "SQL Error");
            }
            finally
            {
                sqlConnection?.Close();
                queryResult?.Close();
            }

        }





    }
}
