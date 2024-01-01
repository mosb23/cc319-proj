

using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace GuiTesting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private Queue<string> tasks;


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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.BtnAdd.Image = global::GuiTesting.Properties.Resources.neonaddnew;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(0, -5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(286, 80);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add Task";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.adddbutton3_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRemove.Image = global::GuiTesting.Properties.Resources.neonaddnew678;
            this.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemove.Location = new System.Drawing.Point(0, 374);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(286, 80);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Remove all tasks";
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveBtn.Image = global::GuiTesting.Properties.Resources.newgarbage123;
            this.RemoveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBtn.Location = new System.Drawing.Point(0, 149);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(286, 80);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove current Task";
            this.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Image = global::GuiTesting.Properties.Resources.Neonmagnew;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(0, 298);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(286, 80);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update a task";
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.viewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewButton.Image = global::GuiTesting.Properties.Resources.glowyeyesnew;
            this.viewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewButton.Location = new System.Drawing.Point(0, 222);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(286, 80);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View current task";
            this.viewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // BtnView
            // 
            this.BtnView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnView.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnView.Image = global::GuiTesting.Properties.Resources.neonlistnew;
            this.BtnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnView.Location = new System.Drawing.Point(0, 72);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(286, 80);
            this.BtnView.TabIndex = 1;
            this.BtnView.Text = "view all Task";
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(571, 455);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.BtnView);
            this.Name = "Form1";
            this.Text = "Task scheduler";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
    }



    public interface IQueue<T>
    {
        bool Enqueue(T task);

        T Dequeue();

        int QueueSize();


    }

    public class Queue<T> : IQueue<T>
    {
        private List<T> taskList;
        private int front, back;     


        public int Front
        {
            get { return front; }
            set { this.front = value; }
        }      

        public int Back
        {
            get { return back; }
            set { this.back = value; }
        }

        //creating constructor   

        public Queue()
        {
            this.taskList = new List<T>();
            this.front = 0;
            this.back = 0;
        }


        //Add Method   


        public virtual bool Enqueue(T task)
        {
            this.taskList.Add(task);

            this.back++;

            return true;

        }

        public virtual T Dequeue()
        {

            T item = this.taskList[this.front];
            this.front++;

            if (this.front == this.back)
            {
                //resetting pointers 
                this.front = 0;
                this.back = 0;

                this.taskList.Clear();
            }
            return item;
        }
        public T Peek()
        {

            T peekitem = this.taskList[this.front];
            return peekitem;
        }
        public int FindIndex(T item)
        {
            if (QueueSize() != 0)
            {
                return this.taskList.IndexOf(item);
            }

            return -1;
        }
        public void ChangeAtIndex(int index, T newValue)
        {
            this.taskList[index] = newValue;

        }
        /*public void Display()
        {
            for (int i = front; i < back; i++)
            {
                Console.WriteLine("- " + this.taskList[i]);
            }
        }
          */

        public virtual int QueueSize()
        {
            return this.taskList.Count;
        }

        public IEnumerable<T> GetAllTasks()
        {
            // Returning all tasks without dequeuing
            return this.taskList;
        }

        
    }

  

}




