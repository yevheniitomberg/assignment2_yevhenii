using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_yevhenii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cacl_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double a_rev = Double.Parse(this.input_a.Text) * 15;
                double b_rev = Double.Parse(this.input_b.Text) * 12;
                double c_rev = Double.Parse(this.input_c.Text) * 9;
                this.class_a_rev_total.Text = a_rev + " €";
                this.class_b_rev_total.Text = b_rev + " €";
                this.class_c_rev_total.Text = c_rev + " €";
                this.rev_total.Text = (a_rev + b_rev + c_rev) + " €";
            } catch (Exception)
            {
                MessageBox.Show("Incorrect input type was used");
            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.input_a.Text = "";
            this.input_b.Text = "";
            this.input_c.Text = "";
            this.rev_total.Text = "";
            this.class_a_rev_total.Text = "";
            this.class_b_rev_total.Text = "";
            this.class_c_rev_total.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
