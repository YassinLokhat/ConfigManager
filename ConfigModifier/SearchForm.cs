using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ConfigModifier
{
    public partial class SearchForm : Form
    {
        MainForm parent;

        public SearchForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;

            tbSearch.KeyUp += TbSearch_KeyUp;
            rbSettingName.CheckedChanged += RbSetting_CheckedChanged;
            rbSettingValue.CheckedChanged += RbSetting_CheckedChanged;
            rbText.CheckedChanged += RbSetting_CheckedChanged;
            cbMatchCase.CheckedChanged += RbSetting_CheckedChanged;
            cbAllowRegex.CheckedChanged += RbSetting_CheckedChanged;

            lbResult.MouseDoubleClick += LbResult_MouseDoubleClick;

            this.SizeChanged += SearchForm_SizeChanged;
        }

        private void LbResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbResult.SelectedIndices.Count == 0)
                return;

            string[] data = lbResult.SelectedItem.ToString().Split('\t');
            string siteCode = (from x in parent.SiteFolderCode where x.Value == data[1].Replace("-" + data[0].ToUpper(), "") select x.Key).First();
            string configPath = Environment.CurrentDirectory + "\\Settings\\SIT1-" + data[0] + @"\App_Config\Include\zzPG.GrowingFamilies.Version1\" + data[1] + @"\PG.GrowingFamilies.Version1." + siteCode + data[2];
            Process.Start(@"C:\Users\ylokhat\Documents\Visual Studio 2015\Projects\XML_Explorer_Tools\XML_Explorer_Tools\bin\Release\XML_Explorer_Tools.exe", "\"" + configPath + "\"");
        }

        private void SearchForm_SizeChanged(object sender, EventArgs e)
        {
            this.lbResult.Size = new System.Drawing.Size(this.Size.Width - 40, this.Size.Height - 89);
        }

        private void RbSetting_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void TbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tbSearch.Text = "";
                return;
            }
            else if (e.KeyCode != Keys.Enter)
                return;

            search();
        }

        private void search()
        {
            lbResult.Items.Clear();
            if (tbSearch.Text == "")
                return;

            string[] configs = Directory.GetFiles("Settings", "*.config", SearchOption.AllDirectories);

            foreach (string config in configs)
            {
                TextReader reader = new StreamReader(config);
                string content = reader.ReadToEnd();
                reader.Close();

                if (!rbText.Checked)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(content);

                    string xpath = "//setting[@" + (rbSettingName.Checked ? "name" : "value") + "]";
                    var res = xmlDoc.SelectNodes(xpath);
                    foreach (XmlNode node in res)
                    {
                        if (cbMatchCase.Checked)
                        {
                            if ((rbSettingName.Checked && !node.Attributes["name"].Value.Like(tbSearch.Text, cbAllowRegex.Checked, cbMatchCase.Checked)) || (rbSettingValue.Checked && !node.Attributes["value"].Value.Like(tbSearch.Text, cbAllowRegex.Checked, cbMatchCase.Checked)))
                                continue;
                        }
                        else
                        {
                            if ((rbSettingName.Checked && !node.Attributes["name"].Value.ToLower().Like(tbSearch.Text.ToLower(), cbAllowRegex.Checked, cbMatchCase.Checked)) || (rbSettingValue.Checked && !node.Attributes["value"].Value.ToLower().Like(tbSearch.Text.ToLower(), cbAllowRegex.Checked, cbMatchCase.Checked)))
                                continue;
                        }

                        string configName = Path.GetFileName(config.Replace("\\", "/"));
                        configName = parent.GetLocalizedConfig(configName);
                        if (configName == "")
                            continue;

                        string[] pathCompo = config.Split('\\');
                        string environment = pathCompo[1].Split('-')[1];
                        string site = pathCompo[5];

                        lbResult.Items.Add(environment + "\t" + site + "\t" + configName + "\tSettingName=\"" + node.Attributes["name"].Value + "\"" + (node.Attributes.GetNamedItem("value") != null ? "\tSettingValue=\"" + node.Attributes["value"].Value + "\"" : ""));
                    }
                }
                else
                {
                    if ((cbMatchCase.Checked && !content.Like(tbSearch.Text, cbAllowRegex.Checked, cbMatchCase.Checked)) || (!cbMatchCase.Checked && !content.ToLower().Like(tbSearch.Text.ToLower(), cbAllowRegex.Checked, cbMatchCase.Checked)))
                        continue;

                    string configName = Path.GetFileName(config.Replace("\\", "/"));
                    configName = parent.GetLocalizedConfig(configName);
                    if (configName == "")
                        continue;

                    string[] pathCompo = config.Split('\\');
                    string environment = pathCompo[1];
                    string site = pathCompo[5];
                    lbResult.Items.Add(environment + "\t" + site + "\t" + configName);
                }
            }
        }
    }
}
