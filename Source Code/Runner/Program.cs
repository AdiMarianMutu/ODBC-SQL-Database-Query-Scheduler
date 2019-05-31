using System;
using System.IO;
using System.Text;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Windows.Forms;
using CsvHelper;

namespace Runner {
    static class Program {

        #region [GLOBAL]
        public static class Global {
            public static string ServerName = "localhost";
            public static string ServerPort = "1433";
            public static string ServerUID  = "sa";
            public static string ServerPWD  = "";

            #region [ENCRYPTION_DECRYPTION]
            public static string Encrypt(string Data) {
                return Convert.ToBase64String(xs8Cipher.Encrypt(Encoding.UTF8.GetBytes(Data), EncryptionKey, xs8CipherKey.Size_128bit));
            }
            public static string Decrypt(string Data) {
                return Encoding.UTF8.GetString(xs8Cipher.Decrypt(Convert.FromBase64String(Data), EncryptionKey, xs8CipherKey.Size_128bit));
            }
            // Encryption key used to encrypt some private information about the Databases
            public static string EncryptionKey = "G+KbPeShVkYp3s6v";
            #endregion
        }
        #endregion

        #region [CONFIGURATION]
        public static class Configuration {
            static string MainConfigDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                              @"\Database Query Scheduler";

            public static class Main {
                public static void Load() {
                    string _configFilePath = String.Format("{0}\\main.config", MainConfigDirectory);

                    if (File.Exists(_configFilePath)) {
                        string[] _config = File.ReadAllLines(_configFilePath);

                        Global.ServerName = _config[1];
                        Global.ServerPort = _config[2];
                        Global.ServerUID  = _config[3];
                        Global.ServerPWD  = Global.Decrypt(_config[4]);
                    }
                }
            }

            public static class Database {
                private static string _dbDirPath = MainConfigDirectory + @"\Databases";

                public static string GetSQLCommand(string DBName) {
                    if (Directory.Exists(_dbDirPath)) {
                        string _dbConfigFile = String.Format("{0}\\{1}", _dbDirPath, DBName);

                       if (Directory.Exists(_dbConfigFile)) {
                            // Return the SQL Command from the DB config file
                            return Global.Decrypt(File.ReadAllLines(String.Format("{0}\\scheduled_configuration.xs8db", _dbConfigFile))[5]);
                        }
                    }

                    return "";
                }

                public enum ReportStatus {
                    SUCCESS,
                    FAIL,
                    QUERYING,
                    CONNECTION_FAILED
                }

