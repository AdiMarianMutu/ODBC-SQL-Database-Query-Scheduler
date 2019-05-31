namespace CSharp_Source_Code {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dbName_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.directory_txtbox = new System.Windows.Forms.TextBox();
            this.directory_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fileName_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeOfDay_masktxtbox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outputFileExtPreview_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.byDaysOfMonth_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.weekMo_cbx = new System.Windows.Forms.CheckBox();
            this.weekTu_cbx = new System.Windows.Forms.CheckBox();
            this.weekWe_cbx = new System.Windows.Forms.CheckBox();
            this.weekTh_cbx = new System.Windows.Forms.CheckBox();
            this.weekFr_cbx = new System.Windows.Forms.CheckBox();
            this.weekSa_cbx = new System.Windows.Forms.CheckBox();
            this.weekSu_cbx = new System.Windows.Forms.CheckBox();
            this.schedulingSeparator_lbl = new System.Windows.Forms.Label();
            this.test_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.byDaysOfMonths_listcbx = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sql_txtbox = new System.Windows.Forms.TextBox();
            this.changesNotSaved_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dbName_lbl
            // 
            this.dbName_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.dbName_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbName_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dbName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dbName_lbl.ForeColor = System.Drawing.Color.Azure;
            this.dbName_lbl.Location = new System.Drawing.Point(0, 0);
            this.dbName_lbl.Name = "dbName_lbl";
            this.dbName_lbl.Size = new System.Drawing.Size(394, 28);
            this.dbName_lbl.TabIndex = 5;
            this.dbName_lbl.Text = "DB Name";
            this.dbName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 501);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Structured Query Language";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Report Output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 61);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(15, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Directory: ";
            // 
            // directory_txtbox
            // 
            this.directory_txtbox.Location = new System.Drawing.Point(76, 239);
            this.directory_txtbox.Name = "directory_txtbox";
            this.directory_txtbox.ReadOnly = true;
            this.directory_txtbox.Size = new System.Drawing.Size(243, 20);
            this.directory_txtbox.TabIndex = 12;
            this.directory_txtbox.TextChanged += new System.EventHandler(this.directory_txtbox_TextChanged);
            // 
            // directory_btn
            // 
            this.directory_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.directory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.directory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.directory_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.directory_btn.Location = new System.Drawing.Point(325, 236);
            this.directory_btn.Name = "directory_btn";
            this.directory_btn.Size = new System.Drawing.Size(54, 25);
            this.directory_btn.TabIndex = 13;
            this.directory_btn.Text = "Select";
            this.directory_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.directory_btn.UseVisualStyleBackColor = false;
            this.directory_btn.Click += new System.EventHandler(this.directory_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(15, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "File name: ";
            // 
            // fileName_txtbox
            // 
            this.fileName_txtbox.Location = new System.Drawing.Point(76, 267);
            this.fileName_txtbox.Name = "fileName_txtbox";
            this.fileName_txtbox.Size = new System.Drawing.Size(163, 20);
            this.fileName_txtbox.TabIndex = 15;
            this.fileName_txtbox.TextChanged += new System.EventHandler(this.fileName_txtbox_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Scheduling";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(12, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 215);
            this.label8.TabIndex = 17;
            // 
            // timeOfDay_masktxtbox
            // 
            this.timeOfDay_masktxtbox.Location = new System.Drawing.Point(299, 320);
            this.timeOfDay_masktxtbox.Mask = "00:00";
            this.timeOfDay_masktxtbox.Name = "timeOfDay_masktxtbox";
            this.timeOfDay_masktxtbox.PromptChar = ' ';
            this.timeOfDay_masktxtbox.Size = new System.Drawing.Size(80, 20);
            this.timeOfDay_masktxtbox.TabIndex = 18;
            this.timeOfDay_masktxtbox.Text = "0000";
            this.timeOfDay_masktxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeOfDay_masktxtbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.timeOfDay_masktxtbox_MouseClick);
            this.timeOfDay_masktxtbox.TextChanged += new System.EventHandler(this.timeOfDay_masktxtbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(207, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Time of day (24h):";
            // 
            // outputFileExtPreview_lbl
            // 
            this.outputFileExtPreview_lbl.AutoSize = true;
            this.outputFileExtPreview_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.outputFileExtPreview_lbl.Location = new System.Drawing.Point(250, 270);
            this.outputFileExtPreview_lbl.Name = "outputFileExtPreview_lbl";
            this.outputFileExtPreview_lbl.Size = new System.Drawing.Size(120, 13);
            this.outputFileExtPreview_lbl.TabIndex = 20;
            this.outputFileExtPreview_lbl.Text = "[17-06-18 20.52.18].csv";
            this.toolTip1.SetToolTip(this.outputFileExtPreview_lbl, "File extension example");
            // 
            // byDaysOfMonth_lbl
            // 
            this.byDaysOfMonth_lbl.AutoSize = true;
            this.byDaysOfMonth_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.byDaysOfMonth_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byDaysOfMonth_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byDaysOfMonth_lbl.Location = new System.Drawing.Point(15, 356);
            this.byDaysOfMonth_lbl.Name = "byDaysOfMonth_lbl";
            this.byDaysOfMonth_lbl.Size = new System.Drawing.Size(109, 13);
            this.byDaysOfMonth_lbl.TabIndex = 37;
            this.byDaysOfMonth_lbl.Text = "By days of the month:";
            this.toolTip1.SetToolTip(this.byDaysOfMonth_lbl, "Click to expand/shrink");
            this.byDaysOfMonth_lbl.Click += new System.EventHandler(this.byDaysOfMonth_lbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(15, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mo.";
            this.toolTip1.SetToolTip(this.label10, "Monday");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(40, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tu.";
            this.toolTip1.SetToolTip(this.label11, "Tuesday");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(65, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "We.";
            this.toolTip1.SetToolTip(this.label12, "Wednesday");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(90, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Th.";
            this.toolTip1.SetToolTip(this.label13, "Thursday");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(115, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Fr.";
            this.toolTip1.SetToolTip(this.label14, "Friday");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(140, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Sa.";
            this.toolTip1.SetToolTip(this.label15, "Saturday");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(165, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Su.";
            this.toolTip1.SetToolTip(this.label16, "Sunday");
            // 
            // weekMo_cbx
            // 
            this.weekMo_cbx.AutoSize = true;
            this.weekMo_cbx.Location = new System.Drawing.Point(18, 339);
            this.weekMo_cbx.Name = "weekMo_cbx";
            this.weekMo_cbx.Size = new System.Drawing.Size(15, 14);
            this.weekMo_cbx.TabIndex = 23;
            this.weekMo_cbx.UseVisualStyleBackColor = true;
            this.weekMo_cbx.CheckedChanged += new System.EventHandler(this.weekMo_cbx_CheckedChanged);
            // 
            // weekTu_cbx
            // 
            this.weekTu_cbx.AutoSize = true;
            this.weekTu_cbx.Location = new System.Drawing.Point(43, 339);
            this.weekTu_cbx.Name = "weekTu_cbx";
            this.weekTu_cbx.Size = new System.Drawing.Size(15, 14);
            this.weekTu_cbx.TabIndex = 25;
            this.weekTu_cbx.UseVisualStyleBackColor = true;
            this.weekTu_cbx.CheckedChanged += new System.EventHandler(this.weekTu_cbx_CheckedChanged);
            // 
            // weekWe_cbx
            // 
            this.weekWe_cbx.AutoSize = true;
            this.weekWe_cbx.Location = new System.Drawing.Point(68, 339);
            this.weekWe_cbx.Name = "weekWe_cbx";
            this.weekWe_cbx.Size = new System.Drawing.Size(15, 14);
            this.weekWe_cbx.TabIndex = 27;
            this.weekWe_cbx.UseVisualStyleBackColor = true;
            this.weekWe_cbx.CheckedChanged += new System.EventHandler(this.weekWe_cbx_CheckedChanged);
            // 
            // weekTh_cbx
            // 
            this.weekTh_cbx.AutoSize = true;
            this.weekTh_cbx.Location = new System.Drawing.Point(93, 339);
            this.weekTh_cbx.Name = "weekTh_cbx";
            this.weekTh_cbx.Size = new System.Drawing.Size(15, 14);
            this.weekTh_cbx.TabIndex = 29;
            this.weekTh_cbx.UseVisualStyleBackColor = true;
            this.weekTh_cbx.CheckedChanged += new System.EventHandler(this.weekTh_cbx_CheckedChanged);
            // 
            // weekFr_cbx
            // 
            this.weekFr_cbx.AutoSize = true;
            this.weekFr_cbx.Location = new System.Drawing.Point(118, 339);
            this.weekFr_cbx.Name = "weekFr_cbx";
            this.weekFr_cbx.Size = new System.Drawing.Size(15, 14);
            this.weekFr_cbx.TabIndex = 31;
            this.weekFr_cbx.UseVisualStyleBackColor = true;
            this.weekFr_cbx.CheckedChanged += new System.EventHandler(this.weekFr_cbx_CheckedChanged);
            // 
            // weekSa_cbx
            // 
            this.weekSa_cbx.AutoSize = true;
            this.weekSa_cbx.Location = new System.Drawing.Point(143, 339);
            this.weekSa_cbx.Name = "weekSa_cbx";
            this.weekSa_cbx.Size = new System.Drawing.Size(15, 14);
            this.weekSa_cbx.TabIndex = 33;
            this.weekSa_cbx.UseVisualStyleBackColor = true;
            this.weekSa_cbx.CheckedChanged += new System.EventHandler(this.weekSa_cbx_CheckedChanged);
            // 
            // weekSu_cbx
            // 
            this.weekSu_cbx.AutoSize = true;
            this.weekSu_cbx.Location = new System.Drawing.Point(168, 339);
            this.weekSu_cbx.Name = "weekSu_cbx";
            this.weekSu_cbx.Size = new System.Drawing.Size(15, 14);
            this.weekSu_cbx.TabIndex = 35;
            this.weekSu_cbx.UseVisualStyleBackColor = true;
            this.weekSu_cbx.CheckedChanged += new System.EventHandler(this.weekSu_cbx_CheckedChanged);
            // 
            // schedulingSeparator_lbl
            // 
            this.schedulingSeparator_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.schedulingSeparator_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.schedulingSeparator_lbl.Location = new System.Drawing.Point(200, 327);
            this.schedulingSeparator_lbl.Name = "schedulingSeparator_lbl";
            this.schedulingSeparator_lbl.Size = new System.Drawing.Size(1, 195);
            this.schedulingSeparator_lbl.TabIndex = 36;
            // 
            // test_btn
            // 
            this.test_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.test_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.test_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.test_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.test_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.test_btn.Location = new System.Drawing.Point(205, 495);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(83, 25);
            this.test_btn.TabIndex = 39;
            this.test_btn.Text = "Test Report";
            this.test_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.test_btn.UseVisualStyleBackColor = false;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save_btn.Location = new System.Drawing.Point(295, 495);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(83, 25);
            this.save_btn.TabIndex = 40;
            this.save_btn.Text = "Save";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // byDaysOfMonths_listcbx
            // 
            this.byDaysOfMonths_listcbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.byDaysOfMonths_listcbx.CheckOnClick = true;
            this.byDaysOfMonths_listcbx.FormattingEnabled = true;
            this.byDaysOfMonths_listcbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.byDaysOfMonths_listcbx.Location = new System.Drawing.Point(18, 372);
            this.byDaysOfMonths_listcbx.Name = "byDaysOfMonths_listcbx";
            this.byDaysOfMonths_listcbx.ScrollAlwaysVisible = true;
            this.byDaysOfMonths_listcbx.Size = new System.Drawing.Size(176, 150);
            this.byDaysOfMonths_listcbx.TabIndex = 41;
            this.byDaysOfMonths_listcbx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.byDaysOfMonths_listcbx_MouseUp);
            // 
            // sql_txtbox
            // 
            this.sql_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sql_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)), true);
            this.sql_txtbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sql_txtbox.Location = new System.Drawing.Point(12, 55);
            this.sql_txtbox.Multiline = true;
            this.sql_txtbox.Name = "sql_txtbox";
            this.sql_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sql_txtbox.Size = new System.Drawing.Size(370, 157);
            this.sql_txtbox.TabIndex = 7;
            this.sql_txtbox.TextChanged += new System.EventHandler(this.sql_txtbox_TextChanged);
            // 
            // changesNotSaved_lbl
            // 
            this.changesNotSaved_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changesNotSaved_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.changesNotSaved_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.changesNotSaved_lbl.Location = new System.Drawing.Point(205, 469);
            this.changesNotSaved_lbl.Name = "changesNotSaved_lbl";
            this.changesNotSaved_lbl.Size = new System.Drawing.Size(174, 13);
            this.changesNotSaved_lbl.TabIndex = 42;
            this.changesNotSaved_lbl.Text = "Changes not saved!";
            this.changesNotSaved_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changesNotSaved_lbl.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 536);
            this.Controls.Add(this.changesNotSaved_lbl);
            this.Controls.Add(this.byDaysOfMonths_listcbx);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.byDaysOfMonth_lbl);
            this.Controls.Add(this.schedulingSeparator_lbl);
            this.Controls.Add(this.weekSu_cbx);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.weekSa_cbx);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.weekFr_cbx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.weekTh_cbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.weekWe_cbx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.weekTu_cbx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.weekMo_cbx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.outputFileExtPreview_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timeOfDay_masktxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fileName_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.directory_btn);
            this.Controls.Add(this.directory_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sql_txtbox);
            this.Controls.Add(this.dbName_lbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Scheduled Report: ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dbName_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox directory_txtbox;
        private System.Windows.Forms.Button directory_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileName_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox timeOfDay_masktxtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label outputFileExtPreview_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox weekMo_cbx;
        private System.Windows.Forms.CheckBox weekTu_cbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox weekWe_cbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox weekTh_cbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox weekFr_cbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox weekSa_cbx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox weekSu_cbx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label schedulingSeparator_lbl;
        private System.Windows.Forms.Label byDaysOfMonth_lbl;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.CheckedListBox byDaysOfMonths_listcbx;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox sql_txtbox;
        private System.Windows.Forms.Label changesNotSaved_lbl;
    }
}