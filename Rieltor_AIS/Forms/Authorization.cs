using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rieltor_AIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open main form
            // close this form after opening main form
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}