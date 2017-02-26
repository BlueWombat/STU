using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BlueWombat.BusinessLogic.Xml;

namespace BlueWombat.Sitecore_Translator_Utility
{
    public partial class MainWindow : Form
    {
        private string _lastUsedDirectory;
        private SitecoreEntity _originalEntity;
        private SitecoreEntity _translatedEntity;
        private string _originalLanguageCode;
        private string _translatedLanguageCode;
        private string _lastSelectedKey;

        public MainWindow()
        {
            InitializeComponent();

            this.Text = AboutDialog.AssemblyTitle;

            FieldNames.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            originalTextBox.Anchor = FieldNames.Anchor | translatedTextBox.Anchor;
            translatedTextBox.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            openOriginalFileButton.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            saveTranslatedFileButton.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            var cultures1 = LanguageManager.GetOriginalLanguages();
            var cultures2 = LanguageManager.GetTargetLanguages();
            originalLanguageSelector.DataSource = cultures1;
            originalLanguageSelector.DisplayMember = "Name";
            translatedLanguageSelector.DataSource = cultures2;
            translatedLanguageSelector.DisplayMember = "Name";
        }

        private void saveTranslatedFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;

            var dialog = sender as SaveFileDialog;

            _lastUsedDirectory = new FileInfo(dialog.FileName).DirectoryName;

            if (File.Exists(dialog.FileName))
                File.Delete(dialog.FileName);

            XmlParser.ToXml(dialog.FileName, _translatedEntity);
        }

        private void saveTranslatedFileButton_Click(object sender, EventArgs e)
        {
            if (_lastUsedDirectory != null)
                saveTranslatedFileDialog.InitialDirectory = _lastUsedDirectory;

            saveTranslatedFileDialog.DefaultExt = ".xml";
            saveTranslatedFileDialog.CreatePrompt = false;
            saveTranslatedFileDialog.OverwritePrompt = true;
            saveTranslatedFileDialog.ShowDialog();
        }

        private void openOriginalFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
                return;

            var dialog = sender as OpenFileDialog;

            _lastUsedDirectory = new FileInfo(dialog.FileName).DirectoryName;

            _originalEntity = XmlParser.FromXml(dialog.FileName);
            _translatedEntity = _originalEntity.Clone() as SitecoreEntity;
            var phrases = _originalEntity.Phrases.Select(p => new KeyValuePair<string, string>($"{p.itemid}/{p.fieldid}", p.path.Replace("/sitecore/content/", "") + "/" + p.fieldid)).ToArray();
            FieldNames.DataSource = phrases;
            FieldNames.DisplayMember = "Value";
        }

        private void openOriginalFileButton_Click(object sender, EventArgs e)
        {
            if (_lastUsedDirectory != null)
                openOriginalFileDialog.InitialDirectory = _lastUsedDirectory;

            openOriginalFileDialog.DefaultExt = ".xml";
            openOriginalFileDialog.ShowDialog();
        }

        private void FieldNames_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_lastSelectedKey))
                return;

            var key = _lastSelectedKey.Split('/');
            var translatedPhrase = _translatedEntity.Phrases.SingleOrDefault(p => p.itemid == key[0] && p.fieldid == key[1]);

            translatedPhrase.GetType().GetProperty(_translatedLanguageCode).SetValue(translatedPhrase, translatedTextBox.Text);
        }

        private void FieldNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            var key = ((KeyValuePair<string, string>)listBox.SelectedItem).Key.Split('/');
            _lastSelectedKey = string.Join("/", key);

            var originalPhrase = _originalEntity.Phrases.SingleOrDefault(p => p.itemid == key[0] && p.fieldid == key[1]);
            originalTextBox.Text = (originalPhrase.GetType().GetProperty(_originalLanguageCode).GetValue(originalPhrase) ?? "").ToString();
            var translatedPhrase = _translatedEntity.Phrases.SingleOrDefault(p => p.itemid == key[0] && p.fieldid == key[1]);
            translatedTextBox.Text = (translatedPhrase.GetType().GetProperty(_translatedLanguageCode).GetValue(translatedPhrase) ?? "").ToString();
        }

        private void originalLanguageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drop = sender as ComboBox;
            var selectedItem = (Language)drop.SelectedItem;
            _originalLanguageCode = selectedItem.PropertyName;
            if (FieldNames.Items.Count > 0)
                FieldNames.SetSelected(FieldNames.SelectedIndex < 0 ? 0 : FieldNames.SelectedIndex, true);
        }

        private void translatedLanguageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drop = sender as ComboBox;
            var selectedItem = (Language)drop.SelectedItem;
            _translatedLanguageCode = selectedItem.PropertyName;
            if (FieldNames.Items.Count > 0)
                FieldNames.SetSelected(FieldNames.SelectedIndex < 0 ? 0 : FieldNames.SelectedIndex, true);
        }

        private void translatedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_lastSelectedKey))
                return;

            var key = _lastSelectedKey.Split('/');
            var translatedPhrase = _translatedEntity.Phrases.SingleOrDefault(p => p.itemid == key[0] && p.fieldid == key[1]);

            translatedPhrase.GetType().GetProperty(_translatedLanguageCode).SetValue(translatedPhrase, translatedTextBox.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new AboutDialog();
            dialog.ShowDialog();
        }
    }
}
