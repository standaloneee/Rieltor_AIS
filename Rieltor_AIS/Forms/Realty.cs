using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    public partial class Realty : NavigationTemplate
    {
        public Realty()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
            NpgsqlConnection conn =
                new NpgsqlConnection(
                    "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            adapter = new NpgsqlDataAdapter("SELECT * FROM \"realty\"", conn);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void comboBox1_Clicked(object sender, EventArgs e)
        {
            
            
            NpgsqlConnection conn =
                new NpgsqlConnection(
                    "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            NpgsqlDataAdapter adapter1 = new NpgsqlDataAdapter("SELECT r_type FROM \"realty\"", conn);

            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            // add "ALL" to combobox
            DataRow row = dt.NewRow();
            row["r_type"] = "ALL";
            dt.Rows.InsertAt(row, 0);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "r_type";
            comboBox1.ValueMember = "r_type";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // display only rows with selected type
            if (comboBox1.Text != "ALL")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("r_type = '{0}'", comboBox1.Text);
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }

        }
    }
}