using System.Drawing;
using System.Windows.Forms;

namespace Rieltor_AIS
{
    public partial class Deals : NavigationTemplate
    {
        public Deals()
        {
            InitializeComponent();
            label1.Visible = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
        }
    }
}