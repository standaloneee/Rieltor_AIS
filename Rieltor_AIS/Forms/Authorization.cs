using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            StartPosition = FormStartPosition.Manual;
            Location = new Point(250, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open main form
            // close this form after opening main form
            // search for user in database and if password is correct open main form
            var conn = new NpgsqlConnection(
                "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT * FROM accounts WHERE login = '" + login.Text + "' AND password = '" + password.Text + "'",
                conn);
            var dr = cmd.ExecuteReader();
            // check if enter was pressed 


            if (dr.Read())
            {
                var main = new Main();
                main.Show();
                Hide();
            }
            else
            {
                warning.Visible = true;
            }
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            NpgsqlConnection conn =
                new NpgsqlConnection(
                    "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            // create table users if not exists id name surname phone
            NpgsqlCommand command =
                new NpgsqlCommand(
                    "CREATE TABLE IF NOT EXISTS users (id serial PRIMARY KEY, name varchar(50), surname varchar(50), phone varchar(50))",
                    conn);

            // create table realty if not exists id location type owner_count status
            NpgsqlCommand command2 =
                new NpgsqlCommand(
                    "CREATE TABLE IF NOT EXISTS realty (id serial PRIMARY KEY, location varchar(50), r_type varchar(50), owner_count int, status varchar(50))",
                    conn);

            // create table deals if not exists id date price personnel_id user_id realty_id
            NpgsqlCommand command3 =
                new NpgsqlCommand(
                    "CREATE TABLE IF NOT EXISTS deals (id serial PRIMARY KEY, date varchar(50), price int, personnel_id int, user_id int, realty_id int)",
                    conn);

            // create table personnel if not exists id login password account_type
            NpgsqlCommand command4 =
                new NpgsqlCommand(
                    "CREATE TABLE IF NOT EXISTS personnel (id serial PRIMARY KEY, login varchar(50), password varchar(50), account_type varchar(50))",
                    conn);

            // create table accounts if not exists id login password account_type personnel_id
            NpgsqlCommand command5 =
                new NpgsqlCommand(
                    "CREATE TABLE IF NOT EXISTS accounts (id serial PRIMARY KEY, login varchar(50), password varchar(50), account_type varchar(50), personnel_id int)",
                    conn);

            // insert one row into each table
            NpgsqlCommand command6 =
                new NpgsqlCommand(
                    "INSERT INTO users (name, surname, phone) VALUES ('Иван', 'Иванов', '8-800-555-35-35')",
                    conn);

            NpgsqlCommand command7 =
                new NpgsqlCommand(
                    "INSERT INTO personnel (login, password, account_type) VALUES ('admin', 'admin', 'admin')", conn);

            NpgsqlCommand command8 =
                new NpgsqlCommand(
                    "INSERT INTO accounts (login, password, account_type, personnel_id) VALUES ('admin', 'admin', 'admin', 1)",
                    conn);

            NpgsqlCommand command9 =
                new NpgsqlCommand(
                    "INSERT INTO realty (location, r_type, owner_count, status) VALUES ('Москва', 'Квартира', 1, 'Продается')",
                    conn);
            NpgsqlCommand command10 =
                new NpgsqlCommand(
                    "INSERT INTO deals (date, price, personnel_id, user_id, realty_id) VALUES ('01.01.2020', 1000000, 1, 1, 1)",
                    conn);
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();
            command5.ExecuteNonQuery();
            
            
            command6.ExecuteNonQuery();
            command7.ExecuteNonQuery();
            command8.ExecuteNonQuery();
            command9.ExecuteNonQuery();
            command10.ExecuteNonQuery();

            
            NpgsqlCommand fk1 = new NpgsqlCommand("ALTER TABLE accounts ADD FOREIGN KEY (personnel_id) REFERENCES personnel(id)", conn);
            NpgsqlCommand fk2 = new NpgsqlCommand("ALTER TABLE realty ADD FOREIGN KEY (id) REFERENCES deals(id)", conn);
            NpgsqlCommand fk3 = new NpgsqlCommand("ALTER TABLE deals ADD FOREIGN KEY (personnel_id) REFERENCES personnel(id)", conn);
            NpgsqlCommand fk4 = new NpgsqlCommand("ALTER TABLE deals ADD FOREIGN KEY (user_id) REFERENCES users(id)", conn);

            fk1.ExecuteNonQuery();
            fk2.ExecuteNonQuery();
            fk3.ExecuteNonQuery();
            fk4.ExecuteNonQuery();


            conn.Close();
            MessageBox.Show("Test");
        }
    }
}