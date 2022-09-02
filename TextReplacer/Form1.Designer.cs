
namespace TextReplacer
{
    partial class windowPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowPanel));
            this.ReplaceSymbolPanel = new System.Windows.Forms.Panel();
            this.sourceGroup = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.symbolGroup = new System.Windows.Forms.Panel();
            this.switchBtn = new System.Windows.Forms.Button();
            this.findBox = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.Label();
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.Label();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.themeLabel = new System.Windows.Forms.Label();
            this.themeBox = new System.Windows.Forms.ComboBox();
            this.ReplaceSymbolPanel.SuspendLayout();
            this.sourceGroup.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.symbolGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReplaceSymbolPanel
            // 
            this.ReplaceSymbolPanel.Controls.Add(this.sourceGroup);
            this.ReplaceSymbolPanel.Controls.Add(this.resultGroup);
            this.ReplaceSymbolPanel.Controls.Add(this.symbolGroup);
            this.ReplaceSymbolPanel.Controls.Add(this.replaceBtn);
            this.ReplaceSymbolPanel.Location = new System.Drawing.Point(17, 47);
            this.ReplaceSymbolPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReplaceSymbolPanel.Name = "ReplaceSymbolPanel";
            this.ReplaceSymbolPanel.Size = new System.Drawing.Size(527, 609);
            this.ReplaceSymbolPanel.TabIndex = 2;
            // 
            // sourceGroup
            // 
            this.sourceGroup.Controls.Add(this.clearBtn);
            this.sourceGroup.Controls.Add(this.originalTextBox);
            this.sourceGroup.ForeColor = System.Drawing.Color.Black;
            this.sourceGroup.Location = new System.Drawing.Point(13, 16);
            this.sourceGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sourceGroup.Name = "sourceGroup";
            this.sourceGroup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sourceGroup.Size = new System.Drawing.Size(498, 222);
            this.sourceGroup.TabIndex = 11;
            this.sourceGroup.TabStop = false;
            this.sourceGroup.Text = "Source";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(409, 179);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(74, 27);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // originalTextBox
            // 
            this.originalTextBox.BackColor = System.Drawing.Color.White;
            this.originalTextBox.ForeColor = System.Drawing.Color.Black;
            this.originalTextBox.Location = new System.Drawing.Point(12, 22);
            this.originalTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalTextBox.Size = new System.Drawing.Size(472, 150);
            this.originalTextBox.TabIndex = 0;
            // 
            // resultGroup
            // 
            this.resultGroup.Controls.Add(this.resultTextBox);
            this.resultGroup.Controls.Add(this.copyBtn);
            this.resultGroup.Location = new System.Drawing.Point(13, 371);
            this.resultGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resultGroup.Name = "resultGroup";
            this.resultGroup.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resultGroup.Size = new System.Drawing.Size(498, 222);
            this.resultGroup.TabIndex = 10;
            this.resultGroup.TabStop = false;
            this.resultGroup.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.ForeColor = System.Drawing.Color.Black;
            this.resultTextBox.Location = new System.Drawing.Point(12, 22);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(472, 150);
            this.resultTextBox.TabIndex = 5;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(409, 179);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(74, 27);
            this.copyBtn.TabIndex = 9;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // symbolGroup
            // 
            this.symbolGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolGroup.Controls.Add(this.switchBtn);
            this.symbolGroup.Controls.Add(this.findBox);
            this.symbolGroup.Controls.Add(this.txtFind);
            this.symbolGroup.Controls.Add(this.replaceBox);
            this.symbolGroup.Controls.Add(this.txtReplace);
            this.symbolGroup.Location = new System.Drawing.Point(103, 262);
            this.symbolGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.symbolGroup.Name = "symbolGroup";
            this.symbolGroup.Size = new System.Drawing.Size(254, 75);
            this.symbolGroup.TabIndex = 8;
            // 
            // switchBtn
            // 
            this.switchBtn.BackColor = System.Drawing.Color.Transparent;
            this.switchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchBtn.FlatAppearance.BorderSize = 0;
            this.switchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.switchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.switchBtn.Image = global::TextReplacer.Properties.Resources.default_swap_24;
            this.switchBtn.Location = new System.Drawing.Point(111, 31);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(33, 27);
            this.switchBtn.TabIndex = 11;
            this.switchBtn.UseVisualStyleBackColor = false;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // findBox
            // 
            this.findBox.BackColor = System.Drawing.Color.White;
            this.findBox.ForeColor = System.Drawing.Color.Black;
            this.findBox.Location = new System.Drawing.Point(13, 34);
            this.findBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.findBox.MaxLength = 5;
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(63, 22);
            this.findBox.TabIndex = 2;
            // 
            // txtFind
            // 
            this.txtFind.AutoSize = true;
            this.txtFind.Location = new System.Drawing.Point(11, 16);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(33, 15);
            this.txtFind.TabIndex = 1;
            this.txtFind.Text = "Find:";
            // 
            // replaceBox
            // 
            this.replaceBox.BackColor = System.Drawing.Color.White;
            this.replaceBox.ForeColor = System.Drawing.Color.Black;
            this.replaceBox.Location = new System.Drawing.Point(175, 34);
            this.replaceBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.replaceBox.MaxLength = 5;
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(63, 22);
            this.replaceBox.TabIndex = 4;
            // 
            // txtReplace
            // 
            this.txtReplace.AutoSize = true;
            this.txtReplace.Location = new System.Drawing.Point(173, 15);
            this.txtReplace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(50, 15);
            this.txtReplace.TabIndex = 3;
            this.txtReplace.Text = "Replace:";
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(422, 298);
            this.replaceBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(74, 27);
            this.replaceBtn.TabIndex = 6;
            this.replaceBtn.Text = "Replace";
            this.replaceBtn.UseVisualStyleBackColor = false;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.closeBtn);
            this.flowLayoutPanel1.Controls.Add(this.minimizeBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(395, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 28);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.LightCoral;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::TextReplacer.Properties.Resources.default_close_16;
            this.closeBtn.Location = new System.Drawing.Point(102, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(62, 27);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.White;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Image = global::TextReplacer.Properties.Resources.default_minus_16;
            this.minimizeBtn.Location = new System.Drawing.Point(40, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(62, 27);
            this.minimizeBtn.TabIndex = 12;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(2, 3);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(112, 18);
            this.title.TabIndex = 13;
            this.title.Text = "TextReplacer v1.5";
            // 
            // creditsLabel
            // 
            this.creditsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.BackColor = System.Drawing.Color.Black;
            this.creditsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsLabel.ForeColor = System.Drawing.Color.White;
            this.creditsLabel.Location = new System.Drawing.Point(-1, 667);
            this.creditsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.creditsLabel.Size = new System.Drawing.Size(148, 25);
            this.creditsLabel.TabIndex = 12;
            this.creditsLabel.Text = "Made by TheRakuSama";
            this.creditsLabel.Click += new System.EventHandler(this.creditsLabel_Click);
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.White;
            this.bgPanel.Controls.Add(this.themeLabel);
            this.bgPanel.Controls.Add(this.themeBox);
            this.bgPanel.Controls.Add(this.ReplaceSymbolPanel);
            this.bgPanel.Controls.Add(this.creditsLabel);
            this.bgPanel.Controls.Add(this.title);
            this.bgPanel.Controls.Add(this.flowLayoutPanel1);
            this.bgPanel.Location = new System.Drawing.Point(12, 12);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(559, 692);
            this.bgPanel.TabIndex = 14;
            this.bgPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bgPanel_MouseDown);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.themeLabel.Location = new System.Drawing.Point(346, 666);
            this.themeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(56, 17);
            this.themeLabel.TabIndex = 15;
            this.themeLabel.Text = "Theme:";
            // 
            // themeBox
            // 
            this.themeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeBox.FormattingEnabled = true;
            this.themeBox.Items.AddRange(new object[] {
            "Default",
            "Dark"});
            this.themeBox.Location = new System.Drawing.Point(407, 662);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(121, 23);
            this.themeBox.TabIndex = 14;
            this.themeBox.SelectedIndexChanged += new System.EventHandler(this.themeBox_SelectedIndexChanged);
            // 
            // windowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(583, 716);
            this.Controls.Add(this.bgPanel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "windowPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextReplacer";
            this.Load += new System.EventHandler(this.windowPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowPanel_MouseDown);
            this.ReplaceSymbolPanel.ResumeLayout(false);
            this.sourceGroup.ResumeLayout(false);
            this.sourceGroup.PerformLayout();
            this.resultGroup.ResumeLayout(false);
            this.resultGroup.PerformLayout();
            this.symbolGroup.ResumeLayout(false);
            this.symbolGroup.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ReplaceSymbolPanel;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.Label txtReplace;
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Label txtFind;
        private System.Windows.Forms.Panel symbolGroup;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.GroupBox sourceGroup;
        private System.Windows.Forms.GroupBox resultGroup;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.ComboBox themeBox;
        private System.Windows.Forms.Label themeLabel;
    }
}

