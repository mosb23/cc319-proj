using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiTesting
{
    public partial class ViewAll : Form
    {

        public int  QueueSize{ set; get; }
        /*public int Orgfront { set; get; }   
        public int Orgback { set; get; } 
*/
        private ListBox taskListBox;
        public ViewAll(IEnumerable<string> tasks,int size)
        {
            InitializeComponent();      
            DisplayTaskList(tasks);        
            this.QueueSize = size;;
        }


        private void DisplayTaskList(IEnumerable<string> tasks)
        {
            // Populate the ListBox with tasks

            //string[] tempArr = tasks.ToArray();
           // for (int i = this.Orgfront; i < this.Orgback; i++) {
            this.taskListBox.Items.Clear();
           
            this.taskListBox.Items.AddRange(tasks.ToArray());   
           // }
            //this.taskListBox.Items.Clear();

        }            

       



        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ViewAll_Load(object sender, EventArgs e)
        {

        }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {

          }

        private void ViewAll_Load_1(object sender, EventArgs e)
        {

        }

        private void ViewAll_Load_2(object sender, EventArgs e)
        {

        }

        private void taskListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {

            if (this.QueueSize == 0) { this.Close(); }

            else
            {
                for (int i = 0; i < this.QueueSize; i++)
                {
                    this.taskListBox.Items.Clear();
                    this.Close();

                }

            }

        }
    }
}
