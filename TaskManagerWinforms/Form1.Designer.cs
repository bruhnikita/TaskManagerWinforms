namespace TaskManagerWinforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstTasks = new ListBox();
            txtTaskName = new TextBox();
            numHours = new NumericUpDown();
            numMinutes = new NumericUpDown();
            btnAddTask = new Button();
            lblTaskCount = new Label();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            SuspendLayout();
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(5, 8);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(376, 499);
            lstTasks.TabIndex = 0;
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(400, 12);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.PlaceholderText = "Введите название задачи...";
            txtTaskName.Size = new Size(440, 23);
            txtTaskName.TabIndex = 1;
            // 
            // numHours
            // 
            numHours.Location = new Point(400, 41);
            numHours.Name = "numHours";
            numHours.Size = new Size(440, 23);
            numHours.TabIndex = 2;
            // 
            // numMinutes
            // 
            numMinutes.Location = new Point(400, 70);
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(440, 23);
            numMinutes.TabIndex = 3;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(400, 99);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(440, 76);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Добавить";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // lblTaskCount
            // 
            lblTaskCount.AutoSize = true;
            lblTaskCount.Location = new Point(400, 492);
            lblTaskCount.Name = "lblTaskCount";
            lblTaskCount.Size = new Size(38, 15);
            lblTaskCount.TabIndex = 5;
            lblTaskCount.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 516);
            Controls.Add(lblTaskCount);
            Controls.Add(btnAddTask);
            Controls.Add(numMinutes);
            Controls.Add(numHours);
            Controls.Add(txtTaskName);
            Controls.Add(lstTasks);
            Name = "MainForm";
            Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTasks;
        private TextBox txtTaskName;
        private NumericUpDown numHours;
        private NumericUpDown numMinutes;
        private Button btnAddTask;
        private Label lblTaskCount;
    }
}
