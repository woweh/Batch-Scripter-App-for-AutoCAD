﻿using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batch_Scripter
{
    public partial class MainForm : Form
    {
        private List<string> drawingFiles;

        public MainForm()
        {
            InitializeComponent();
            drawingFiles = new List<string>();
            ApplyDarkTheme();
        }

        private void btnBrowseDrawings_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Drawing files (*.dwg;*.dwt)|*.dwg;*.dwt|All files (*.*)|*.*",
                    Multiselect = true
                })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in openFileDialog.FileNames)
                        {
                            if (!drawingFiles.Contains(file))
                            {
                                drawingFiles.Add(file);
                                listBoxDrawings.Items.Add(file);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error browsing drawings", ex);
            }
        }

        private void btnRemoveDrawings_Click(object sender, EventArgs e)
        {
            try
            {
                while (listBoxDrawings.SelectedItems.Count > 0)
                {
                    string selectedFile = listBoxDrawings.SelectedItems[0].ToString();
                    drawingFiles.Remove(selectedFile);
                    listBoxDrawings.Items.Remove(selectedFile);
                }
            }
            catch (Exception ex)
            {
                ShowError("Error removing drawings", ex);
            }
        }

        private void btnBrowseScript_Click(object sender, EventArgs e)
        {
            BrowseScriptFile();
        }

        private async void btnRunScript_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to run the script?", "Run Script", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string tempScriptFile = Path.Combine(Path.GetTempPath(), $"BatchScripter_Script_{Guid.NewGuid()}.scr");
                try
                {
                    await Task.Run(() =>
                    {
                        using (StreamWriter writer = new StreamWriter(tempScriptFile))
                        {
                           // writer.WriteLine("(setq originalSDI (getvar \"SDI\"))");
                            writer.WriteLine("(setvar \"SDI\" 1)");

                            foreach (string drawingFile in drawingFiles)
                            {
                                try
                                {
                                    if (chkSaveDrawings.InvokeRequired)
                                    {
                                        chkSaveDrawings.Invoke((Action)(() =>
                                        {
                                            if (chkSaveDrawings.Checked)
                                            {
                                                writer.WriteLine($"(command \"_.OPEN\" \"{EscapePath(drawingFile)}\")");
                                            }
                                            else
                                            {
                                                writer.WriteLine($"(command \"_.OPEN\" \"{EscapePath(drawingFile)}\" \"READONLY\")");
                                            }
                                        }));
                                    }

                                    string[] scriptLines = textBoxContents.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                                    foreach (string line in scriptLines)
                                    {
                                        writer.WriteLine(line);
                                    }

                                    if (chkSaveDrawings.Checked)
                                    {
                                        writer.WriteLine($"(command \"_.SAVE\" \"{EscapePath(drawingFile)}\")");
                                    }
                                    //writer.WriteLine("(command \"_.CLOSE\" \"No\")");
                                }
                                catch (Exception ex)
                                {
                                    Invoke((Action)(() =>
                                    {
                                        MessageBox.Show($"Error processing {drawingFile}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        LogError($"Error processing {drawingFile}: {ex.Message}");
                                    }));
                                }
                            }

                            writer.WriteLine("(setvar \"SDI\" 0)");
                            writer.WriteLine("(command \"_.CLOSE\" \"No\")");
                        }

                        RunScriptFile(tempScriptFile);
                    });

                    // Close the Batch Script dialog
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while creating the script file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogError($"Error creating script file: {ex.Message}");
                }
            }
        }

        private void RunScriptFile(string scriptFilePath)
        {
            try
            {
                Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                Editor ed = doc.Editor;
                string command = $"(command \"_.SCRIPT\" \"{EscapePath(scriptFilePath)}\")\n";
                ed.Document.SendStringToExecute(command, true, false, false);
            }
            catch (Exception ex)
            {
                ShowError("Error running the script file", ex);
            }
        }


        private void BrowseScriptFile()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Script files (*.scr;*.txt)|*.scr;*.txt|All files (*.*)|*.*",
                    Multiselect = false
                })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileContent = File.ReadAllText(openFileDialog.FileName);
                        textBoxContents.AppendText(fileContent + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error browsing scripts", ex);
            }
        }

        private string EscapePath(string path)
        {
            return path.Replace("\\", "\\\\");
        }

        private void ShowError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogError($"{message}: {ex.Message}");
        }

        private void LogError(string message)
        {
            try
            {
                string logFilePath = Path.Combine(Path.GetTempPath(), $"BatchScripter_ErrorLog_{Guid.NewGuid()}.log");
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging the error: {ex.Message}", "Logging Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            this.ForeColor = System.Drawing.Color.White;

            foreach (Control control in this.Controls)
            {
                //if (control is Button || control is CheckBox || control is Label || control is TextBox || control is ListBox)
                if (control is Button || control is TextBox || control is ListBox)
                {
                    control.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                    control.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        private void linkLblFootnote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://ca.linkedin.com/in/oliverwackenreuther");
        }

        private void linkLblLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://github.com/OliversDev/Batch-Scripter-App-for-AutoCAD/blob/master/LICENSE.txt");
        }

        private void linkLblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://github.com/OliversDev/Batch-Scripter-App-for-AutoCAD/blob/master/README.md");
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/OliversDev");
        }

        private void LinkedIn_Click(object sender, EventArgs e)
        {
            OpenUrl("https://ca.linkedin.com/in/oliverwackenreuther");
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open link. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
