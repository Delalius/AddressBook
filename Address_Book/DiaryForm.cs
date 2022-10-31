using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Address_Book
{
    enum RowStat
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class DiaryForm : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("note", "Запис");
            dataGridView2.Columns.Add("date", "Дата");
            dataGridView2.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowStat.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from diary";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void deleteRow()
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[5].Value = RowStat.Deleted;
                return;
            }

            dataGridView2.Rows[index].Cells[5].Value = RowStat.Deleted;
        }

        private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowStat)dataGridView2.Rows[index].Cells[2].Value;
                if (rowState == RowStat.Existed)
                    continue;
                if (rowState == RowStat.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from diary where id = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowStat.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var note = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var date = dataGridView2.Rows[index].Cells[2].Value.ToString();
                  

                    var changeQuery = $"update diary set note = '{note}',date ='{date}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                }
            }
            dataBase.closeConnection();
        }



        public DiaryForm()
        {
            InitializeComponent();
        }

        private void DiaryForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxNote.Text = row.Cells[1].Value.ToString();
                textBoxDate.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void buttonRefr_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            AddNote addnote = new AddNote();
            addnote.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from diary where concat(id,note,date) like '%" + textBox1_srch.Text + "%' ";
            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void button2_del_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button4_sv_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            var id = textBoxID.Text;
            var note = textBoxNote.Text;
            var date = textBoxDate.Text;

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView2.Rows[selectedRowIndex].SetValues(id, note, date);
                dataGridView2.Rows[selectedRowIndex].Cells[2].Value = RowStat.Modified;
            }
        }

        private void button_ch_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void textBox1_srch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView2);
        }
    }
}
