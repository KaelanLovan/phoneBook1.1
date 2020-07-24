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
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter a valid ID!");
                return;
            }
            //-------------------------------
            string fn;
            fn = "info\\";
            string p;
            string r;
            //-------------first name--------------------------------
            p = fn + this.textBox1.Text + "_fn.txt";
            if (System.IO.File.Exists(p)== true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.fn_label.Text = r;
            }
            //-------------------------------------------------------
            //-------------last name---------------------------------
            p = fn + this.textBox1.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.ln_label.Text = r;
            }
            //-------------telephone---------------------------------
            p = fn + this.textBox1.Text + "_tel.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tel_label.Text = r;
            }
            //-------------cellphone---------------------------------
            p = fn + this.textBox1.Text + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.cell_label.Text = r;
            }
            //-------------email-------------------------------------
            p = fn + this.textBox1.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_label.Text = r;
            }
            //-------------address-----------------------------------
            p = fn + this.textBox1.Text + "_address.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.address_label.Text = r;
            }
            //-------------comment-----------------------------------
            p = fn + this.textBox1.Text + "_comment.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.comment_label.Text = r;
            }
            //-------------------------------------------------------
            this.id_label.Text = this.textBox1.Text;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tel_label_Click(object sender, EventArgs e)
        {

        }
    }
}
