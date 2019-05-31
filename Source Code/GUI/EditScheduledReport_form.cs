using System;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace CSharp_Source_Code {
    public partial class Form2 : Form {
        public Form2() { InitializeComponent(); }

        public static class Global {
            public static TaskService TaskSrvc         = new TaskService();
            public static string      TaskMainFolder   = @"\Database Query Scheduler";
            public static string      ReportRunnerPath = Form1.Global.MainConfigDirectory + @"\report_runner.exe";
            public static bool        CanTestReport    = false;

            public static DateTime    _changesNSavedDelay;
        }

        private void Form2_Load(object sender, EventArgs e) {
            #region [FORM_SETTINGS]

            #region [DB_NAME]
            Text           += Form1.Global.SelectedDBName;
            dbName_lbl.Text = Form1.Global.SelectedDBName;
            if (dbName_lbl.Text.Length > 26) 
                dbName_lbl.Text = String.Format("{0}...", dbName_lbl.Text.Substring(0, 26));
            toolTip1.SetToolTip(dbName_lbl, Form1.Global.SelectedDBName);
            #endregion

            // Other
            byDaysOfMonths_listcbx.Height  = 45;
            label8.Height                  = 110;
            schedulingSeparator_lbl.Height = 88;
            Height                         = 470;
            Global._changesNSavedDelay     = DateTime.Now + TimeSpan.FromSeconds(1);

            outputFileExtPreview_lbl.Text = String.Format("[{0}].csv", GetDateTime());
            #endregion

            #region [CHECK_IF_ALREADY_EXISTS_A_TASK]
            try {
                Task _tsk = Global.TaskSrvc.GetTask(String.Format("{0}\\{1}", Global.TaskMainFolder, Form1.Global.SelectedDBName));

                if (_tsk.Name == Form1.Global.SelectedDBName) {
                    Global.CanTestReport = true;

                    // If the task already exists, we load some propreties from the active task
                    // And others propreties from the configuration file

                    #region [LOAD_FROM_CONFIGURATION_FILE]
                    string[] _dbStructure = File.ReadAllLines(String.Format("{0}\\scheduled_configuration.xs8db",
                                                             Form1.Global.MainConfigDirectory + @"\Databases\" + Form1.Global.SelectedDBName));
                    // Get output directory
                    directory_txtbox.Text = Form1.Global.Decrypt(_dbStructure[3]);
                    // Get file name
                    fileName_txtbox.Text = Form1.Global.Decrypt(_dbStructure[4]);
                    // Get SQL command
                    sql_txtbox.Text      = Form1.Global.Decrypt(_dbStructure[5]);
                    #endregion

                    #region [LOAD_FROM_THE_TASK]
                    string _tskProp = "";
                    foreach (Trigger _trg in _tsk.Definition.Triggers) {
                        _tskProp = _trg.ToString();
                    }

                    // Get time of day
                    timeOfDay_masktxtbox.Text = _tskProp.Substring(3, 5);
                    // Retrieves if the task is scheduled by days of week or by days of month

                    if (_tskProp.Contains("week")) {
                        // Get days of week

                        if (_tskProp.Contains("Monday"))
                            weekMo_cbx.Checked = true;
                        if (_tskProp.Contains("Tuesday"))
                            weekTu_cbx.Checked = true;
                        if (_tskProp.Contains("Wednesday"))
                            weekWe_cbx.Checked = true;
                        if (_tskProp.Contains("Thursday"))
                            weekTh_cbx.Checked = true;
                        if (_tskProp.Contains("Friday"))
                            weekFr_cbx.Checked = true;
                        if (_tskProp.Contains("Saturday"))
                            weekSa_cbx.Checked = true;
                        if (_tskProp.Contains("Sunday"))
                            weekSu_cbx.Checked = true;

                        if (_tskProp.Contains("every day of every week")) {
                            weekMo_cbx.Checked = true;
                            weekTu_cbx.Checked = true;
                            weekWe_cbx.Checked = true;
                            weekTh_cbx.Checked = true;
                            weekFr_cbx.Checked = true;
                            weekSa_cbx.Checked = true;
                            weekSu_cbx.Checked = true;
                        }
                    } else {
                        // Get days of month
                        // We extract only the days from the string
                        string _tmp = _tskProp.Substring(_tskProp.IndexOf("day") + 4);
                        _tmp = _tmp.Remove(_tmp.IndexOf("of"));
                        _tmp += ','; // We need this to can retrieve also the last day from the string

                        string _day = "";
                        for (UInt16 i = 0; i < _tmp.Length; i++) {
                            if (_tmp[i] != ',') {
                                _day += _tmp[i];
                            } else {
                                byDaysOfMonths_listcbx.SetItemCheckState(Convert.ToInt32(_day) - 1, CheckState.Checked);
                                _day = "";
                            }
                        }

                        #region [DISABLE_BY_DAYS_OF_WEEK]
                        weekMo_cbx.Enabled = false;
                        weekTu_cbx.Enabled = false;
                        weekWe_cbx.Enabled = false;
                        weekTh_cbx.Enabled = false;
                        weekFr_cbx.Enabled = false;
                        weekSa_cbx.Enabled = false;
                        weekSu_cbx.Enabled = false;
                        #endregion
                    }
                    #endregion
                } else {
                    Global.CanTestReport = false;
                }
            } catch { Global.CanTestReport = false; }
            #endregion
        }

        #region [GET_DATE_TIME]
        public static string GetDateTime() {
            return String.Format(
                  "{0}-{1}-{2} {3}.{4}.{5}", 
                   DateTime.Now.Day,
                   DateTime.Now.Month,
                   DateTime.Now.Year,
                   DateTime.Now.Hour,
                   DateTime.Now.Minute,
                   DateTime.Now.Second);
        }
        #endregion

        #region [24H_CLOCK_TIME]
        private void timeOfDay_masktxtbox_MouseClick(object sender, MouseEventArgs e) {
            for (UInt16 i = 0; i < 4; i++) {
                if (!Char.IsNumber(timeOfDay_masktxtbox.Text[i])) {
                    timeOfDay_masktxtbox.Text += "0";
                }
            }
        }

        private void timeOfDay_masktxtbox_TextChanged(object sender, EventArgs e) {
            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;

            string _tof = timeOfDay_masktxtbox.Text;

            if (_tof[0] >= 51) {
                _tof = _tof.Remove(0, 1);
                _tof = "2000";
            }
            if (_tof.Length > 1) {
                if (_tof[0] == 50 && _tof[1] > 51) {
                    _tof = _tof.Remove(1, 1);
                    _tof = String.Format("{0}{1}", _tof[0], "300");
                }
            }
            if (_tof.Length > 3) {
                if (_tof[3] > 53) {
                    _tof = _tof.Remove(3, 1);
                    _tof = String.Format("{0}{1}{2}", _tof[0], _tof[1], "50");
                }
            }

            if (_tof.Length < 4) {
                for (UInt16 i = 0; i < 4; i++) {
                    if (!Char.IsNumber(_tof[i])) {
                        _tof += "0";
                    }
                }
            }

            timeOfDay_masktxtbox.Text = _tof;
        }
        #endregion

        #region [BY_DAYS_OF_WEEK]
        #region [DISABLE_BY_DAYS_OF_MONTH]
        #region [MO]
        private void weekMo_cbx_CheckedChanged(object sender, EventArgs e) {
            if 
            (
            !weekTu_cbx.Checked &&
            !weekWe_cbx.Checked &&
            !weekTh_cbx.Checked &&
            !weekFr_cbx.Checked &&
            !weekSa_cbx.Checked &&
            !weekSu_cbx.Checked
            )     
            {
                byDaysOfMonths_listcbx.Enabled = true;
            }

            if (weekMo_cbx.Checked)
                byDaysOfMonths_listcbx.Enabled = false;

            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion
        #region [TU]
        private void weekTu_cbx_CheckedChanged(object sender, EventArgs e) {
            if
            (
            !weekMo_cbx.Checked &&
            !weekWe_cbx.Checked &&
            !weekTh_cbx.Checked &&
            !weekFr_cbx.Checked &&
            !weekSa_cbx.Checked &&
            !weekSu_cbx.Checked
            ) 
            {
                byDaysOfMonths_listcbx.Enabled = true;
            }

            if (weekTu_cbx.Checked)
                byDaysOfMonths_listcbx.Enabled = false;

            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion
        #region [WE]
        private void weekWe_cbx_CheckedChanged(object sender, EventArgs e) {
            if
            (
            !weekMo_cbx.Checked &&
            !weekTu_cbx.Checked &&
            !weekTh_cbx.Checked &&
            !weekFr_cbx.Checked &&
            !weekSa_cbx.Checked &&
            !weekSu_cbx.Checked
            ) 
            {
                byDaysOfMonths_listcbx.Enabled = true;
            }

            if (weekWe_cbx.Checked)
                byDaysOfMonths_listcbx.Enabled = false;

            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion
        #region [TH]
        private void weekTh_cbx_CheckedChanged(object sender, EventArgs e) {
            if
            (
            !weekMo_cbx.Checked &&
            !weekTu_cbx.Checked &&
            !weekWe_cbx.Checked &&
            !weekFr_cbx.Checked &&
            !weekSa_cbx.Checked &&
            !weekSu_cbx.Checked
            ) 
            {
                byDaysOfMonths_listcbx.Enabled = true;
            }

            if (weekTh_cbx.Checked)
                byDaysOfMonths_listcbx.Enabled = false;

            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion
        #region [FR]
        private void weekFr_cbx_CheckedChanged(object sender, EventArgs e) {
            if
            (
            !weekMo_cbx.Checked &&
            !weekTu_cbx.Checked &&
            !weekWe_cbx.Checked &&
            !weekTh_cbx.Checked &&
            !weekSa_cbx.Checked &&
            !weekSu_cbx.Checked
            ) 
            {
                byDaysOfMonths_listcbx.Enabled = true;
            }

            if (weekFr_cbx.Checked)
                byDaysOfMonths_listcbx.Enabled = false;

            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion
        #region [SA]
        private void weekSa_cbx_CheckedChanged(object sender, EventArgs e) {
            if
            (
            !weekMo_cbx.Checked &&
            !weekTu_cbx.Checked &&
            !weekWe_cbx.Checked &&
            !weekTh_cbx.Checked &&
            !weekFr_cbx.Checked &&
            !weekSu_cbx.Checked
            ) 
            {
                byDaysOfMonths_listcbx.Enabled = true;
            }

            if (weekSa_cbx.Checked)
                byDaysOfMonths_listcbx.Enabled = false;

            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion
        #region [SU]
        private void weekSu_cbx_CheckedChanged(object sender, EventArgs e) {
            if
            (
            !weekMo_cbx.Checked &&
            !weekTu_cbx.Checked &&
            !weekWe_cbx.Checked &&
            !weekTh_cbx.Checked &&
            !weekFr_cbx.Checked &&
            !weekSa_cbx.Checked
            ) 
            {
                byDaysOfMonths_listcbx.Enabled = true;
            }

            if (weekSu_cbx.Checked)
                byDaysOfMonths_listcbx.Enabled = false;

            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion
        #endregion
        #endregion

        #region [BY_DAYS_OF_MONTH]

        #region [EXPAND/SHRINK_FORM]
        private void byDaysOfMonth_lbl_Click(object sender, EventArgs e) {
            if (Height == 470) {
                byDaysOfMonths_listcbx.Height  = 150;
                label8.Height                  = 215;
                schedulingSeparator_lbl.Height = 195;
                Height                         = 575;
            } else {
                byDaysOfMonths_listcbx.Height  = 45;
                label8.Height                  = 110;
                schedulingSeparator_lbl.Height = 88;
                Height                         = 470;
            }
        }
        #endregion

        #region [DISABLE_BY_DAYS_OF_WEEK]
        private void byDaysOfMonths_listcbx_MouseUp(object sender, MouseEventArgs e) {
            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;

            if (byDaysOfMonths_listcbx.CheckedItems.Count > 0) {
                weekMo_cbx.Enabled = false;
                weekTu_cbx.Enabled = false;
                weekWe_cbx.Enabled = false;
                weekTh_cbx.Enabled = false;
                weekFr_cbx.Enabled = false;
                weekSa_cbx.Enabled = false;
                weekSu_cbx.Enabled = false;
            } else {
                weekMo_cbx.Enabled = true;
                weekTu_cbx.Enabled = true;
                weekWe_cbx.Enabled = true;
                weekTh_cbx.Enabled = true;
                weekFr_cbx.Enabled = true;
                weekSa_cbx.Enabled = true;
                weekSu_cbx.Enabled = true;
            }
        }
        #endregion

        #endregion

        #region [OUTPUT_DIRECTORY]
        private void directory_btn_Click(object sender, EventArgs e) {
            folderBrowserDialog1.Description = "Select a directory where to save the report logs";
            if (directory_txtbox.TextLength > 0)
                folderBrowserDialog1.SelectedPath = directory_txtbox.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                directory_txtbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        #endregion

        #region [CHANGES_NOT_SAVED_CONTROLS]
        private void sql_txtbox_TextChanged(object sender, EventArgs e) {
            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        private void directory_txtbox_TextChanged(object sender, EventArgs e) {
            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        private void fileName_txtbox_TextChanged(object sender, EventArgs e) {
            if (DateTime.Now > Global._changesNSavedDelay)
                changesNotSaved_lbl.Visible = true;
        }
        #endregion

        #region [SAVE_TASK]
        private void save_btn_Click(object sender, EventArgs e) {

            #region [CHECK_IF_THE_CONTROLS_ARE_EMPTY]
            if (sql_txtbox.TextLength == 0) {
                MessageBox.Show("Can't save the task:\nThe SQL textbox is empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (directory_txtbox.TextLength == 0) {
                MessageBox.Show("Can't save the task:\nYou have not chosen an output directory!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (fileName_txtbox.TextLength == 0) {
                MessageBox.Show("Can't save the task:\nYou have not written a name for the report file!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (byDaysOfMonths_listcbx.Enabled && weekMo_cbx.Enabled) {
                MessageBox.Show("Can't save the task:\nYou have not chosen if the task will run by days of week or by days of month!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            // Creates a task in the 'Scheduled Tasks' who when triggered will launch the report exe

            // We need this to can retrieve if the task folder doesn't exists so we can create it
            int jf = 0;

            // Iterates all the subfolders in the root folder
            foreach (TaskFolder _tskFolder in Global.TaskSrvc.RootFolder.SubFolders) {
                jf++;

                // If we found the 'Database Query Scheduler'
                if (_tskFolder.Path == Global.TaskMainFolder) {
                    // We need this to can retrieve if the task doesn't exists
                    int i = 0;

                    // Iterates all the tasks in the folder
                    foreach (Task _tsk in _tskFolder.Tasks) {
                        i++;

                        if (_tsk.Name == Form1.Global.SelectedDBName) {
                            // If the task already exists we will edit it
                            goto editTask;
                        }

                        if (i == _tskFolder.Tasks.Count) {
                            // If the task doesn't exists, we will create it
                            goto createTask;
                        }
                    }
                    break;
                }

                if (jf == Global.TaskSrvc.RootFolder.SubFolders.Count) {
                    // If the 'Database Query Scheduler' folder was not found, we will create it
                    Global.TaskSrvc.RootFolder.CreateFolder("Database Query Scheduler");
                    goto createTask;
                }
            }

            #region [CREATE]
            createTask:

            if (fileName_txtbox.Text.Any(Path.GetInvalidFileNameChars().Contains)) {
                MessageBox.Show("The report file name contains invalid characters!", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }

            
            try {
                // We create a new empty scheduled task
                TaskDefinition _cTsk = Global.TaskSrvc.NewTask();
                //_cTsk.Principal.LogonType = TaskLogonType.InteractiveTokenOrPassword;

                #region [CONFIGURATION_FILE]
                string[] _dbStructure = File.ReadAllLines(String.Format("{0}\\scheduled_configuration.xs8db",
                                                          Form1.Global.MainConfigDirectory + @"\Databases\" + Form1.Global.SelectedDBName));
                // Database last report
                _dbStructure[2] = Form1.Global.Encrypt("Scheduled report not yet run");
                // Set output directory
                _dbStructure[3] = Form1.Global.Encrypt(directory_txtbox.Text);
                // Set file name
                _dbStructure[4] = Form1.Global.Encrypt(fileName_txtbox.Text);
                // Set SQL command
                _dbStructure[5] = Form1.Global.Encrypt(sql_txtbox.Text);

                File.WriteAllLines(String.Format("{0}\\scheduled_configuration.xs8db",
                                   Form1.Global.MainConfigDirectory + @"\Databases\" + Form1.Global.SelectedDBName),
                                   _dbStructure);
                #endregion

                #region [SCHEDULED_TASK]

                #region [GENERAL]
                // Registration Info
                _cTsk.RegistrationInfo.Author      = "Mutu Adi-Marian";
                _cTsk.RegistrationInfo.Date        = DateTime.Today;
                _cTsk.RegistrationInfo.Description = "This task will automatically launch a query report against the database.";
                // Principal
                _cTsk.Principal.RunLevel           = TaskRunLevel.Highest;
                #endregion

                #region [SETTINGS]
                _cTsk.Settings.Enabled                    = true;
                //_cTsk.Settings.RunOnlyIfLoggedOn          = false;
                _cTsk.Settings.AllowDemandStart           = true;
                _cTsk.Settings.AllowHardTerminate         = false;
                _cTsk.Settings.DisallowStartIfOnBatteries = false;
                _cTsk.Settings.MultipleInstances          = TaskInstancesPolicy.Queue;
                _cTsk.Settings.Priority                   = System.Diagnostics.ProcessPriorityClass.High;
                _cTsk.Settings.RestartCount               = 5;
                _cTsk.Settings.RestartInterval            = TimeSpan.FromMinutes(1);
                _cTsk.Settings.RunOnlyIfIdle              = false;
                _cTsk.Settings.StartWhenAvailable         = true;
                _cTsk.Settings.StopIfGoingOnBatteries     = false;
                _cTsk.Settings.WakeToRun                  = true;
                #endregion

                #region [TRIGGERS]
                // Get the Hour from the day of time control
                double _ch = Convert.ToDouble(timeOfDay_masktxtbox.Text.Substring(0, 2));
                // Get the Minutes from the day of time control
                double _cm = Convert.ToDouble(timeOfDay_masktxtbox.Text.Substring(3, 2));

                // Get if the task will be triggered by days of week or by days of month
                if (weekMo_cbx.Enabled) {
                    DaysOfTheWeek _dow = DaysOfTheWeek.AllDays;

                    if (!weekMo_cbx.Checked)
                        _dow -= DaysOfTheWeek.Monday;
                    if (!weekTu_cbx.Checked)
                        _dow -= DaysOfTheWeek.Tuesday;
                    if (!weekWe_cbx.Checked)
                        _dow -= DaysOfTheWeek.Wednesday;
                    if (!weekTh_cbx.Checked)
                        _dow -= DaysOfTheWeek.Thursday;
                    if (!weekFr_cbx.Checked)
                        _dow -= DaysOfTheWeek.Friday;
                    if (!weekSa_cbx.Checked)
                        _dow -= DaysOfTheWeek.Saturday;
                    if (!weekSu_cbx.Checked)
                        _dow -= DaysOfTheWeek.Sunday;

                    WeeklyTrigger _tskWt = new WeeklyTrigger(_dow) {
                        StartBoundary    = DateTime.Today + (TimeSpan.FromHours(_ch) + TimeSpan.FromMinutes(_cm))
                    };

                    _cTsk.Triggers.Add(_tskWt);
                } else {
                    int[] _dom = new int[byDaysOfMonths_listcbx.CheckedIndices.Cast<int>().ToArray().Count()];

                    for (UInt16 i = 0; i < _dom.Length; i++) {
                        _dom[i] = Convert.ToInt32(byDaysOfMonths_listcbx.CheckedItems.Cast<string>().ToArray()[i]);
                    }

                    MonthlyTrigger _tskMt = new MonthlyTrigger {
                        DaysOfMonth   = _dom,
                        StartBoundary = DateTime.Today + (TimeSpan.FromHours(_ch) + TimeSpan.FromMinutes(_cm))
                    };

                    _cTsk.Triggers.Add(_tskMt);
                }
                #endregion

                #region [ACTIONS]
                // Add the updated action
                _cTsk.Actions.Add(Global.ReportRunnerPath, String.Format("\"{0}\" \"{1}\" \"{2}\"", Form1.Global.SelectedDBName, fileName_txtbox.Text, directory_txtbox.Text));
                #endregion

                #endregion

                // Save the created task in the 'Database Query Scheduler' folder
                Global.TaskSrvc.RootFolder.RegisterTaskDefinition(String.Format("{0}\\{1}", Global.TaskMainFolder, Form1.Global.SelectedDBName), _cTsk);
                // Enable the 'Test Report' button
                Global.CanTestReport = true;

                MessageBox.Show("Scheduled report successfully created!", "Info");

                changesNotSaved_lbl.Visible = false;
            } catch {
                MessageBox.Show("Unable to create the 'Scheduled Report'", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            return;
            #endregion

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region [EDIT]
            editTask:

            if (fileName_txtbox.Text.Any(Path.GetInvalidFileNameChars().Contains)) {
                MessageBox.Show("The report file name contains invalid characters!", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }

            try {
                Task _eTsk = Global.TaskSrvc.GetTask(String.Format("{0}\\{1}", Global.TaskMainFolder, Form1.Global.SelectedDBName));

                #region [CONFIGURATION_FILE]
                string[] _dbStructure = File.ReadAllLines(String.Format("{0}\\scheduled_configuration.xs8db",
                                                 Form1.Global.MainConfigDirectory + @"\Databases\" + Form1.Global.SelectedDBName));
                // Database last report
                if (!Form1.Global.Decrypt(_dbStructure[2]).Contains("Fail") && !Form1.Global.Decrypt(_dbStructure[2]).Contains("Success"))
                    _dbStructure[2] = Form1.Global.Encrypt("Scheduled report not yet run");
                // Set output directory
                _dbStructure[3] = Form1.Global.Encrypt(directory_txtbox.Text);
                // Set file name
                _dbStructure[4] = Form1.Global.Encrypt(fileName_txtbox.Text);
                // Set SQL command
                _dbStructure[5] = Form1.Global.Encrypt(sql_txtbox.Text);

                File.WriteAllLines(String.Format("{0}\\scheduled_configuration.xs8db",
                                   Form1.Global.MainConfigDirectory + @"\Databases\" + Form1.Global.SelectedDBName),
                                   _dbStructure);
                #endregion

                #region [SCHEDULED_TASK]

                #region [GENERAL]
                // Registration Info
                _eTsk.Definition.RegistrationInfo.Author      = "Mutu Adi-Marian";
                _eTsk.Definition.RegistrationInfo.Date        = DateTime.Today;
                _eTsk.Definition.RegistrationInfo.Description = "This task will automatically launch a query report against the database.";
                // Princiapl
                _eTsk.Definition.Principal.RunLevel           = TaskRunLevel.Highest;
                #endregion

                #region [SETTINGS]
                _eTsk.Definition.Settings.Enabled                    = true;
                _eTsk.Definition.Settings.AllowDemandStart           = true;
                _eTsk.Definition.Settings.AllowHardTerminate         = false;
                _eTsk.Definition.Settings.DisallowStartIfOnBatteries = false;
                _eTsk.Definition.Settings.MultipleInstances          = TaskInstancesPolicy.Queue;
                _eTsk.Definition.Settings.Priority                   = System.Diagnostics.ProcessPriorityClass.High;
                _eTsk.Definition.Settings.RestartCount               = 5;
                _eTsk.Definition.Settings.RestartInterval            = TimeSpan.FromMinutes(1);
                _eTsk.Definition.Settings.RunOnlyIfIdle              = false;
                _eTsk.Definition.Settings.StartWhenAvailable         = true;
                _eTsk.Definition.Settings.StopIfGoingOnBatteries     = false;
                _eTsk.Definition.Settings.WakeToRun                  = true;
                #endregion

                #region [TRIGGERS]
                // Get the Hour from the day of time control
                double _eh = Convert.ToDouble(timeOfDay_masktxtbox.Text.Substring(0, 2));
                // Get the Minutes from the day of time control
                double _em = Convert.ToDouble(timeOfDay_masktxtbox.Text.Substring(3, 2));

                // First we remove the previous trigger
                _eTsk.Definition.Triggers.RemoveAt(0);

                // Get if the task will be triggered by days of week or by days of month
                if (weekMo_cbx.Enabled) {
                    DaysOfTheWeek _dow = DaysOfTheWeek.AllDays;

                    if (!weekMo_cbx.Checked)
                        _dow -= DaysOfTheWeek.Monday;
                    if (!weekTu_cbx.Checked)
                        _dow -= DaysOfTheWeek.Tuesday;
                    if (!weekWe_cbx.Checked)
                        _dow -= DaysOfTheWeek.Wednesday;
                    if (!weekTh_cbx.Checked)
                        _dow -= DaysOfTheWeek.Thursday;
                    if (!weekFr_cbx.Checked)
                        _dow -= DaysOfTheWeek.Friday;
                    if (!weekSa_cbx.Checked)
                        _dow -= DaysOfTheWeek.Saturday;
                    if (!weekSu_cbx.Checked)
                        _dow -= DaysOfTheWeek.Sunday;

                    WeeklyTrigger _tskWt = new WeeklyTrigger(_dow) {
                        StartBoundary    = DateTime.Today + (TimeSpan.FromHours(_eh) + TimeSpan.FromMinutes(_em))
                    };

                    _eTsk.Definition.Triggers.Add(_tskWt);
                } else {
                    int[] _dom = new int[byDaysOfMonths_listcbx.CheckedIndices.Cast<int>().ToArray().Count()];

                    for (UInt16 i = 0; i < _dom.Length; i++) {
                        _dom[i] = Convert.ToInt32(byDaysOfMonths_listcbx.CheckedItems.Cast<string>().ToArray()[i]);
                    }

                    MonthlyTrigger _tskMt = new MonthlyTrigger {
                        DaysOfMonth       = _dom,
                        StartBoundary     = DateTime.Today + (TimeSpan.FromHours(_eh) + TimeSpan.FromMinutes(_em))
                    };

                    _eTsk.Definition.Triggers.Add(_tskMt);
                }
                #endregion

                #region [ACTIONS]
                // First remove the previous action
                _eTsk.Definition.Actions.RemoveAt(0);
                // Add the updated action
                _eTsk.Definition.Actions.Add(Global.ReportRunnerPath, String.Format("\"{0}\" \"{1}\" \"{2}\"", Form1.Global.SelectedDBName, fileName_txtbox.Text, directory_txtbox.Text));
                #endregion

                #endregion

                // Saves the changes to the task
                _eTsk.RegisterChanges();

                MessageBox.Show("Scheduled report successfully updated!", "Info");

                changesNotSaved_lbl.Visible = false;
            } catch {
                MessageBox.Show("Unable to update the 'Scheduled Report'", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            #endregion
        }
        #endregion

        #region [TEST_REPORT]
        private void test_btn_Click(object sender, EventArgs e) {
            if (!Global.CanTestReport) {
                MessageBox.Show("You need first to save the task to can test the report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    Global.TaskSrvc.GetTask(String.Format("{0}\\{1}", Global.TaskMainFolder, Form1.Global.SelectedDBName)).Run();

                    MessageBox.Show(
                        "'Scheduled Test Report' successfully executed!\n\n" +
                        "N.B: This does not necessarily mean that the DB has been successfully queried.\n" +
                        "See the 'Last Report Status' for this information.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                } catch {
                    MessageBox.Show(
                        "'Scheduled Test Report' failed!\n\n" +
                        "This can happen when the program can't launch the task from the 'Task Scheduler' or something is blocking him.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}