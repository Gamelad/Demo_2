using Demo_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Demo_2.ProductForm;

namespace Demo_2.UI
{
    public partial class uc_Product : UserControl
    {   
        /// <summary>
        /// 
        /// </summary>
        public static int uc_id { get; set; }
        public uc_Product()
        {
            InitializeComponent();
        }

        private void uc_Product_Load(object sender, EventArgs e)
        {
            uc_Fill();
        }
        /// <summary>
        /// 
        /// </summary>
        private void uc_Fill()
        {
            try
            {
                double discount = 0;
                double cost = 0;
                DataTable dataTable = db_Connect.fromDB($"select*from v_Product where ProductID = '{uc_id}'");
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    lbl_ID.Text = $"{dataTable.Rows[i][0]}";
                    lbl_Name.Text = $"{dataTable.Rows[i][1]}";
                    lbl_Desc.Text = $"{dataTable.Rows[i][2]}";
                    lbl_Cost.Text = $"Цена: {dataTable.Rows[i][3]} руб.";
                    lbl_Count.Text = $"Кол-во: {dataTable.Rows[i][4]} шт.";
                    lbl_Provider.Text = $"Поставщик: {dataTable.Rows[i][5]}";
                    lbl_Manuf.Text = $"Производитель: {dataTable.Rows[i][6]}";
                    lbl_Categ.Text = $"Категория: {dataTable.Rows[i][7]}";
                    if (Convert.ToInt32(dataTable.Rows[i][4]) < 5)
                        BackColor = Color.LightPink;
                    
                    Random random = new Random();
                    discount = random.Next(0, 90);
                    lbl_Discount.Text = $"Скидка: {discount}%";
                    if (discount > 0)
                    {
                        cost = Convert.ToDouble(dataTable.Rows[i][3]) - (Convert.ToDouble(dataTable.Rows[i][3]) * (discount/100));
                        lbl_Cost.Font = new Font(lbl_Cost.Font, FontStyle.Strikeout);
                        lbl_Cost_2.Visible = true;
                        lbl_Cost_2.Text = $"Цена: {cost} руб.";
                        BackColor = Color.LightGreen;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class Product
        {
            public static int ID;
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {
            Product.ID = Convert.ToInt32(lbl_ID.Text);
            AddUpdate.Select = "Update";
            AddUpdateForm addUpdateForm = new AddUpdateForm();
            addUpdateForm.ShowDialog();
        }
    }
}
