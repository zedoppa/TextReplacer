
namespace TextReplacer
{
    partial class TextReplacer
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
            this.ReplaceSymbolPanel = new System.Windows.Forms.Panel();
            this.sourceGroup = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.resultGroup = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.ReplaceSymbolPanel.SuspendLayout();
            this.sourceGroup.SuspendLayout();
            this.resultGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReplaceSymbolPanel
            // 
            this.ReplaceSymbolPanel.Controls.Add(this.sourceGroup);
            this.ReplaceSymbolPanel.Controls.Add(this.resultGroup);
            this.ReplaceSymbolPanel.Controls.Add(this.panel1);
            this.ReplaceSymbolPanel.Controls.Add(this.replaceBtn);
            this.ReplaceSymbolPanel.Location = new System.Drawing.Point(11, 46);
            this.ReplaceSymbolPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReplaceSymbolPanel.Name = "ReplaceSymbolPanel";
            this.ReplaceSymbolPanel.Size = new System.Drawing.Size(527, 609);
            this.ReplaceSymbolPanel.TabIndex = 2;
            // 
            // sourceGroup
            // 
            this.sourceGroup.Controls.Add(this.clearBtn);
            this.sourceGroup.Controls.Add(this.originalTextBox);
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
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // originalTextBox
            // 
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.switchBtn);
            this.panel1.Controls.Add(this.findBox);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.replaceBox);
            this.panel1.Controls.Add(this.txtReplace);
            this.panel1.Location = new System.Drawing.Point(103, 262);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 75);
            this.panel1.TabIndex = 8;
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
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.closeBtn);
            this.flowLayoutPanel1.Controls.Add(this.minimizeBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(388, 0);
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
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
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
            this.title.Location = new System.Drawing.Point(12, 5);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(14, 18);
            this.title.TabIndex = 13;
            this.title.Text = string.Format("{0} v{1}", System.Windows.Forms.Application.ProductName, System.Windows.Forms.Application.ProductVersion);
            // 
            // creditsLabel
            // 
            this.creditsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.BackColor = System.Drawing.Color.Black;
            this.creditsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsLabel.ForeColor = System.Drawing.Color.White;
            this.creditsLabel.Location = new System.Drawing.Point(0, 666);
            this.creditsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.creditsLabel.Size = new System.Drawing.Size(148, 25);
            this.creditsLabel.TabIndex = 12;
            this.creditsLabel.Text = "Made by TheRakuSama";
            this.creditsLabel.Click += new System.EventHandler(this.creditsLabel_Click);
            // 
            // TextReplacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 691);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ReplaceSymbolPanel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "TextReplacer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextReplacer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextReplacer_MouseDown);
            this.ReplaceSymbolPanel.ResumeLayout(false);
            this.sourceGroup.ResumeLayout(false);
            this.sourceGroup.PerformLayout();
            this.resultGroup.ResumeLayout(false);
            this.resultGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ReplaceSymbolPanel;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.Label txtReplace;
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Label txtFind;
        private System.Windows.Forms.Panel panel1;
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
    }
}

