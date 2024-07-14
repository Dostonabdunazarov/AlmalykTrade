using AlmalykTrade.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmalykTrade.DbConnection
{
    public class DBquery
    {
        public string StringCon()
        {
            return @"Data Source=DESKTOP-3CO9M8M\MYSQLEXPRESS;Initial Catalog=AlmalykTrade2024;Integrated Security=True; Persist Security Info=True;User ID=admin;Password=Dost0n1994!";
        }
        public SqlDataAdapter queryExecute(string query)
        {
            //try
            //{
            SqlConnection myCon = new SqlConnection(StringCon());
            myCon.Open();

            SqlDataAdapter SDA = new SqlDataAdapter(query, myCon);

            SDA.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Действие успешно выполнено!", "Успех");
            return SDA;
            //}
            //catch
            //{
            //    MessageBox.Show("Возникла ошибка при выполнении запроса.", "Ошибка");
            //    return null;
            //}
        }
        public DataTable queryReturnData(string query, DataGridView grid)
        {
            //try
            //{
            SqlConnection myCon = new SqlConnection(StringCon());
            myCon.Open();

            SqlDataAdapter SDA = new SqlDataAdapter(query, myCon);
            SDA.SelectCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SDA.Fill(dt);

            grid.DataSource = dt;
            MessageBox.Show("Действие успешно выполнено!", "Успех");
            return dt;
            //}
            //catch
            //{
            //    MessageBox.Show("Возникла ошибка при выполнении запроса.", "Ошибка");
            //    return null;
            //}
        }

       

    }
}
