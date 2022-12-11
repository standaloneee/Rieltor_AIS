using System;
using System.Linq;
using System.Windows.Forms;

namespace Rieltor_AIS
{
    public partial class NavigationTemplate : Form
    {
        public NavigationTemplate()
        {
            InitializeComponent();
        }

        private void mainBt_Click(object sender, EventArgs e)
        {
            // open navigation form
            //check if form is already opened
            if (Application.OpenForms["NavigationTemplate"] == null)
            {
                NavigationTemplate navigationForm = new NavigationTemplate();
                navigationForm.Show();
            }
            else
            {
                Application.OpenForms["NavigationTemplate"].Activate();
            }
            
        }

        private void personnelBt_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Personnel>().FirstOrDefault();
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                new Personnel().Show();
            }
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            // close application
            Application.Exit();
        }
    }
}