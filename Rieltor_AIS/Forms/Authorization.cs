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
    }
}