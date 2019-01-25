using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public partial class ComponentSettings : UserControl
    {
        public bool autoReset { get; set; }
        public bool autoStart { get; set; }
        public bool autoSplit { get; set; }

        public ComponentSettings()
        {
            InitializeComponent();
            autoReset = true;
            autoStart = true;
            autoSplit = true;
            
            chkAutoReset.DataBindings.Add("Checked", this, "autoReset", false, DataSourceUpdateMode.OnPropertyChanged);
            chkAutoStart.DataBindings.Add("Checked", this, "autoStart", false, DataSourceUpdateMode.OnPropertyChanged);
            chkAutoSplit.DataBindings.Add("Checked", this, "autoSplit", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            var settingsNode = document.CreateElement("Settings");

            var node = document.CreateElement("autoReset");
            node.InnerText = autoReset.ToString();
            settingsNode.AppendChild(node);
            node = document.CreateElement("autoStart");
            node.InnerText = autoStart.ToString();
            settingsNode.AppendChild(node);
            node = document.CreateElement("autoSplit");
            node.InnerText = autoSplit.ToString();
            settingsNode.AppendChild(node);

            return settingsNode;
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            autoReset = Boolean.Parse(settings["autoReset"].InnerText);

            autoStart = Boolean.Parse(settings["autoStart"].InnerText);

            autoSplit = Boolean.Parse(settings["autoSplit"].InnerText);
        }
    }
}
