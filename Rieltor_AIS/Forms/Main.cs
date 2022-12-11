using System.Drawing;
using System.Windows.Forms;

namespace Rieltor_AIS
{
    public partial class Main : NavigationTemplate
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(250, 250);
        }
    }
}