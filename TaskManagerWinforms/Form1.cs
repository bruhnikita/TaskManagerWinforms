using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManagerWinforms
{
    public partial class MainForm : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private System.Windows.Forms.Timer updateTimer;

        public MainForm()
        {
            InitializeComponent();
            UpdateTaskCount();

            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 1000; 
            updateTimer.Tick += OnUpdateTimerTick;
            updateTimer.Start();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            int hours = (int)numHours.Value;
            int minutes = (int)numMinutes.Value;

            if (!string.IsNullOrEmpty(taskName) && (hours > 0 || minutes > 0))
            {
                TaskItem task = new TaskItem(taskName, hours, minutes);
                task.TaskCompleted += OnTaskCompleted;
                tasks.Add(task);
                lstTasks.Items.Add(task);
                txtTaskName.Clear();
                numHours.Value = 0;
                numMinutes.Value = 0;
                UpdateTaskCount();
            }
        }

        private void OnTaskCompleted(TaskItem task)
        {
            tasks.Remove(task);
            lstTasks.Items.Remove(task);
            UpdateTaskCount();
        }

        private void UpdateTaskCount()
        {
            lblTaskCount.Text = $"Оставшиеся задачи: {tasks.Count}";
        }

        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            foreach (var task in tasks)
            {
                int index = tasks.IndexOf(task);
                lstTasks.Items[index] = task;
            }
        }
    }
}