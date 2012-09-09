namespace TemplateProcessor
{
    using System;
    using System.Windows.Forms;
    using Creelio.Framework;
    using TemplateProcessor.Client.Interfaces;
    using TemplateProcessor.Properties;

    public partial class MainForm : Form, ITemplateProcessor
    {
        public MainForm()
        {
            InitializeComponent();
            SettingsManager = new SettingsManager<Settings, ITemplateProcessor>(Settings.Default);
        }

        public string TemplateDirectory
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string OutputDirectory
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private SettingsManager<Settings, ITemplateProcessor> SettingsManager { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SettingsManager.Load(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsManager.Save(this);
        }
    }
}