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

    


    public partial class Form1 : Form
    {

        Queue<string> tasks = new Queue<string>();

        public static string currtxt;
        private UpdateForm formupdate;
        


        public Form1()
        {
            
            InitializeComponent();
            



        }      

        

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //all 
                      if (tasks.QueueSize() > 0)
                      {
                // Retrieve all tasks without dequeuing
                         /*List<string> tempList = new List<string>();

                         IEnumerable<string> tArr=tasks.GetAllTasks();
                
                         for(int i = tasks.Front; i < tasks.Back; i++)
                         {
                             
                            tempList.Add(tArr[i]);

                         }
*/


                       IEnumerable<string> allTasks = tasks.GetAllTasks();
                       int currSize=tasks.QueueSize();
                /*int currFront = tasks.Front;     
                int currBack = tasks.Back;
*/
                // Display all tasks in a new form
                      using (ViewAll viewAllTasksForm = new ViewAll(allTasks,currSize))
                       {
                        viewAllTasksForm.ShowDialog();
                      

                        }
                      }
                      else
                      {
                            MessageBox.Show("You don't have any tasks for today.");
                      }
/*
            if (tasks.QueueSize() > 0)
            {            
                
                MessageBox.Show("All Tasks for Today:\n" + string.Join("\n", tasks.GetAllTasks()));   
                
                

            }
            else
            {
                MessageBox.Show("You don't have any tasks for today.");
            }*/


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //removing all tasks
            if (tasks.QueueSize() != 0)
            {
                while (tasks.QueueSize() != 0)
                {
                    tasks.Dequeue();
                }
                MessageBox.Show("ALL tasks are removed");
            }
            else
            {
                MessageBox.Show("you have no tasks for today");
            }
        }

        private void adddbutton3_Click(object sender, EventArgs e)
        {
            Add_Form2 f2 = new Add_Form2(); 
            DialogResult response= f2.ShowDialog();

            if (response == DialogResult.OK)
            {
                if (f2.Qtext == "")
                {
                    MessageBox.Show("Please enter a task");
                }
                else
                {
                    string txt = f2.Qtext;
                    if (tasks.Enqueue(txt)) { MessageBox.Show("Added succesfually"); };
                }
                
            }    


            
            


           
        }

        private void addbutton1_Click(object sender, EventArgs e)
        {

        }   

        //this event will show the current task to perform.

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (tasks.QueueSize() == 0) { MessageBox.Show("You have no tasks for tdy"); }     

            else   
            {
                currtxt= tasks.Peek();
                viewall_from3 f3 = new viewall_from3();

                f3.ShowDialog();

            }    


        }

        //removing a task event
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //remove task 
            if (tasks.QueueSize() != 0)
            {
                tasks.Dequeue();
                MessageBox.Show("the current task is removed");
            }
            else
            {
                MessageBox.Show("You have no tasks for today ");

            }
        }

        public void OnUpdateTask(string selectedTask, string updatedTask)
        {
            // Implement the logic to update the task in the Queue
            int index = tasks.FindIndex(selectedTask);
            if (index != -1)
            {
                tasks.ChangeAtIndex(index, updatedTask);
                MessageBox.Show("Task updated successfully!");
            }
            else
            {
                MessageBox.Show("Selected task not found.");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //update event 
            if (tasks.QueueSize() > 0)
            {
                using (UpdateForm updateTaskForm = new UpdateForm(tasks.GetAllTasks(),this))
                {
                    updateTaskForm.ShowDialog();        
                }
            }
            else
            {
                MessageBox.Show("You don't have any tasks for today.");
            }
        }            

    }
}
