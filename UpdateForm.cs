using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GuiTesting
{
    public partial class UpdateForm : Form
    {

        private ComboBox taskComboBox;
        private TextBox updatedTaskTextBox;
        private Button updateButton;

        private readonly IEnumerable<string> taskList;
        private readonly Form1 parentForm;
            
       
       
        public UpdateForm(IEnumerable<string> tasks,Form1 ParentForm)
        {
            InitializeComponent(); 
            this.taskComboBox = new ComboBox();
            this.updatedTaskTextBox = new TextBox();
            this.updateButton = new Button();
            this.parentForm = ParentForm;

            // Set properties for controls
            this.taskComboBox.Location = new System.Drawing.Point(12, 12);
            this.taskComboBox.Size = new System.Drawing.Size(200, 21);

            this.updatedTaskTextBox.Location = new System.Drawing.Point(12, 39);
            this.updatedTaskTextBox.Size = new System.Drawing.Size(200, 20);

            this.updateButton.Location = new System.Drawing.Point(12, 65);
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.Text = "Update";
            this.updateButton.Click += new EventHandler(this.UpdateButton_Click);

            // Add controls to the form
            this.Controls.Add(this.taskComboBox);
            this.Controls.Add(this.updatedTaskTextBox);
            this.Controls.Add(this.updateButton);

            // Set form properties
            this.Text = "Update Task";
            this.Size = new System.Drawing.Size(240, 130);


            // Populate the ComboBox with existing tasks
            taskComboBox.Items.AddRange(tasks.ToArray());

            taskList = tasks;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }    


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Get the selected task and the updated task
            string selectedTask = taskComboBox.SelectedItem?.ToString();
            string updatedTask = updatedTaskTextBox.Text.ToLower();

            if (!string.IsNullOrEmpty(selectedTask) && !string.IsNullOrEmpty(updatedTask))
            {
                // Pass the selected and updated tasks back to the MainForm          
                parentForm.OnUpdateTask(selectedTask, updatedTask);
                /*Form1 f1=new Form1();
                f1.OnUpdateTask(selectedTask, updatedTask);
                 */
                // Close the form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a task and enter an updated task.");
            }

        }

    }
}
