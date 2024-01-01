using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiTesting
{
    public partial class Add_Form2 : Form
    {

        public string Qtext {  get; set; }
        public Add_Form2()
        {
            InitializeComponent();
            //QueueImplementatio

        }

        private void Add_Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
               

            
           

            
        }

        private void buttonconfimAdd_Click(object sender, EventArgs e)
        {

            
              this.Qtext = textBox1.Text;
              textBox1.Clear(); 
              this.Close();
            
            

            
            
          
        }
    }
}



