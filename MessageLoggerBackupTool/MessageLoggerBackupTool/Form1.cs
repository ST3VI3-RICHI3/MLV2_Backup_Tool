using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace MessageLoggerBackupTool
{
    public partial class MainWindow : Form
    {

        bool DBG = false;
        string BetterDiscordPath = null;
        string StorageFolderBasePath = null;
        string StorageFolderName = null;
        bool Func_called = false;

        public MainWindow()
        {
            DBG = Program.Debug;
            InitializeComponent();
        }

        private void TitleBarCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitleBarMinButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (DBG)
            {
                TitlebarDBG_Cmd.Enabled = true;
                TitlebarDBG_Cmd.Visible = true;
            }
        }

        private void InitTimer_Tick(object sender, EventArgs e)
        {
            InitTimer.Enabled = false;
            InitLoadLabel.Visible = true;
            Console.WriteLine("Load application settings");
            if (File.Exists("config.json"))
            {
                StreamReader setReader = new StreamReader("config.json");
                string data = setReader.ReadToEnd();
                setReader.Close();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Data Read: \n" + data);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                data = "[ " + data + " ]";
                JsonDocument doc = null;
                try
                {
                    doc = JsonDocument.Parse(data);
                }
                catch (System.Text.Json.JsonException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FATAL: Unable to parse config.json.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    InitLoadLabel.Text = "Load failed.";
                    InitLoadLabel.Location = new Point(467, 312);
                    InitLoadFailResetButton.Visible = true;
                    InitLoadFailResetButton.Enabled = true;
                    if (Func_called)
                    {
                        throw new JsonException();
                    }
                    else
                    {
                        return;
                    }
                }
                JsonElement root = doc.RootElement;
                var users = root.EnumerateArray();
                while (users.MoveNext())
                {
                    var user = users.Current;
                    var props = user.EnumerateObject();
                    while (props.MoveNext())
                    {
                        var prop = props.Current;
                        Console.WriteLine($"{prop.Name}: {prop.Value}");
                        if (prop.Name == "BDPath")
                        {
                            BetterDiscordPath = prop.Value.ToString();
                            BetterDiscordPath = BetterDiscordPath.Replace("%username%", Environment.UserName);
                            Console.Write($"Check if path \"{BetterDiscordPath}\" is valid: ");
                            if (Directory.Exists(BetterDiscordPath))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Passed!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failed.");
                                Console.ForegroundColor = ConsoleColor.White;
                                BetterDiscordPath = null;
                            }
                            Console.Write($"Check if path \"{BetterDiscordPath}\\plugins\" is valid: ");
                            if (Directory.Exists($"{BetterDiscordPath}\\plugins"))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Passed!");
                                Console.ForegroundColor = ConsoleColor.White;
                                SettingsBDLocTextBox.Text = BetterDiscordPath;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Failed.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else if (prop.Name == "BackStorageBasePath")
                        {
                            if (prop.Value.ToString() == "$BDDir")
                            {
                                if (BetterDiscordPath != null)
                                {
                                    Console.WriteLine($"Setting BackupStorageIntPath to \"{BetterDiscordPath}\".");
                                    StorageFolderBasePath = BetterDiscordPath;
                                    SettingsBackBasePathTextBox.Text = StorageFolderBasePath;
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Warn: Unable to set BackupStorageIntPath to BetterDiscordPath, var is 'null'.");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else
                            {
                                StorageFolderBasePath = prop.Value.ToString();
                                StorageFolderBasePath.Replace("%username%", Environment.UserName);
                                Console.Write($"Check if path \"{StorageFolderBasePath}\" is valid: ");
                                if (Directory.Exists(StorageFolderBasePath))
                                {
                                    SettingsBackBasePathTextBox.Text = StorageFolderBasePath;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Passed!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Failed.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                        else if (prop.Name == "BackStorageFolderName")
                        {
                            StorageFolderName = prop.Value.ToString();
                            SettingsBackFolderTexBox.Text = StorageFolderName;
                            Console.WriteLine($"Backup storage folder name set to \"{StorageFolderName}\".");
                        }
                        else if (prop.Name == "BackMethod")
                        {
                            if (int.Parse(prop.Value.ToString()) == 1)
                            {
                                Console.WriteLine($"Backup method set to \"Multi File\".");
                                SettingsBackupMethodComboBox.SelectedItem = "Multi File";
                                BackUpSectionCreateBackupButton.Text = "Create new backup";
                            }
                            else
                            {

                                if (Directory.Exists($"{StorageFolderBasePath}\\{StorageFolderName}"))
                                {
                                    if (File.Exists($"{StorageFolderBasePath}\\{StorageFolderName}\\Backup.json"))
                                    {
                                        BackUpSectionCreateBackupButton.Text = "Update backup";
                                    }
                                    else
                                    {
                                        BackUpSectionCreateBackupButton.Text = "Create backup";
                                    }
                                }
                                else
                                {
                                    Directory.CreateDirectory($"{StorageFolderBasePath}\\{StorageFolderName}");
                                    BackUpSectionCreateBackupButton.Text = "Create backup";
                                }
                                Console.WriteLine($"Backup method set to \"Single File\".");
                                SettingsBackupMethodComboBox.SelectedItem = "Single File";
                            }
                        }
                    }
                }

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Warn: Load of config.json failed, file missing, resorting to defaults.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            NavPanelSettingsButton.Enabled = true;
            BackUpSectionLabel.Enabled = true;
            BackUpSectionLabel.Visible = true;
            BackUpSectionCreateBackupButton.Enabled = true;
            BackUpSectionCreateBackupButton.Visible = true;
            InitLoadLabel.Visible = false;
            InitLoadLabel.Enabled = false;
            InitLoadFailResetButton.Enabled = false;
            InitLoadFailResetButton.Visible = false;
        }

        private void NavPanelSettingsButton_Click(object sender, EventArgs e)
        {
            BackUpSectionLabel.Enabled = !BackUpSectionLabel.Enabled;
            BackUpSectionLabel.Visible = !BackUpSectionLabel.Visible;
            BackUpSectionCreateBackupButton.Enabled = !BackUpSectionCreateBackupButton.Enabled;
            BackUpSectionCreateBackupButton.Visible = !BackUpSectionCreateBackupButton.Visible;
            SettingTitleLabel.Enabled = !SettingTitleLabel.Enabled;
            SettingTitleLabel.Visible = !SettingTitleLabel.Visible;
            SettingsBDLocLabel.Enabled = !SettingsBDLocLabel.Enabled;
            SettingsBDLocLabel.Visible = !SettingsBDLocLabel.Visible;
            SettingsBDLocTextBox.Enabled = !SettingsBDLocTextBox.Enabled;
            SettingsBDLocTextBox.Visible = !SettingsBDLocTextBox.Visible;
            SettingsShowBackFolder.Enabled = !SettingsShowBackFolder.Enabled;
            SettingsShowBackFolder.Visible = !SettingsShowBackFolder.Visible;
            SettingsBDLocOpenFExButt.Enabled = !SettingsBDLocOpenFExButt.Enabled;
            SettingsBDLocOpenFExButt.Visible = !SettingsBDLocOpenFExButt.Visible;
            SettingsBackBasePathLabel.Enabled = !SettingsBackBasePathLabel.Enabled;
            SettingsBackBasePathLabel.Visible = !SettingsBackBasePathLabel.Visible;
            SettingsBackBasePathTextBox.Enabled = !SettingsBackBasePathTextBox.Enabled;
            SettingsBackBasePathTextBox.Visible = !SettingsBackBasePathTextBox.Visible;
            SettingsBackBasePathFExButt.Enabled = !SettingsBackBasePathFExButt.Enabled;
            SettingsBackBasePathFExButt.Visible = !SettingsBackBasePathFExButt.Visible;
            SettingsBackFolderLabel.Enabled = !SettingsBackFolderLabel.Enabled;
            SettingsBackFolderLabel.Visible = !SettingsBackFolderLabel.Visible;
            SettingsBackFolderTexBox.Enabled = !SettingsBackFolderTexBox.Enabled;
            SettingsBackFolderTexBox.Visible = !SettingsBackFolderTexBox.Visible;
            SettingsBackupMethodlabel.Enabled = !SettingsBackupMethodlabel.Enabled;
            SettingsBackupMethodlabel.Visible = !SettingsBackupMethodlabel.Visible;
            SettingsBackupMethodComboBox.Enabled = !SettingsBackupMethodComboBox.Enabled;
            SettingsBackupMethodComboBox.Visible = !SettingsBackupMethodComboBox.Visible;
            SettingsAppVer.Enabled = !SettingsAppVer.Enabled;
            SettingsAppVer.Visible = !SettingsAppVer.Visible;
        }

        private void SettingsBDLocOpenFExButt_Click(object sender, EventArgs e)
        {
            SettingsFEx.ShowDialog();
            if (SettingsFEx.SelectedPath != "")
            {
                SettingsBDLocTextBox.Text = SettingsFEx.SelectedPath;
            }
        }

        private void SettingsBackBasePathFExButt_Click(object sender, EventArgs e)
        {
            SettingsFEx.ShowDialog();
            if (SettingsFEx.SelectedPath != "")
            {
                SettingsBackBasePathTextBox.Text = SettingsFEx.SelectedPath;
            }
        }

        private void TitlebarDBG_Cmd_Click(object sender, EventArgs e)
        {
            Console.Write("CMD> ");
            string CMD = Console.ReadLine();
            CMD = CMD.ToLower();
            if (CMD == "help" || CMD == "?")
            {
                Console.WriteLine("\n-----HELP-----\n\nreloadconf - Reloads \"config.json\".\nhang - Causes the application to \"hang\" / crash.\nwindow.resetui - Reloads the form UI.\nwindow.close - Closes the application window.\nexit - Causes the application to exit (triggers: Enviroment.Exit(0);).\n\n--------------\n");
            }
            else if (CMD == "reloadconf")
            {
                InitLoadLabel.Enabled = true;
                InitLoadLabel.Visible = true;
                Console.WriteLine("Reloading config...\n");
                try
                {
                    Func_called = true;
                    InitTimer_Tick(sender, e);
                    Console.WriteLine("\nConfig successfully reloaded.");
                }
                catch (JsonException)
                {

                }
                Func_called = false;
            }
            else if (CMD=="window.resetui")
            {
                NavPanelSettingsButton.Enabled = true;
                BackUpSectionLabel.Enabled = true;
                BackUpSectionLabel.Visible = true;
                BackUpSectionCreateBackupButton.Enabled = true;
                BackUpSectionCreateBackupButton.Visible = true;
                InitLoadLabel.Visible = false;
                InitLoadLabel.Enabled = false;
                InitLoadFailResetButton.Enabled = false;
                InitLoadFailResetButton.Visible = false;
                SettingTitleLabel.Enabled = false;
                SettingTitleLabel.Visible = false;
                SettingsBDLocLabel.Enabled = false;
                SettingsBDLocLabel.Visible = false;
                SettingsBDLocTextBox.Enabled = false;
                SettingsBDLocTextBox.Visible = false;
                SettingsShowBackFolder.Enabled = false;
                SettingsShowBackFolder.Visible = false;
                SettingsBDLocOpenFExButt.Enabled = false;
                SettingsBDLocOpenFExButt.Visible = false;
                SettingsBackBasePathLabel.Enabled = false;
                SettingsBackBasePathLabel.Visible = false;
                SettingsBackBasePathTextBox.Enabled = false;
                SettingsBackBasePathTextBox.Visible = false;
                SettingsBackBasePathFExButt.Enabled = false;
                SettingsBackBasePathFExButt.Visible = false;
                SettingsBackFolderLabel.Enabled = false;
                SettingsBackFolderLabel.Visible = false;
                SettingsBackFolderTexBox.Enabled = false;
                SettingsBackFolderTexBox.Visible = false;
                SettingsBackupMethodlabel.Enabled = false;
                SettingsBackupMethodlabel.Visible = false;
                SettingsBackupMethodComboBox.Enabled = false;
                SettingsBackupMethodComboBox.Visible = false;
                SettingsAppVer.Enabled = false;
                SettingsAppVer.Visible = false;
                NavPanelLoc.X = -75;
                NavPanel.Location = NavPanelLoc;
                NavPanelMoveButton.Text = "Navigation     >";
                this.Refresh();
            }
            else if (CMD == "window.close")
            {
                this.Close();
            }
            else if (CMD == "hang")
            {
                while (true)
                {

                }
            }
            else if (CMD == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Unknown command, \"{CMD}\".");
            }
        }

        private Point NavPanelLoc = new Point(-75, 25);

        private void NavPanelMoveButton_Click(object sender, EventArgs e)
        {
            if (NavPanel.Location.X == -75)
            {
                NavPanelLoc.X = 0;
                NavPanel.Location = NavPanelLoc;
                NavPanelMoveButton.Text = "Navigation     <";
            }
            else
            {
                NavPanelLoc.X = -75;
                NavPanel.Location = NavPanelLoc;
                NavPanelMoveButton.Text = "Navigation     >";
            }
        }

        private void SettingsShowBackFolder_Click(object sender, EventArgs e)
        {
            string ExplorerArgs;
            if (Directory.Exists($"{StorageFolderBasePath}\\{StorageFolderName}"))
            {
                ExplorerArgs = $"{StorageFolderBasePath}\\{StorageFolderName}";
            }
            else
            {
                ExplorerArgs = $"{StorageFolderBasePath}";
            }
            System.Diagnostics.Process.Start("explorer.exe", ExplorerArgs);
        }

        private void SettingsBackupMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SettingsBackupMethodComboBox.SelectedItem.ToString() == "Multi File")
            {
                BackUpSectionCreateBackupButton.Text = "Create new backup";
            }
            else
            {

                if (Directory.Exists($"{StorageFolderBasePath}\\{StorageFolderName}"))
                {
                    if (File.Exists($"{StorageFolderBasePath}\\{StorageFolderName}\\Backup.json"))
                    {
                        BackUpSectionCreateBackupButton.Text = "Update backup";
                    }
                    else
                    {
                        BackUpSectionCreateBackupButton.Text = "Create backup";
                    }
                }
                else
                {
                    Directory.CreateDirectory($"{StorageFolderBasePath}\\{StorageFolderName}");
                    BackUpSectionCreateBackupButton.Text = "Create backup";
                }
                SettingsBackupMethodComboBox.SelectedItem = "Single File";
            }
        }
    }
}
