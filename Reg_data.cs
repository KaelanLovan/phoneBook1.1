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
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void New_butt_Click(object sender, EventArgs e)
        {
            this.New_butt.Enabled = false;
            this.Save_butt.Enabled = true;
            //--------------------------------
            this.Info_gbox.Enabled = true;
            //---------Clear TextBoxes -------
            this.id_textBox1.ResetText();
            this.fn_textBox2.ResetText();
            this.ln_textBox3.ResetText();
            this.tel_textBox4.ResetText();
            this.cell_textBox5.ResetText();
            this.email_textBox6.ResetText();
            this.address_textBox7.ResetText();
            this.comment_textBox8.ResetText();            
            //--------------------------------
        }

        private void Save_butt_Click(object sender, EventArgs e)
        {
            if (this.id_textBox1.Text=="")
            {
                MessageBox.Show("You must enter a valid ID!");
                return;
            }
            //-------------------------------
            this.Save_butt.Enabled = false;
            this.New_butt.Enabled = true;
            //-------------------------------
            this.Info_gbox.Enabled = false;
            //-------------------------------
            string fn;
            fn = "info\\";
            string p;
            //-------------first name--------------------------------
            p = fn + this.id_textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.fn_textBox2.Text, Encoding.UTF8);
            //--------------last name--------------------------------
            p = fn + this.id_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.ln_textBox3.Text, Encoding.UTF8);
            //--------------telephone--------------------------------
            p = fn + this.id_textBox1.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.tel_textBox4.Text, Encoding.UTF8);
            //--------------cellphone--------------------------------
            p = fn + this.id_textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.cell_textBox5.Text, Encoding.UTF8);
            //--------------email------------------------------------
            p = fn + this.id_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.email_textBox6.Text, Encoding.UTF8);
            //--------------adress-----------------------------------
            p = fn + this.id_textBox1.Text + "_address.txt";
            System.IO.File.WriteAllText(p, this.address_textBox7.Text, Encoding.UTF8);
            //--------------comment-----------------------------------
            p = fn + this.id_textBox1.Text + "_comment.txt";
            System.IO.File.WriteAllText(p, this.comment_textBox8.Text, Encoding.UTF8);
            //--------------------------------------------------------            
            MessageBox.Show("Saved!");
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.Info_gbox.Enabled = false;
        }
    }
}
