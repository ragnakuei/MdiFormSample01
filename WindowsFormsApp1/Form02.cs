using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
