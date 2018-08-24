﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using SsOpsDatabaseLibrary;
using SsOpsDatabaseLibrary.Entity;

namespace TimesheetForWindows
{
	public partial class TimecardForm : Form
	{
		// Enums and variables having form-wide scope
		private enum FormState
		{
			ViewingData,
			ViewingPotentialChanges,
			SavingChanges
		}
		private FormState _currentFormState;
		private Employee _employee;
		private List<Timecard> _timecards;
		private Timecard _thisTimecard;
		private List<TimecardDetail> _thisTcDetail;
		private int _thisWeekNumber = 1;

		// =======================================================
		// FORM CONSTRUCTOR
		public TimecardForm(Employee emp)
		{
			InitializeComponent();
			// We will manually control the form location on screen
			this.StartPosition = FormStartPosition.Manual;

			// We want to preview the keystrokes being made into any text box
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(TimecardForm_KeyDown);
			this.KeyPreview = true;

			// Get a copy of the employee key
			_employee = emp;
		}

		// ====================================================
		#region FORM EVENT HANDLERS
	    //
		// Key_Down Event Handler
		private void TimecardForm_KeyDown(object sender, KeyEventArgs e)
		{
			_currentFormState = FormState.ViewingPotentialChanges;
			assertFormState();
		}
		//
		// Form Load Event Handler
		private void TimecardForm_Load(object sender, EventArgs e)
		{
			// Calc the week number
			_thisWeekNumber = GetIso8601WeekOfYear(DateTime.Now);

			// Get the employee's data onto the form
			this.Text = "TimeCard -- " + _employee.FirstName +  " "  + _employee.LastName;
			
			//Call opsdatareader to get timecards for this employee
			using (OpsDataReader dbReader = new OpsDataReader())
			{
				_timecards = dbReader.GetTimecardsForEmployee(_employee.EmployeeId);
				//_timecards = GetTimecardsForEmployeeSTUB(_employee.EmployeeId);  // STUB !!

				InitializeComboBox();

				// Call OpsDataReader to get the details for the selected week
				//_thisTcDetail = dbReader.GetTcDetailsByTimecardId(_thisTimecard.TimecardId);
				_thisTcDetail = GetTcDetailsByTimecardIdSTUB(_thisTimecard.TimecardId);

				dgvTimecardDetail.DataSource = _thisTcDetail;
			}

		}

		//
		// Add Week Button Click
		private void buttonAddWeek_Click(object sender, EventArgs e)
		{

		}

		#endregion

		// ====================================================
		#region DATA STUBS

		// !!##!!## STUB ##!!##!!STUB ##!!##!!STUB ##!!##!!STUB ##!!##!!
		public List<Timecard> GetTimecardsForEmployeeSTUB(string employeeId)
		{
			List<Timecard> tcards = new List<Timecard>();
			for (int x = 5; x > 0; --x)
			{
				Timecard tc = new Timecard();
				tc.DetailTable = null;
				tc.EmployeeId = employeeId;
				tc.TimecardId = Convert.ToString(2000 + x);
				tc.WeekNumber = Convert.ToString(32 + x);
				tc.Year = "2018";

				tcards.Add(tc);
			}
			return tcards;
		}
		// !!##!!## STUB ##!!##!!STUB ##!!##!!STUB ##!!##!!STUB ##!!##!!
		public List<TimecardDetail> GetTcDetailsByTimecardIdSTUB(string tcardId)
		{
			List<TimecardDetail> details = new List<TimecardDetail>();
			for (int x = 0; x < 5; x++)
			{
				TimecardDetail dtl = new TimecardDetail();
				dtl.Detail_ID = Convert.ToString(1010 + x);
				dtl.Task_ID = Convert.ToString(10010 + x);
				dtl.Timecard_ID = tcardId;
				dtl.Monday_Hrs = "9.0";
				dtl.Tuesday_Hrs = "8.0";
				dtl.Wednesday_Hrs = "7.0";
				dtl.Thursday_Hrs = "6.0";
				dtl.Friday_Hrs = "4.0";
				dtl.Saturday_Hrs = "2.0";
				dtl.Sunday_Hrs = "1.0";

				details.Add(dtl);
			}
			return details;
		}

		#endregion

		// ====================================================
		#region FORM HELPER FUNCTIONS

		private void InitializeComboBox()
		{
			comboBoxWeek.Items.Clear();
			if (_timecards.Count > 0)
			{
				foreach (Timecard tc in _timecards)
				{
					comboBoxWeek.Items.Add(tc);
				}
				comboBoxWeek.SelectedIndex = 0;
				_thisTimecard = (Timecard)comboBoxWeek.SelectedItem;

				this.Text += " --- " + comboBoxWeek.SelectedItem.ToString();
			}
			else
			{
				//Employee has no timecards. Add New Week.
				AddNewWeekToTimecard();
			}

		}
		// This presumes that weeks start with Monday.
		// Week 1 is the 1st week of the year with a Thursday in it.
		public static int GetIso8601WeekOfYear(DateTime time)
		{
			// Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
			// be the same week# as whatever Thursday, Friday or Saturday are,
			// and we always get those right
			DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
			//if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
			//{
			//	time = time.AddDays(3);
			//}

			// Return the week of our adjusted day
			return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
		}

		private void InitializeDGV()
		{
			try
			{
				dgvTimecardDetail.Dock = DockStyle.Fill;
				dgvTimecardDetail.AutoGenerateColumns = true;
			}
			catch (Exception ex)
			{
				// ToDo:
				System.Threading.Thread.CurrentThread.Abort();
			}
		}

		private void assertFormState()
		{
			switch (_currentFormState)
			{
				case FormState.SavingChanges:
					buttonUpdate.Enabled = false;
					buttonCancel.Enabled = false;
					buttonQuit.Enabled = false;
					break;
				case FormState.ViewingData:
					buttonUpdate.Enabled = false;
					buttonCancel.Enabled = false;
					buttonQuit.Enabled = true;
					break;
				case FormState.ViewingPotentialChanges:
					buttonUpdate.Enabled = true;
					buttonCancel.Enabled = true;
					buttonQuit.Enabled = false;
					break;
			}
		}

		private void AddNewWeekToTimecard()
		{
			//Empty the grid
			_thisTcDetail.Clear();
			//Append the new week to the combobox and select it


		}


		#endregion


	}
}