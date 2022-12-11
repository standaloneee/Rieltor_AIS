using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    public partial class NavigationTemplate : Form
    {
        public NpgsqlDataAdapter adapter;
        public DataSet ds = new DataSet();
        
        public NavigationTemplate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
        }

        private void mainBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = Application.OpenForms.OfType<NavigationTemplate>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
                form.Show();
            }
            else
            {
                new NavigationTemplate().Show();
                this.Hide();
                this.Text = "Main";

            }

            
        }

        private void personnelBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = Application.OpenForms.OfType<Personnel>().FirstOrDefault();
            if (form != null)
            {
                form.Text = "Personnel";
                form.Activate();
                form.Show();
            }
            else
            {
                new Personnel().Show();
                this.Hide();
            }
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void realtyBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = Application.OpenForms.OfType<Realty>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
                form.Show();
            }
            else
            {
                new Realty().Show();
                this.Hide();
            }
            
        }

        private void deals_Bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = Application.OpenForms.OfType<Deals>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
                form.Show();
            }
            else
            {
                new Deals().Show();
                this.Hide();
            }
        }

        private void save_Bt_Click(object sender, EventArgs e)
        {
            // save all
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            adapter.InsertCommand = new NpgsqlCommandBuilder(adapter).GetInsertCommand();
            adapter.UpdateCommand = new NpgsqlCommandBuilder(adapter).GetUpdateCommand();
            adapter.Update(ds);
            ds.Clear();
            adapter.Fill(ds);
            conn.Close();

        }
    }
}