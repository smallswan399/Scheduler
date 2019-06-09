using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace Scheduler
{
    public partial class Main : Form
    {
        private string _path;
        public Main()
        {
            InitializeComponent();
        }

        private void browseTasksBtn_Click(object sender, EventArgs e)
        {
            using (var taskService = new TaskService())
            {
                var taskBrowser = new TaskBrowserDialog()
                {
                    TaskService = taskService
                };
                if (taskBrowser.ShowDialog() == DialogResult.OK)
                {
                    _path = taskBrowser.SelectedPath;
                    taskTxt.Text = _path;
                }
            }
        }

        private void editTaskBtn_Click(object sender, EventArgs e)
        {
            using (var taskService = new TaskService())
            {
                var task = taskService.GetTask(_path);
                if (task != null)
                {
                    var taskDialog = new TaskEditDialog(task, true);
                    taskDialog.ShowDialog();
                }
            }
        }

        private void createWizardTaskBtn_Click(object sender, EventArgs e)
        {
            using (var taskService = new TaskService())
            {
                var wizard = new TaskSchedulerWizard(taskService, null, true);
                wizard.ShowDialog();
            }
        }

        private void createTaskBtn_Click(object sender, EventArgs e)
        {
            using (var taskService = new TaskService())
            {
                var taskDialog = new TaskEditDialog(taskService);
                taskDialog.ShowDialog();
            }
        }
    }
}
