using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form01 : Form
    {
        private readonly Main   _mdiParentForm;

        public Form01(Main mdiParentForm)
        {
            _mdiParentForm = mdiParentForm;
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            _mdiParentForm.OpenForm2();
        }

        private void btnOpenForm3_Click(object sender, EventArgs e)
        {
            _mdiParentForm.OpenForm3(true);
        }
    }
}