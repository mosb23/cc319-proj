using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuiTesting
{
    public partial class viewall_from3 : Form
    {
        public viewall_from3()
        {
            InitializeComponent();

            label1.Text = Form1.currtxt;

        }

        private void viewall_from3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

            

            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


            textBox1.Text = Form1.currtxt;   
            
            


        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Text=Form1.currtxt;
            //label1.Show();
            //this.Controls.Add(label1);
            //var l= new Label();
            //l.Show();
        }
        private void label1_CLick(object sender, EventArgs e) 
        { 
            this.Controls.Add(label1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
