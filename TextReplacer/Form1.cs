using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace TextReplacer
{
    public partial class windowPanel : Form
    {
        public windowPanel()
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
            }
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text != "")
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

        private void windowPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bgPanel_MouseDown(object sender, MouseEventArgs e)
        {
            windowPanel_MouseDown(bgPanel, e);
        }
        #endregion

        #region Minimize By Taskbar Clicked
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        #endregion

        private void creditsLabel_Click(object sender, EventArgs e)
        {
            ProcessStartInfo authorLinks = new ProcessStartInfo("https://github.com/zedoppa");
            Process.Start(authorLinks);
        }

        private void windowPanel_Load(object sender, EventArgs e)
        {
            // set default value for theme
            themeBox.SelectedItem = themeBox.Items[0];
        }

        private void themeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox) sender).SelectedItem as string)
            {
                case "Default":
                    bgPanel.BackColor = Color.White;
                    this.BackColor = Color.Black;
                    this.ForeColor = Color.Black;

                    sourceGroup.ForeColor = Color.Black;
                    resultGroup.ForeColor = Color.Black;
                    symbolGroup.ForeColor = Color.Black;

                    clearBtn.BackColor = Color.White;
                    replaceBtn.BackColor = Color.White;
                    copyBtn.BackColor = Color.White;

                    creditsLabel.BackColor = Color.Black;
                    creditsLabel.ForeColor = Color.White;

                    originalTextBox.BackColor = Color.White;
                    originalTextBox.ForeColor = Color.Black;
                    resultTextBox.BackColor = Color.White;
                    resultTextBox.ForeColor = Color.Black;
                    findBox.BackColor = Color.White;
                    findBox.ForeColor = Color.Black;
                    replaceBox.BackColor = Color.White;
                    replaceBox.ForeColor = Color.Black;

                    switchBtn.Image = TextReplacer.Properties.Resources.default_swap_24;
                    break;

                case "Dark":
                    bgPanel.BackColor = Color.Black;
                    this.BackColor = Color.White;
                    this.ForeColor = Color.White;

                    sourceGroup.ForeColor = Color.White;
                    resultGroup.ForeColor = Color.White;
                    symbolGroup.ForeColor = Color.White;

                    clearBtn.BackColor = Color.Black;
                    replaceBtn.BackColor = Color.Black;
                    copyBtn.BackColor = Color.Black;

                    creditsLabel.BackColor = Color.White;
                    creditsLabel.ForeColor = Color.Black;

                    originalTextBox.BackColor = Color.Black;
                    originalTextBox.ForeColor = Color.White;
                    resultTextBox.BackColor = Color.Black;
                    resultTextBox.ForeColor = Color.White;
                    findBox.BackColor = Color.Black;
                    findBox.ForeColor = Color.White;
                    replaceBox.BackColor = Color.Black;
                    replaceBox.ForeColor = Color.White;

                    switchBtn.Image = TextReplacer.Properties.Resources.dark_swap_24;
                    break;
            }
        }
    }
}
