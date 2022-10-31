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
    public partial class AddForm : Form
    {
        DataBase dataBase = new DataBase();
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = textBox1.Text;
            var bday = textBox2.Text;
            var address = textBox3.Text;
            var tel = textBox4.Text;
            var addQuery = $"insert into addressee (name, bday, adress, tel) values ('{name}', '{bday}', '{address}', '{tel}')";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запис створено");
            dataBase.closeConnection();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
