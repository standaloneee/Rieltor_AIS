using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    public partial class UserForm : Form
    {
        NpgsqlDataAdapter adapter;

        NpgsqlConnection conn =
            new NpgsqlConnection(
                "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");

        DataSet ds = new DataSet();

        private int user_id = 0;
        private int realty_id = 0;

        public UserForm(string user_id)
        {
            InitializeComponent();
            this.user_id = Convert.ToInt32(user_id);
            StartPosition = FormStartPosition.Manual;
            Location = new Point(250, 250);
            conn.Open();
            adapter = new NpgsqlDataAdapter("SELECT * FROM \"realty\"", conn);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.realty_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void choose_Bt_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string date_str = date.ToString("dd-MM-yyyy");
            string _price = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            
            // insert into deals
            conn.Open();
            //check if user has already bought this realty
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM \"deals\" WHERE \"user_id\" = " + this.user_id + " AND \"realty_id\" = " + this.realty_id, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Вы уже приобрели эту недвижимость");
            }
            else
            {
                dr.Close();
                cmd = new NpgsqlCommand("INSERT INTO \"deals\" (\"user_id\", \"realty_id\", \"date\", \"price\") VALUES (" + this.user_id + ", " + this.realty_id + ", '" + date_str + "', " + _price + ")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Поздравляем! Вы приобрели недвижимость!");
            }
            // NpgsqlCommand command =
            //     new NpgsqlCommand(
            //         "INSERT INTO \"deals\" (\"date\", \"user_id\", \"realty_id\", \"price\") VALUES ('" + date_str + "', " +
            //         user_id + ", " + realty_id + "," + _price + ")", conn);
            // command.ExecuteNonQuery();
            // MessageBox.Show("Успешно!");
            conn.Close();
        }

        private void back_Bt_Click(object sender, EventArgs e)
        {
            // go back to auhorization form
            this.Hide();
            Form1 authorizationForm = new Form1();
            authorizationForm.Show();
            
        }

        private void exit_Bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}