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
    public partial class Main : Form
    {
        private Form01 _form01;
        public Form02 Form02;
        public Form03 Form03;

        public Main()
        {
            InitializeComponent();
        }

        private void form01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_form01 == null)
            {
                _form01            =  new Form01(this);
                _form01.MdiParent  =  this;
                _form01.FormClosed += new FormClosedEventHandler(form01_FormClosed);
                _form01.Show();
            }
            else _form01.Activate();
        }
        
        private void form02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }

        private void form03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm3();
        }

        public void OpenForm2()
        {
            if (Form02 == null)
            {
                Form02            =  new Form02();
                Form02.MdiParent  =  this;
                Form02.FormClosed += new FormClosedEventHandler(form02_FormClosed);
                Form02.Show();
            }
            else Form02.Activate();
        }

        public void OpenForm3()
        {
            if (Form03 == null)
            {
                Form03            =  new Form03();
                Form03.MdiParent  =  this;
                Form03.FormClosed += new FormClosedEventHandler(form03_FormClosed);
                Form03.Show();
                Form02.Form03 = Form03;
            }
            else Form03.Activate();
        }

        void form01_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form01 = null;
        }

        void form02_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form02 = null;
        }

        void form03_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form03 = null;
        }
    }
}
