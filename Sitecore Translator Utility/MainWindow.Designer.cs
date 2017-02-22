namespace BlueWombat.Sitecore_Translator_Utility
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FieldNames = new System.Windows.Forms.ListBox();
            this.openOriginalFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openOriginalFileButton = new System.Windows.Forms.Button();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.translatedTextBox = new System.Windows.Forms.TextBox();
            this.saveTranslatedFileButton = new System.Windows.Forms.Button();
            this.saveTranslatedFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.originalLanguageSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.translatedLanguageSelector = new System.Windows.Forms.ComboBox();
            this.MainWindowToolbar = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldNames
            // 
            this.FieldNames.FormattingEnabled = true;
            this.FieldNames.HorizontalScrollbar = true;
            this.FieldNames.Location = new System.Drawing.Point(12, 60);
            this.FieldNames.Name = "FieldNames";
            this.FieldNames.ScrollAlwaysVisible = true;
            this.FieldNames.Size = new System.Drawing.Size(339, 810);
            this.FieldNames.TabIndex = 0;
            this.FieldNames.Click += new System.EventHandler(this.FieldNames_Click);
            this.FieldNames.SelectedIndexChanged += new System.EventHandler(this.FieldNames_SelectedIndexChanged);
            // 
            // openOriginalFileDialog
            // 
            this.openOriginalFileDialog.FileName = "originalFile";
            this.openOriginalFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openOriginalFileDialog_FileOk);
            // 
            // openOriginalFileButton
            // 
            this.openOriginalFileButton.Location = new System.Drawing.Point(12, 23);
            this.openOriginalFileButton.Name = "openOriginalFileButton";
            this.openOriginalFileButton.Size = new System.Drawing.Size(339, 23);
            this.openOriginalFileButton.TabIndex = 1;
            this.openOriginalFileButton.Text = "Open Orignal File...";
            this.openOriginalFileButton.UseVisualStyleBackColor = true;
            this.openOriginalFileButton.Click += new System.EventHandler(this.openOriginalFileButton_Click);
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(357, 60);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.Size = new System.Drawing.Size(660, 810);
            this.originalTextBox.TabIndex = 2;
            // 
            // translatedTextBox
            // 
            this.translatedTextBox.Location = new System.Drawing.Point(1023, 60);
            this.translatedTextBox.Multiline = true;
            this.translatedTextBox.Name = "translatedTextBox";
            this.translatedTextBox.Size = new System.Drawing.Size(660, 810);
            this.translatedTextBox.TabIndex = 3;
            this.translatedTextBox.TextChanged += new System.EventHandler(this.translatedTextBox_TextChanged);
            // 
            // saveTranslatedFileButton
            // 
            this.saveTranslatedFileButton.Location = new System.Drawing.Point(1344, 23);
            this.saveTranslatedFileButton.Name = "saveTranslatedFileButton";
            this.saveTranslatedFileButton.Size = new System.Drawing.Size(339, 23);
            this.saveTranslatedFileButton.TabIndex = 4;
            this.saveTranslatedFileButton.Text = "Save Translated File...";
            this.saveTranslatedFileButton.UseVisualStyleBackColor = true;
            this.saveTranslatedFileButton.Click += new System.EventHandler(this.saveTranslatedFileButton_Click);
            // 
            // saveTranslatedFileDialog
            // 
            this.saveTranslatedFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveTranslatedFileDialog_FileOk);
            // 
            // originalLanguageSelector
            // 
            this.originalLanguageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originalLanguageSelector.FormattingEnabled = true;
            this.originalLanguageSelector.Location = new System.Drawing.Point(459, 23);
            this.originalLanguageSelector.Name = "originalLanguageSelector";
            this.originalLanguageSelector.Size = new System.Drawing.Size(121, 21);
            this.originalLanguageSelector.TabIndex = 5;
            this.originalLanguageSelector.SelectedIndexChanged += new System.EventHandler(this.originalLanguageSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Language:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1020, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Target Language:";
            // 
            // translatedLanguageSelector
            // 
            this.translatedLanguageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.translatedLanguageSelector.FormattingEnabled = true;
            this.translatedLanguageSelector.Location = new System.Drawing.Point(1118, 23);
            this.translatedLanguageSelector.Name = "translatedLanguageSelector";
            this.translatedLanguageSelector.Size = new System.Drawing.Size(121, 21);
            this.translatedLanguageSelector.TabIndex = 7;
            this.translatedLanguageSelector.SelectedIndexChanged += new System.EventHandler(this.translatedLanguageSelector_SelectedIndexChanged);
            // 
            // MainWindowToolbar
            // 
            this.MainWindowToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.MainWindowToolbar.Location = new System.Drawing.Point(0, 0);
            this.MainWindowToolbar.Name = "MainWindowToolbar";
            this.MainWindowToolbar.Size = new System.Drawing.Size(1694, 24);
            this.MainWindowToolbar.TabIndex = 9;
            this.MainWindowToolbar.Text = "MainWindowToolbar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 885);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.translatedLanguageSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.originalLanguageSelector);
            this.Controls.Add(this.saveTranslatedFileButton);
            this.Controls.Add(this.translatedTextBox);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.openOriginalFileButton);
            this.Controls.Add(this.FieldNames);
            this.Controls.Add(this.MainWindowToolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainWindowToolbar;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.MainWindowToolbar.ResumeLayout(false);
            this.MainWindowToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FieldNames;
        private System.Windows.Forms.OpenFileDialog openOriginalFileDialog;
        private System.Windows.Forms.Button openOriginalFileButton;
        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.TextBox translatedTextBox;
        private System.Windows.Forms.Button saveTranslatedFileButton;
        private System.Windows.Forms.SaveFileDialog saveTranslatedFileDialog;
        private System.Windows.Forms.ComboBox originalLanguageSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox translatedLanguageSelector;
        private System.Windows.Forms.MenuStrip MainWindowToolbar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

