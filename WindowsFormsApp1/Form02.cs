using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form02 : Form
    {
        public Form03 Form03 { get; set; }

        public Form02()
        {
            InitializeComponent();
        }

        private void btnCloseForm3_Click(object sender, EventArgs e)
        {
            Form03?.Close();
        }
    }
}
