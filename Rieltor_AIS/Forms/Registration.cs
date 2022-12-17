using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void register_Bt_Click(object sender, EventArgs e)
        {
            // take name surname phone login and password from textboxes and send them to database
            // if login is already taken, color login textbox red and snap cursor to it
            
            // if everything is ok, close this form and open main form
            
            NpgsqlConnection conn =
                new NpgsqlConnection(
                    "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            // check if login is already taken
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM accounts WHERE login = '" + login_TextBox.Text + "'", conn);
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Login is already taken");
                login_TextBox.BackColor = Color.Red;
                login_TextBox.Focus();
            }
            else
            {
                conn.Close();
                conn.Open();
                if (!validateInputs())
                {
                    
                }
                else
                {

                    // if login is not taken, add user to database
                    NpgsqlCommand cmd1 =
                        new NpgsqlCommand(
                            "INSERT INTO users (name, surname, phone) VALUES ('" + name_TextBox.Text + "', '" +
                            surname_TextBox.Text + "', '" + phone_TextBox.Text + "')", conn);
                    cmd1.ExecuteNonQuery();
                    // insert into accounts (login, password, user_id) values ('login', 'password', (select id from users where login = 'login' and password = 'password' and user_id = latest created user from table users))
                    NpgsqlCommand cmd2 =
                        new NpgsqlCommand("INSERT INTO accounts (login, password, user_id, account_type)" +
                                          " VALUES ('" + login_TextBox.Text + "', '" + password_TextBox.Text +
                                          "', (select id from users where name = '" + name_TextBox.Text +
                                          "' and surname = '" + surname_TextBox.Text + "' and phone = '" +
                                          phone_TextBox.Text + "'), 'customer')", conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Registration successful");
                    reader.Close();
                    conn.Close();
                    Close();
                    Form authorization = new Form1();
                    authorization.Show();
                }
                conn.Close();
            }
            
        }
        private bool validateInputs()
        {
            if (name_TextBox.Text == "" || surname_TextBox.Text == "" || phone_TextBox.Text == "" || login_TextBox.Text == "" || password_TextBox.Text == "")
            {
                // color all empty textboxes red
                if (name_TextBox.Text == "")
                {
                    name_TextBox.BackColor = Color.Red;
                }
                if (surname_TextBox.Text == "")
                {
                    surname_TextBox.BackColor = Color.Red;
                }
                if (phone_TextBox.Text == "")
                {
                    phone_TextBox.BackColor = Color.Red;
                }
                if (login_TextBox.Text == "")
                {
                    login_TextBox.BackColor = Color.Red;
                }
                if (password_TextBox.Text == "")
                {
                    password_TextBox.BackColor = Color.Red;
                }
                
                return false;
            }
            // else if check if phone number contains only numbers
            else if (!phone_TextBox.Text.All(char.IsDigit))
            {
                phone_TextBox.BackColor = Color.Red;
                phone_TextBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void back_Bt_Click(object sender, EventArgs e)
        {
            // open main form
            Close();
            Form authorization = new Form1();
            authorization.Show();
        }
    }
}