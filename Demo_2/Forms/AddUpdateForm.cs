using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Demo_2.ProductForm;
using static Demo_2.UI.uc_Product;

namespace Demo_2.Forms
{
    public partial class AddUpdateForm : Form
    {
        public AddUpdateForm()
        {
            InitializeComponent();
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = db_Connect.fromDB($"select*from v_Product");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (box_Manuf.Items.Contains(dataTable.Rows[i][6].ToString()) == false)
                    box_Manuf.Items.Add(dataTable.Rows[i][6].ToString());
                if (box_Provider.Items.Contains(dataTable.Rows[i][5].ToString()) == false)
                    box_Provider.Items.Add(dataTable.Rows[i][5].ToString());
                if (box_Categor.Items.Contains(dataTable.Rows[i][7].ToString()) == false)
                    box_Categor.Items.Add(dataTable.Rows[i][7].ToString());
            }
            DataTable dataTable1 = db_Connect.fromDB($"select*from v_Product where ProductID = {Product.ID}");
            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                if (AddUpdate.Select == "Update")
                {
                    box_Name.Text = $"{dataTable1.Rows[i][1]}";
                    box_Desc.Text = $"{dataTable1.Rows[i][2]}";
                    box_Cost.Text = $"{dataTable1.Rows[i][3]}";
                    box_Count.Text = $"{dataTable1.Rows[i][4]}";
                    box_Provider.SelectedItem = $"{dataTable1.Rows[i][5]}";
                    box_Manuf.SelectedItem = $"{dataTable1.Rows[i][6]}";
                    box_Categor.SelectedItem = $"{dataTable1.Rows[i][7]}";
                }
            }
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите выйти?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Close();
            }
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    box_Image.Image = new Bitmap(openFileDialog.FileName);
                    box_Image_Text.Text = openFileDialog.FileName.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                switch (AddUpdate.Select)
                {
                    case "Add":
                        db_Connect.toDB($"execute sp_AddUpdate1 'Add','','{box_Name.Text}','{box_Desc.Text}','{box_Cost.Text}','{box_Count.Text}','{box_Provider.SelectedIndex+1}','{box_Manuf.SelectedIndex+1}','{box_Categor.SelectedIndex+1}'");
                        MessageBox.Show("Товар успешно добавлен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        break;
                    case "Update":
                        db_Connect.toDB($"execute sp_AddUpdate1 'Update','{Product.ID}','{box_Name.Text}','{box_Desc.Text}','{box_Cost.Text}','{box_Count.Text}','{box_Provider.SelectedIndex+1}','{box_Manuf.SelectedIndex+1}','{box_Categor.SelectedIndex+1}'");
                        MessageBox.Show("Товар успешно изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите удалить товар?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    db_Connect.toDB($"execute sp_Delete '{Product.ID}'");
                    MessageBox.Show("Товар успешно удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
