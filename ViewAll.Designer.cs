using System.Windows.Forms;

namespace GuiTesting
{
    partial class ViewAll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.Closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskListBox
            // 
            this.taskListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.taskListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListBox.ForeColor = System.Drawing.Color.Red;
            this.taskListBox.ItemHeight = 22;
            this.taskListBox.Location = new System.Drawing.Point(0, 0);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(232, 329);
            this.taskListBox.TabIndex = 0;
            this.taskListBox.SelectedIndexChanged += new System.EventHandler(this.taskListBox_SelectedIndexChanged_1);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(72, 270);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 23);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.Text = "close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // ViewAll
            // 
            this.ClientSize = new System.Drawing.Size(232, 329);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.taskListBox);
            this.Name = "ViewAll";
            this.Text = "All Tasks";
            this.Load += new System.EventHandler(this.ViewAll_Load_2);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Button Closebutton;
    }
}