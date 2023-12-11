namespace Demo_2.UI
{
    partial class uc_Product
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_Manuf = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_Provider = new System.Windows.Forms.Label();
            this.lbl_Categ = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Cost_2 = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // box_Image
            // 
            this.box_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_Image.Location = new System.Drawing.Point(5, 10);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(120, 120);
            this.box_Image.TabIndex = 27;
            this.box_Image.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Name.Location = new System.Drawing.Point(130, 10);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(101, 28);
            this.lbl_Name.TabIndex = 28;
            this.lbl_Name.Text = "Название";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Desc.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Desc.Location = new System.Drawing.Point(130, 50);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(515, 80);
            this.lbl_Desc.TabIndex = 29;
            this.lbl_Desc.Text = "Описание";
            // 
            // lbl_Manuf
            // 
            this.lbl_Manuf.AutoSize = true;
            this.lbl_Manuf.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Manuf.Location = new System.Drawing.Point(5, 150);
            this.lbl_Manuf.Name = "lbl_Manuf";
            this.lbl_Manuf.Size = new System.Drawing.Size(130, 23);
            this.lbl_Manuf.TabIndex = 30;
            this.lbl_Manuf.Text = "Производитель";
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cost.Location = new System.Drawing.Point(650, 55);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(52, 23);
            this.lbl_Cost.TabIndex = 31;
            this.lbl_Cost.Text = "Цена:";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Count.Location = new System.Drawing.Point(650, 105);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(68, 23);
            this.lbl_Count.TabIndex = 32;
            this.lbl_Count.Text = "Кол-во:";
            // 
            // lbl_Provider
            // 
            this.lbl_Provider.AutoSize = true;
            this.lbl_Provider.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Provider.Location = new System.Drawing.Point(310, 150);
            this.lbl_Provider.Name = "lbl_Provider";
            this.lbl_Provider.Size = new System.Drawing.Size(97, 23);
            this.lbl_Provider.TabIndex = 33;
            this.lbl_Provider.Text = "Поставщик";
            // 
            // lbl_Categ
            // 
            this.lbl_Categ.AutoSize = true;
            this.lbl_Categ.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Categ.Location = new System.Drawing.Point(580, 150);
            this.lbl_Categ.Name = "lbl_Categ";
            this.lbl_Categ.Size = new System.Drawing.Size(93, 23);
            this.lbl_Categ.TabIndex = 34;
            this.lbl_Categ.Text = "Категория:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ID.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ID.Location = new System.Drawing.Point(760, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(37, 28);
            this.lbl_ID.TabIndex = 35;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // lbl_Cost_2
            // 
            this.lbl_Cost_2.AutoSize = true;
            this.lbl_Cost_2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cost_2.Location = new System.Drawing.Point(650, 80);
            this.lbl_Cost_2.Name = "lbl_Cost_2";
            this.lbl_Cost_2.Size = new System.Drawing.Size(52, 23);
            this.lbl_Cost_2.TabIndex = 36;
            this.lbl_Cost_2.Text = "Цена:";
            this.lbl_Cost_2.Visible = false;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Discount.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Discount.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Discount.Location = new System.Drawing.Point(625, 10);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(119, 28);
            this.lbl_Discount.TabIndex = 37;
            this.lbl_Discount.Text = "Скидка: 0%";
            // 
            // uc_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.lbl_Cost_2);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Categ);
            this.Controls.Add(this.lbl_Provider);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.lbl_Manuf);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.box_Image);
            this.Name = "uc_Product";
            this.Size = new System.Drawing.Size(796, 196);
            this.Load += new System.EventHandler(this.uc_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box_Image;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_Manuf;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_Provider;
        private System.Windows.Forms.Label lbl_Categ;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Cost_2;
        private System.Windows.Forms.Label lbl_Discount;
    }
}
