namespace Demo_2.Forms
{
    partial class AddUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_Desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_Provider = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_Manuf = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_Categor = new System.Windows.Forms.ComboBox();
            this.box_Count = new System.Windows.Forms.MaskedTextBox();
            this.box_Cost = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.box_Image = new System.Windows.Forms.PictureBox();
            this.box_Image_Text = new System.Windows.Forms.TextBox();
            this.btn_Image = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Добавление/изменение";
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.Location = new System.Drawing.Point(725, 5);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(74, 23);
            this.lbl_Exit.TabIndex = 11;
            this.lbl_Exit.Text = "<--Назад";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // box_Name
            // 
            this.box_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Name.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Name.Location = new System.Drawing.Point(5, 65);
            this.box_Name.Name = "box_Name";
            this.box_Name.Size = new System.Drawing.Size(275, 30);
            this.box_Name.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(295, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Описание";
            // 
            // box_Desc
            // 
            this.box_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Desc.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Desc.Location = new System.Drawing.Point(295, 65);
            this.box_Desc.Multiline = true;
            this.box_Desc.Name = "box_Desc";
            this.box_Desc.Size = new System.Drawing.Size(495, 145);
            this.box_Desc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Поставщик";
            // 
            // box_Provider
            // 
            this.box_Provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Provider.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Provider.FormattingEnabled = true;
            this.box_Provider.Location = new System.Drawing.Point(10, 130);
            this.box_Provider.Name = "box_Provider";
            this.box_Provider.Size = new System.Drawing.Size(165, 31);
            this.box_Provider.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Производитель";
            // 
            // box_Manuf
            // 
            this.box_Manuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Manuf.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Manuf.FormattingEnabled = true;
            this.box_Manuf.Location = new System.Drawing.Point(10, 200);
            this.box_Manuf.Name = "box_Manuf";
            this.box_Manuf.Size = new System.Drawing.Size(165, 31);
            this.box_Manuf.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Категория";
            // 
            // box_Categor
            // 
            this.box_Categor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Categor.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Categor.FormattingEnabled = true;
            this.box_Categor.Location = new System.Drawing.Point(10, 270);
            this.box_Categor.Name = "box_Categor";
            this.box_Categor.Size = new System.Drawing.Size(165, 31);
            this.box_Categor.TabIndex = 20;
            // 
            // box_Count
            // 
            this.box_Count.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Count.Location = new System.Drawing.Point(565, 260);
            this.box_Count.Mask = "00000";
            this.box_Count.Name = "box_Count";
            this.box_Count.Size = new System.Drawing.Size(100, 30);
            this.box_Count.TabIndex = 22;
            this.box_Count.ValidatingType = typeof(int);
            // 
            // box_Cost
            // 
            this.box_Cost.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Cost.Location = new System.Drawing.Point(685, 260);
            this.box_Cost.Mask = "00000";
            this.box_Cost.Name = "box_Cost";
            this.box_Cost.Size = new System.Drawing.Size(100, 30);
            this.box_Cost.TabIndex = 23;
            this.box_Cost.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(565, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Кол-во";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(685, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Цена";
            // 
            // box_Image
            // 
            this.box_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_Image.Location = new System.Drawing.Point(30, 315);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(120, 120);
            this.box_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_Image.TabIndex = 26;
            this.box_Image.TabStop = false;
            // 
            // box_Image_Text
            // 
            this.box_Image_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Image_Text.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Image_Text.Location = new System.Drawing.Point(165, 315);
            this.box_Image_Text.Name = "box_Image_Text";
            this.box_Image_Text.Size = new System.Drawing.Size(390, 30);
            this.box_Image_Text.TabIndex = 27;
            // 
            // btn_Image
            // 
            this.btn_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Image.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Image.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Image.Location = new System.Drawing.Point(300, 355);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(135, 40);
            this.btn_Image.TabIndex = 28;
            this.btn_Image.Text = "Выбрать фото";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Location = new System.Drawing.Point(655, 340);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(135, 40);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Сохранить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.Location = new System.Drawing.Point(655, 395);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(135, 40);
            this.btn_Delete.TabIndex = 30;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.box_Image_Text);
            this.Controls.Add(this.box_Image);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_Cost);
            this.Controls.Add(this.box_Count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_Categor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_Manuf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_Provider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_Desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_Name);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "AddUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно добавления/изменения";
            this.Load += new System.EventHandler(this.AddUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_Desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox box_Provider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox box_Manuf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox box_Categor;
        private System.Windows.Forms.MaskedTextBox box_Count;
        private System.Windows.Forms.MaskedTextBox box_Cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox box_Image;
        private System.Windows.Forms.TextBox box_Image_Text;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
    }
}