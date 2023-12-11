namespace Demo_2
{
    partial class ProductForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.box_Sort = new System.Windows.Forms.ComboBox();
            this.box_Filter = new System.Windows.Forms.ComboBox();
            this.box_Search = new System.Windows.Forms.TextBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_Product
            // 
            this.pnl_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Product.AutoScroll = true;
            this.pnl_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Product.Location = new System.Drawing.Point(10, 80);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.Size = new System.Drawing.Size(835, 575);
            this.pnl_Product.TabIndex = 0;
            // 
            // box_Sort
            // 
            this.box_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Sort.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Sort.FormattingEnabled = true;
            this.box_Sort.Items.AddRange(new object[] {
            "Без сортировки",
            "Кол-во (по возрастанию)",
            "Кол-во (по убыванию)",
            "Цена (по возрастанию)",
            "Цена (по убыванию)"});
            this.box_Sort.Location = new System.Drawing.Point(10, 40);
            this.box_Sort.Name = "box_Sort";
            this.box_Sort.Size = new System.Drawing.Size(165, 31);
            this.box_Sort.TabIndex = 1;
            this.box_Sort.SelectedIndexChanged += new System.EventHandler(this.box_Sort_SelectedIndexChanged);
            // 
            // box_Filter
            // 
            this.box_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Filter.FormattingEnabled = true;
            this.box_Filter.Location = new System.Drawing.Point(186, 40);
            this.box_Filter.Name = "box_Filter";
            this.box_Filter.Size = new System.Drawing.Size(165, 31);
            this.box_Filter.TabIndex = 2;
            this.box_Filter.SelectedIndexChanged += new System.EventHandler(this.box_Filter_SelectedIndexChanged);
            // 
            // box_Search
            // 
            this.box_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Search.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Search.Location = new System.Drawing.Point(365, 40);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(480, 30);
            this.box_Search.TabIndex = 3;
            this.box_Search.TextChanged += new System.EventHandler(this.box_Search_TextChanged);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Remove.Location = new System.Drawing.Point(855, 40);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(135, 40);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Сбросить";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Location = new System.Drawing.Point(855, 90);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(135, 40);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(186, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фильтрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(365, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поиск";
            // 
            // lbl_Count
            // 
            this.lbl_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Count.Location = new System.Drawing.Point(875, 140);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(94, 28);
            this.lbl_Count.TabIndex = 9;
            this.lbl_Count.Text = "30 из 30";
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.Location = new System.Drawing.Point(945, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(60, 23);
            this.lbl_Exit.TabIndex = 10;
            this.lbl_Exit.Text = "Выход";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.box_Filter);
            this.Controls.Add(this.box_Sort);
            this.Controls.Add(this.pnl_Product);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.Activated += new System.EventHandler(this.ProductForm_Activated);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_Product;
        private System.Windows.Forms.ComboBox box_Sort;
        private System.Windows.Forms.ComboBox box_Filter;
        private System.Windows.Forms.TextBox box_Search;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_Exit;
    }
}

