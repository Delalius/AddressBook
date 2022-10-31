namespace Address_Book
{
    partial class DiaryForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1_srch = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button1_add = new System.Windows.Forms.Button();
            this.button2_del = new System.Windows.Forms.Button();
            this.button_ch = new System.Windows.Forms.Button();
            this.button4_sv = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.buttonRefr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(802, 79);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Щоденник";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(802, 208);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // textBox1_srch
            // 
            this.textBox1_srch.Location = new System.Drawing.Point(646, 27);
            this.textBox1_srch.Name = "textBox1_srch";
            this.textBox1_srch.Size = new System.Drawing.Size(142, 20);
            this.textBox1_srch.TabIndex = 3;
            this.textBox1_srch.TextChanged += new System.EventHandler(this.textBox1_srch_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(50, 309);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(175, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(50, 335);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(175, 20);
            this.textBoxNote.TabIndex = 5;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(50, 361);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(175, 20);
            this.textBoxDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-1, 288);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(247, 122);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button1_add
            // 
            this.button1_add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_add.Location = new System.Drawing.Point(420, 296);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(89, 33);
            this.button1_add.TabIndex = 11;
            this.button1_add.Text = "Додати";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // button2_del
            // 
            this.button2_del.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_del.Location = new System.Drawing.Point(420, 335);
            this.button2_del.Name = "button2_del";
            this.button2_del.Size = new System.Drawing.Size(89, 33);
            this.button2_del.TabIndex = 12;
            this.button2_del.Text = "Видалити";
            this.button2_del.UseVisualStyleBackColor = true;
            this.button2_del.Click += new System.EventHandler(this.button2_del_Click);
            // 
            // button_ch
            // 
            this.button_ch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ch.Location = new System.Drawing.Point(420, 374);
            this.button_ch.Name = "button_ch";
            this.button_ch.Size = new System.Drawing.Size(89, 33);
            this.button_ch.TabIndex = 13;
            this.button_ch.Text = "Змініти";
            this.button_ch.UseVisualStyleBackColor = true;
            this.button_ch.Click += new System.EventHandler(this.button_ch_Click);
            // 
            // button4_sv
            // 
            this.button4_sv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4_sv.Location = new System.Drawing.Point(420, 413);
            this.button4_sv.Name = "button4_sv";
            this.button4_sv.Size = new System.Drawing.Size(89, 33);
            this.button4_sv.TabIndex = 14;
            this.button4_sv.Text = "Зберегти";
            this.button4_sv.UseVisualStyleBackColor = true;
            this.button4_sv.Click += new System.EventHandler(this.button4_sv_Click);
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(349, 288);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(243, 162);
            this.listView3.TabIndex = 15;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRefr
            // 
            this.buttonRefr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRefr.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefr.Location = new System.Drawing.Point(458, 24);
            this.buttonRefr.Name = "buttonRefr";
            this.buttonRefr.Size = new System.Drawing.Size(109, 30);
            this.buttonRefr.TabIndex = 16;
            this.buttonRefr.Text = "Оновити";
            this.buttonRefr.UseVisualStyleBackColor = false;
            this.buttonRefr.Click += new System.EventHandler(this.buttonRefr_Click);
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefr);
            this.Controls.Add(this.button4_sv);
            this.Controls.Add(this.button_ch);
            this.Controls.Add(this.button2_del);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBox1_srch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView3);
            this.Name = "DiaryForm";
            this.Text = "DiaryForm";
            this.Load += new System.EventHandler(this.DiaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1_srch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.Button button2_del;
        private System.Windows.Forms.Button button_ch;
        private System.Windows.Forms.Button button4_sv;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button buttonRefr;
    }
}