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

namespace ConfigModifier
{
    public partial class DuplicateForm : Form
    {
        MainForm parent;
        public static string[] Environments = new string[] { "All", "CD", "CM", "Job" };

        public DuplicateForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;

            cbFromEnvironment.SelectedIndexChanged += CbFromEnvironment_SelectedIndexChanged;

            bDuplicate.Click += BDuplicate_Click;

            cbFromEnvironment.Items.AddRange(Environments);
            lbSites.Items.AddRange(parent.Sites.ToArray());
        }

        private void BDuplicate_Click(object sender, EventArgs e)
        {
            if (cbFromEnvironment.SelectedIndex == -1)
            {
                MessageBox.Show("No selected source Environement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbToEnvironment.SelectedIndex == -1)
            {
                MessageBox.Show("No selected target Environement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbConfigs.SelectedItems.Count == 0)
            {
                MessageBox.Show("No selected Configuration file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbSites.SelectedItems.Count == 0)
            {
                MessageBox.Show("No selected Culture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string site in lbSites.SelectedItems)
            {
                string fromDirPath = "Settings/SIT1-" + cbFromEnvironment.SelectedItem + "/App_Config/Include/zzPG.GrowingFamilies.Version1/" + parent.SiteFolderCode[site] + "-" + cbFromEnvironment.SelectedItem;
                if (!Directory.Exists(fromDirPath))
                {
                    MessageBox.Show(cbFromEnvironment.SelectedItem + " not contains the culture " + site, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                foreach (string confFile in lbConfigs.SelectedItems)
                {
                    string filePath = fromDirPath + "/PG.GrowingFamilies.Version1." + site + confFile;
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show(cbFromEnvironment.SelectedItem + " " + site + " not contains " + confFile, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    string toDirPath = "Settings/SIT1-" + cbToEnvironment.SelectedItem + "/App_Config/Include/zzPG.GrowingFamilies.Version1/" + parent.SiteFolderCode[site] + "-" + cbToEnvironment.SelectedItem;
                    if (!Directory.Exists(toDirPath))
                        Directory.CreateDirectory(toDirPath);

                    string fileCopyPath = toDirPath + "/PG.GrowingFamilies.Version1." + site + confFile;

                    try
                    {
                        if (File.Exists(fileCopyPath))
                        {
                            if (MessageBox.Show(fileCopyPath + " already exist.\nDo-you want to erase it?", "File Collision", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                continue;
                            File.Delete(fileCopyPath);
                        }

                        File.Copy(filePath, fileCopyPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Task Finished", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CbFromEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbConfigs.Items.Clear();
            cbToEnvironment.Items.Clear();

            string[] configs = Directory.GetFiles("Settings", "*.config", SearchOption.AllDirectories);
            foreach (string config in configs)
            {
                string configName = Path.GetFileName(config.Replace("\\", "/"));
                configName = GetLocalizedConfig(configName);
                if (configName == "" || !config.Contains(cbFromEnvironment.SelectedItem.ToString()))
                    continue;

                if (!lbConfigs.Items.Contains(configName))
                    lbConfigs.Items.Add(configName);
            }

            foreach (object item in cbFromEnvironment.Items)
            {
                if (item != cbFromEnvironment.SelectedItem)
                    cbToEnvironment.Items.Add(item);
            }
        }

        public string GetLocalizedConfig(string configName)
        {
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
    }
}
