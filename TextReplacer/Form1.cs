using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace TextReplacer
{
    public partial class TextReplacer : Form
    {
        public TextReplacer()
        {
            InitializeComponent();
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            string errorTitle = "Textbox Empty";
            int count = 0;

            if (originalTextBox.Text == "")
            {
                MessageBox.Show("\"Source\" textbox can't be empty!", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                count++;
            }
            else if (findBox.Text == "")
            {
                MessageBox.Show("\"Find\" textbox can't be empty!", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                count++;
            }
            else if (replaceBox.Text == "")
            {
                MessageBox.Show("\"Replace\" textbox can't be empty!", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                count++;
            }

            if (count == 0)
            {
                resultTextBox.Text = originalTextBox.Text.Replace(findBox.Text, replaceBox.Text);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (originalTextBox.Text != "")
            {
                originalTextBox.Text = "";
                resultTextBox.Text = "";
                MessageBox.Show("Text is cleared!", "Clear Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultTextBox.Text);
        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            string temp = "";

            temp = findBox.Text;

            findBox.Text = replaceBox.Text;
            replaceBox.Text = temp;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region Draggable Borderless Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TextReplacer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void creditsLabel_Click(object sender, EventArgs e)
        {
            ProcessStartInfo authorLinks = new ProcessStartInfo("https://github.com/zedoppa");
            Process.Start(authorLinks);
        }
    }
}