                public static void SaveReport(string DBName, ReportStatus Status) {
                    if (Directory.Exists(_dbDirPath)) {
                        string _dbConfigFile = String.Format("{0}\\{1}", _dbDirPath, DBName);

                        if (Directory.Exists(_dbConfigFile)) {
                            string[] _dbStructure = File.ReadAllLines(String.Format("{0}\\scheduled_configuration.xs8db", _dbConfigFile));

                            if (Status == ReportStatus.SUCCESS) {
                                _dbStructure[2] = Global.Encrypt(String.Format("[{0}] - Success", DateTime.Now));
                            } else 
                            if (Status == ReportStatus.FAIL) {
                                _dbStructure[2] = Global.Encrypt(String.Format("[{0}] - Fail", DateTime.Now));
                            } else
                            if (Status == ReportStatus.QUERYING) {
                                _dbStructure[2] = Global.Encrypt(String.Format("[{0}] - Querying...", DateTime.Now));
                            } else {
                                _dbStructure[2] = Global.Encrypt(String.Format("[{0}] - Can't connect to the DB", DateTime.Now));
                            }

                            File.WriteAllLines(String.Format("{0}\\scheduled_configuration.xs8db", _dbConfigFile), _dbStructure);
                        } else {
                            MessageBox.Show(String.Format(
                                "Unable to save the 'Report Status' because the '{0}\\{1}' folder is missing!\n\n" +
                                "[INFORMATIONS]\n" +
                                "DB Name:       {1}\n" +
                                "Report Status: {2}\n" +
                                "Date Time:     {3}",
                                MainConfigDirectory, DBName, Status.ToString(), DateTime.Now),
                                "Database Query Scheduler [WARNING]",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    } else {
                        MessageBox.Show(String.Format(
                            "Unable to save the 'Report Status' because the '{0}' folder is missing!\n\n" +
                            "[INFORMATIONS]\n" +
                            "DB Name:       {1}\n" +
                            "Report Status: {2}\n" +
                            "Date Time:     {3}", 
                            MainConfigDirectory, DBName, Status.ToString(), DateTime.Now), 
                            "Database Query Scheduler [WARNING]",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
        }
        #endregion

        #region [ODBC_SQL_HELPER_CLASS]
        public static class ODBCSQL {
            private static OdbcConnection _connection;
            private static OdbcDataReader _reader;
            private static OdbcCommand    _oCmd;
            private static string         _cmd;
            
            public static int             ColumnsCount  = 0;
            public static int             ElementsCount = 0;

            #region [CONNECTION]
            public static bool Connect(string ConnectionString, string Command) {
                _connection = new OdbcConnection(ConnectionString);
                _cmd        = Command;

                try {
                    _connection.Open();
                    _oCmd = new OdbcCommand(_cmd, _connection);

                    // Test to see if we can read data from the DB
                    if (!ReadData())
                        return false;

                    return true;
                } catch {
                    CloseConnection();
                    
                    return false;
                }
            }

            // Dispose
            public static void CloseConnection() {
                try { _connection.Close(); } catch { }
            }
            #endregion

            #region [DATA]
            private static void ResetReader() {
                _reader.Close();
                _reader = _oCmd.ExecuteReader();
            }

            private static bool ReadData() {
                try {
                    _reader = _oCmd.ExecuteReader();

                    // Retrieve the number of columns
                    ColumnsCount  = _reader.FieldCount;
                    ElementsCount = GetElementsCount();

                    return true;
                } catch {
                    return false;
                }
            }
            private static int GetElementsCount() {
                int _cnt = 0;

                ResetReader();

                while (_reader.Read())
                    _cnt++;

                return _cnt;
            }
            public static string GetColumnName(int ColumnID) {
                return _reader.GetName(ColumnID);
            }
            public static List<string> GetAllElements() {
                List<string> _elements = new List<string>();
                ResetReader();

                while (_reader.Read()) {
                    for (int i = 0; i < ColumnsCount; i++)
                        _elements.Add(_reader[i].ToString());
                }

                return _elements;
            }
            #endregion
        }
        #endregion

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

        [STAThread]
        static void Main(string[] args) {
            // Arguments
            // 0 = Database name
            // 1 = Report file name
            // 2 = Report file directory path

            // Prevention
            try {
                Configuration.Database.SaveReport(args[0], Configuration.Database.ReportStatus.QUERYING);
            } catch { /* The runner was executed without arguments */ }

            try {
                Configuration.Main.Load();
                
                if (ODBCSQL.Connect("Driver={SQL Server};" + String.Format(
                    // Connection string
                    "Server={0};port={1};Database={2};Uid={3};Pwd={4};",
                    Global.ServerName,
                    Global.ServerPort,
                    args[0], // Database name from command line
                    Global.ServerUID,
                    Global.ServerPWD),
                    // SQL Command
                    Configuration.Database.GetSQLCommand(args[0]))) 
                    {

                    // Start writing the CSV file
                    string _reportName     = String.Format("{0}\\{1}[{2}].csv", args[2], args[1], GetDateTime());

                    using (TextWriter _w   = new StreamWriter(_reportName))
                    using (CsvWriter  _csv = new CsvWriter(_w)) {
                        _csv.Configuration.Delimiter = ",";

                        // Writes the column names
                        for (int i = 0; i < ODBCSQL.ColumnsCount; i++)
                            _csv.WriteField(ODBCSQL.GetColumnName(i), true);
                        _csv.NextRecord();

                        // Starts writing the rows
                        List<string> _elements = ODBCSQL.GetAllElements();
                        for (int i = 0; i < (ODBCSQL.ElementsCount * ODBCSQL.ColumnsCount); i += ODBCSQL.ColumnsCount) {
                            for (int j = 0; j < ODBCSQL.ColumnsCount; j++) {
                                _csv.WriteField(_elements[i + j], true);

                                if (j == ODBCSQL.ColumnsCount - 1)
                                    _csv.NextRecord();
                            }
                        }
                        _w.Flush();
                    }

                    // Closes the connection
                    ODBCSQL.CloseConnection();
                    // Saves the report
                    if (File.Exists(_reportName)) {
                        Configuration.Database.SaveReport(args[0], Configuration.Database.ReportStatus.SUCCESS);
                    } else {
                        Configuration.Database.SaveReport(args[0], Configuration.Database.ReportStatus.FAIL);
                    }
                    // Exit
                    return;
                } else { Configuration.Database.SaveReport(args[0], Configuration.Database.ReportStatus.CONNECTION_FAILED); }
            } catch { Configuration.Database.SaveReport(args[0], Configuration.Database.ReportStatus.FAIL); }
        }
    }
}
