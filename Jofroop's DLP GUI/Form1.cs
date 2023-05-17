using System;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Jofroop_s_DLP_GUI
{
    public partial class Form1 : Form
    {
        string dlpPath = "";
        string outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\JofroopsDLPGUIOutput";
        string mp3Option = "";

        string strCmdLine;

        OpenFileDialog dlpDialogue = new OpenFileDialog();
        FolderBrowserDialog outputDialogue = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dlpPath = Properties.Settings.Default.dlpPath;
            outputPath = Properties.Settings.Default.outputPath;

            // MessageBox.Show("dlpPath:" + dlpPath + "\noutputPath: " + outputPath);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.dlpPath = dlpPath;
            Properties.Settings.Default.outputPath = outputPath;
            Properties.Settings.Default.Save();

            // MessageBox.Show("dlpPath:" + dlpPath + "\noutputPath: " + outputPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlpPath == "")
            {
                MessageBox.Show("You must select the YT-DLP.exe file using the folder button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (linkInput.Text != "")
                {
                    strCmdLine = $"/k {dlpPath} {linkInput.Text} -o \"{outputPath}\\%(title)s-%(id)s.%(ext)s\" {mp3Option}";
                    // MessageBox.Show(strCmdLine);
                    System.Diagnostics.Process.Start("CMD.exe", strCmdLine);
                }
                else
                {
                    MessageBox.Show("The link cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void openExe_Click(object sender, EventArgs e)
        {
            dlpDialogue.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dlpDialogue.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            dlpDialogue.ShowDialog();
            dlpPath = dlpDialogue.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string infoTitle = "Help";
            string infoMessage = "Instructions for use:\n- First, download the latest version of yt-dlp or a variant of your wish.\n- Next, click the folder button and select the yt-dlp file.\n- You can now enter a link, then press the download button.\n\nFile paths:\n- By default, videos are output to C:\\Videos\\JofroopsDLGGUIOutput, but this can be changed.\n\nTroubleshooting:\n - Ensure that you've selected the yt-dlp file, and not something random.\n- Make sure that the yt-dlp file has not moved.\n - The program cannot output to folders that need admin access. Make sure you are outputting somewhere like Your Documents or Your Videos.";
            MessageBoxButtons infoButtons = MessageBoxButtons.OK;

            MessageBox.Show(infoMessage, infoTitle, infoButtons, MessageBoxIcon.Question);
        }

        private void outputPathSet_Click(object sender, EventArgs e)
        {
            outputDialogue.ShowDialog();
            outputPath = outputDialogue.SelectedPath;
        }

        private void mp3Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(audioOnlyCheckbox.CheckState))
            {
                mp3Option = "-f \"bestaudio\"";
            }
            else
            {
                mp3Option = "";
            }
            
        }
    }
}


