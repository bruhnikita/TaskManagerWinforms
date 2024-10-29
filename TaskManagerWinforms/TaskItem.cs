using System;
using System.Windows.Forms;

namespace TaskManagerWinforms
{
    public class TaskItem
    {
        private string taskName;
        private int totalSeconds;
        private System.Windows.Forms.Timer timer;

        public event Action<TaskItem> TaskCompleted;

        public TaskItem(string name, int hours, int minutes)
        {
            taskName = name;
            totalSeconds = hours * 3600 + minutes * 60;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            totalSeconds--;

            if (totalSeconds <= 0)
            {
                timer.Stop();
                TaskCompleted?.Invoke(this);
                MessageBox.Show($"{taskName} завершена!");
            }
        }

        public override string ToString()
        {
            return $"{taskName} - {totalSeconds / 60}:{totalSeconds % 60:D2}";
        }
    }
}