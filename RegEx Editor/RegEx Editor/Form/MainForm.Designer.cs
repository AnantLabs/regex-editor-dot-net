namespace RegEx_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.RegExTextBox = new System.Windows.Forms.TextBox();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MatchDataGrid = new System.Windows.Forms.DataGridView();
            this.found = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuitButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.MatchButton = new System.Windows.Forms.Button();
            this.IsMatchButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.LoadReplaceButton = new System.Windows.Forms.Button();
            this.LoadExpressionButton = new System.Windows.Forms.Button();
            this.FileTextBox = new DigitalRune.Windows.TextEditor.TextEditorControl();
            this.ResultTextBox = new DigitalRune.Windows.TextEditor.TextEditorControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActivWindowLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MatchDataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.Location = new System.Drawing.Point(12, 14);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(481, 20);
            this.PathTextBox.TabIndex = 1;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // RegExTextBox
            // 
            this.RegExTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegExTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegExTextBox.Location = new System.Drawing.Point(95, 180);
            this.RegExTextBox.Multiline = true;
            this.RegExTextBox.Name = "RegExTextBox";
            this.RegExTextBox.Size = new System.Drawing.Size(398, 73);
            this.RegExTextBox.TabIndex = 3;
            this.RegExTextBox.TextChanged += new System.EventHandler(this.RegExTextBox_TextChanged);
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReplaceTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceTextBox.Location = new System.Drawing.Point(95, 261);
            this.ReplaceTextBox.Multiline = true;
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(398, 79);
            this.ReplaceTextBox.TabIndex = 7;
            this.ReplaceTextBox.TextChanged += new System.EventHandler(this.ReplaceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search \r\nExpression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Replace";
            // 
            // MatchDataGrid
            // 
            this.MatchDataGrid.AllowUserToAddRows = false;
            this.MatchDataGrid.AllowUserToDeleteRows = false;
            this.MatchDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MatchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.found});
            this.MatchDataGrid.Location = new System.Drawing.Point(12, 346);
            this.MatchDataGrid.Name = "MatchDataGrid";
            this.MatchDataGrid.ReadOnly = true;
            this.MatchDataGrid.Size = new System.Drawing.Size(599, 160);
            this.MatchDataGrid.TabIndex = 11;
            // 
            // found
            // 
            this.found.HeaderText = "Found";
            this.found.Name = "found";
            this.found.ReadOnly = true;
            // 
            // QuitButton
            // 
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Image = global::RegEx_Editor.Properties.Resources.action_stop;
            this.QuitButton.Location = new System.Drawing.Point(594, 12);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(23, 23);
            this.QuitButton.TabIndex = 13;
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Image = global::RegEx_Editor.Properties.Resources.icon_info;
            this.InfoButton.Location = new System.Drawing.Point(565, 12);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(23, 23);
            this.InfoButton.TabIndex = 12;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.BackColor = System.Drawing.SystemColors.Window;
            this.ReplaceButton.Enabled = false;
            this.ReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceButton.Image = global::RegEx_Editor.Properties.Resources.action_refresh_blue;
            this.ReplaceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReplaceButton.Location = new System.Drawing.Point(542, 286);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceButton.TabIndex = 6;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReplaceButton.UseVisualStyleBackColor = false;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // MatchButton
            // 
            this.MatchButton.BackColor = System.Drawing.SystemColors.Window;
            this.MatchButton.Enabled = false;
            this.MatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchButton.Image = global::RegEx_Editor.Properties.Resources.icon_package_get;
            this.MatchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MatchButton.Location = new System.Drawing.Point(542, 229);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(75, 23);
            this.MatchButton.TabIndex = 5;
            this.MatchButton.Text = "Match";
            this.MatchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MatchButton.UseVisualStyleBackColor = false;
            this.MatchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // IsMatchButton
            // 
            this.IsMatchButton.BackColor = System.Drawing.SystemColors.Window;
            this.IsMatchButton.Enabled = false;
            this.IsMatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsMatchButton.Image = global::RegEx_Editor.Properties.Resources.icon_wand;
            this.IsMatchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IsMatchButton.Location = new System.Drawing.Point(542, 204);
            this.IsMatchButton.Name = "IsMatchButton";
            this.IsMatchButton.Size = new System.Drawing.Size(75, 23);
            this.IsMatchButton.TabIndex = 4;
            this.IsMatchButton.Text = "IsMatch";
            this.IsMatchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsMatchButton.UseVisualStyleBackColor = false;
            this.IsMatchButton.Click += new System.EventHandler(this.IsMatchButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.SystemColors.Window;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Image = global::RegEx_Editor.Properties.Resources.folder1;
            this.OpenFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.Location = new System.Drawing.Point(499, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(50, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "File";
            this.OpenFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // LoadReplaceButton
            // 
            this.LoadReplaceButton.BackColor = System.Drawing.SystemColors.Window;
            this.LoadReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadReplaceButton.Image = global::RegEx_Editor.Properties.Resources.folder1;
            this.LoadReplaceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadReplaceButton.Location = new System.Drawing.Point(499, 261);
            this.LoadReplaceButton.Name = "LoadReplaceButton";
            this.LoadReplaceButton.Size = new System.Drawing.Size(118, 23);
            this.LoadReplaceButton.TabIndex = 15;
            this.LoadReplaceButton.Text = "Load Replace";
            this.LoadReplaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadReplaceButton.UseVisualStyleBackColor = false;
            this.LoadReplaceButton.Click += new System.EventHandler(this.LoadReplaceButton_Click);
            // 
            // LoadExpressionButton
            // 
            this.LoadExpressionButton.BackColor = System.Drawing.SystemColors.Window;
            this.LoadExpressionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadExpressionButton.Image = global::RegEx_Editor.Properties.Resources.folder1;
            this.LoadExpressionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadExpressionButton.Location = new System.Drawing.Point(499, 179);
            this.LoadExpressionButton.Name = "LoadExpressionButton";
            this.LoadExpressionButton.Size = new System.Drawing.Size(118, 23);
            this.LoadExpressionButton.TabIndex = 14;
            this.LoadExpressionButton.Text = "Load Expression";
            this.LoadExpressionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadExpressionButton.UseVisualStyleBackColor = false;
            this.LoadExpressionButton.Click += new System.EventHandler(this.LoadExpressionButton_Click);
            // 
            // FileTextBox
            // 
            this.FileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileTextBox.Location = new System.Drawing.Point(12, 40);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(605, 133);
            this.FileTextBox.TabIndex = 16;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Location = new System.Drawing.Point(12, 346);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(597, 160);
            this.ResultTextBox.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ActivWindowLabel,
            this.toolStripStatusLabel3,
            this.PositionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "Active Textbox:";
            // 
            // ActivWindowLabel
            // 
            this.ActivWindowLabel.Name = "ActivWindowLabel";
            this.ActivWindowLabel.Size = new System.Drawing.Size(109, 17);
            this.ActivWindowLabel.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel3.Text = "    Position:";
            // 
            // PositionLabel
            // 
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(109, 17);
            this.PositionLabel.Text = "toolStripStatusLabel4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.LoadReplaceButton);
            this.Controls.Add(this.LoadExpressionButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.MatchDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceTextBox);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.IsMatchButton);
            this.Controls.Add(this.RegExTextBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RegEx Editor.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatchDataGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox RegExTextBox;
        private System.Windows.Forms.Button IsMatchButton;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MatchDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn found;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button LoadReplaceButton;
        private System.Windows.Forms.Button LoadExpressionButton;
        private DigitalRune.Windows.TextEditor.TextEditorControl FileTextBox;
        private DigitalRune.Windows.TextEditor.TextEditorControl ResultTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ActivWindowLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel PositionLabel;
    }
}

