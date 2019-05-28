using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ConfigModifier
{
    public partial class MainForm : Form
    {

        public List<string> Environement { get; private set; }
        public List<string> Sites { get; private set; }
        public List<string> Configs { get; private set; }
        public Dictionary<string, Dictionary<string, string>> Cultures { get; private set; }
        public Dictionary<string, string> SiteFolderCode;

        private Dictionary<string, Dictionary<string, string>> DictionaryValues;
        private OpenFileDialog o;

        public MainForm()
        {
            InitializeComponent();

            Environement = new List<string>();
            Sites = new List<string>() { "en-PH", "sv-SE", "fr-FR", "es-ES", "nl-NL", "it-IT", "pt-PT", "kk-KZ", "ru-KZ", "fr-BE", "nl-BE", "el-GR", "hu-HU", "de-DE", "en-SA", "ar-SA", "ru-RU", "pl-PL", "tr-TR", "en-IN", "en-CA", "fr-CA", "jp-JP", "en-US" };
            SiteFolderCode = new Dictionary<string, string>() { { "en-PH", "PH" }, { "sv-SE", "SE" }, { "fr-FR", "FR" }, { "es-ES", "ES" }, { "nl-NL", "NL" }, { "it-IT", "IT" }, { "pt-PT", "PT" }, { "kk-KZ", "KK-KZ" }, { "ru-KZ", "RU-KZ" }, { "fr-BE", "FR-BE" }, { "nl-BE", "NL-BE" }, { "el-GR", "GR" }, { "hu-HU", "HU" }, { "de-DE", "DE" }, { "en-SA", "EN-SA" }, { "ar-SA", "AR-SA" }, { "ru-RU", "RU" }, { "pl-PL", "PL" }, { "tr-TR", "TR" }, { "en-IN", "IN" }, { "en-CA", "EN-CA" }, { "fr-CA", "FR-CA" }, { "jp-JP", "JP" }, { "en-US", "US" } };
            Configs = new List<string>();
            Cultures = new Dictionary<string, Dictionary<string, string>>();
            foreach (string site in Sites)
                Cultures[site] = GetVariant(site);

            cbSTI1ALL.CheckStateChanged += CbSTI1_CheckStateChanged;
            cbSTI1CD.CheckStateChanged += CbSTI1_CheckStateChanged;
            cbSTI1CM.CheckStateChanged += CbSTI1_CheckStateChanged;
            cbSTI1Job.CheckStateChanged += CbSTI1_CheckStateChanged;

            o = new OpenFileDialog();
            o.Title = "Choose the CSV Config value file";
            o.Filter = "CSV (MS-DOS)|*.csv|Formated Config FIle|*.config|All files|*";
            o.InitialDirectory = Environment.CurrentDirectory + "\\CSV_Config";

            if (MessageBox.Show("Do-you want to update Settings Folder?", "Update Settings Folder?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                updateSettingFolder();
            else
                updateConfigFileList();
            lbSites.Items.AddRange(Sites.ToArray());

            bBrowse.Click += BBrowse_Click;
            bGenerate.Click += BGenerate_Click;
            bSearch.Click += BSearch_Click;
            bDuplicate.Click += BDuplicate_Click;

            bCopyFrom.Click += BCopyFrom_Click;
            bCopyTo.Click += BCopyTo_Click;
            bOpenSettings.Click += BOpenSettings_Click;
            bOpenSolution.Click += BOpenSolution_Click;

            tbResult.TextChanged += TbResult_TextChanged;
        }

        private void BCopyFrom_Click(object sender, EventArgs e)
        {
            updateSettingFolder();
            MessageBox.Show("Task Finished", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BCopyTo_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("Settings", "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                string targetPath = @"C:\DotCom\pg-growing-families\PG.GrowingFamilies.Version1.Environments\" + file.Substring(9);

                if (!Directory.Exists(Path.GetDirectoryName(targetPath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(targetPath));

                if (File.Exists(targetPath))
                    File.Delete(targetPath);

                File.Copy(file, targetPath);
            }
            MessageBox.Show("Task Finished", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BOpenSolution_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "\"" + @"C:\DotCom\pg-growing-families\PG.GrowingFamilies.Version1.Environments" + "\"");
        }

        private void BOpenSettings_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "\"" + Environment.CurrentDirectory + "\\Settings\"");
        }

        public void updateSettingFolder()
        {
            try
            {
                foreach (string env in DuplicateForm.Environments)
                {
                    if (Directory.Exists("Settings/SIT1-" + env))
                        Directory.Delete("Settings/SIT1-" + env, true);

                    string[] files = Directory.GetFiles(@"C:\DotCom\pg-growing-families\PG.GrowingFamilies.Version1.Environments\SIT1-" + env, "*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string sourceDir = Path.GetDirectoryName(file);
                        string targetDir = sourceDir.Replace(@"C:\DotCom\pg-growing-families\PG.GrowingFamilies.Version1.Environments", "Settings").Replace(@"\", "/");
                        if (!Directory.Exists(targetDir))
                            Directory.CreateDirectory(targetDir);

                        File.Copy(file, targetDir + "/" + fileName);
                    }
                }

                updateConfigFileList();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Unable to delete Settings from Setting forlder.\nMaybe folder is open.\nClose the Settings Folder and click Retry or Cancel", "Unable to delete Settings", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    updateSettingFolder();
            }
        }

        private void BDuplicate_Click(object sender, EventArgs e)
        {
            new DuplicateForm(this).Show();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            new SearchForm(this).Show();
        }

        private void TbResult_TextChanged(object sender, EventArgs e)
        {
            tbResult.SelectionStart = tbResult.Text.Length;
            tbResult.ScrollToCaret();
        }

        private void updateConfigFileList()
        {
            lbConfigs.Items.Clear();
            lbConfigs.Items.Add("----Add new config file----");
            Configs.Clear();

            string[] configs = Directory.GetFiles("Settings", "*.config", SearchOption.AllDirectories);
            foreach (string config in configs)
            {
                string configName = Path.GetFileName(config.Replace("\\", "/"));
                configName = GetLocalizedConfig(configName);
                if (configName == "")
                    continue;

                if (!Configs.Contains(configName))
                    Configs.Add(configName);
            }

            lbConfigs.Items.AddRange(Configs.ToArray());
        }

        public string GetLocalizedConfig(string configName)
        {
            //PG.GrowingFamilies.Version1.en-PH.BazaarVoice.Agents.config
            string[] configComponnent = configName.Split('.');
            if (configComponnent.Length < 6)
                return "";
            string site = configComponnent[3];
            if (site.Length != 5 || site[2] != '-')
                return "";

            string output = "";
            for (int i = 4; i < configComponnent.Length; i++)
                output += "." + configComponnent[i];

            return output;
        }

        private void BGenerate_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            tbConfigValues.ForeColor = Color.Red;

            if (Environement.Count == 0)
            {
                tbResult.Text = "No selected Environement";
                MessageBox.Show(tbResult.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbSites.SelectedIndices.Count == 0)
            {
                tbResult.Text = "No selected Market";
                MessageBox.Show(tbResult.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbConfigs.SelectedIndices.Count == 0)
            {
                tbResult.Text = "No selected Configuration File";
                MessageBox.Show(tbResult.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (o.Multiselect)
            {
                foreach (string file in o.FileNames)
                {
                    if (!File.Exists(file))
                    {
                        tbResult.Text = "Configuration Values File is missing";
                        MessageBox.Show(tbResult.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else if (!o.Multiselect && !File.Exists(tbConfigValues.Text))
            {
                tbResult.Text = "Configuration Values File is missing";
                MessageBox.Show(tbResult.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               

            tbResult.ForeColor = Color.Green;

            try
            {
                if(lbConfigs.SelectedItems.Contains("----Add new config file----"))
                {
                    addNewConfigFile();
                    return;
                }

                foreach (string environement in Environement)
                {
                    string dirPath = "Settings/SIT1-" + environement + "/App_Config/Include/zzPG.GrowingFamilies.Version1/";

                    foreach (string site in lbSites.SelectedItems)
                    {
                        foreach (string confFile in lbConfigs.SelectedItems)
                        {
                            if (!Directory.Exists(dirPath + SiteFolderCode[site] + "-" + environement))
                            {
                                tbResult.Text += (environement + " not contains the culture " + site);
                                continue;
                            }

                            string filePath = dirPath + SiteFolderCode[site] + "-" + environement + "/PG.GrowingFamilies.Version1." + site + confFile;
                            if (!File.Exists(filePath))
                            {
                                tbResult.Text += (environement + " " + site + " not contains " + confFile);
                                continue;
                            }

                            TextReader reader = new StreamReader(filePath);
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.LoadXml(reader.ReadToEnd());
                            reader.Close();

                            if (!DictionaryValues.ContainsKey(site))
                                tbResult.Text += site + " is missing in the Configuration Values File\r\n";
                            else
                            {
                                foreach (var value in DictionaryValues[site])
                                {
                                    string settingName = value.Key;

                                    bool addExtention = settingName[0] == '#';
                                    if (addExtention)
                                        settingName = settingName.Substring(1);

                                    settingName = "PG.GrowingFamiliesVersion1." + site + settingName;
                                    var res = xmlDoc.SelectNodes("//setting[@name='" + settingName + "']");
                                    foreach (XmlNode node in res)
                                        node.Attributes["value"].Value = value.Value;

                                    if (addExtention)
                                    {
                                        settingName += "." + site.Substring(3);
                                        var res2 = xmlDoc.SelectNodes("//setting[@name='" + settingName + "']");
                                        foreach (XmlNode node in res2)
                                            node.Attributes["value"].Value = value.Value;
                                    }
                                }

                                xmlDoc.Save(filePath);
                                tbResult.Text += (environement + "\tPG.GrowingFamiliesVersion1." + site + confFile + "\tdone\r\n");
                            }
                        }
                    }
                }

                tbResult.Text += "\r\nAll done\r\n";
            }
            catch (Exception ex)
            {
                tbResult.ForeColor = Color.Red;
                tbResult.Text += ex.Message + "\r\n";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewConfigFile()
        {
            //string[] variants = new string[] { "xx-YY", "XX-YY", "xx_YY", ".YY\"", " YY\"", "\"YY\"", " YY ", "YY<", "xxyy" };

            try
            {
                foreach (string newConfig in o.FileNames)
                {
                    foreach (string site in lbSites.SelectedItems)
                    {
                        foreach (string environement in Environement)
                        {
                            string dirPath = "Settings/SIT1-" + environement + "/App_Config/Include/zzPG.GrowingFamilies.Version1/";

                            if (!Directory.Exists(dirPath + SiteFolderCode[site] + "-" + environement.ToUpper()))
                                Directory.CreateDirectory(dirPath + SiteFolderCode[site] + "-" + environement.ToUpper());

                            string fileName = Path.GetFileName(newConfig).Replace("xx-YY", site);

                            TextReader reader = new StreamReader(newConfig);
                            string content = reader.ReadToEnd();
                            reader.Close();
                            foreach (var variant in Cultures[site])
                                content = content.Replace(variant.Key, variant.Value);
                            TextWriter writer = new StreamWriter(dirPath + SiteFolderCode[site] + "-" + environement.ToUpper() + "/" + fileName);
                            writer.Write(content);
                            writer.Close();

                            tbResult.Text += (environement + "\t" + site + "\t" + fileName + " \tdone\r\n");
                        }
                    }
                }

                tbResult.Text += "\r\nAll done\r\n";
            }
            catch (Exception ex)
            {
                tbResult.ForeColor = Color.Red;
                tbResult.Text += ex.Message + "\r\n";
            }

            updateConfigFileList();
        }

        private Dictionary<string, string> GetVariant(string source)
        {
            Dictionary<string, string> culture = new Dictionary<string, string>();
            culture["¤la¤"] = "" + source.ToLower()[0];
            culture["¤lb¤"] = "" + source.ToLower()[1];
            culture["¤lc¤"] = "" + source.ToLower()[3];
            culture["¤ld¤"] = "" + source.ToLower()[4];
            culture["¤ua¤"] = "" + source.ToUpper()[0];
            culture["¤ub¤"] = "" + source.ToUpper()[1];
            culture["¤uc¤"] = "" + source.ToUpper()[3];
            culture["¤ud¤"] = "" + source.ToUpper()[4];

            return culture;
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            o.Multiselect = lbConfigs.SelectedItems.Contains("----Add new config file----");
            if (o.Multiselect)
                o.Filter = "Formated Config FIle|*.config|All files|*";
            else
                o.Filter = "CSV (MS-DOS)|*.csv|All files|*";

            if (o.ShowDialog() != DialogResult.OK)
                return;

            if (o.Multiselect)
            {
                tbConfigValues.Text = String.Join(";", o.FileNames);
                return;
            }

            tbConfigValues.Text = o.FileName;

            DictionaryValues = new Dictionary<string, Dictionary<string, string>>();

            try
            {
                TextReader reader = new StreamReader(tbConfigValues.Text);
                string[] column = reader.ReadLine().Split(',');
                string line = reader.ReadLine();

                if (String.IsNullOrEmpty(line))
                    throw new Exception("No data in CSV file.");

                while (line != null)
                {
                    string[] info = line.Split(',');
                    if (info.Length != column.Length)
                        throw new Exception("CSV file's column is bad.");

                    DictionaryValues[info[0]] = new Dictionary<string, string>();
                    for (int i = 1; i < column.Length; i++)
                        DictionaryValues[info[0]][column[i]] = info[i];

                    line = reader.ReadLine();
                }
                reader.Close();

                lbSites.SelectedItems.Clear();
                foreach (var item in DictionaryValues)
                    lbSites.SelectedItems.Add(item.Key);
            }
            catch (Exception ex) { DictionaryValues = null; tbResult.Text += ex.Message + "\r\n"; }
        }

        private void CbSTI1_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox cbSender = (CheckBox)sender;

            if (cbSender.Checked)
                Environement.Add(cbSender.Text);
            else
                Environement.Remove(cbSender.Text);
        }
    }
}
