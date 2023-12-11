using Demo_2.Forms;
using Demo_2.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_2
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            box_Filter.Items.Add("Все производители");
            DataTable dataTable = db_Connect.fromDB($"select*from Manufactures");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (box_Filter.Items.Contains(dataTable.Rows[i][1].ToString()) == false)
                    box_Filter.Items.Add(dataTable.Rows[i][1].ToString());
            }
            uc_Load();
        }
        /// <summary>
        /// 
        /// </summary>
        private void uc_Load()
        {
            try
            {
                int result = 0;
                pnl_Product.Controls.Clear();
                DataTable dataTable = db_Connect.fromDB($"execute sp_Load_2 '{box_Filter.SelectedItem}','{box_Sort.SelectedIndex}','{box_Search.Text}'");
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    uc_Product uc_Product = new uc_Product();
                    uc_Product.uc_id = (int)dataTable.Rows[i][0];
                    pnl_Product.Controls.Add(uc_Product);
                    result++;
                }
                DataTable dataTable1 = db_Connect.fromDB($"select*from v_Product");
                lbl_Count.Text = $"{result} из {dataTable1.Rows.Count}";
                if (result == 0)
                {
                    MessageBox.Show("Ничего не найдено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void box_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void box_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void box_Search_TextChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите выйти?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            box_Filter.SelectedIndex = 0;
            box_Sort.SelectedIndex = 0;
            box_Search.Clear();
        }

        public static class AddUpdate
        {
            public static string Select;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddUpdate.Select = "Add";
            AddUpdateForm addUpdateForm = new AddUpdateForm();
            addUpdateForm.ShowDialog();
            uc_Load();
        }

        private void ProductForm_Activated(object sender, EventArgs e)
        {
            uc_Load();
        }
    }
}
