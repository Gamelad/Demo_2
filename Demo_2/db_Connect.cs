using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_2
{
    internal class db_Connect
    {
        /// <summary>
        /// 
        /// </summary>
        public static string con = "Data Source = localhost; Initial Catalog = Demo_1; Integrated Security = true";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SqlConnection sqlConnection()
        {
            return new SqlConnection(con);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable fromDB(string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection());
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                DataTable dataTable = new DataTable();
                dataTable = dataSet.Tables[0];
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        public static void toDB(string sql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection());
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
