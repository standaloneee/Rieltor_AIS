using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Rieltor_AIS
{
    public partial class NavigationTemplate : Form
    {
        
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
                label1.Visible = true;
                form.Activate();
                form.Show();
            }
            else
            {
                new NavigationTemplate().Show();
                label1.Visible = true;
                this.Hide();
                label1.Visible = true;
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
                label1.Visible = false;
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
    }
}