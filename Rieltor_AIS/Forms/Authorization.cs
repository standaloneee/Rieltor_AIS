using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open main form
            // close this form after opening main form
            // seartch for user in database and if password is correct open main form
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM accounts WHERE login = '" + login.Text + "' AND password = '" + password.Text + "'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Main main = new Main();
                main.Show();
                this.Hide();
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
    }
}