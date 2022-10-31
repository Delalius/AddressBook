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
    public partial class AddNote : Form
    {
        DataBase dataBase = new DataBase();
        public AddNote()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var note = textBox1.Text;
            var date = textBox2.Text;
            var addQuery = $"insert into diary (note, date) values ('{note}', '{date}')";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запис створено");
            dataBase.closeConnection();
        }

        private void AddNote_Load(object sender, EventArgs e)
        {

        }
    }
}

