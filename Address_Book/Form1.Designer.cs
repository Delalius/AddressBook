namespace Address_Book
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_bday = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_bday = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label_search = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_diary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адресати";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(803, 52);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(634, 21);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(154, 20);
            this.textBox_search.TabIndex = 2;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(148, 266);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(187, 20);
            this.textBox_id.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(148, 292);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(187, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_bday
            // 
            this.textBox_bday.Location = new System.Drawing.Point(148, 318);
            this.textBox_bday.Name = "textBox_bday";
            this.textBox_bday.Size = new System.Drawing.Size(187, 20);
            this.textBox_bday.TabIndex = 5;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(148, 344);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(187, 20);
            this.textBox_address.TabIndex = 6;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(148, 370);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(187, 20);
            this.textBox_tel.TabIndex = 7;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(18, 237);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(358, 201);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.Location = new System.Drawing.Point(76, 267);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(25, 19);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "ID";
            this.label_id.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(76, 293);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(46, 19);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Name";
            // 
            // label_bday
            // 
            this.label_bday.AutoSize = true;
            this.label_bday.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label_bday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_bday.Location = new System.Drawing.Point(74, 319);
            this.label_bday.Name = "label_bday";
            this.label_bday.Size = new System.Drawing.Size(60, 19);
            this.label_bday.TabIndex = 11;
            this.label_bday.Text = "Birthday";
            this.label_bday.Click += new System.EventHandler(this.label_bday_Click);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_address.Location = new System.Drawing.Point(76, 343);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(60, 19);
            this.label_address.TabIndex = 12;
            this.label_address.Text = "Address";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label_tel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tel.Location = new System.Drawing.Point(76, 369);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(27, 19);
            this.label_tel.TabIndex = 13;
            this.label_tel.Text = "Tel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(488, 266);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(95, 34);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "Додати";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del.Location = new System.Drawing.Point(488, 306);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(95, 34);
            this.button_del.TabIndex = 16;
            this.button_del.Text = "Видалити";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_change
            // 
            this.button_change.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change.Location = new System.Drawing.Point(488, 346);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(95, 34);
            this.button_change.TabIndex = 17;
            this.button_change.Text = "Змінити";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(488, 386);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(95, 34);
            this.button_save.TabIndex = 18;
            this.button_save.Text = "Зберегти";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(439, 237);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(201, 201);
            this.listView3.TabIndex = 19;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.Location = new System.Drawing.Point(559, 21);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(65, 21);
            this.label_search.TabIndex = 20;
            this.label_search.Text = "Пошук";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(439, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(344, 18);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 22;
            this.button_clear.Text = "Очистити";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_diary
            // 
            this.button_diary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_diary.Location = new System.Drawing.Point(672, 394);
            this.button_diary.Name = "button_diary";
            this.button_diary.Size = new System.Drawing.Size(110, 44);
            this.button_diary.TabIndex = 23;
            this.button_diary.Text = "Щоденник";
            this.button_diary.UseVisualStyleBackColor = true;
            this.button_diary.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.button_diary);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_bday);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_bday);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_bday;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_bday;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_diary;
    }
}

