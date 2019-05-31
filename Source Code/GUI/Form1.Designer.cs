namespace CSharp_Source_Code {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addDB_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.serverUID_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serverPassword_txtbox = new System.Windows.Forms.TextBox();
            this.mainSettings_grpbox = new System.Windows.Forms.GroupBox();
            this.runBg_cbx = new System.Windows.Forms.CheckBox();
            this.runStartup_cbx = new System.Windows.Forms.CheckBox();
            this.separator0_lbl = new System.Windows.Forms.Label();
            this.dbName_txtbox = new System.Windows.Forms.TextBox();
            this.dbName_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverPort_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverName_txbox = new System.Windows.Forms.TextBox();
            this.editSchedReport_btn = new System.Windows.Forms.Button();
            this.deleteSchedReport_btn = new System.Windows.Forms.Button();
            this.version_label = new System.Windows.Forms.Label();
            this.dbMain_listview = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reportColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.mainSettings_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developed by: Mutu Adi-Marian";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(741, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "©2018 Edward Bennett";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(868, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Query Report Scheduler";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDB_btn
            // 
            this.addDB_btn.BackColor = System.Drawing.Color.Azure;
            this.addDB_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDB_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.addDB_btn.ForeColor = System.Drawing.Color.Black;
            this.addDB_btn.Location = new System.Drawing.Point(3, 159);
            this.addDB_btn.Name = "addDB_btn";
            this.addDB_btn.Size = new System.Drawing.Size(120, 24);
            this.addDB_btn.TabIndex = 5;
            this.addDB_btn.Text = "Add new Database";
            this.addDB_btn.UseVisualStyleBackColor = false;
            this.addDB_btn.Click += new System.EventHandler(this.newDB_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.serverUID_txtbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.serverPassword_txtbox);
            this.panel1.Controls.Add(this.mainSettings_grpbox);
            this.panel1.Controls.Add(this.separator0_lbl);
            this.panel1.Controls.Add(this.dbName_txtbox);
            this.panel1.Controls.Add(this.dbName_lbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.serverPort_txtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.serverName_txbox);
            this.panel1.Controls.Add(this.editSchedReport_btn);
            this.panel1.Controls.Add(this.deleteSchedReport_btn);
            this.panel1.Controls.Add(this.addDB_btn);
            this.panel1.Location = new System.Drawing.Point(741, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 428);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Server UID:";
            // 
            // serverUID_txtbox
            // 
            this.serverUID_txtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.serverUID_txtbox.Location = new System.Drawing.Point(3, 94);
            this.serverUID_txtbox.Name = "serverUID_txtbox";
            this.serverUID_txtbox.Size = new System.Drawing.Size(120, 20);
            this.serverUID_txtbox.TabIndex = 19;
            this.serverUID_txtbox.Text = "sa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Server Password:";
            // 
            // serverPassword_txtbox
            // 
            this.serverPassword_txtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.serverPassword_txtbox.Location = new System.Drawing.Point(3, 133);
            this.serverPassword_txtbox.Name = "serverPassword_txtbox";
            this.serverPassword_txtbox.PasswordChar = '*';
            this.serverPassword_txtbox.Size = new System.Drawing.Size(120, 20);
            this.serverPassword_txtbox.TabIndex = 17;
            // 
            // mainSettings_grpbox
            // 
            this.mainSettings_grpbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSettings_grpbox.BackColor = System.Drawing.Color.Honeydew;
            this.mainSettings_grpbox.Controls.Add(this.runBg_cbx);
            this.mainSettings_grpbox.Controls.Add(this.runStartup_cbx);
            this.mainSettings_grpbox.Location = new System.Drawing.Point(3, 331);
            this.mainSettings_grpbox.Name = "mainSettings_grpbox";
            this.mainSettings_grpbox.Size = new System.Drawing.Size(118, 62);
            this.mainSettings_grpbox.TabIndex = 16;
            this.mainSettings_grpbox.TabStop = false;
            this.mainSettings_grpbox.Text = "Program Settings";
            // 
            // runBg_cbx
            // 
            this.runBg_cbx.AutoSize = true;
            this.runBg_cbx.Location = new System.Drawing.Point(6, 42);
            this.runBg_cbx.Name = "runBg_cbx";
            this.runBg_cbx.Size = new System.Drawing.Size(93, 17);
            this.runBg_cbx.TabIndex = 1;
            this.runBg_cbx.Text = "Run in backg.";
            this.toolTip1.SetToolTip(this.runBg_cbx, "Run in background");
            this.runBg_cbx.UseVisualStyleBackColor = true;
            this.runBg_cbx.CheckedChanged += new System.EventHandler(this.runBg_cbx_CheckedChanged);
            // 
            // runStartup_cbx
            // 
            this.runStartup_cbx.AutoSize = true;
            this.runStartup_cbx.Location = new System.Drawing.Point(6, 19);
            this.runStartup_cbx.Name = "runStartup_cbx";
            this.runStartup_cbx.Size = new System.Drawing.Size(93, 17);
            this.runStartup_cbx.TabIndex = 0;
            this.runStartup_cbx.Text = "Run at startup";
            this.toolTip1.SetToolTip(this.runStartup_cbx, "Run at Windows Startup");
            this.runStartup_cbx.UseVisualStyleBackColor = true;
            this.runStartup_cbx.CheckedChanged += new System.EventHandler(this.runStartup_cbx_CheckedChanged);
            // 
            // separator0_lbl
            // 
            this.separator0_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator0_lbl.Location = new System.Drawing.Point(12, 218);
            this.separator0_lbl.Name = "separator0_lbl";
            this.separator0_lbl.Size = new System.Drawing.Size(100, 1);
            this.separator0_lbl.TabIndex = 15;
            this.separator0_lbl.Text = "                            ";
            this.separator0_lbl.Visible = false;
            // 
            // dbName_txtbox
            // 
            this.dbName_txtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dbName_txtbox.Location = new System.Drawing.Point(3, 239);
            this.dbName_txtbox.Name = "dbName_txtbox";
            this.dbName_txtbox.Size = new System.Drawing.Size(120, 20);
            this.dbName_txtbox.TabIndex = 12;
            this.dbName_txtbox.Visible = false;
            this.dbName_txtbox.TextChanged += new System.EventHandler(this.dbName_txtbox_TextChanged);
            // 
            // dbName_lbl
            // 
            this.dbName_lbl.AutoSize = true;
            this.dbName_lbl.Location = new System.Drawing.Point(0, 223);
            this.dbName_lbl.Name = "dbName_lbl";
            this.dbName_lbl.Size = new System.Drawing.Size(87, 13);
            this.dbName_lbl.TabIndex = 11;
            this.dbName_lbl.Text = "Database Name:";
            this.dbName_lbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server Port:";
            // 
            // serverPort_txtbox
            // 
            this.serverPort_txtbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.serverPort_txtbox.Location = new System.Drawing.Point(3, 55);
            this.serverPort_txtbox.Name = "serverPort_txtbox";
            this.serverPort_txtbox.Size = new System.Drawing.Size(120, 20);
            this.serverPort_txtbox.TabIndex = 9;
            this.serverPort_txtbox.Text = "1433";
            this.serverPort_txtbox.TextChanged += new System.EventHandler(this.serverPort_txtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server Name:";
            // 
            // serverName_txbox
            // 
            this.serverName_txbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.serverName_txbox.Location = new System.Drawing.Point(3, 16);
            this.serverName_txbox.Name = "serverName_txbox";
            this.serverName_txbox.Size = new System.Drawing.Size(120, 20);
            this.serverName_txbox.TabIndex = 0;
            this.serverName_txbox.Text = "localhost";
            this.serverName_txbox.TextChanged += new System.EventHandler(this.serverDNS_txtbox_TextChanged);
            // 
            // editSchedReport_btn
            // 
            this.editSchedReport_btn.BackColor = System.Drawing.Color.Azure;
            this.editSchedReport_btn.Enabled = false;
            this.editSchedReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editSchedReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.editSchedReport_btn.ForeColor = System.Drawing.Color.Black;
            this.editSchedReport_btn.Location = new System.Drawing.Point(3, 189);
            this.editSchedReport_btn.Name = "editSchedReport_btn";
            this.editSchedReport_btn.Size = new System.Drawing.Size(120, 24);
            this.editSchedReport_btn.TabIndex = 8;
            this.editSchedReport_btn.Text = "Edit Sched. Report";
            this.toolTip1.SetToolTip(this.editSchedReport_btn, "Edit the scheduled report for the selected database");
            this.editSchedReport_btn.UseVisualStyleBackColor = false;
            this.editSchedReport_btn.Click += new System.EventHandler(this.editReport_btn_Click);
            // 
            // deleteSchedReport_btn
            // 
            this.deleteSchedReport_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSchedReport_btn.BackColor = System.Drawing.Color.Azure;
            this.deleteSchedReport_btn.Enabled = false;
            this.deleteSchedReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSchedReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.deleteSchedReport_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteSchedReport_btn.Location = new System.Drawing.Point(3, 399);
            this.deleteSchedReport_btn.Name = "deleteSchedReport_btn";
            this.deleteSchedReport_btn.Size = new System.Drawing.Size(120, 24);
            this.deleteSchedReport_btn.TabIndex = 7;
            this.deleteSchedReport_btn.Text = "Delete";
            this.deleteSchedReport_btn.UseVisualStyleBackColor = false;
            this.deleteSchedReport_btn.Click += new System.EventHandler(this.deleteReport_btn_Click);
            // 
            // version_label
            // 
            this.version_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.version_label.AutoSize = true;
            this.version_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.version_label.Location = new System.Drawing.Point(170, 484);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(15, 15);
            this.version_label.TabIndex = 9;
            this.version_label.Text = "v";
            // 
            // dbMain_listview
            // 
            this.dbMain_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbMain_listview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dbMain_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.reportColumn});
            this.dbMain_listview.FullRowSelect = true;
            this.dbMain_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dbMain_listview.Location = new System.Drawing.Point(6, 53);
            this.dbMain_listview.Name = "dbMain_listview";
            this.dbMain_listview.Size = new System.Drawing.Size(733, 428);
            this.dbMain_listview.TabIndex = 10;
            this.dbMain_listview.UseCompatibleStateImageBehavior = false;
            this.dbMain_listview.View = System.Windows.Forms.View.Details;
            this.dbMain_listview.SelectedIndexChanged += new System.EventHandler(this.dbMain_listview_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 338;
            // 
            // reportColumn
            // 
            this.reportColumn.Text = "Last Report Status";
            this.reportColumn.Width = 390;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Passed in background mode...";
            this.notifyIcon1.BalloonTipTitle = "Database Query Scheduler";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Database Query Scheduler";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(875, 502);
            this.Controls.Add(this.dbMain_listview);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(551, 475);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainSettings_grpbox.ResumeLayout(false);
            this.mainSettings_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addDB_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editSchedReport_btn;
        private System.Windows.Forms.Button deleteSchedReport_btn;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader reportColumn;
        public System.Windows.Forms.ListView dbMain_listview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox serverPort_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverName_txbox;
        private System.Windows.Forms.TextBox dbName_txtbox;
        private System.Windows.Forms.Label dbName_lbl;
        private System.Windows.Forms.Label separator0_lbl;
        private System.Windows.Forms.GroupBox mainSettings_grpbox;
        private System.Windows.Forms.CheckBox runBg_cbx;
        private System.Windows.Forms.CheckBox runStartup_cbx;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serverUID_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serverPassword_txtbox;
    }
}

