namespace Scheduler
{
    partial class Main
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
            this.browseTasksBtn = new System.Windows.Forms.Button();
            this.taskTxt = new System.Windows.Forms.TextBox();
            this.editTaskBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createWizardTaskBtn = new System.Windows.Forms.Button();
            this.createTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseTasksBtn
            // 
            this.browseTasksBtn.Location = new System.Drawing.Point(338, 42);
            this.browseTasksBtn.Name = "browseTasksBtn";
            this.browseTasksBtn.Size = new System.Drawing.Size(120, 23);
            this.browseTasksBtn.TabIndex = 0;
            this.browseTasksBtn.Text = "Browse Tasks";
            this.browseTasksBtn.UseVisualStyleBackColor = true;
            this.browseTasksBtn.Click += new System.EventHandler(this.browseTasksBtn_Click);
            // 
            // taskTxt
            // 
            this.taskTxt.Location = new System.Drawing.Point(12, 44);
            this.taskTxt.Name = "taskTxt";
            this.taskTxt.ReadOnly = true;
            this.taskTxt.Size = new System.Drawing.Size(320, 20);
            this.taskTxt.TabIndex = 1;
            // 
            // editTaskBtn
            // 
            this.editTaskBtn.Location = new System.Drawing.Point(464, 42);
            this.editTaskBtn.Name = "editTaskBtn";
            this.editTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.editTaskBtn.TabIndex = 2;
            this.editTaskBtn.Text = "Edit";
            this.editTaskBtn.UseVisualStyleBackColor = true;
            this.editTaskBtn.Click += new System.EventHandler(this.editTaskBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(545, 42);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // createWizardTaskBtn
            // 
            this.createWizardTaskBtn.Location = new System.Drawing.Point(12, 12);
            this.createWizardTaskBtn.Name = "createWizardTaskBtn";
            this.createWizardTaskBtn.Size = new System.Drawing.Size(97, 23);
            this.createWizardTaskBtn.TabIndex = 4;
            this.createWizardTaskBtn.Text = "Create Wizard";
            this.createWizardTaskBtn.UseVisualStyleBackColor = true;
            this.createWizardTaskBtn.Click += new System.EventHandler(this.createWizardTaskBtn_Click);
            // 
            // createTaskBtn
            // 
            this.createTaskBtn.Location = new System.Drawing.Point(115, 12);
            this.createTaskBtn.Name = "createTaskBtn";
            this.createTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.createTaskBtn.TabIndex = 5;
            this.createTaskBtn.Text = "Create";
            this.createTaskBtn.UseVisualStyleBackColor = true;
            this.createTaskBtn.Click += new System.EventHandler(this.createTaskBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 76);
            this.Controls.Add(this.createTaskBtn);
            this.Controls.Add(this.createWizardTaskBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editTaskBtn);
            this.Controls.Add(this.taskTxt);
            this.Controls.Add(this.browseTasksBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseTasksBtn;
        private System.Windows.Forms.TextBox taskTxt;
        private System.Windows.Forms.Button editTaskBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button createWizardTaskBtn;
        private System.Windows.Forms.Button createTaskBtn;
    }
}