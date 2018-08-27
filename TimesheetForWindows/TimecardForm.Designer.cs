﻿namespace TimesheetForWindows
{
	partial class TimecardForm
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonAddTask = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.comboBoxWeek = new System.Windows.Forms.ComboBox();
			this.dgvTimecardDetail = new System.Windows.Forms.DataGridView();
			this.buttonAddWeek = new System.Windows.Forms.Button();
			this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Monday_Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tuesday_Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Wednesday_Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thursday_Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Friday_Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Saturday_Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sunday_Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Detail_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Task_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Timecard_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimecardDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 442);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1042, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(546, 14);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(107, 25);
			this.buttonUpdate.TabIndex = 97;
			this.buttonUpdate.TabStop = false;
			this.buttonUpdate.Text = "Save Changes";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			// 
			// buttonAddTask
			// 
			this.buttonAddTask.Location = new System.Drawing.Point(320, 14);
			this.buttonAddTask.Name = "buttonAddTask";
			this.buttonAddTask.Size = new System.Drawing.Size(107, 24);
			this.buttonAddTask.TabIndex = 99;
			this.buttonAddTask.TabStop = false;
			this.buttonAddTask.Text = "Append Task";
			this.buttonAddTask.UseVisualStyleBackColor = true;
			this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(433, 14);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(107, 25);
			this.buttonCancel.TabIndex = 98;
			this.buttonCancel.TabStop = false;
			this.buttonCancel.Text = "Cancel Changes";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(659, 14);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(108, 25);
			this.buttonQuit.TabIndex = 96;
			this.buttonQuit.TabStop = false;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = true;
			// 
			// comboBoxWeek
			// 
			this.comboBoxWeek.FormattingEnabled = true;
			this.comboBoxWeek.Location = new System.Drawing.Point(22, 17);
			this.comboBoxWeek.Name = "comboBoxWeek";
			this.comboBoxWeek.Size = new System.Drawing.Size(102, 21);
			this.comboBoxWeek.TabIndex = 95;
			this.comboBoxWeek.TabStop = false;
			// 
			// dgvTimecardDetail
			// 
			this.dgvTimecardDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimecardDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Monday_Hrs,
            this.Tuesday_Hrs,
            this.Wednesday_Hrs,
            this.Thursday_Hrs,
            this.Friday_Hrs,
            this.Saturday_Hrs,
            this.Sunday_Hrs,
            this.Detail_ID,
            this.Task_ID,
            this.Timecard_ID});
			this.dgvTimecardDetail.Location = new System.Drawing.Point(22, 58);
			this.dgvTimecardDetail.MultiSelect = false;
			this.dgvTimecardDetail.Name = "dgvTimecardDetail";
			this.dgvTimecardDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvTimecardDetail.Size = new System.Drawing.Size(994, 339);
			this.dgvTimecardDetail.TabIndex = 0;
			// 
			// buttonAddWeek
			// 
			this.buttonAddWeek.Location = new System.Drawing.Point(207, 14);
			this.buttonAddWeek.Name = "buttonAddWeek";
			this.buttonAddWeek.Size = new System.Drawing.Size(107, 24);
			this.buttonAddWeek.TabIndex = 100;
			this.buttonAddWeek.TabStop = false;
			this.buttonAddWeek.Text = "Add New Week";
			this.buttonAddWeek.UseVisualStyleBackColor = true;
			this.buttonAddWeek.Click += new System.EventHandler(this.buttonAddWeek_Click);
			// 
			// TaskName
			// 
			this.TaskName.DataPropertyName = "TaskName";
			this.TaskName.HeaderText = "Task";
			this.TaskName.Name = "TaskName";
			this.TaskName.Width = 220;
			// 
			// Monday_Hrs
			// 
			this.Monday_Hrs.DataPropertyName = "Monday_Hrs";
			this.Monday_Hrs.HeaderText = "Monday";
			this.Monday_Hrs.Name = "Monday_Hrs";
			// 
			// Tuesday_Hrs
			// 
			this.Tuesday_Hrs.DataPropertyName = "Tuesday_Hrs";
			this.Tuesday_Hrs.HeaderText = "Tuesday";
			this.Tuesday_Hrs.Name = "Tuesday_Hrs";
			// 
			// Wednesday_Hrs
			// 
			this.Wednesday_Hrs.DataPropertyName = "Wednesday_Hrs";
			this.Wednesday_Hrs.HeaderText = "Wednesday";
			this.Wednesday_Hrs.Name = "Wednesday_Hrs";
			// 
			// Thursday_Hrs
			// 
			this.Thursday_Hrs.DataPropertyName = "Thursday_Hrs";
			this.Thursday_Hrs.HeaderText = "Thursday";
			this.Thursday_Hrs.Name = "Thursday_Hrs";
			// 
			// Friday_Hrs
			// 
			this.Friday_Hrs.DataPropertyName = "Friday_Hrs";
			this.Friday_Hrs.HeaderText = "Friday";
			this.Friday_Hrs.Name = "Friday_Hrs";
			// 
			// Saturday_Hrs
			// 
			this.Saturday_Hrs.DataPropertyName = "Saturday_Hrs";
			this.Saturday_Hrs.HeaderText = "Saturday";
			this.Saturday_Hrs.Name = "Saturday_Hrs";
			// 
			// Sunday_Hrs
			// 
			this.Sunday_Hrs.DataPropertyName = "Sunday_Hrs";
			this.Sunday_Hrs.HeaderText = "Sunday";
			this.Sunday_Hrs.Name = "Sunday_Hrs";
			// 
			// Detail_ID
			// 
			this.Detail_ID.DataPropertyName = "Detail_ID";
			this.Detail_ID.HeaderText = "Detail_ID";
			this.Detail_ID.Name = "Detail_ID";
			this.Detail_ID.Visible = false;
			// 
			// Task_ID
			// 
			this.Task_ID.DataPropertyName = "Task_ID";
			this.Task_ID.HeaderText = "Task_ID";
			this.Task_ID.Name = "Task_ID";
			this.Task_ID.Visible = false;
			// 
			// Timecard_ID
			// 
			this.Timecard_ID.DataPropertyName = "Timecard_ID";
			this.Timecard_ID.HeaderText = "Timecard_ID";
			this.Timecard_ID.Name = "Timecard_ID";
			this.Timecard_ID.Visible = false;
			// 
			// TimecardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 464);
			this.ControlBox = false;
			this.Controls.Add(this.buttonAddWeek);
			this.Controls.Add(this.dgvTimecardDetail);
			this.Controls.Add(this.comboBoxWeek);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAddTask);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "TimecardForm";
			this.Text = "Timecard -- Amanda Merrifield";
			this.Load += new System.EventHandler(this.TimecardForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTimecardDetail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonAddTask;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.ComboBox comboBoxWeek;
		private System.Windows.Forms.DataGridView dgvTimecardDetail;
		private System.Windows.Forms.Button buttonAddWeek;
		private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Monday_Hrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday_Hrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday_Hrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Thursday_Hrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Friday_Hrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Saturday_Hrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sunday_Hrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn Detail_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Task_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Timecard_ID;
	}
}