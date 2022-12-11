using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;



namespace Rieltor_AIS
{
    public partial class Personnel : NavigationTemplate
    {
        
        public Personnel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
            //connect to postgres and put data into data grid view
            
            

            NpgsqlConnection conn = new NpgsqlConnection
                ("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            adapter = new NpgsqlDataAdapter("SELECT * FROM \"users\"", conn);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
        }

    }
}