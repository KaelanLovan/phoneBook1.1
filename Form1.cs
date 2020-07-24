using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            About_Us rg = new About_Us();
            rg.MdiParent = this;
            rg.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Reg_data rg = new Reg_data();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search_Form rg = new Search_Form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string c;
            //--------------------------------------------------------------------
            c = "Calculator Pro.exe";

            if (System.IO.File.Exists(c) == true)
            {
                //MessageBox.Show("this is working");
                this.process1.StartInfo.FileName = "Calculator Pro.exe";
                this.process1.Start();
            }
            else
            {
                this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
                this.process1.Start();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            //------------------------
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            //------------------------
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton3_Click(sender, e);
            }
            //------------------------
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton4_Click(sender, e);
            }
            //------------------------
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton5_Click(sender, e);
            }
            //------------------------
        }
    }
}
