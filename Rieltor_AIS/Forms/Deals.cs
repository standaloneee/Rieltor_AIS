using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    public partial class Deals : NavigationTemplate
    {
        public Deals()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            adapter = new NpgsqlDataAdapter("SELECT * FROM \"deals\"", conn);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter.Update(ds);
        }
    }
}