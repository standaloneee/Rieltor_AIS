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

        public NpgsqlConnection conn =
            new NpgsqlConnection(
                "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");

        public DataSet ds = new DataSet();

        public NavigationTemplate()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(250, 250);
        }

        private void mainBt_Click(object sender, EventArgs e)
        {
            
            Hide();
            var form = Application.OpenForms.OfType<NavigationTemplate>().FirstOrDefault();
            
            if (form != null)
            {
                form.Activate();
                form.save_Bt.Visible = false;
                form.Show();
            }
            else
            {
                new NavigationTemplate().Show();
                Hide();
                Text = "Main";
                save_Bt.Visible = false;

            }
        }

        private void personnelBt_Click(object sender, EventArgs e)
        {
            Hide();
            var form = Application.OpenForms.OfType<Personnel>().FirstOrDefault();
            if (form != null)
            {
                form.Text = "Personnel";
                form.Activate();
                form.Show();
                save_Bt.Visible = true;
            }
            else
            {
                new Personnel().Show();
                Hide();
                save_Bt.Visible = true;
            }
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void realtyBt_Click(object sender, EventArgs e)
        {
            Hide();
            var form = Application.OpenForms.OfType<Realty>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
                form.Show();
                save_Bt.Visible = true;
            }
            else
            {
                new Realty().Show();
                Hide();
                save_Bt.Visible = true;
            }
        }

        private void deals_Bt_Click(object sender, EventArgs e)
        {
            Hide();
            var form = Application.OpenForms.OfType<Deals>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
                form.Show();
                save_Bt.Visible = true;
            }
            else
            {
                new Deals().Show();
                Hide();
                save_Bt.Visible = true;
            }
        }

        private void save_Bt_Click(object sender, EventArgs e)
        {
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